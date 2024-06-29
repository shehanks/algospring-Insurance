using AlgospringInsurance.App.Dtos;
using AlgospringInsurance.Infrastructure;

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
            UserForm_Welcome_Label.Text = $"Welcome, {LoginFormDataParser.LoginName} !";

            if (!LoginFormDataParser.IsAdmin)
                UserForm_Superadmin_LinkLabel.Hide();
        }

        private void UserForm_Exit_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void UserForm_Logout_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void UserForm_Superadmin_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => 
            formFactory.Create<AdminForm>().ShowDialog();

        private void UserForm_MotorQuoteRequest_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => 
            formFactory.Create<MotorQuoteRequestForm>().ShowDialog(this);

        private void UserForm_MedicalQuoteRequest_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => 
            formFactory.Create<MedicalQuoteRequestForm>().ShowDialog();
    }
}
