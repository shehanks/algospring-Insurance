using AlgospringInsurance.App.Dtos;
using AlgospringInsurance.DataAccess.UnitOfWork;
using AlgospringInsurance.Infrastructure;
using AlgospringInsurance.Services.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AlgospringInsurance.App.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IFormFactory formFactory;

        private readonly IUserService userService;

        private readonly IUnitOfWork unitOfWork;

        public LoginForm(
            IFormFactory formFactory,
            IUserService userService,
            IUnitOfWork unitOfWork)
        {
            this.formFactory = formFactory;
            this.userService = userService;
            this.unitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void LoginForm_Exit_Button_Click(object sender, EventArgs e)
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

        private void LoginForm_Clear_Button_Click(object sender, EventArgs e)
        {
            LoginForm_Password_Textbox.Clear();
            LoginForm_Username_Textbox.Clear();
            LoginForm_Username_Textbox.Focus();
        }

        private void LoginForm_Login_Button_Click(object sender, EventArgs e)
        {
            if (!IsValidLogin())
                return;

            var passwordHash = SecurityProvider.Encrypt(LoginForm_Password_Textbox.Text);
            var userName = LoginForm_Username_Textbox.Text.Trim();

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

        private void LoginForm_Username_Textbox_TextChanged(object sender, EventArgs e)
            => ValidateUserName(LoginForm_Username_Textbox.Text);

        private void LoginForm_Password_Textbox_TextChanged(object sender, EventArgs e)
            => ValidatePassword(LoginForm_Password_Textbox.Text);

        #region Validations

        private bool IsValidLogin()
        {
            var validations = new List<Func<bool>>()
            {
                () => ValidateUserName(LoginForm_Username_Textbox.Text),
                () => ValidatePassword(LoginForm_Password_Textbox.Text)
            };

            var results = new List<bool>();

            foreach (var action in validations)
                results.Add(action.Invoke());

            return !results.Any(x => !x);
        }

        private bool ValidateUserName(string text)
        {
            bool isValid = false;

            if (string.IsNullOrWhiteSpace(text))
                LoginForm_Username_ErrorProvider.SetError(LoginForm_Username_Textbox, "Username is required.");
            else
            {
                LoginForm_Username_ErrorProvider.SetError(LoginForm_Username_Textbox, string.Empty);
                isValid = true;
            }

            return isValid;
        }

        private bool ValidatePassword(string text)
        {
            bool isValid = false;

            if (string.IsNullOrWhiteSpace(text))
                LoginForm_Password_ErrorProvider.SetError(LoginForm_Password_Textbox, "Password is required.");
            else
            {
                LoginForm_Password_ErrorProvider.SetError(LoginForm_Password_Textbox, string.Empty);
                isValid = true;
            }

            return isValid;
        }

        #endregion
    }
}
