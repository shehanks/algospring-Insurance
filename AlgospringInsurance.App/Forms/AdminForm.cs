using AlgospringInsurance.App.Dtos;
using AlgospringInsurance.DataAccess.UnitOfWork;
using AlgospringInsurance.Infrastructure;
using System.Collections.Immutable;

namespace AlgospringInsurance.App.Forms
{
    public partial class AdminForm : Form
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IValidationProvider validationProvider;

        public AdminForm(
            IUnitOfWork unitOfWork,
            IValidationProvider validationProvider)
        {
            this.unitOfWork = unitOfWork;
            this.validationProvider = validationProvider;
            InitializeComponent();
            LoadUsers();
            LoadEmailReceivers();
        }

        #region User Registration

        #region Control Events

        private void AdminForm_UserRegistration_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = AdminForm_UserRegistration_ComboBox.SelectedItem as DropDownItem;

            AdminForm_UserRegistration_Register_Button.Enabled = false;
            AdminForm_UserRegistration_Update_Button.Enabled = true;
            AdminForm_UserRegistration_Delete_Button.Enabled = true;

            ResetUserRegistrationErrors();

            try
            {
                var user = unitOfWork.UserRepository.GetById(selectedUser!.Id)!;

                AdminForm_UserRegistration_Email_TextBox.Text = user.Email;
                AdminForm_UserRegistration_Name_TextBox.Text = user.Name;
                AdminForm_UserRegistration_Username_TextBox.Text = user.Username;
                AdminForm_UserRegistration_IsAdmin_CheckBox.Checked = user.IsAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_UserRegistration_Register_Button_Click(object sender, EventArgs e)
        {
            if (!IsValidUserRegistration())
                return;

            try
            {
                var user = unitOfWork.UserRepository.Insert(new DataAccess.Models.User
                {
                    Name = AdminForm_UserRegistration_Name_TextBox.Text.Trim(),
                    Email = AdminForm_UserRegistration_Email_TextBox.Text.Trim(),
                    Username = AdminForm_UserRegistration_Username_TextBox.Text.Trim(),
                    Password = SecurityProvider.Encrypt(AdminForm_UserRegistration_Password_TextBox.Text),
                    IsAdmin = AdminForm_UserRegistration_IsAdmin_CheckBox.Checked
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

        private void AdminForm_UserRegistration_Update_Button_Click(object sender, EventArgs e)
        {
            var selectedUser = AdminForm_UserRegistration_ComboBox.SelectedItem as DropDownItem;

            if (!IsValidUserRegistration())
                return;

            try
            {
                var user = unitOfWork.UserRepository.GetById(selectedUser!.Id);

                if (user is not null)
                {
                    user.Name = AdminForm_UserRegistration_Name_TextBox.Text.Trim();
                    user.Email = AdminForm_UserRegistration_Email_TextBox.Text.Trim();
                    user.Username = AdminForm_UserRegistration_Username_TextBox.Text.Trim();
                    user.IsAdmin = AdminForm_UserRegistration_IsAdmin_CheckBox.Checked;

                    if (!string.IsNullOrWhiteSpace(AdminForm_UserRegistration_Password_TextBox.Text))
                        user.Password = SecurityProvider.Encrypt(AdminForm_UserRegistration_Password_TextBox.Text);

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

        private void AdminForm_UserRegistration_Delete_Button_Click(object sender, EventArgs e)
        {
            var selectedUser = AdminForm_UserRegistration_ComboBox.SelectedItem as DropDownItem;

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
                        MessageBox.Show("Record Deleted Succesfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AdminForm_UserRegistration_Reset_Button_Click(object sender, EventArgs e) =>
            ResetUserForm();

        private void AdminForm_UserRegistration_Name_TextBox_TextChanged(object sender, EventArgs e) =>
            ValidateUserRegistrationName();

        private void AdminForm_UserRegistration_Email_TextBox_TextChanged(object sender, EventArgs e) =>
            ValidateUserRegistrationEmail();

        private void AdminForm_UserRegistration_Username_TextBox_TextChanged(object sender, EventArgs e) =>
            ValidateUserRegistrationUsername();

        private void AdminForm_UserRegistration_Password_TextBox_TextChanged(object sender, EventArgs e) =>
            ValidateUserRegistrationPassword();

        #endregion

        #region Support Functions

        private void LoadUsers()
        {
            AdminForm_UserRegistration_ComboBox.Items.Clear();

            try
            {
                var users = unitOfWork.UserRepository
                    .Get(u => !string.Equals(u.Email, LoginFormDataParser.Email));

                if (users.Any())
                {
                    foreach (var user in users)
                    {
                        AdminForm_UserRegistration_ComboBox.Items.Add(new DropDownItem
                        {
                            Id = user.Id,
                            Text = $"{user.Name} - {user.Email}"
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetUserForm()
        {
            LoadUsers();
            AdminForm_UserRegistration_Name_TextBox.ResetText();
            AdminForm_UserRegistration_Email_TextBox.ResetText();
            AdminForm_UserRegistration_Password_TextBox.ResetText();
            AdminForm_UserRegistration_Username_TextBox.ResetText();
            AdminForm_UserRegistration_IsAdmin_CheckBox.Checked = false;

            ResetUserRegistrationErrors();

            AdminForm_UserRegistration_Register_Button.Enabled = true;
            AdminForm_UserRegistration_Update_Button.Enabled = false;
            AdminForm_UserRegistration_Delete_Button.Enabled = false;
        }

        private bool isUserEditMode() =>
            AdminForm_UserRegistration_ComboBox.SelectedItem as DropDownItem is not null;

        private void ResetUserRegistrationErrors() =>
            ImmutableList.Create(
                AdminForm_UserRegistration_Name_ErrorProvider,
                AdminForm_UserRegistration_Email_ErrorProvider,
                AdminForm_UserRegistration_Username_ErrorProvider,
                AdminForm_UserRegistration_Password_ErrorProvider)
                .ForEach(x => x.Clear());

        #endregion

        #region Validations

        private bool IsValidUserRegistration() =>
            validationProvider.ValidateAll(new List<Func<bool>>()
            {
                () => ValidateUserRegistrationName(),
                () => ValidateUserRegistrationEmail(),
                () => ValidateUserRegistrationUsername(),
                () => ValidateUserRegistrationPassword()
            });

        private bool ValidateUserRegistrationName() =>
            validationProvider.Required(AdminForm_UserRegistration_Name_TextBox, AdminForm_UserRegistration_Name_ErrorProvider);

        private bool ValidateUserRegistrationEmail() =>
            validationProvider.Required(AdminForm_UserRegistration_Email_TextBox, AdminForm_UserRegistration_Email_ErrorProvider) &&
            validationProvider.Email(AdminForm_UserRegistration_Email_TextBox, AdminForm_UserRegistration_Email_ErrorProvider);

        private bool ValidateUserRegistrationUsername() =>
            validationProvider.Required(AdminForm_UserRegistration_Username_TextBox, AdminForm_UserRegistration_Username_ErrorProvider) &&
            validationProvider.Length(4, AdminForm_UserRegistration_Username_TextBox, AdminForm_UserRegistration_Username_ErrorProvider);

        private bool ValidateUserRegistrationPassword()
        {
            if (!isUserEditMode() ||
                (isUserEditMode() && !string.IsNullOrEmpty(AdminForm_UserRegistration_Password_TextBox.Text)))
            {
                return
                    validationProvider.Required(AdminForm_UserRegistration_Password_TextBox, AdminForm_UserRegistration_Password_ErrorProvider) &&
                    validationProvider.Length(3, AdminForm_UserRegistration_Password_TextBox, AdminForm_UserRegistration_Password_ErrorProvider);
            }

            AdminForm_UserRegistration_Password_ErrorProvider.Clear();
            return true;
        }

        #endregion

        #endregion

        #region Email Receiver Registration

        #region Control Events

        private void AdminForm_EmailReceiverRegistration_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEmailReceiverRegistration = AdminForm_EmailReceiverRegistration_ComboBox.SelectedItem as DropDownItem;

            AdminForm_EmailReceiverRegistration_Register_Button.Enabled = false;
            AdminForm_EmailReceiverRegistration_Update_Button.Enabled = true;
            AdminForm_EmailReceiverRegistration_Delete_Button.Enabled = true;

            ResetEmailReceiverRegistrationErrors();

            try
            {
                var EmailReceiverRegistration = unitOfWork.EmailReceiverRegistrationRepository.GetById(selectedEmailReceiverRegistration!.Id)!;
                AdminForm_EmailReceiverRegistration_Email_TextBox.Text = EmailReceiverRegistration.Email;
                AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.Checked = EmailReceiverRegistration.IsMedical;
                AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.Checked = EmailReceiverRegistration.IsMotor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_EmailReceiverRegistration_Register_Button_Click(object sender, EventArgs e)
        {
            if (!IsValidEmailReceiverRegistration())
                return;

            try
            {
                var user = unitOfWork.EmailReceiverRegistrationRepository.Insert(new DataAccess.Models.EmailReceiverRegistration
                {
                    Email = AdminForm_EmailReceiverRegistration_Email_TextBox.Text.Trim(),
                    IsMotor = AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.Checked,
                    IsMedical = AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.Checked
                });

                unitOfWork.Complete();

                MessageBox.Show("Record Added Succesfully", "Register Email Receiver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetEmailReceiverForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_EmailReceiverRegistration_Update_Button_Click(object sender, EventArgs e)
        {
            var selectedUser = AdminForm_EmailReceiverRegistration_ComboBox.SelectedItem as DropDownItem;

            if (!IsValidEmailReceiverRegistration())
                return;

            try
            {
                var emailReceiver = unitOfWork.EmailReceiverRegistrationRepository.GetById(selectedUser!.Id);

                if (emailReceiver is not null)
                {
                    emailReceiver.Email = AdminForm_EmailReceiverRegistration_Email_TextBox.Text.Trim();
                    emailReceiver.IsMotor = AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.Checked;
                    emailReceiver.IsMedical = AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.Checked;

                    unitOfWork.EmailReceiverRegistrationRepository.Update(emailReceiver);
                    unitOfWork.Complete();

                    MessageBox.Show("Record Updated Succesfully", "Update Email Receiver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetEmailReceiverForm();
                }
                else
                {
                    MessageBox.Show("Invalid record", "Update Email Receiver",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_EmailReceiverRegistration_Delete_Button_Click(object sender, EventArgs e)
        {
            var selectedUser = AdminForm_EmailReceiverRegistration_ComboBox.SelectedItem as DropDownItem;

            try
            {

                var emailReceiver = unitOfWork.EmailReceiverRegistrationRepository.GetById(selectedUser!.Id);

                if (emailReceiver is not null)
                {
                    var deleteDialog = MessageBox.Show(
                        "Are you sure, Do you really want to Delete this Record...?",
                        "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteDialog == DialogResult.Yes)
                    {
                        unitOfWork.EmailReceiverRegistrationRepository.Delete(emailReceiver);
                        unitOfWork.Complete();
                        MessageBox.Show("Record Deleted Succesfully", "Delete Email Receiver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetEmailReceiverForm();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid record", "Delete Email Receiver", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_EmailReceiverRegistration_Reset_Button_Click(object sender, EventArgs e) =>
            ResetEmailReceiverForm();

        private void AdminForm_EmailReceiverRegistration_Email_TextBox_TextChanged(object sender, EventArgs e) =>
            ValidateEmailReceiverRegistrationEmail();

        #endregion

        #region Support Functions

        private void LoadEmailReceivers()
        {
            AdminForm_EmailReceiverRegistration_ComboBox.Items.Clear();

            try
            {
                var emailReceivers = unitOfWork.EmailReceiverRegistrationRepository.Get();

                if (emailReceivers.Any())
                {
                    foreach (var receiver in emailReceivers)
                    {
                        AdminForm_EmailReceiverRegistration_ComboBox.Items.Add(new DropDownItem
                        {
                            Id = receiver.Id,
                            Text = receiver.Email
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetEmailReceiverForm()
        {
            LoadEmailReceivers();
            AdminForm_EmailReceiverRegistration_Email_TextBox.ResetText();
            AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.Checked = false;
            AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.Checked = false;

            ResetEmailReceiverRegistrationErrors();

            AdminForm_EmailReceiverRegistration_Register_Button.Enabled = true;
            AdminForm_EmailReceiverRegistration_Update_Button.Enabled = false;
            AdminForm_EmailReceiverRegistration_Delete_Button.Enabled = false;
        }

        private bool isEmailReceiverEditMode() =>
            AdminForm_EmailReceiverRegistration_ComboBox.SelectedItem as DropDownItem is not null;

        private void ResetEmailReceiverRegistrationErrors() => ImmutableList.Create(
            AdminForm_EmailReceiverRegistration_Email_ErrorProvider)
            .ForEach(x => x.Clear());

        #endregion

        #region Validations

        private bool IsValidEmailReceiverRegistration() =>
            validationProvider.ValidateAll(new List<Func<bool>>()
            {
                () => ValidateEmailReceiverRegistrationEmail()
            });

        private bool ValidateEmailReceiverRegistrationEmail() =>
            validationProvider.Required(AdminForm_EmailReceiverRegistration_Email_TextBox, AdminForm_EmailReceiverRegistration_Email_ErrorProvider) &&
            validationProvider.Email(AdminForm_EmailReceiverRegistration_Email_TextBox, AdminForm_EmailReceiverRegistration_Email_ErrorProvider);

        #endregion

        #endregion
    }
}
