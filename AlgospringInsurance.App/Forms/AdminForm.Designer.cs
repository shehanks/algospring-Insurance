namespace AlgospringInsurance.App.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            AdminFormTab = new TabControl();
            UsersTabPage = new TabPage();
            UserRegistrationGroupBox = new GroupBox();
            UserRegistrationEmail = new TextBox();
            UserRegistrationDropDown = new ComboBox();
            UserRegistrationDeleteButton = new Button();
            UserRegistrationIsAdmin = new CheckBox();
            UserRegistrationResetButton = new Button();
            UserRegistrationIsAdminLabel = new Label();
            UserRegistrationRegisterButton = new Button();
            UserRegistrationPassword = new TextBox();
            UserRegistrationUpdateButton = new Button();
            UserRegistrationPasswordLabel = new Label();
            UserRegistrationUsername = new TextBox();
            UserRegistrationUsernameLabel = new Label();
            UserRegistrationName = new TextBox();
            UserRegistrationNameLabel = new Label();
            UserRegistrationEmailLabel = new Label();
            EmailReceiversTabPage = new TabPage();
            EmailReceiverRegistrationGroupBox = new GroupBox();
            EmailReceiverRegistrationDropDown = new ComboBox();
            EmailReceiverRegistrationIsMotor = new CheckBox();
            UserRegistrationIsMotorLabel = new Label();
            EmailReceiverRegistrationDeleteButton = new Button();
            EmailReceiverRegistrationIsMedical = new CheckBox();
            EmailReceiverRegistrationResetButton = new Button();
            UserRegistrationIsMedicalLabel = new Label();
            EmailReceiverRegistrationRegisterButton = new Button();
            EmailReceiverRegistrationUpdateButton = new Button();
            EmailReceiverRegistrationEmail = new TextBox();
            EmailReceiverRegistrationEmailLabel = new Label();
            UserRegistrationNameErrorProvider = new ErrorProvider(components);
            UserRegistrationEmailErrorProvider = new ErrorProvider(components);
            UserRegistrationUsernameErrorProvider = new ErrorProvider(components);
            UserRegistrationPasswordErrorProvider = new ErrorProvider(components);
            EmailReceiverRegistrationEmailErrorProvider = new ErrorProvider(components);
            AdminFormTab.SuspendLayout();
            UsersTabPage.SuspendLayout();
            UserRegistrationGroupBox.SuspendLayout();
            EmailReceiversTabPage.SuspendLayout();
            EmailReceiverRegistrationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserRegistrationNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserRegistrationEmailErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserRegistrationUsernameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserRegistrationPasswordErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailReceiverRegistrationEmailErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // AdminFormTab
            // 
            AdminFormTab.Controls.Add(UsersTabPage);
            AdminFormTab.Controls.Add(EmailReceiversTabPage);
            AdminFormTab.Location = new Point(5, 6);
            AdminFormTab.Name = "AdminFormTab";
            AdminFormTab.SelectedIndex = 0;
            AdminFormTab.Size = new Size(546, 379);
            AdminFormTab.TabIndex = 0;
            // 
            // UsersTabPage
            // 
            UsersTabPage.Controls.Add(UserRegistrationGroupBox);
            UsersTabPage.Location = new Point(4, 29);
            UsersTabPage.Name = "UsersTabPage";
            UsersTabPage.Padding = new Padding(3);
            UsersTabPage.Size = new Size(538, 346);
            UsersTabPage.TabIndex = 0;
            UsersTabPage.Text = "Users";
            UsersTabPage.UseVisualStyleBackColor = true;
            // 
            // UserRegistrationGroupBox
            // 
            UserRegistrationGroupBox.Controls.Add(UserRegistrationEmail);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationDropDown);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationDeleteButton);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationIsAdmin);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationResetButton);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationIsAdminLabel);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationRegisterButton);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationPassword);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationUpdateButton);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationPasswordLabel);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationUsername);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationUsernameLabel);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationName);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationNameLabel);
            UserRegistrationGroupBox.Controls.Add(UserRegistrationEmailLabel);
            UserRegistrationGroupBox.Location = new Point(6, 6);
            UserRegistrationGroupBox.Name = "UserRegistrationGroupBox";
            UserRegistrationGroupBox.Size = new Size(522, 333);
            UserRegistrationGroupBox.TabIndex = 0;
            UserRegistrationGroupBox.TabStop = false;
            UserRegistrationGroupBox.Text = "User Registration";
            // 
            // UserRegistrationEmail
            // 
            UserRegistrationEmail.Location = new Point(115, 108);
            UserRegistrationEmail.MaxLength = 320;
            UserRegistrationEmail.Name = "UserRegistrationEmail";
            UserRegistrationEmail.Size = new Size(319, 27);
            UserRegistrationEmail.TabIndex = 20;
            UserRegistrationEmail.TextChanged += UserRegistrationEmailTextChanged;
            // 
            // UserRegistrationDropDown
            // 
            UserRegistrationDropDown.DisplayMember = "Text";
            UserRegistrationDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            UserRegistrationDropDown.FormattingEnabled = true;
            UserRegistrationDropDown.Location = new Point(6, 26);
            UserRegistrationDropDown.Name = "UserRegistrationDropDown";
            UserRegistrationDropDown.Size = new Size(428, 28);
            UserRegistrationDropDown.TabIndex = 19;
            UserRegistrationDropDown.ValueMember = "Value";
            UserRegistrationDropDown.SelectedIndexChanged += UserRegistrationDropDownSelectedIndexChanged;
            // 
            // UserRegistrationDeleteButton
            // 
            UserRegistrationDeleteButton.Enabled = false;
            UserRegistrationDeleteButton.Location = new Point(315, 283);
            UserRegistrationDeleteButton.Name = "UserRegistrationDeleteButton";
            UserRegistrationDeleteButton.Size = new Size(94, 39);
            UserRegistrationDeleteButton.TabIndex = 17;
            UserRegistrationDeleteButton.Text = "Delete";
            UserRegistrationDeleteButton.UseVisualStyleBackColor = true;
            UserRegistrationDeleteButton.Click += UserRegistrationDeleteButtonClick;
            // 
            // UserRegistrationIsAdmin
            // 
            UserRegistrationIsAdmin.AutoSize = true;
            UserRegistrationIsAdmin.Location = new Point(115, 207);
            UserRegistrationIsAdmin.Name = "UserRegistrationIsAdmin";
            UserRegistrationIsAdmin.Size = new Size(18, 17);
            UserRegistrationIsAdmin.TabIndex = 9;
            UserRegistrationIsAdmin.UseVisualStyleBackColor = true;
            // 
            // UserRegistrationResetButton
            // 
            UserRegistrationResetButton.Location = new Point(415, 283);
            UserRegistrationResetButton.Name = "UserRegistrationResetButton";
            UserRegistrationResetButton.Size = new Size(94, 39);
            UserRegistrationResetButton.TabIndex = 18;
            UserRegistrationResetButton.Text = "Reset";
            UserRegistrationResetButton.UseVisualStyleBackColor = true;
            UserRegistrationResetButton.Click += UserRegistrationResetButtonClick;
            // 
            // UserRegistrationIsAdminLabel
            // 
            UserRegistrationIsAdminLabel.AutoSize = true;
            UserRegistrationIsAdminLabel.Location = new Point(6, 204);
            UserRegistrationIsAdminLabel.Name = "UserRegistrationIsAdminLabel";
            UserRegistrationIsAdminLabel.Size = new Size(91, 20);
            UserRegistrationIsAdminLabel.TabIndex = 8;
            UserRegistrationIsAdminLabel.Text = "Make admin";
            // 
            // UserRegistrationRegisterButton
            // 
            UserRegistrationRegisterButton.Location = new Point(115, 283);
            UserRegistrationRegisterButton.Name = "UserRegistrationRegisterButton";
            UserRegistrationRegisterButton.Size = new Size(94, 39);
            UserRegistrationRegisterButton.TabIndex = 15;
            UserRegistrationRegisterButton.Text = "Register";
            UserRegistrationRegisterButton.UseVisualStyleBackColor = true;
            UserRegistrationRegisterButton.Click += UserRegistrationRegisterButtonClick;
            // 
            // UserRegistrationPassword
            // 
            UserRegistrationPassword.Location = new Point(115, 174);
            UserRegistrationPassword.MaxLength = 20;
            UserRegistrationPassword.Name = "UserRegistrationPassword";
            UserRegistrationPassword.PlaceholderText = "Add a new password";
            UserRegistrationPassword.Size = new Size(319, 27);
            UserRegistrationPassword.TabIndex = 7;
            UserRegistrationPassword.TextChanged += UserRegistrationPasswordTextChanged;
            // 
            // UserRegistrationUpdateButton
            // 
            UserRegistrationUpdateButton.Enabled = false;
            UserRegistrationUpdateButton.Location = new Point(215, 283);
            UserRegistrationUpdateButton.Name = "UserRegistrationUpdateButton";
            UserRegistrationUpdateButton.Size = new Size(94, 39);
            UserRegistrationUpdateButton.TabIndex = 16;
            UserRegistrationUpdateButton.Text = "Update";
            UserRegistrationUpdateButton.UseVisualStyleBackColor = true;
            UserRegistrationUpdateButton.Click += UserRegistrationUpdateButtonClick;
            // 
            // UserRegistrationPasswordLabel
            // 
            UserRegistrationPasswordLabel.AutoSize = true;
            UserRegistrationPasswordLabel.Location = new Point(6, 177);
            UserRegistrationPasswordLabel.Name = "UserRegistrationPasswordLabel";
            UserRegistrationPasswordLabel.Size = new Size(70, 20);
            UserRegistrationPasswordLabel.TabIndex = 6;
            UserRegistrationPasswordLabel.Text = "Password";
            // 
            // UserRegistrationUsername
            // 
            UserRegistrationUsername.Location = new Point(115, 141);
            UserRegistrationUsername.MaxLength = 20;
            UserRegistrationUsername.Name = "UserRegistrationUsername";
            UserRegistrationUsername.Size = new Size(319, 27);
            UserRegistrationUsername.TabIndex = 5;
            UserRegistrationUsername.TextChanged += UserRegistrationUsernameTextChanged;
            // 
            // UserRegistrationUsernameLabel
            // 
            UserRegistrationUsernameLabel.AutoSize = true;
            UserRegistrationUsernameLabel.Location = new Point(6, 144);
            UserRegistrationUsernameLabel.Name = "UserRegistrationUsernameLabel";
            UserRegistrationUsernameLabel.Size = new Size(75, 20);
            UserRegistrationUsernameLabel.TabIndex = 4;
            UserRegistrationUsernameLabel.Text = "Username";
            // 
            // UserRegistrationName
            // 
            UserRegistrationName.Location = new Point(115, 75);
            UserRegistrationName.MaxLength = 50;
            UserRegistrationName.Name = "UserRegistrationName";
            UserRegistrationName.Size = new Size(319, 27);
            UserRegistrationName.TabIndex = 3;
            UserRegistrationName.TextChanged += UserRegistrationNameTextChanged;
            // 
            // UserRegistrationNameLabel
            // 
            UserRegistrationNameLabel.AutoSize = true;
            UserRegistrationNameLabel.Location = new Point(6, 78);
            UserRegistrationNameLabel.Name = "UserRegistrationNameLabel";
            UserRegistrationNameLabel.Size = new Size(49, 20);
            UserRegistrationNameLabel.TabIndex = 2;
            UserRegistrationNameLabel.Text = "Name";
            // 
            // UserRegistrationEmailLabel
            // 
            UserRegistrationEmailLabel.AutoSize = true;
            UserRegistrationEmailLabel.Location = new Point(6, 111);
            UserRegistrationEmailLabel.Name = "UserRegistrationEmailLabel";
            UserRegistrationEmailLabel.Size = new Size(46, 20);
            UserRegistrationEmailLabel.TabIndex = 0;
            UserRegistrationEmailLabel.Text = "Email";
            // 
            // EmailReceiversTabPage
            // 
            EmailReceiversTabPage.Controls.Add(EmailReceiverRegistrationGroupBox);
            EmailReceiversTabPage.Location = new Point(4, 29);
            EmailReceiversTabPage.Name = "EmailReceiversTabPage";
            EmailReceiversTabPage.Padding = new Padding(3);
            EmailReceiversTabPage.Size = new Size(538, 346);
            EmailReceiversTabPage.TabIndex = 1;
            EmailReceiversTabPage.Text = "Email Receivers";
            EmailReceiversTabPage.UseVisualStyleBackColor = true;
            // 
            // EmailReceiverRegistrationGroupBox
            // 
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationDropDown);
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationIsMotor);
            EmailReceiverRegistrationGroupBox.Controls.Add(UserRegistrationIsMotorLabel);
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationDeleteButton);
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationIsMedical);
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationResetButton);
            EmailReceiverRegistrationGroupBox.Controls.Add(UserRegistrationIsMedicalLabel);
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationRegisterButton);
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationUpdateButton);
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationEmail);
            EmailReceiverRegistrationGroupBox.Controls.Add(EmailReceiverRegistrationEmailLabel);
            EmailReceiverRegistrationGroupBox.Location = new Point(5, 7);
            EmailReceiverRegistrationGroupBox.Name = "EmailReceiverRegistrationGroupBox";
            EmailReceiverRegistrationGroupBox.Size = new Size(522, 334);
            EmailReceiverRegistrationGroupBox.TabIndex = 1;
            EmailReceiverRegistrationGroupBox.TabStop = false;
            EmailReceiverRegistrationGroupBox.Text = "Emails Receiver  Registration";
            // 
            // EmailReceiverRegistrationDropDown
            // 
            EmailReceiverRegistrationDropDown.DisplayMember = "Text";
            EmailReceiverRegistrationDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            EmailReceiverRegistrationDropDown.FormattingEnabled = true;
            EmailReceiverRegistrationDropDown.Location = new Point(6, 26);
            EmailReceiverRegistrationDropDown.Name = "EmailReceiverRegistrationDropDown";
            EmailReceiverRegistrationDropDown.Size = new Size(429, 28);
            EmailReceiverRegistrationDropDown.TabIndex = 21;
            EmailReceiverRegistrationDropDown.ValueMember = "Value";
            EmailReceiverRegistrationDropDown.SelectedIndexChanged += EmailReceiverRegistrationDropDownSelectedIndexChanged;
            // 
            // EmailReceiverRegistrationIsMotor
            // 
            EmailReceiverRegistrationIsMotor.AutoSize = true;
            EmailReceiverRegistrationIsMotor.Location = new Point(116, 107);
            EmailReceiverRegistrationIsMotor.Name = "EmailReceiverRegistrationIsMotor";
            EmailReceiverRegistrationIsMotor.Size = new Size(18, 17);
            EmailReceiverRegistrationIsMotor.TabIndex = 20;
            EmailReceiverRegistrationIsMotor.UseVisualStyleBackColor = true;
            // 
            // UserRegistrationIsMotorLabel
            // 
            UserRegistrationIsMotorLabel.AutoSize = true;
            UserRegistrationIsMotorLabel.Location = new Point(6, 104);
            UserRegistrationIsMotorLabel.Name = "UserRegistrationIsMotorLabel";
            UserRegistrationIsMotorLabel.Size = new Size(50, 20);
            UserRegistrationIsMotorLabel.TabIndex = 19;
            UserRegistrationIsMotorLabel.Text = "Motor";
            // 
            // EmailReceiverRegistrationDeleteButton
            // 
            EmailReceiverRegistrationDeleteButton.Enabled = false;
            EmailReceiverRegistrationDeleteButton.Location = new Point(316, 283);
            EmailReceiverRegistrationDeleteButton.Name = "EmailReceiverRegistrationDeleteButton";
            EmailReceiverRegistrationDeleteButton.Size = new Size(94, 39);
            EmailReceiverRegistrationDeleteButton.TabIndex = 17;
            EmailReceiverRegistrationDeleteButton.Text = "Delete";
            EmailReceiverRegistrationDeleteButton.UseVisualStyleBackColor = true;
            EmailReceiverRegistrationDeleteButton.Click += EmailReceiverRegistrationDeleteButtonClick;
            // 
            // EmailReceiverRegistrationIsMedical
            // 
            EmailReceiverRegistrationIsMedical.AutoSize = true;
            EmailReceiverRegistrationIsMedical.Location = new Point(116, 130);
            EmailReceiverRegistrationIsMedical.Name = "EmailReceiverRegistrationIsMedical";
            EmailReceiverRegistrationIsMedical.Size = new Size(18, 17);
            EmailReceiverRegistrationIsMedical.TabIndex = 9;
            EmailReceiverRegistrationIsMedical.UseVisualStyleBackColor = true;
            // 
            // EmailReceiverRegistrationResetButton
            // 
            EmailReceiverRegistrationResetButton.Location = new Point(416, 283);
            EmailReceiverRegistrationResetButton.Name = "EmailReceiverRegistrationResetButton";
            EmailReceiverRegistrationResetButton.Size = new Size(94, 39);
            EmailReceiverRegistrationResetButton.TabIndex = 18;
            EmailReceiverRegistrationResetButton.Text = "Reset";
            EmailReceiverRegistrationResetButton.UseVisualStyleBackColor = true;
            EmailReceiverRegistrationResetButton.Click += EmailReceiverRegistrationResetButtonClick;
            // 
            // UserRegistrationIsMedicalLabel
            // 
            UserRegistrationIsMedicalLabel.AutoSize = true;
            UserRegistrationIsMedicalLabel.Location = new Point(6, 127);
            UserRegistrationIsMedicalLabel.Name = "UserRegistrationIsMedicalLabel";
            UserRegistrationIsMedicalLabel.Size = new Size(62, 20);
            UserRegistrationIsMedicalLabel.TabIndex = 8;
            UserRegistrationIsMedicalLabel.Text = "Medical";
            // 
            // EmailReceiverRegistrationRegisterButton
            // 
            EmailReceiverRegistrationRegisterButton.Location = new Point(116, 283);
            EmailReceiverRegistrationRegisterButton.Name = "EmailReceiverRegistrationRegisterButton";
            EmailReceiverRegistrationRegisterButton.Size = new Size(94, 39);
            EmailReceiverRegistrationRegisterButton.TabIndex = 15;
            EmailReceiverRegistrationRegisterButton.Text = "Register";
            EmailReceiverRegistrationRegisterButton.UseVisualStyleBackColor = true;
            EmailReceiverRegistrationRegisterButton.Click += EmailReceiverRegistrationRegisterButtonClick;
            // 
            // EmailReceiverRegistrationUpdateButton
            // 
            EmailReceiverRegistrationUpdateButton.Enabled = false;
            EmailReceiverRegistrationUpdateButton.Location = new Point(216, 283);
            EmailReceiverRegistrationUpdateButton.Name = "EmailReceiverRegistrationUpdateButton";
            EmailReceiverRegistrationUpdateButton.Size = new Size(94, 39);
            EmailReceiverRegistrationUpdateButton.TabIndex = 16;
            EmailReceiverRegistrationUpdateButton.Text = "Update";
            EmailReceiverRegistrationUpdateButton.UseVisualStyleBackColor = true;
            EmailReceiverRegistrationUpdateButton.Click += EmailReceiverRegistrationUpdateButtonClick;
            // 
            // EmailReceiverRegistrationEmail
            // 
            EmailReceiverRegistrationEmail.Location = new Point(116, 74);
            EmailReceiverRegistrationEmail.MaxLength = 320;
            EmailReceiverRegistrationEmail.Name = "EmailReceiverRegistrationEmail";
            EmailReceiverRegistrationEmail.Size = new Size(319, 27);
            EmailReceiverRegistrationEmail.TabIndex = 3;
            EmailReceiverRegistrationEmail.TextChanged += EmailReceiverRegistrationEmailTextChanged;
            // 
            // EmailReceiverRegistrationEmailLabel
            // 
            EmailReceiverRegistrationEmailLabel.AutoSize = true;
            EmailReceiverRegistrationEmailLabel.Location = new Point(6, 77);
            EmailReceiverRegistrationEmailLabel.Name = "EmailReceiverRegistrationEmailLabel";
            EmailReceiverRegistrationEmailLabel.Size = new Size(46, 20);
            EmailReceiverRegistrationEmailLabel.TabIndex = 2;
            EmailReceiverRegistrationEmailLabel.Text = "Email";
            // 
            // UserRegistrationNameErrorProvider
            // 
            UserRegistrationNameErrorProvider.ContainerControl = this;
            // 
            // UserRegistrationEmailErrorProvider
            // 
            UserRegistrationEmailErrorProvider.ContainerControl = this;
            // 
            // UserRegistrationUsernameErrorProvider
            // 
            UserRegistrationUsernameErrorProvider.ContainerControl = this;
            // 
            // UserRegistrationPasswordErrorProvider
            // 
            UserRegistrationPasswordErrorProvider.ContainerControl = this;
            // 
            // EmailReceiverRegistrationEmailErrorProvider
            // 
            EmailReceiverRegistrationEmailErrorProvider.ContainerControl = this;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 386);
            Controls.Add(AdminFormTab);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Alogospring Insurance";
            AdminFormTab.ResumeLayout(false);
            UsersTabPage.ResumeLayout(false);
            UserRegistrationGroupBox.ResumeLayout(false);
            UserRegistrationGroupBox.PerformLayout();
            EmailReceiversTabPage.ResumeLayout(false);
            EmailReceiverRegistrationGroupBox.ResumeLayout(false);
            EmailReceiverRegistrationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserRegistrationNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserRegistrationEmailErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserRegistrationUsernameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserRegistrationPasswordErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailReceiverRegistrationEmailErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AdminFormTab;
        private TabPage UsersTabPage;
        private TabPage EmailReceiversTabPage;
        private GroupBox UserRegistrationGroupBox;
        private Label UserRegistrationEmailLabel;
        private Label UserRegistrationNameLabel;
        private TextBox UserRegistrationName;
        private CheckBox UserRegistrationIsAdmin;
        private Label UserRegistrationIsAdminLabel;
        private TextBox UserRegistrationPassword;
        private Label UserRegistrationPasswordLabel;
        private TextBox UserRegistrationUsername;
        private Label UserRegistrationUsernameLabel;
        private Button UserRegistrationResetButton;
        private Button UserRegistrationDeleteButton;
        private Button UserRegistrationUpdateButton;
        private Button UserRegistrationRegisterButton;
        private GroupBox EmailReceiverRegistrationGroupBox;
        private CheckBox EmailReceiverRegistrationIsMotor;
        private Label UserRegistrationIsMotorLabel;
        private Button EmailReceiverRegistrationDeleteButton;
        private CheckBox EmailReceiverRegistrationIsMedical;
        private Button EmailReceiverRegistrationResetButton;
        private Label UserRegistrationIsMedicalLabel;
        private Button EmailReceiverRegistrationRegisterButton;
        private Button EmailReceiverRegistrationUpdateButton;
        private TextBox EmailReceiverRegistrationEmail;
        private Label EmailReceiverRegistrationEmailLabel;
        private ComboBox UserRegistrationDropDown;
        private TextBox UserRegistrationEmail;
        private ErrorProvider UserRegistrationNameErrorProvider;
        private ErrorProvider UserRegistrationEmailErrorProvider;
        private ErrorProvider UserRegistrationUsernameErrorProvider;
        private ErrorProvider UserRegistrationPasswordErrorProvider;
        private ComboBox EmailReceiverRegistrationDropDown;
        private ErrorProvider EmailReceiverRegistrationEmailErrorProvider;
    }
}