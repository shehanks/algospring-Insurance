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
            AdminForm_Manage_TabPage = new TabControl();
            AdminForm_ManageUsers_Tab = new TabPage();
            AdminForm_UserRegistration_GroupBox = new GroupBox();
            AdminForm_UserRegistration_Email_TextBox = new TextBox();
            AdminForm_UserRegistration_ComboBox = new ComboBox();
            AdminForm_UserRegistration_Delete_Button = new Button();
            AdminForm_UserRegistration_IsAdmin_CheckBox = new CheckBox();
            AdminForm_UserRegistration_Reset_Button = new Button();
            AdminForm_UserRegistration_IsAdmin_Label = new Label();
            AdminForm_UserRegistration_Register_Button = new Button();
            AdminForm_UserRegistration_Password_TextBox = new TextBox();
            AdminForm_UserRegistration_Update_Button = new Button();
            AdminForm_UserRegistration_Password_Label = new Label();
            AdminForm_UserRegistration_Username_TextBox = new TextBox();
            AdminForm_UserRegistration_Username_Label = new Label();
            AdminForm_UserRegistration_Name_TextBox = new TextBox();
            AdminForm_UserRegistration_Name_Label = new Label();
            AdminForm_UserRegistration_Email_Label = new Label();
            AdminForm_ManageSenders_Tab = new TabPage();
            AdminForm_EmailReceiverRegistration_GroupBox = new GroupBox();
            AdminForm_EmailReceiverRegistration_ComboBox = new ComboBox();
            AdminForm_EmailReceiverRegistration_IsMotor_CheckBox = new CheckBox();
            AdminForm_UserRegistration_IsMotor_Label = new Label();
            AdminForm_EmailReceiverRegistration_Delete_Button = new Button();
            AdminForm_EmailReceiverRegistration_IsMedical_CheckBox = new CheckBox();
            AdminForm_EmailReceiverRegistration_Reset_Button = new Button();
            AdminForm_UserRegistration_IsMedical_Label = new Label();
            AdminForm_EmailReceiverRegistration_Register_Button = new Button();
            AdminForm_EmailReceiverRegistration_Update_Button = new Button();
            AdminForm_EmailReceiverRegistration_Email_TextBox = new TextBox();
            AdminForm_EmailReceiverRegistration_Email_Label = new Label();
            AdminForm_UserRegistration_Name_ErrorProvider = new ErrorProvider(components);
            AdminForm_UserRegistration_Email_ErrorProvider = new ErrorProvider(components);
            AdminForm_UserRegistration_Username_ErrorProvider = new ErrorProvider(components);
            AdminForm_UserRegistration_Password_ErrorProvider = new ErrorProvider(components);
            AdminForm_EmailReceiverRegistration_Email_ErrorProvider = new ErrorProvider(components);
            AdminForm_Manage_TabPage.SuspendLayout();
            AdminForm_ManageUsers_Tab.SuspendLayout();
            AdminForm_UserRegistration_GroupBox.SuspendLayout();
            AdminForm_ManageSenders_Tab.SuspendLayout();
            AdminForm_EmailReceiverRegistration_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminForm_UserRegistration_Name_ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminForm_UserRegistration_Email_ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminForm_UserRegistration_Username_ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminForm_UserRegistration_Password_ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminForm_EmailReceiverRegistration_Email_ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // AdminForm_Manage_TabPage
            // 
            AdminForm_Manage_TabPage.Controls.Add(AdminForm_ManageUsers_Tab);
            AdminForm_Manage_TabPage.Controls.Add(AdminForm_ManageSenders_Tab);
            AdminForm_Manage_TabPage.Location = new Point(5, 6);
            AdminForm_Manage_TabPage.Name = "AdminForm_Manage_TabPage";
            AdminForm_Manage_TabPage.SelectedIndex = 0;
            AdminForm_Manage_TabPage.Size = new Size(546, 379);
            AdminForm_Manage_TabPage.TabIndex = 0;
            // 
            // AdminForm_ManageUsers_Tab
            // 
            AdminForm_ManageUsers_Tab.Controls.Add(AdminForm_UserRegistration_GroupBox);
            AdminForm_ManageUsers_Tab.Location = new Point(4, 29);
            AdminForm_ManageUsers_Tab.Name = "AdminForm_ManageUsers_Tab";
            AdminForm_ManageUsers_Tab.Padding = new Padding(3);
            AdminForm_ManageUsers_Tab.Size = new Size(538, 346);
            AdminForm_ManageUsers_Tab.TabIndex = 0;
            AdminForm_ManageUsers_Tab.Text = "Users";
            AdminForm_ManageUsers_Tab.UseVisualStyleBackColor = true;
            // 
            // AdminForm_UserRegistration_GroupBox
            // 
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Email_TextBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_ComboBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Delete_Button);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_IsAdmin_CheckBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Reset_Button);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_IsAdmin_Label);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Register_Button);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Password_TextBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Update_Button);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Password_Label);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Username_TextBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Username_Label);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Name_TextBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Name_Label);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_Email_Label);
            AdminForm_UserRegistration_GroupBox.Location = new Point(6, 6);
            AdminForm_UserRegistration_GroupBox.Name = "AdminForm_UserRegistration_GroupBox";
            AdminForm_UserRegistration_GroupBox.Size = new Size(522, 333);
            AdminForm_UserRegistration_GroupBox.TabIndex = 0;
            AdminForm_UserRegistration_GroupBox.TabStop = false;
            AdminForm_UserRegistration_GroupBox.Text = "User Registration";
            // 
            // AdminForm_UserRegistration_Email_TextBox
            // 
            AdminForm_UserRegistration_Email_TextBox.Location = new Point(115, 108);
            AdminForm_UserRegistration_Email_TextBox.MaxLength = 320;
            AdminForm_UserRegistration_Email_TextBox.Name = "AdminForm_UserRegistration_Email_TextBox";
            AdminForm_UserRegistration_Email_TextBox.Size = new Size(319, 27);
            AdminForm_UserRegistration_Email_TextBox.TabIndex = 20;
            AdminForm_UserRegistration_Email_TextBox.TextChanged += AdminForm_UserRegistration_Email_TextBox_TextChanged;
            // 
            // AdminForm_UserRegistration_ComboBox
            // 
            AdminForm_UserRegistration_ComboBox.DisplayMember = "Text";
            AdminForm_UserRegistration_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AdminForm_UserRegistration_ComboBox.FormattingEnabled = true;
            AdminForm_UserRegistration_ComboBox.Location = new Point(6, 26);
            AdminForm_UserRegistration_ComboBox.Name = "AdminForm_UserRegistration_ComboBox";
            AdminForm_UserRegistration_ComboBox.Size = new Size(428, 28);
            AdminForm_UserRegistration_ComboBox.TabIndex = 19;
            AdminForm_UserRegistration_ComboBox.ValueMember = "Id";
            AdminForm_UserRegistration_ComboBox.SelectedIndexChanged += AdminForm_UserRegistration_ComboBox_SelectedIndexChanged;
            // 
            // AdminForm_UserRegistration_Delete_Button
            // 
            AdminForm_UserRegistration_Delete_Button.Enabled = false;
            AdminForm_UserRegistration_Delete_Button.Location = new Point(315, 283);
            AdminForm_UserRegistration_Delete_Button.Name = "AdminForm_UserRegistration_Delete_Button";
            AdminForm_UserRegistration_Delete_Button.Size = new Size(94, 39);
            AdminForm_UserRegistration_Delete_Button.TabIndex = 17;
            AdminForm_UserRegistration_Delete_Button.Text = "Delete";
            AdminForm_UserRegistration_Delete_Button.UseVisualStyleBackColor = true;
            AdminForm_UserRegistration_Delete_Button.Click += AdminForm_UserRegistration_Delete_Button_Click;
            // 
            // AdminForm_UserRegistration_IsAdmin_CheckBox
            // 
            AdminForm_UserRegistration_IsAdmin_CheckBox.AutoSize = true;
            AdminForm_UserRegistration_IsAdmin_CheckBox.Location = new Point(115, 207);
            AdminForm_UserRegistration_IsAdmin_CheckBox.Name = "AdminForm_UserRegistration_IsAdmin_CheckBox";
            AdminForm_UserRegistration_IsAdmin_CheckBox.Size = new Size(18, 17);
            AdminForm_UserRegistration_IsAdmin_CheckBox.TabIndex = 9;
            AdminForm_UserRegistration_IsAdmin_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminForm_UserRegistration_Reset_Button
            // 
            AdminForm_UserRegistration_Reset_Button.Location = new Point(415, 283);
            AdminForm_UserRegistration_Reset_Button.Name = "AdminForm_UserRegistration_Reset_Button";
            AdminForm_UserRegistration_Reset_Button.Size = new Size(94, 39);
            AdminForm_UserRegistration_Reset_Button.TabIndex = 18;
            AdminForm_UserRegistration_Reset_Button.Text = "Reset";
            AdminForm_UserRegistration_Reset_Button.UseVisualStyleBackColor = true;
            AdminForm_UserRegistration_Reset_Button.Click += AdminForm_UserRegistration_Reset_Button_Click;
            // 
            // AdminForm_UserRegistration_IsAdmin_Label
            // 
            AdminForm_UserRegistration_IsAdmin_Label.AutoSize = true;
            AdminForm_UserRegistration_IsAdmin_Label.Location = new Point(6, 204);
            AdminForm_UserRegistration_IsAdmin_Label.Name = "AdminForm_UserRegistration_IsAdmin_Label";
            AdminForm_UserRegistration_IsAdmin_Label.Size = new Size(91, 20);
            AdminForm_UserRegistration_IsAdmin_Label.TabIndex = 8;
            AdminForm_UserRegistration_IsAdmin_Label.Text = "Make admin";
            // 
            // AdminForm_UserRegistration_Register_Button
            // 
            AdminForm_UserRegistration_Register_Button.Location = new Point(115, 283);
            AdminForm_UserRegistration_Register_Button.Name = "AdminForm_UserRegistration_Register_Button";
            AdminForm_UserRegistration_Register_Button.Size = new Size(94, 39);
            AdminForm_UserRegistration_Register_Button.TabIndex = 15;
            AdminForm_UserRegistration_Register_Button.Text = "Register";
            AdminForm_UserRegistration_Register_Button.UseVisualStyleBackColor = true;
            AdminForm_UserRegistration_Register_Button.Click += AdminForm_UserRegistration_Register_Button_Click;
            // 
            // AdminForm_UserRegistration_Password_TextBox
            // 
            AdminForm_UserRegistration_Password_TextBox.Location = new Point(115, 174);
            AdminForm_UserRegistration_Password_TextBox.MaxLength = 20;
            AdminForm_UserRegistration_Password_TextBox.Name = "AdminForm_UserRegistration_Password_TextBox";
            AdminForm_UserRegistration_Password_TextBox.PlaceholderText = "Add a new password";
            AdminForm_UserRegistration_Password_TextBox.Size = new Size(319, 27);
            AdminForm_UserRegistration_Password_TextBox.TabIndex = 7;
            AdminForm_UserRegistration_Password_TextBox.TextChanged += AdminForm_UserRegistration_Password_TextBox_TextChanged;
            // 
            // AdminForm_UserRegistration_Update_Button
            // 
            AdminForm_UserRegistration_Update_Button.Enabled = false;
            AdminForm_UserRegistration_Update_Button.Location = new Point(215, 283);
            AdminForm_UserRegistration_Update_Button.Name = "AdminForm_UserRegistration_Update_Button";
            AdminForm_UserRegistration_Update_Button.Size = new Size(94, 39);
            AdminForm_UserRegistration_Update_Button.TabIndex = 16;
            AdminForm_UserRegistration_Update_Button.Text = "Update";
            AdminForm_UserRegistration_Update_Button.UseVisualStyleBackColor = true;
            AdminForm_UserRegistration_Update_Button.Click += AdminForm_UserRegistration_Update_Button_Click;
            // 
            // AdminForm_UserRegistration_Password_Label
            // 
            AdminForm_UserRegistration_Password_Label.AutoSize = true;
            AdminForm_UserRegistration_Password_Label.Location = new Point(6, 177);
            AdminForm_UserRegistration_Password_Label.Name = "AdminForm_UserRegistration_Password_Label";
            AdminForm_UserRegistration_Password_Label.Size = new Size(70, 20);
            AdminForm_UserRegistration_Password_Label.TabIndex = 6;
            AdminForm_UserRegistration_Password_Label.Text = "Password";
            // 
            // AdminForm_UserRegistration_Username_TextBox
            // 
            AdminForm_UserRegistration_Username_TextBox.Location = new Point(115, 141);
            AdminForm_UserRegistration_Username_TextBox.MaxLength = 20;
            AdminForm_UserRegistration_Username_TextBox.Name = "AdminForm_UserRegistration_Username_TextBox";
            AdminForm_UserRegistration_Username_TextBox.Size = new Size(319, 27);
            AdminForm_UserRegistration_Username_TextBox.TabIndex = 5;
            AdminForm_UserRegistration_Username_TextBox.TextChanged += AdminForm_UserRegistration_Username_TextBox_TextChanged;
            // 
            // AdminForm_UserRegistration_Username_Label
            // 
            AdminForm_UserRegistration_Username_Label.AutoSize = true;
            AdminForm_UserRegistration_Username_Label.Location = new Point(6, 144);
            AdminForm_UserRegistration_Username_Label.Name = "AdminForm_UserRegistration_Username_Label";
            AdminForm_UserRegistration_Username_Label.Size = new Size(75, 20);
            AdminForm_UserRegistration_Username_Label.TabIndex = 4;
            AdminForm_UserRegistration_Username_Label.Text = "Username";
            // 
            // AdminForm_UserRegistration_Name_TextBox
            // 
            AdminForm_UserRegistration_Name_TextBox.Location = new Point(115, 75);
            AdminForm_UserRegistration_Name_TextBox.MaxLength = 50;
            AdminForm_UserRegistration_Name_TextBox.Name = "AdminForm_UserRegistration_Name_TextBox";
            AdminForm_UserRegistration_Name_TextBox.Size = new Size(319, 27);
            AdminForm_UserRegistration_Name_TextBox.TabIndex = 3;
            AdminForm_UserRegistration_Name_TextBox.TextChanged += AdminForm_UserRegistration_Name_TextBox_TextChanged;
            // 
            // AdminForm_UserRegistration_Name_Label
            // 
            AdminForm_UserRegistration_Name_Label.AutoSize = true;
            AdminForm_UserRegistration_Name_Label.Location = new Point(6, 78);
            AdminForm_UserRegistration_Name_Label.Name = "AdminForm_UserRegistration_Name_Label";
            AdminForm_UserRegistration_Name_Label.Size = new Size(49, 20);
            AdminForm_UserRegistration_Name_Label.TabIndex = 2;
            AdminForm_UserRegistration_Name_Label.Text = "Name";
            // 
            // AdminForm_UserRegistration_Email_Label
            // 
            AdminForm_UserRegistration_Email_Label.AutoSize = true;
            AdminForm_UserRegistration_Email_Label.Location = new Point(6, 111);
            AdminForm_UserRegistration_Email_Label.Name = "AdminForm_UserRegistration_Email_Label";
            AdminForm_UserRegistration_Email_Label.Size = new Size(46, 20);
            AdminForm_UserRegistration_Email_Label.TabIndex = 0;
            AdminForm_UserRegistration_Email_Label.Text = "Email";
            // 
            // AdminForm_ManageSenders_Tab
            // 
            AdminForm_ManageSenders_Tab.Controls.Add(AdminForm_EmailReceiverRegistration_GroupBox);
            AdminForm_ManageSenders_Tab.Location = new Point(4, 29);
            AdminForm_ManageSenders_Tab.Name = "AdminForm_ManageSenders_Tab";
            AdminForm_ManageSenders_Tab.Padding = new Padding(3);
            AdminForm_ManageSenders_Tab.Size = new Size(538, 346);
            AdminForm_ManageSenders_Tab.TabIndex = 1;
            AdminForm_ManageSenders_Tab.Text = "Email Receivers";
            AdminForm_ManageSenders_Tab.UseVisualStyleBackColor = true;
            // 
            // AdminForm_EmailReceiverRegistration_GroupBox
            // 
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_ComboBox);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_IsMotor_CheckBox);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_IsMotor_Label);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_Delete_Button);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_IsMedical_CheckBox);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_Reset_Button);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_UserRegistration_IsMedical_Label);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_Register_Button);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_Update_Button);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_Email_TextBox);
            AdminForm_EmailReceiverRegistration_GroupBox.Controls.Add(AdminForm_EmailReceiverRegistration_Email_Label);
            AdminForm_EmailReceiverRegistration_GroupBox.Location = new Point(5, 7);
            AdminForm_EmailReceiverRegistration_GroupBox.Name = "AdminForm_EmailReceiverRegistration_GroupBox";
            AdminForm_EmailReceiverRegistration_GroupBox.Size = new Size(522, 334);
            AdminForm_EmailReceiverRegistration_GroupBox.TabIndex = 1;
            AdminForm_EmailReceiverRegistration_GroupBox.TabStop = false;
            AdminForm_EmailReceiverRegistration_GroupBox.Text = "Emails Receiver  Registration";
            // 
            // AdminForm_EmailReceiverRegistration_ComboBox
            // 
            AdminForm_EmailReceiverRegistration_ComboBox.DisplayMember = "Text";
            AdminForm_EmailReceiverRegistration_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AdminForm_EmailReceiverRegistration_ComboBox.FormattingEnabled = true;
            AdminForm_EmailReceiverRegistration_ComboBox.Location = new Point(6, 26);
            AdminForm_EmailReceiverRegistration_ComboBox.Name = "AdminForm_EmailReceiverRegistration_ComboBox";
            AdminForm_EmailReceiverRegistration_ComboBox.Size = new Size(429, 28);
            AdminForm_EmailReceiverRegistration_ComboBox.TabIndex = 21;
            AdminForm_EmailReceiverRegistration_ComboBox.ValueMember = "Id";
            AdminForm_EmailReceiverRegistration_ComboBox.SelectedIndexChanged += AdminForm_EmailReceiverRegistration_ComboBox_SelectedIndexChanged;
            // 
            // AdminForm_EmailReceiverRegistration_IsMotor_CheckBox
            // 
            AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.AutoSize = true;
            AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.Location = new Point(116, 107);
            AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.Name = "AdminForm_EmailReceiverRegistration_IsMotor_CheckBox";
            AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.Size = new Size(18, 17);
            AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.TabIndex = 20;
            AdminForm_EmailReceiverRegistration_IsMotor_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminForm_UserRegistration_IsMotor_Label
            // 
            AdminForm_UserRegistration_IsMotor_Label.AutoSize = true;
            AdminForm_UserRegistration_IsMotor_Label.Location = new Point(6, 104);
            AdminForm_UserRegistration_IsMotor_Label.Name = "AdminForm_UserRegistration_IsMotor_Label";
            AdminForm_UserRegistration_IsMotor_Label.Size = new Size(50, 20);
            AdminForm_UserRegistration_IsMotor_Label.TabIndex = 19;
            AdminForm_UserRegistration_IsMotor_Label.Text = "Motor";
            // 
            // AdminForm_EmailReceiverRegistration_Delete_Button
            // 
            AdminForm_EmailReceiverRegistration_Delete_Button.Enabled = false;
            AdminForm_EmailReceiverRegistration_Delete_Button.Location = new Point(316, 283);
            AdminForm_EmailReceiverRegistration_Delete_Button.Name = "AdminForm_EmailReceiverRegistration_Delete_Button";
            AdminForm_EmailReceiverRegistration_Delete_Button.Size = new Size(94, 39);
            AdminForm_EmailReceiverRegistration_Delete_Button.TabIndex = 17;
            AdminForm_EmailReceiverRegistration_Delete_Button.Text = "Delete";
            AdminForm_EmailReceiverRegistration_Delete_Button.UseVisualStyleBackColor = true;
            AdminForm_EmailReceiverRegistration_Delete_Button.Click += AdminForm_EmailReceiverRegistration_Delete_Button_Click;
            // 
            // AdminForm_EmailReceiverRegistration_IsMedical_CheckBox
            // 
            AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.AutoSize = true;
            AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.Location = new Point(116, 130);
            AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.Name = "AdminForm_EmailReceiverRegistration_IsMedical_CheckBox";
            AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.Size = new Size(18, 17);
            AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.TabIndex = 9;
            AdminForm_EmailReceiverRegistration_IsMedical_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminForm_EmailReceiverRegistration_Reset_Button
            // 
            AdminForm_EmailReceiverRegistration_Reset_Button.Location = new Point(416, 283);
            AdminForm_EmailReceiverRegistration_Reset_Button.Name = "AdminForm_EmailReceiverRegistration_Reset_Button";
            AdminForm_EmailReceiverRegistration_Reset_Button.Size = new Size(94, 39);
            AdminForm_EmailReceiverRegistration_Reset_Button.TabIndex = 18;
            AdminForm_EmailReceiverRegistration_Reset_Button.Text = "Reset";
            AdminForm_EmailReceiverRegistration_Reset_Button.UseVisualStyleBackColor = true;
            AdminForm_EmailReceiverRegistration_Reset_Button.Click += AdminForm_EmailReceiverRegistration_Reset_Button_Click;
            // 
            // AdminForm_UserRegistration_IsMedical_Label
            // 
            AdminForm_UserRegistration_IsMedical_Label.AutoSize = true;
            AdminForm_UserRegistration_IsMedical_Label.Location = new Point(6, 127);
            AdminForm_UserRegistration_IsMedical_Label.Name = "AdminForm_UserRegistration_IsMedical_Label";
            AdminForm_UserRegistration_IsMedical_Label.Size = new Size(62, 20);
            AdminForm_UserRegistration_IsMedical_Label.TabIndex = 8;
            AdminForm_UserRegistration_IsMedical_Label.Text = "Medical";
            // 
            // AdminForm_EmailReceiverRegistration_Register_Button
            // 
            AdminForm_EmailReceiverRegistration_Register_Button.Location = new Point(116, 283);
            AdminForm_EmailReceiverRegistration_Register_Button.Name = "AdminForm_EmailReceiverRegistration_Register_Button";
            AdminForm_EmailReceiverRegistration_Register_Button.Size = new Size(94, 39);
            AdminForm_EmailReceiverRegistration_Register_Button.TabIndex = 15;
            AdminForm_EmailReceiverRegistration_Register_Button.Text = "Register";
            AdminForm_EmailReceiverRegistration_Register_Button.UseVisualStyleBackColor = true;
            AdminForm_EmailReceiverRegistration_Register_Button.Click += AdminForm_EmailReceiverRegistration_Register_Button_Click;
            // 
            // AdminForm_EmailReceiverRegistration_Update_Button
            // 
            AdminForm_EmailReceiverRegistration_Update_Button.Enabled = false;
            AdminForm_EmailReceiverRegistration_Update_Button.Location = new Point(216, 283);
            AdminForm_EmailReceiverRegistration_Update_Button.Name = "AdminForm_EmailReceiverRegistration_Update_Button";
            AdminForm_EmailReceiverRegistration_Update_Button.Size = new Size(94, 39);
            AdminForm_EmailReceiverRegistration_Update_Button.TabIndex = 16;
            AdminForm_EmailReceiverRegistration_Update_Button.Text = "Update";
            AdminForm_EmailReceiverRegistration_Update_Button.UseVisualStyleBackColor = true;
            AdminForm_EmailReceiverRegistration_Update_Button.Click += AdminForm_EmailReceiverRegistration_Update_Button_Click;
            // 
            // AdminForm_EmailReceiverRegistration_Email_TextBox
            // 
            AdminForm_EmailReceiverRegistration_Email_TextBox.Location = new Point(116, 74);
            AdminForm_EmailReceiverRegistration_Email_TextBox.MaxLength = 320;
            AdminForm_EmailReceiverRegistration_Email_TextBox.Name = "AdminForm_EmailReceiverRegistration_Email_TextBox";
            AdminForm_EmailReceiverRegistration_Email_TextBox.Size = new Size(319, 27);
            AdminForm_EmailReceiverRegistration_Email_TextBox.TabIndex = 3;
            AdminForm_EmailReceiverRegistration_Email_TextBox.TextChanged += AdminForm_EmailReceiverRegistration_Email_TextBox_TextChanged;
            // 
            // AdminForm_EmailReceiverRegistration_Email_Label
            // 
            AdminForm_EmailReceiverRegistration_Email_Label.AutoSize = true;
            AdminForm_EmailReceiverRegistration_Email_Label.Location = new Point(6, 77);
            AdminForm_EmailReceiverRegistration_Email_Label.Name = "AdminForm_EmailReceiverRegistration_Email_Label";
            AdminForm_EmailReceiverRegistration_Email_Label.Size = new Size(46, 20);
            AdminForm_EmailReceiverRegistration_Email_Label.TabIndex = 2;
            AdminForm_EmailReceiverRegistration_Email_Label.Text = "Email";
            // 
            // AdminForm_UserRegistration_Name_ErrorProvider
            // 
            AdminForm_UserRegistration_Name_ErrorProvider.ContainerControl = this;
            // 
            // AdminForm_UserRegistration_Email_ErrorProvider
            // 
            AdminForm_UserRegistration_Email_ErrorProvider.ContainerControl = this;
            // 
            // AdminForm_UserRegistration_Username_ErrorProvider
            // 
            AdminForm_UserRegistration_Username_ErrorProvider.ContainerControl = this;
            // 
            // AdminForm_UserRegistration_Password_ErrorProvider
            // 
            AdminForm_UserRegistration_Password_ErrorProvider.ContainerControl = this;
            // 
            // AdminForm_EmailReceiverRegistration_Email_ErrorProvider
            // 
            AdminForm_EmailReceiverRegistration_Email_ErrorProvider.ContainerControl = this;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 386);
            Controls.Add(AdminForm_Manage_TabPage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Alogospring Insurance";
            AdminForm_Manage_TabPage.ResumeLayout(false);
            AdminForm_ManageUsers_Tab.ResumeLayout(false);
            AdminForm_UserRegistration_GroupBox.ResumeLayout(false);
            AdminForm_UserRegistration_GroupBox.PerformLayout();
            AdminForm_ManageSenders_Tab.ResumeLayout(false);
            AdminForm_EmailReceiverRegistration_GroupBox.ResumeLayout(false);
            AdminForm_EmailReceiverRegistration_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminForm_UserRegistration_Name_ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminForm_UserRegistration_Email_ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminForm_UserRegistration_Username_ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminForm_UserRegistration_Password_ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminForm_EmailReceiverRegistration_Email_ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AdminForm_Manage_TabPage;
        private TabPage AdminForm_ManageUsers_Tab;
        private TabPage AdminForm_ManageSenders_Tab;
        private GroupBox AdminForm_UserRegistration_GroupBox;
        private Label AdminForm_UserRegistration_Email_Label;
        private Label AdminForm_UserRegistration_Name_Label;
        private TextBox AdminForm_UserRegistration_Name_TextBox;
        private CheckBox AdminForm_UserRegistration_IsAdmin_CheckBox;
        private Label AdminForm_UserRegistration_IsAdmin_Label;
        private TextBox AdminForm_UserRegistration_Password_TextBox;
        private Label AdminForm_UserRegistration_Password_Label;
        private TextBox AdminForm_UserRegistration_Username_TextBox;
        private Label AdminForm_UserRegistration_Username_Label;
        private Button AdminForm_UserRegistration_Reset_Button;
        private Button AdminForm_UserRegistration_Delete_Button;
        private Button AdminForm_UserRegistration_Update_Button;
        private Button AdminForm_UserRegistration_Register_Button;
        private GroupBox AdminForm_EmailReceiverRegistration_GroupBox;
        private CheckBox AdminForm_EmailReceiverRegistration_IsMotor_CheckBox;
        private Label AdminForm_UserRegistration_IsMotor_Label;
        private Button AdminForm_EmailReceiverRegistration_Delete_Button;
        private CheckBox AdminForm_EmailReceiverRegistration_IsMedical_CheckBox;
        private Button AdminForm_EmailReceiverRegistration_Reset_Button;
        private Label AdminForm_UserRegistration_IsMedical_Label;
        private Button AdminForm_EmailReceiverRegistration_Register_Button;
        private Button AdminForm_EmailReceiverRegistration_Update_Button;
        private TextBox AdminForm_EmailReceiverRegistration_Email_TextBox;
        private Label AdminForm_EmailReceiverRegistration_Email_Label;
        private ComboBox AdminForm_UserRegistration_ComboBox;
        private TextBox AdminForm_UserRegistration_Email_TextBox;
        private ErrorProvider AdminForm_UserRegistration_Name_ErrorProvider;
        private ErrorProvider AdminForm_UserRegistration_Email_ErrorProvider;
        private ErrorProvider AdminForm_UserRegistration_Username_ErrorProvider;
        private ErrorProvider AdminForm_UserRegistration_Password_ErrorProvider;
        private ComboBox AdminForm_EmailReceiverRegistration_ComboBox;
        private ErrorProvider AdminForm_EmailReceiverRegistration_Email_ErrorProvider;
    }
}