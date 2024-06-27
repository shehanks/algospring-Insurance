using AlgospringInsurance.App.Dtos;
using AlgospringInsurance.DataAccess.UnitOfWork;
using AlgospringInsurance.Infrastructure;

namespace AlgospringInsurance.App.Forms
{
    public partial class AdminForm : Form
    {
        private readonly IUnitOfWork unitOfWork;

        public AdminForm(
            IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            InitializeComponent();
            LoadUserNameItems();
        }

        private void LoadUserNameItems()
        {
            AdminForm_Search_ComboBox.Items.Clear();

            try
            {
                var users = unitOfWork.UserRepository
                    .Get(u => !string.Equals(u.Email, LoginFormDataParser.Email));

                if (users.Any())
                {
                    foreach (var user in users)
                        AddNewUserSearchComboBoxItem(user.Id, user.Name, user.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_Search_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = AdminForm_Search_ComboBox.SelectedItem as DropDownItem;
            UseRegistrationForm_Register_Button.Enabled = false;

            try
            {
                var user = unitOfWork.UserRepository.GetById(selectedUser!.Id)!;

                AdminForm_Email_TextBox.Text = user.Email;
                AdminForm_Name_TextBox.Text = user.Name;
                AdminForm_Username_TextBox.Text = user.Username;
                AdminForm_IsAdmin_CheckBox.Checked = user.IsAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UseRegistrationForm_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var user = unitOfWork.UserRepository.Insert(new DataAccess.Models.User
                {
                    Name = AdminForm_Name_TextBox.Text.Trim(),
                    Email = AdminForm_Email_TextBox.Text.Trim(),
                    Username = AdminForm_Username_TextBox.Text.Trim(),
                    Password = SecurityProvider.Encrypt(AdminForm_Password_TextBox.Text),
                    IsAdmin = AdminForm_IsAdmin_CheckBox.Checked
                });

                unitOfWork.Complete();

                MessageBox.Show("Record Added Succesfully", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetUserForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UseRegistrationForm_Update_Button_Click(object sender, EventArgs e)
        {
            var selectedUser = AdminForm_Search_ComboBox.SelectedItem as DropDownItem;

            try
            {
                var user = unitOfWork.UserRepository.GetById(selectedUser!.Id);

                if (user is not null)
                {
                    user.Name = AdminForm_Name_TextBox.Text.Trim();
                    user.Email = AdminForm_Email_TextBox.Text.Trim();
                    user.Username = AdminForm_Username_TextBox.Text.Trim();
                    user.IsAdmin = AdminForm_IsAdmin_CheckBox.Checked;

                    if (!string.IsNullOrWhiteSpace(AdminForm_Password_TextBox.Text))
                        user.Password = SecurityProvider.Encrypt(AdminForm_Password_TextBox.Text);

                    unitOfWork.UserRepository.Update(user);
                    unitOfWork.Complete();

                    MessageBox.Show("Record Updated Succesfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetUserForm();
                }
                else
                {
                    MessageBox.Show("Invalid record", "Update User",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UseRegistrationForm_Delete_Button_Click(object sender, EventArgs e)
        {
            var selectedUser = AdminForm_Search_ComboBox.SelectedItem as DropDownItem;

            try
            {

                var user = unitOfWork.UserRepository.GetById(selectedUser!.Id);

                if (user is not null)
                {
                    var deleteDialog = MessageBox.Show(
                        "Are you sure, Do you really want to Delete this Record...?",
                        "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteDialog == DialogResult.Yes)
                    {
                        unitOfWork.UserRepository.Delete(user);
                        unitOfWork.Complete();
                        MessageBox.Show("Record Deleted Succesfully", "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetUserForm();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid record", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetUserForm()
        {

            LoadUserNameItems();
            AdminForm_Name_TextBox.ResetText();
            AdminForm_Email_TextBox.ResetText();
            AdminForm_Password_TextBox.ResetText();
            AdminForm_Username_TextBox.ResetText();
            AdminForm_IsAdmin_CheckBox.Checked = false;
            UseRegistrationForm_Register_Button.Enabled = true;
        }

        private void AddNewUserSearchComboBoxItem(int id, string name, string email) =>
            AdminForm_Search_ComboBox.Items.Add(new DropDownItem
            {
                Id = id,
                Text = $"{name} - {email}"
            });

        private void UseRegistrationForm_Clear_Button_Click(object sender, EventArgs e) => ResetUserForm();
    }
}
