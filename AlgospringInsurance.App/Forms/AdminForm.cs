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

        private void UserRegistrationDropDownSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = UserRegistrationDropDown.SelectedItem as DropDownItem;

            UserRegistrationRegisterButton.Enabled = false;
            UserRegistrationUpdateButton.Enabled = true;
            UserRegistrationDeleteButton.Enabled = true;

            ResetUserRegistrationErrors();

            try
            {
                var user = unitOfWork.UserRepository.GetById(selectedUser!.Id)!;

                UserRegistrationEmail.Text = user.Email;
                UserRegistrationName.Text = user.Name;
                UserRegistrationUsername.Text = user.Username;
                UserRegistrationIsAdmin.Checked = user.IsAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserRegistrationRegisterButtonClick(object sender, EventArgs e)
        {
            if (!IsValidUserRegistration())
                return;

            try
            {
                var user = unitOfWork.UserRepository.Insert(new DataAccess.Models.User
                {
                    Name = UserRegistrationName.Text.Trim(),
                    Email = UserRegistrationEmail.Text.Trim(),
                    Username = UserRegistrationUsername.Text.Trim(),
                    Password = SecurityProvider.Encrypt(UserRegistrationPassword.Text),
                    IsAdmin = UserRegistrationIsAdmin.Checked
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

        private void UserRegistrationUpdateButtonClick(object sender, EventArgs e)
        {
            var selectedUser = UserRegistrationDropDown.SelectedItem as DropDownItem;

            if (!IsValidUserRegistration())
                return;

            try
            {
                var user = unitOfWork.UserRepository.GetById(selectedUser!.Id);

                if (user is not null)
                {
                    user.Name = UserRegistrationName.Text.Trim();
                    user.Email = UserRegistrationEmail.Text.Trim();
                    user.Username = UserRegistrationUsername.Text.Trim();
                    user.IsAdmin = UserRegistrationIsAdmin.Checked;

                    if (!string.IsNullOrWhiteSpace(UserRegistrationPassword.Text))
                        user.Password = SecurityProvider.Encrypt(UserRegistrationPassword.Text);

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

        private void UserRegistrationDeleteButtonClick(object sender, EventArgs e)
        {
            var selectedUser = UserRegistrationDropDown.SelectedItem as DropDownItem;

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

        private void UserRegistrationResetButtonClick(object sender, EventArgs e) =>
            ResetUserForm();

        private void UserRegistrationNameTextChanged(object sender, EventArgs e) =>
            ValidateUserRegistrationName();

        private void UserRegistrationEmailTextChanged(object sender, EventArgs e) =>
            ValidateUserRegistrationEmail();

        private void UserRegistrationUsernameTextChanged(object sender, EventArgs e) =>
            ValidateUserRegistrationUsername();

        private void UserRegistrationPasswordTextChanged(object sender, EventArgs e) =>
            ValidateUserRegistrationPassword();

        #endregion

        #region Support Functions

        private void LoadUsers()
        {
            UserRegistrationDropDown.Items.Clear();

            try
            {
                var users = unitOfWork.UserRepository
                    .Get(u => !string.Equals(u.Email, LoginFormDataParser.Email));

                if (users.Any())
                {
                    foreach (var user in users)
                    {
                        UserRegistrationDropDown.Items.Add(new DropDownItem
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
            UserRegistrationName.ResetText();
            UserRegistrationEmail.ResetText();
            UserRegistrationPassword.ResetText();
            UserRegistrationUsername.ResetText();
            UserRegistrationIsAdmin.Checked = false;

            ResetUserRegistrationErrors();

            UserRegistrationRegisterButton.Enabled = true;
            UserRegistrationUpdateButton.Enabled = false;
            UserRegistrationDeleteButton.Enabled = false;
        }

        private bool isUserEditMode() =>
            UserRegistrationDropDown.SelectedItem as DropDownItem is not null;

        private void ResetUserRegistrationErrors() =>
            ImmutableList.Create(
                UserRegistrationNameErrorProvider,
                UserRegistrationEmailErrorProvider,
                UserRegistrationUsernameErrorProvider,
                UserRegistrationPasswordErrorProvider)
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
            validationProvider.Required(UserRegistrationName, UserRegistrationNameErrorProvider);

        private bool ValidateUserRegistrationEmail() =>
            validationProvider.Required(UserRegistrationEmail, UserRegistrationEmailErrorProvider) &&
            validationProvider.Email(UserRegistrationEmail, UserRegistrationEmailErrorProvider);

        private bool ValidateUserRegistrationUsername() =>
            validationProvider.Required(UserRegistrationUsername, UserRegistrationUsernameErrorProvider) &&
            validationProvider.Length(4, UserRegistrationUsername, UserRegistrationUsernameErrorProvider);

        private bool ValidateUserRegistrationPassword()
        {
            if (!isUserEditMode() ||
                (isUserEditMode() && !string.IsNullOrEmpty(UserRegistrationPassword.Text)))
            {
                return
                    validationProvider.Required(UserRegistrationPassword, UserRegistrationPasswordErrorProvider) &&
                    validationProvider.Length(3, UserRegistrationPassword, UserRegistrationPasswordErrorProvider);
            }

            UserRegistrationPasswordErrorProvider.Clear();
            return true;
        }

        #endregion

        #endregion

        #region Email Receiver Registration

        #region Control Events

        private void EmailReceiverRegistrationDropDownSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEmailReceiverRegistration = EmailReceiverRegistrationDropDown.SelectedItem as DropDownItem;

            EmailReceiverRegistrationRegisterButton.Enabled = false;
            EmailReceiverRegistrationUpdateButton.Enabled = true;
            EmailReceiverRegistrationDeleteButton.Enabled = true;

            ResetEmailReceiverRegistrationErrors();

            try
            {
                var EmailReceiverRegistration = unitOfWork.EmailReceiverRegistrationRepository.GetById(selectedEmailReceiverRegistration!.Id)!;
                EmailReceiverRegistrationEmail.Text = EmailReceiverRegistration.Email;
                EmailReceiverRegistrationIsMedical.Checked = EmailReceiverRegistration.IsMedical;
                EmailReceiverRegistrationIsMotor.Checked = EmailReceiverRegistration.IsMotor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailReceiverRegistrationRegisterButtonClick(object sender, EventArgs e)
        {
            if (!IsValidEmailReceiverRegistration())
                return;

            try
            {
                var user = unitOfWork.EmailReceiverRegistrationRepository.Insert(new DataAccess.Models.EmailReceiverRegistration
                {
                    Email = EmailReceiverRegistrationEmail.Text.Trim(),
                    IsMotor = EmailReceiverRegistrationIsMotor.Checked,
                    IsMedical = EmailReceiverRegistrationIsMedical.Checked
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

        private void EmailReceiverRegistrationUpdateButtonClick(object sender, EventArgs e)
        {
            var selectedUser = EmailReceiverRegistrationDropDown.SelectedItem as DropDownItem;

            if (!IsValidEmailReceiverRegistration())
                return;

            try
            {
                var emailReceiver = unitOfWork.EmailReceiverRegistrationRepository.GetById(selectedUser!.Id);

                if (emailReceiver is not null)
                {
                    emailReceiver.Email = EmailReceiverRegistrationEmail.Text.Trim();
                    emailReceiver.IsMotor = EmailReceiverRegistrationIsMotor.Checked;
                    emailReceiver.IsMedical = EmailReceiverRegistrationIsMedical.Checked;

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

        private void EmailReceiverRegistrationDeleteButtonClick(object sender, EventArgs e)
        {
            var selectedUser = EmailReceiverRegistrationDropDown.SelectedItem as DropDownItem;

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

        private void EmailReceiverRegistrationResetButtonClick(object sender, EventArgs e) =>
            ResetEmailReceiverForm();

        private void EmailReceiverRegistrationEmailTextChanged(object sender, EventArgs e) =>
            ValidateEmailReceiverRegistrationEmail();

        #endregion

        #region Support Functions

        private void LoadEmailReceivers()
        {
            EmailReceiverRegistrationDropDown.Items.Clear();

            try
            {
                var emailReceivers = unitOfWork.EmailReceiverRegistrationRepository.Get();

                if (emailReceivers.Any())
                {
                    foreach (var receiver in emailReceivers)
                    {
                        EmailReceiverRegistrationDropDown.Items.Add(new DropDownItem
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
            EmailReceiverRegistrationEmail.ResetText();
            EmailReceiverRegistrationIsMedical.Checked = false;
            EmailReceiverRegistrationIsMotor.Checked = false;

            ResetEmailReceiverRegistrationErrors();

            EmailReceiverRegistrationRegisterButton.Enabled = true;
            EmailReceiverRegistrationUpdateButton.Enabled = false;
            EmailReceiverRegistrationDeleteButton.Enabled = false;
        }

        private bool isEmailReceiverEditMode() =>
            EmailReceiverRegistrationDropDown.SelectedItem as DropDownItem is not null;

        private void ResetEmailReceiverRegistrationErrors() => ImmutableList.Create(
            EmailReceiverRegistrationEmailErrorProvider)
            .ForEach(x => x.Clear());

        #endregion

        #region Validations

        private bool IsValidEmailReceiverRegistration() =>
            validationProvider.ValidateAll(new List<Func<bool>>()
            {
                () => ValidateEmailReceiverRegistrationEmail()
            });

        private bool ValidateEmailReceiverRegistrationEmail() =>
            validationProvider.Required(EmailReceiverRegistrationEmail, EmailReceiverRegistrationEmailErrorProvider) &&
            validationProvider.Email(EmailReceiverRegistrationEmail, EmailReceiverRegistrationEmailErrorProvider);

        #endregion

        #endregion
    }
}
