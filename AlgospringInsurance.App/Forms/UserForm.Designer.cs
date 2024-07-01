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
            UserForm_MotorQuoteRequest_LinkLabel = new LinkLabel();
            UserForm_MotorInsurance_GroupBox = new GroupBox();
            UserForm_MotorDescription_Label = new Label();
            UserForm_MedicalInsurance_GroupBox = new GroupBox();
            UserForm_MedicalDescription_Label = new Label();
            UserForm_MedicalQuoteRequest_LinkLabel = new LinkLabel();
            UserForm_Exit_LinkLabel = new LinkLabel();
            UserForm_Logout_LinkLabel = new LinkLabel();
            UserForm_Welcome_Label = new Label();
            UserForm_Superadmin_LinkLabel = new LinkLabel();
            UserForm_MotorInsurance_GroupBox.SuspendLayout();
            UserForm_MedicalInsurance_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // UserForm_MotorQuoteRequest_LinkLabel
            // 
            UserForm_MotorQuoteRequest_LinkLabel.AutoSize = true;
            UserForm_MotorQuoteRequest_LinkLabel.Location = new Point(437, 54);
            UserForm_MotorQuoteRequest_LinkLabel.Name = "UserForm_MotorQuoteRequest_LinkLabel";
            UserForm_MotorQuoteRequest_LinkLabel.Size = new Size(62, 20);
            UserForm_MotorQuoteRequest_LinkLabel.TabIndex = 0;
            UserForm_MotorQuoteRequest_LinkLabel.TabStop = true;
            UserForm_MotorQuoteRequest_LinkLabel.Text = "Request";
            UserForm_MotorQuoteRequest_LinkLabel.LinkClicked += UserForm_MotorQuoteRequest_LinkLabel_LinkClicked;
            // 
            // UserForm_MotorInsurance_GroupBox
            // 
            UserForm_MotorInsurance_GroupBox.Controls.Add(UserForm_MotorDescription_Label);
            UserForm_MotorInsurance_GroupBox.Controls.Add(UserForm_MotorQuoteRequest_LinkLabel);
            UserForm_MotorInsurance_GroupBox.Location = new Point(13, 37);
            UserForm_MotorInsurance_GroupBox.Name = "UserForm_MotorInsurance_GroupBox";
            UserForm_MotorInsurance_GroupBox.Size = new Size(505, 88);
            UserForm_MotorInsurance_GroupBox.TabIndex = 1;
            UserForm_MotorInsurance_GroupBox.TabStop = false;
            UserForm_MotorInsurance_GroupBox.Text = "Motor";
            // 
            // UserForm_MotorDescription_Label
            // 
            UserForm_MotorDescription_Label.AutoSize = true;
            UserForm_MotorDescription_Label.Location = new Point(6, 23);
            UserForm_MotorDescription_Label.Name = "UserForm_MotorDescription_Label";
            UserForm_MotorDescription_Label.Size = new Size(444, 20);
            UserForm_MotorDescription_Label.TabIndex = 1;
            UserForm_MotorDescription_Label.Text = "Please proceed here to request a quotation for a motor insurance.";
            // 
            // UserForm_MedicalInsurance_GroupBox
            // 
            UserForm_MedicalInsurance_GroupBox.Controls.Add(UserForm_MedicalDescription_Label);
            UserForm_MedicalInsurance_GroupBox.Controls.Add(UserForm_MedicalQuoteRequest_LinkLabel);
            UserForm_MedicalInsurance_GroupBox.Location = new Point(13, 131);
            UserForm_MedicalInsurance_GroupBox.Name = "UserForm_MedicalInsurance_GroupBox";
            UserForm_MedicalInsurance_GroupBox.Size = new Size(505, 88);
            UserForm_MedicalInsurance_GroupBox.TabIndex = 2;
            UserForm_MedicalInsurance_GroupBox.TabStop = false;
            UserForm_MedicalInsurance_GroupBox.Text = "Medical";
            // 
            // UserForm_MedicalDescription_Label
            // 
            UserForm_MedicalDescription_Label.AutoSize = true;
            UserForm_MedicalDescription_Label.Location = new Point(6, 23);
            UserForm_MedicalDescription_Label.Name = "UserForm_MedicalDescription_Label";
            UserForm_MedicalDescription_Label.Size = new Size(456, 20);
            UserForm_MedicalDescription_Label.TabIndex = 1;
            UserForm_MedicalDescription_Label.Text = "Please proceed here to request a quotation for a medical insurance.";
            // 
            // UserForm_MedicalQuoteRequest_LinkLabel
            // 
            UserForm_MedicalQuoteRequest_LinkLabel.AutoSize = true;
            UserForm_MedicalQuoteRequest_LinkLabel.Location = new Point(437, 52);
            UserForm_MedicalQuoteRequest_LinkLabel.Name = "UserForm_MedicalQuoteRequest_LinkLabel";
            UserForm_MedicalQuoteRequest_LinkLabel.Size = new Size(62, 20);
            UserForm_MedicalQuoteRequest_LinkLabel.TabIndex = 0;
            UserForm_MedicalQuoteRequest_LinkLabel.TabStop = true;
            UserForm_MedicalQuoteRequest_LinkLabel.Text = "Request";
            UserForm_MedicalQuoteRequest_LinkLabel.LinkClicked += UserForm_MedicalQuoteRequest_LinkLabel_LinkClicked;
            // 
            // UserForm_Exit_LinkLabel
            // 
            UserForm_Exit_LinkLabel.AutoSize = true;
            UserForm_Exit_LinkLabel.Location = new Point(485, 222);
            UserForm_Exit_LinkLabel.Name = "UserForm_Exit_LinkLabel";
            UserForm_Exit_LinkLabel.Size = new Size(33, 20);
            UserForm_Exit_LinkLabel.TabIndex = 3;
            UserForm_Exit_LinkLabel.TabStop = true;
            UserForm_Exit_LinkLabel.Text = "Exit";
            UserForm_Exit_LinkLabel.LinkClicked += UserForm_Exit_LinkLabel_LinkClicked;
            // 
            // UserForm_Logout_LinkLabel
            // 
            UserForm_Logout_LinkLabel.AutoSize = true;
            UserForm_Logout_LinkLabel.Location = new Point(456, 5);
            UserForm_Logout_LinkLabel.Name = "UserForm_Logout_LinkLabel";
            UserForm_Logout_LinkLabel.Size = new Size(56, 20);
            UserForm_Logout_LinkLabel.TabIndex = 4;
            UserForm_Logout_LinkLabel.TabStop = true;
            UserForm_Logout_LinkLabel.Text = "Logout";
            UserForm_Logout_LinkLabel.LinkClicked += UserForm_Logout_LinkLabel_LinkClicked;
            // 
            // UserForm_Welcome_Label
            // 
            UserForm_Welcome_Label.AutoSize = true;
            UserForm_Welcome_Label.Location = new Point(13, 5);
            UserForm_Welcome_Label.Name = "UserForm_Welcome_Label";
            UserForm_Welcome_Label.Size = new Size(133, 20);
            UserForm_Welcome_Label.TabIndex = 6;
            UserForm_Welcome_Label.Text = "Welcome, [name] !";
            // 
            // UserForm_Superadmin_LinkLabel
            // 
            UserForm_Superadmin_LinkLabel.AutoSize = true;
            UserForm_Superadmin_LinkLabel.Location = new Point(397, 5);
            UserForm_Superadmin_LinkLabel.Name = "UserForm_Superadmin_LinkLabel";
            UserForm_Superadmin_LinkLabel.Size = new Size(53, 20);
            UserForm_Superadmin_LinkLabel.TabIndex = 7;
            UserForm_Superadmin_LinkLabel.TabStop = true;
            UserForm_Superadmin_LinkLabel.Text = "Admin";
            UserForm_Superadmin_LinkLabel.LinkClicked += UserForm_Superadmin_LinkLabel_LinkClicked;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 251);
            Controls.Add(UserForm_Superadmin_LinkLabel);
            Controls.Add(UserForm_Welcome_Label);
            Controls.Add(UserForm_Logout_LinkLabel);
            Controls.Add(UserForm_Exit_LinkLabel);
            Controls.Add(UserForm_MedicalInsurance_GroupBox);
            Controls.Add(UserForm_MotorInsurance_GroupBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User - Alospring Insurance";
            Load += UserForm_Load;
            UserForm_MotorInsurance_GroupBox.ResumeLayout(false);
            UserForm_MotorInsurance_GroupBox.PerformLayout();
            UserForm_MedicalInsurance_GroupBox.ResumeLayout(false);
            UserForm_MedicalInsurance_GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel UserForm_MotorQuoteRequest_LinkLabel;
        private GroupBox UserForm_MotorInsurance_GroupBox;
        private Label UserForm_MotorDescription_Label;
        private GroupBox UserForm_MedicalInsurance_GroupBox;
        private Label UserForm_MedicalDescription_Label;
        private LinkLabel UserForm_MedicalQuoteRequest_LinkLabel;
        private LinkLabel UserForm_Exit_LinkLabel;
        private LinkLabel UserForm_Logout_LinkLabel;
        private Label UserForm_Welcome_Label;
        private LinkLabel UserForm_Superadmin_LinkLabel;
    }
}