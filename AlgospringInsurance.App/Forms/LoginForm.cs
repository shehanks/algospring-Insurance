using AlgospringInsurance.App.Dtos;
using AlgospringInsurance.DataAccess.Repository.Contracts;
using AlgospringInsurance.Infrastructure;
using AlgospringInsurance.Services.Contracts;
using MySql.Data.MySqlClient;
using System.Data;

namespace AlgospringInsurance.App.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IFormFactory formFactory;

        private readonly IConnectionProvider connectionProvider;

        private readonly IUserService userService;

        public LoginForm(
            IConnectionProvider connectionProvider,
            IFormFactory formFactory,
            IUserService userService)
        {
            this.connectionProvider = connectionProvider;
            this.formFactory = formFactory;
            this.userService = userService;
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

            var user = userService.GetUser(1);

            var con = new MySqlConnection();
            var query = "select Name, Email, IsAdmin from user where binary username = binary @userName and password = @password limit 1";

            try
            {
                using (con = new MySqlConnection(connectionProvider.GetConnectionString()))
                {
                    con.Open();
                    var command = con.CreateCommand();
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@username", LoginForm_Username_Textbox.Text.Trim());
                    command.Parameters.AddWithValue("@password", SecurityProvider.Encrypt(LoginForm_Password_Textbox.Text));
                    var reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (!reader.HasRows)
                    {
                        MessageBox.Show(
                            "Invalid login credentials, please check Username and Password and try again",
                            "Invalid login details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            LoginFormDataParser.LoginName = reader["Name"].ToString();
                            LoginFormDataParser.Email = reader["Email"].ToString();
                            LoginFormDataParser.IsAdmin = reader["IsAdmin"].ToString() == "1" ? true : false;
                        }

                        Hide();
                        var userForm = formFactory.Create<UserForm>();
                        userForm.Show();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
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
