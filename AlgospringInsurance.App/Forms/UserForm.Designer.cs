namespace AlgospringInsurance.App.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            MotorQuoteRequestLinkLabel = new LinkLabel();
            MotorInsuranceGroupBox = new GroupBox();
            MotorDescriptionLabel = new Label();
            MedicalInsuranceGroupBox = new GroupBox();
            MedicalDescriptionLabel = new Label();
            MedicalQuoteRequestLinkLabel = new LinkLabel();
            ExitLinkLabel = new LinkLabel();
            LogoutLinkLabel = new LinkLabel();
            WelcomeLabel = new Label();
            AdminLinkLabel = new LinkLabel();
            MotorInsuranceGroupBox.SuspendLayout();
            MedicalInsuranceGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MotorQuoteRequestLinkLabel
            // 
            MotorQuoteRequestLinkLabel.AutoSize = true;
            MotorQuoteRequestLinkLabel.Location = new Point(437, 54);
            MotorQuoteRequestLinkLabel.Name = "MotorQuoteRequestLinkLabel";
            MotorQuoteRequestLinkLabel.Size = new Size(62, 20);
            MotorQuoteRequestLinkLabel.TabIndex = 0;
            MotorQuoteRequestLinkLabel.TabStop = true;
            MotorQuoteRequestLinkLabel.Text = "Request";
            MotorQuoteRequestLinkLabel.LinkClicked += MotorQuoteRequestLinkClicked;
            // 
            // MotorInsuranceGroupBox
            // 
            MotorInsuranceGroupBox.Controls.Add(MotorDescriptionLabel);
            MotorInsuranceGroupBox.Controls.Add(MotorQuoteRequestLinkLabel);
            MotorInsuranceGroupBox.Location = new Point(13, 37);
            MotorInsuranceGroupBox.Name = "MotorInsuranceGroupBox";
            MotorInsuranceGroupBox.Size = new Size(505, 88);
            MotorInsuranceGroupBox.TabIndex = 1;
            MotorInsuranceGroupBox.TabStop = false;
            MotorInsuranceGroupBox.Text = "Motor";
            // 
            // MotorDescriptionLabel
            // 
            MotorDescriptionLabel.AutoSize = true;
            MotorDescriptionLabel.Location = new Point(6, 23);
            MotorDescriptionLabel.Name = "MotorDescriptionLabel";
            MotorDescriptionLabel.Size = new Size(444, 20);
            MotorDescriptionLabel.TabIndex = 1;
            MotorDescriptionLabel.Text = "Please proceed here to request a quotation for a motor insurance.";
            // 
            // MedicalInsuranceGroupBox
            // 
            MedicalInsuranceGroupBox.Controls.Add(MedicalDescriptionLabel);
            MedicalInsuranceGroupBox.Controls.Add(MedicalQuoteRequestLinkLabel);
            MedicalInsuranceGroupBox.Location = new Point(13, 131);
            MedicalInsuranceGroupBox.Name = "MedicalInsuranceGroupBox";
            MedicalInsuranceGroupBox.Size = new Size(505, 88);
            MedicalInsuranceGroupBox.TabIndex = 2;
            MedicalInsuranceGroupBox.TabStop = false;
            MedicalInsuranceGroupBox.Text = "Medical";
            // 
            // MedicalDescriptionLabel
            // 
            MedicalDescriptionLabel.AutoSize = true;
            MedicalDescriptionLabel.Location = new Point(6, 23);
            MedicalDescriptionLabel.Name = "MedicalDescriptionLabel";
            MedicalDescriptionLabel.Size = new Size(456, 20);
            MedicalDescriptionLabel.TabIndex = 1;
            MedicalDescriptionLabel.Text = "Please proceed here to request a quotation for a medical insurance.";
            // 
            // MedicalQuoteRequestLinkLabel
            // 
            MedicalQuoteRequestLinkLabel.AutoSize = true;
            MedicalQuoteRequestLinkLabel.Location = new Point(437, 52);
            MedicalQuoteRequestLinkLabel.Name = "MedicalQuoteRequestLinkLabel";
            MedicalQuoteRequestLinkLabel.Size = new Size(62, 20);
            MedicalQuoteRequestLinkLabel.TabIndex = 0;
            MedicalQuoteRequestLinkLabel.TabStop = true;
            MedicalQuoteRequestLinkLabel.Text = "Request";
            MedicalQuoteRequestLinkLabel.LinkClicked += MedicalQuoteRequestLinkClicked;
            // 
            // ExitLinkLabel
            // 
            ExitLinkLabel.AutoSize = true;
            ExitLinkLabel.Location = new Point(485, 222);
            ExitLinkLabel.Name = "ExitLinkLabel";
            ExitLinkLabel.Size = new Size(33, 20);
            ExitLinkLabel.TabIndex = 3;
            ExitLinkLabel.TabStop = true;
            ExitLinkLabel.Text = "Exit";
            ExitLinkLabel.LinkClicked += ExitLinkClicked;
            // 
            // LogoutLinkLabel
            // 
            LogoutLinkLabel.AutoSize = true;
            LogoutLinkLabel.Location = new Point(456, 5);
            LogoutLinkLabel.Name = "LogoutLinkLabel";
            LogoutLinkLabel.Size = new Size(56, 20);
            LogoutLinkLabel.TabIndex = 4;
            LogoutLinkLabel.TabStop = true;
            LogoutLinkLabel.Text = "Logout";
            LogoutLinkLabel.LinkClicked += LogoutLinkClicked;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Location = new Point(13, 5);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(133, 20);
            WelcomeLabel.TabIndex = 6;
            WelcomeLabel.Text = "Welcome, [name] !";
            // 
            // AdminLinkLabel
            // 
            AdminLinkLabel.AutoSize = true;
            AdminLinkLabel.Location = new Point(397, 5);
            AdminLinkLabel.Name = "AdminLinkLabel";
            AdminLinkLabel.Size = new Size(53, 20);
            AdminLinkLabel.TabIndex = 7;
            AdminLinkLabel.TabStop = true;
            AdminLinkLabel.Text = "Admin";
            AdminLinkLabel.LinkClicked += AdminLinkClicked;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 251);
            Controls.Add(AdminLinkLabel);
            Controls.Add(WelcomeLabel);
            Controls.Add(LogoutLinkLabel);
            Controls.Add(ExitLinkLabel);
            Controls.Add(MedicalInsuranceGroupBox);
            Controls.Add(MotorInsuranceGroupBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User - Alospring Insurance";
            Load += UserForm_Load;
            MotorInsuranceGroupBox.ResumeLayout(false);
            MotorInsuranceGroupBox.PerformLayout();
            MedicalInsuranceGroupBox.ResumeLayout(false);
            MedicalInsuranceGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel MotorQuoteRequestLinkLabel;
        private GroupBox MotorInsuranceGroupBox;
        private Label MotorDescriptionLabel;
        private GroupBox MedicalInsuranceGroupBox;
        private Label MedicalDescriptionLabel;
        private LinkLabel MedicalQuoteRequestLinkLabel;
        private LinkLabel ExitLinkLabel;
        private LinkLabel LogoutLinkLabel;
        private Label WelcomeLabel;
        private LinkLabel AdminLinkLabel;
    }
}