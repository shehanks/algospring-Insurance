using AlgospringInsurance.App.Dtos;
using AlgospringInsurance.Infrastructure.Contracts;

namespace AlgospringInsurance.App.Forms
{
    public partial class UserForm : Form
    {
        private readonly IFormFactory formFactory;

        public UserForm(IFormFactory formFactory)
        {
            this.formFactory = formFactory;
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (Application.OpenForms.Count > 0)
            {
                var firstForm = Application.OpenForms[0];

                if (firstForm != null)
                    firstForm.Show();
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = $"Welcome, {LoginFormDataParser.LoginName} !";

            if (!LoginFormDataParser.IsAdmin)
                AdminLinkLabel.Hide();
        }

        private void ExitLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void LogoutLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.Count > 0)
            {
                var firstForm = Application.OpenForms[0];

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    var form = Application.OpenForms[i];
                    if (form != null && form.Name != "LoginForm")
                        form.Close();
                }

                if (firstForm != null)
                    firstForm.Show();
            }
        }

        private void AdminLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            formFactory.Create<AdminForm>().ShowDialog();

        private void MotorQuoteRequestLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            formFactory.Create<MotorQuoteRequestForm>().ShowDialog(this);

        private void MedicalQuoteRequestLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            formFactory.Create<MedicalQuoteRequestForm>().ShowDialog();
    }
}
