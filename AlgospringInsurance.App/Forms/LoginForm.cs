using AlgospringInsurance.App.Dtos;
using AlgospringInsurance.DataAccess.UnitOfWork;
using AlgospringInsurance.Infrastructure;
using AlgospringInsurance.Infrastructure.Contracts;

namespace AlgospringInsurance.App.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IFormFactory formFactory;

        private readonly IUnitOfWork unitOfWork;

        private readonly IValidationProvider validationProvider;

        public LoginForm(
            IFormFactory formFactory,
            IUnitOfWork unitOfWork,
            IValidationProvider validationProvider)
        {
            this.formFactory = formFactory;
            this.unitOfWork = unitOfWork;
            this.validationProvider = validationProvider;
            InitializeComponent();
        }

        #region Control Events

        private void ExitButtonClick(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            Password.Clear();
            Username.Clear();
            Username.Focus();
            UsernameErrorProvider.Clear();
            PasswordErrorProvider.Clear();
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if (!IsValidLogin())
                return;

            var passwordHash = SecurityProvider.Encrypt(Password.Text);
            var userName = Username.Text.Trim();

            try
            {
                var user = unitOfWork.UserRepository
                    .Get(u => string.Equals(u.Username, userName) && string.Equals(u.Password, passwordHash))
                    .SingleOrDefault();

                if (user is null)
                {
                    MessageBox.Show(
                        "Invalid login credentials, please check Username and Password and try again",
                        "Invalid login details",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    LoginFormDataParser.LoginName = user.Name;
                    LoginFormDataParser.Email = user.Email;
                    LoginFormDataParser.IsAdmin = user.IsAdmin;

                    Hide();
                    var userForm = formFactory.Create<UserForm>();
                    userForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsernameTextChanged(object sender, EventArgs e) => ValidateUsername();

        private void PasswordTextChanged(object sender, EventArgs e) => ValidatePassword();

        #endregion

        #region Validations

        private bool IsValidLogin() =>
            validationProvider.ValidateAll(new List<Func<bool>>()
            {
                () => ValidateUsername(),
                () => ValidatePassword()
            });

        private bool ValidateUsername() =>
            validationProvider.Required(Username, UsernameErrorProvider);

        private bool ValidatePassword() =>
            validationProvider.Required(Password, PasswordErrorProvider);

        #endregion
    }
}
