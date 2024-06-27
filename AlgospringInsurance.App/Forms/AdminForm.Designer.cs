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
            AdminForm_Manage_TabPage = new TabControl();
            AdminForm_ManageUsers_Tab = new TabPage();
            AdminForm_UserRegistration_GroupBox = new GroupBox();
            AdminForm_Email_TextBox = new TextBox();
            AdminForm_Search_ComboBox = new ComboBox();
            UseRegistrationForm_Delete_Button = new Button();
            AdminForm_IsAdmin_CheckBox = new CheckBox();
            UseRegistrationForm_Clear_Button = new Button();
            AdminForm_IsAdmin_Label = new Label();
            UseRegistrationForm_Register_Button = new Button();
            AdminForm_Password_TextBox = new TextBox();
            UseRegistrationForm_Update_Button = new Button();
            AdminForm_Password_Label = new Label();
            AdminForm_Username_TextBox = new TextBox();
            AdminForm_Username_Label = new Label();
            AdminForm_Name_TextBox = new TextBox();
            AdminForm_Email_Label = new Label();
            AdminForm_Name_Label = new Label();
            AdminForm_ManageSenders_Tab = new TabPage();
            AdminForm_SenderRegistration_GroupBox = new GroupBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            AdminForm_Manage_TabPage.SuspendLayout();
            AdminForm_ManageUsers_Tab.SuspendLayout();
            AdminForm_UserRegistration_GroupBox.SuspendLayout();
            AdminForm_ManageSenders_Tab.SuspendLayout();
            AdminForm_SenderRegistration_GroupBox.SuspendLayout();
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
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Email_TextBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Search_ComboBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(UseRegistrationForm_Delete_Button);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_IsAdmin_CheckBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(UseRegistrationForm_Clear_Button);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_IsAdmin_Label);
            AdminForm_UserRegistration_GroupBox.Controls.Add(UseRegistrationForm_Register_Button);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Password_TextBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(UseRegistrationForm_Update_Button);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Password_Label);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Username_TextBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Username_Label);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Name_TextBox);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Email_Label);
            AdminForm_UserRegistration_GroupBox.Controls.Add(AdminForm_Name_Label);
            AdminForm_UserRegistration_GroupBox.Location = new Point(6, 6);
            AdminForm_UserRegistration_GroupBox.Name = "AdminForm_UserRegistration_GroupBox";
            AdminForm_UserRegistration_GroupBox.Size = new Size(522, 333);
            AdminForm_UserRegistration_GroupBox.TabIndex = 0;
            AdminForm_UserRegistration_GroupBox.TabStop = false;
            AdminForm_UserRegistration_GroupBox.Text = "User Registration";
            // 
            // AdminForm_Email_TextBox
            // 
            AdminForm_Email_TextBox.Location = new Point(115, 74);
            AdminForm_Email_TextBox.MaxLength = 320;
            AdminForm_Email_TextBox.Name = "AdminForm_Email_TextBox";
            AdminForm_Email_TextBox.Size = new Size(319, 27);
            AdminForm_Email_TextBox.TabIndex = 20;
            // 
            // AdminForm_Search_ComboBox
            // 
            AdminForm_Search_ComboBox.DisplayMember = "Text";
            AdminForm_Search_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AdminForm_Search_ComboBox.FormattingEnabled = true;
            AdminForm_Search_ComboBox.Location = new Point(6, 26);
            AdminForm_Search_ComboBox.Name = "AdminForm_Search_ComboBox";
            AdminForm_Search_ComboBox.Size = new Size(428, 28);
            AdminForm_Search_ComboBox.TabIndex = 19;
            AdminForm_Search_ComboBox.ValueMember = "Id";
            AdminForm_Search_ComboBox.SelectedIndexChanged += AdminForm_Search_ComboBox_SelectedIndexChanged;
            // 
            // UseRegistrationForm_Delete_Button
            // 
            UseRegistrationForm_Delete_Button.Location = new Point(315, 283);
            UseRegistrationForm_Delete_Button.Name = "UseRegistrationForm_Delete_Button";
            UseRegistrationForm_Delete_Button.Size = new Size(94, 39);
            UseRegistrationForm_Delete_Button.TabIndex = 17;
            UseRegistrationForm_Delete_Button.Text = "Delete";
            UseRegistrationForm_Delete_Button.UseVisualStyleBackColor = true;
            UseRegistrationForm_Delete_Button.Click += UseRegistrationForm_Delete_Button_Click;
            // 
            // AdminForm_IsAdmin_CheckBox
            // 
            AdminForm_IsAdmin_CheckBox.AutoSize = true;
            AdminForm_IsAdmin_CheckBox.Location = new Point(115, 240);
            AdminForm_IsAdmin_CheckBox.Name = "AdminForm_IsAdmin_CheckBox";
            AdminForm_IsAdmin_CheckBox.Size = new Size(18, 17);
            AdminForm_IsAdmin_CheckBox.TabIndex = 9;
            AdminForm_IsAdmin_CheckBox.UseVisualStyleBackColor = true;
            // 
            // UseRegistrationForm_Clear_Button
            // 
            UseRegistrationForm_Clear_Button.Location = new Point(415, 283);
            UseRegistrationForm_Clear_Button.Name = "UseRegistrationForm_Clear_Button";
            UseRegistrationForm_Clear_Button.Size = new Size(94, 39);
            UseRegistrationForm_Clear_Button.TabIndex = 18;
            UseRegistrationForm_Clear_Button.Text = "Reset";
            UseRegistrationForm_Clear_Button.UseVisualStyleBackColor = true;
            UseRegistrationForm_Clear_Button.Click += UseRegistrationForm_Clear_Button_Click;
            // 
            // AdminForm_IsAdmin_Label
            // 
            AdminForm_IsAdmin_Label.AutoSize = true;
            AdminForm_IsAdmin_Label.Location = new Point(6, 237);
            AdminForm_IsAdmin_Label.Name = "AdminForm_IsAdmin_Label";
            AdminForm_IsAdmin_Label.Size = new Size(91, 20);
            AdminForm_IsAdmin_Label.TabIndex = 8;
            AdminForm_IsAdmin_Label.Text = "Make admin";
            // 
            // UseRegistrationForm_Register_Button
            // 
            UseRegistrationForm_Register_Button.Location = new Point(115, 283);
            UseRegistrationForm_Register_Button.Name = "UseRegistrationForm_Register_Button";
            UseRegistrationForm_Register_Button.Size = new Size(94, 39);
            UseRegistrationForm_Register_Button.TabIndex = 15;
            UseRegistrationForm_Register_Button.Text = "Register";
            UseRegistrationForm_Register_Button.UseVisualStyleBackColor = true;
            UseRegistrationForm_Register_Button.Click += UseRegistrationForm_Register_Button_Click;
            // 
            // AdminForm_Password_TextBox
            // 
            AdminForm_Password_TextBox.Location = new Point(115, 195);
            AdminForm_Password_TextBox.MaxLength = 20;
            AdminForm_Password_TextBox.Name = "AdminForm_Password_TextBox";
            AdminForm_Password_TextBox.PlaceholderText = "Add a new password";
            AdminForm_Password_TextBox.Size = new Size(319, 27);
            AdminForm_Password_TextBox.TabIndex = 7;
            // 
            // UseRegistrationForm_Update_Button
            // 
            UseRegistrationForm_Update_Button.Location = new Point(215, 283);
            UseRegistrationForm_Update_Button.Name = "UseRegistrationForm_Update_Button";
            UseRegistrationForm_Update_Button.Size = new Size(94, 39);
            UseRegistrationForm_Update_Button.TabIndex = 16;
            UseRegistrationForm_Update_Button.Text = "Update";
            UseRegistrationForm_Update_Button.UseVisualStyleBackColor = true;
            UseRegistrationForm_Update_Button.Click += UseRegistrationForm_Update_Button_Click;
            // 
            // AdminForm_Password_Label
            // 
            AdminForm_Password_Label.AutoSize = true;
            AdminForm_Password_Label.Location = new Point(6, 198);
            AdminForm_Password_Label.Name = "AdminForm_Password_Label";
            AdminForm_Password_Label.Size = new Size(70, 20);
            AdminForm_Password_Label.TabIndex = 6;
            AdminForm_Password_Label.Text = "Password";
            // 
            // AdminForm_Username_TextBox
            // 
            AdminForm_Username_TextBox.Location = new Point(115, 153);
            AdminForm_Username_TextBox.MaxLength = 20;
            AdminForm_Username_TextBox.Name = "AdminForm_Username_TextBox";
            AdminForm_Username_TextBox.Size = new Size(319, 27);
            AdminForm_Username_TextBox.TabIndex = 5;
            // 
            // AdminForm_Username_Label
            // 
            AdminForm_Username_Label.AutoSize = true;
            AdminForm_Username_Label.Location = new Point(6, 156);
            AdminForm_Username_Label.Name = "AdminForm_Username_Label";
            AdminForm_Username_Label.Size = new Size(75, 20);
            AdminForm_Username_Label.TabIndex = 4;
            AdminForm_Username_Label.Text = "Username";
            // 
            // AdminForm_Name_TextBox
            // 
            AdminForm_Name_TextBox.Location = new Point(115, 113);
            AdminForm_Name_TextBox.MaxLength = 50;
            AdminForm_Name_TextBox.Name = "AdminForm_Name_TextBox";
            AdminForm_Name_TextBox.Size = new Size(319, 27);
            AdminForm_Name_TextBox.TabIndex = 3;
            // 
            // AdminForm_Email_Label
            // 
            AdminForm_Email_Label.AutoSize = true;
            AdminForm_Email_Label.Location = new Point(6, 116);
            AdminForm_Email_Label.Name = "AdminForm_Email_Label";
            AdminForm_Email_Label.Size = new Size(49, 20);
            AdminForm_Email_Label.TabIndex = 2;
            AdminForm_Email_Label.Text = "Name";
            // 
            // AdminForm_Name_Label
            // 
            AdminForm_Name_Label.AutoSize = true;
            AdminForm_Name_Label.Location = new Point(6, 77);
            AdminForm_Name_Label.Name = "AdminForm_Name_Label";
            AdminForm_Name_Label.Size = new Size(46, 20);
            AdminForm_Name_Label.TabIndex = 0;
            AdminForm_Name_Label.Text = "Email";
            // 
            // AdminForm_ManageSenders_Tab
            // 
            AdminForm_ManageSenders_Tab.Controls.Add(AdminForm_SenderRegistration_GroupBox);
            AdminForm_ManageSenders_Tab.Location = new Point(4, 29);
            AdminForm_ManageSenders_Tab.Name = "AdminForm_ManageSenders_Tab";
            AdminForm_ManageSenders_Tab.Padding = new Padding(3);
            AdminForm_ManageSenders_Tab.Size = new Size(538, 346);
            AdminForm_ManageSenders_Tab.TabIndex = 1;
            AdminForm_ManageSenders_Tab.Text = "Senders";
            AdminForm_ManageSenders_Tab.UseVisualStyleBackColor = true;
            // 
            // AdminForm_SenderRegistration_GroupBox
            // 
            AdminForm_SenderRegistration_GroupBox.Controls.Add(checkBox2);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(label2);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(button1);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(checkBox1);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(button2);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(label1);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(button3);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(button4);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(textBox3);
            AdminForm_SenderRegistration_GroupBox.Controls.Add(label4);
            AdminForm_SenderRegistration_GroupBox.Location = new Point(5, 6);
            AdminForm_SenderRegistration_GroupBox.Name = "AdminForm_SenderRegistration_GroupBox";
            AdminForm_SenderRegistration_GroupBox.Size = new Size(522, 334);
            AdminForm_SenderRegistration_GroupBox.TabIndex = 1;
            AdminForm_SenderRegistration_GroupBox.TabStop = false;
            AdminForm_SenderRegistration_GroupBox.Text = "Sender  Registration";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(116, 74);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 20;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 19;
            label2.Text = "Make admin";
            // 
            // button1
            // 
            button1.Location = new Point(316, 283);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 17;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(116, 110);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(416, 283);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 18;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 110);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 8;
            label1.Text = "Make admin";
            // 
            // button3
            // 
            button3.Location = new Point(116, 283);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 15;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(216, 283);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 16;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 33);
            textBox3.MaxLength = 320;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(319, 27);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 386);
            Controls.Add(AdminForm_Manage_TabPage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Alogospring Insurance";
            AdminForm_Manage_TabPage.ResumeLayout(false);
            AdminForm_ManageUsers_Tab.ResumeLayout(false);
            AdminForm_UserRegistration_GroupBox.ResumeLayout(false);
            AdminForm_UserRegistration_GroupBox.PerformLayout();
            AdminForm_ManageSenders_Tab.ResumeLayout(false);
            AdminForm_SenderRegistration_GroupBox.ResumeLayout(false);
            AdminForm_SenderRegistration_GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AdminForm_Manage_TabPage;
        private TabPage AdminForm_ManageUsers_Tab;
        private TabPage AdminForm_ManageSenders_Tab;
        private GroupBox AdminForm_UserRegistration_GroupBox;
        private Label AdminForm_Name_Label;
        private Label AdminForm_Email_Label;
        private TextBox AdminForm_Name_TextBox;
        private CheckBox AdminForm_IsAdmin_CheckBox;
        private Label AdminForm_IsAdmin_Label;
        private TextBox AdminForm_Password_TextBox;
        private Label AdminForm_Password_Label;
        private TextBox AdminForm_Username_TextBox;
        private Label AdminForm_Username_Label;
        private Button UseRegistrationForm_Clear_Button;
        private Button UseRegistrationForm_Delete_Button;
        private Button UseRegistrationForm_Update_Button;
        private Button UseRegistrationForm_Register_Button;
        private GroupBox AdminForm_SenderRegistration_GroupBox;
        private CheckBox checkBox2;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private Label label4;
        private ComboBox AdminForm_Search_ComboBox;
        private TextBox AdminForm_Email_TextBox;
    }
}