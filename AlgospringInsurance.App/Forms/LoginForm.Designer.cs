namespace AlgospringInsurance.App.Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginForm_Image_PictureBox = new PictureBox();
            LoginForm_Heading_Label = new Label();
            LoginForm_Login_GroupBox = new GroupBox();
            LoginForm_Login_Button = new Button();
            LoginForm_Clear_Button = new Button();
            LoginForm_Password_Textbox = new TextBox();
            LoginForm_Password_Label = new Label();
            LoginForm_Username_Textbox = new TextBox();
            LoginForm_Username_Label = new Label();
            LoginForm_Exit_Button = new Button();
            LoginForm_Username_ErrorProvider = new ErrorProvider(components);
            LoginForm_Password_ErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)LoginForm_Image_PictureBox).BeginInit();
            LoginForm_Login_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginForm_Username_ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginForm_Password_ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // LoginForm_Image_PictureBox
            // 
            LoginForm_Image_PictureBox.Image = (Image)resources.GetObject("LoginForm_Image_PictureBox.Image");
            LoginForm_Image_PictureBox.Location = new Point(113, 12);
            LoginForm_Image_PictureBox.Name = "LoginForm_Image_PictureBox";
            LoginForm_Image_PictureBox.Size = new Size(185, 50);
            LoginForm_Image_PictureBox.TabIndex = 0;
            LoginForm_Image_PictureBox.TabStop = false;
            // 
            // LoginForm_Heading_Label
            // 
            LoginForm_Heading_Label.AutoSize = true;
            LoginForm_Heading_Label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginForm_Heading_Label.Location = new Point(12, 65);
            LoginForm_Heading_Label.Name = "LoginForm_Heading_Label";
            LoginForm_Heading_Label.Size = new Size(362, 46);
            LoginForm_Heading_Label.TabIndex = 1;
            LoginForm_Heading_Label.Text = "Algospring Insurance";
            // 
            // LoginForm_Login_GroupBox
            // 
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Login_Button);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Clear_Button);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Password_Textbox);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Password_Label);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Username_Textbox);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Username_Label);
            LoginForm_Login_GroupBox.Location = new Point(12, 128);
            LoginForm_Login_GroupBox.Name = "LoginForm_Login_GroupBox";
            LoginForm_Login_GroupBox.Size = new Size(391, 168);
            LoginForm_Login_GroupBox.TabIndex = 2;
            LoginForm_Login_GroupBox.TabStop = false;
            LoginForm_Login_GroupBox.Text = "Login";
            // 
            // LoginForm_Login_Button
            // 
            LoginForm_Login_Button.Location = new Point(265, 121);
            LoginForm_Login_Button.Name = "LoginForm_Login_Button";
            LoginForm_Login_Button.Size = new Size(94, 39);
            LoginForm_Login_Button.TabIndex = 5;
            LoginForm_Login_Button.Text = "Login";
            LoginForm_Login_Button.UseVisualStyleBackColor = true;
            LoginForm_Login_Button.Click += LoginForm_Login_Button_Click;
            // 
            // LoginForm_Clear_Button
            // 
            LoginForm_Clear_Button.Location = new Point(165, 121);
            LoginForm_Clear_Button.Name = "LoginForm_Clear_Button";
            LoginForm_Clear_Button.Size = new Size(94, 39);
            LoginForm_Clear_Button.TabIndex = 4;
            LoginForm_Clear_Button.Text = "Clear";
            LoginForm_Clear_Button.UseVisualStyleBackColor = true;
            LoginForm_Clear_Button.Click += LoginForm_Clear_Button_Click;
            // 
            // LoginForm_Password_Textbox
            // 
            LoginForm_Password_Textbox.Location = new Point(101, 79);
            LoginForm_Password_Textbox.Name = "LoginForm_Password_Textbox";
            LoginForm_Password_Textbox.Size = new Size(258, 27);
            LoginForm_Password_Textbox.TabIndex = 3;
            LoginForm_Password_Textbox.TextChanged += LoginForm_Password_Textbox_TextChanged;
            // 
            // LoginForm_Password_Label
            // 
            LoginForm_Password_Label.AutoSize = true;
            LoginForm_Password_Label.Location = new Point(6, 82);
            LoginForm_Password_Label.Name = "LoginForm_Password_Label";
            LoginForm_Password_Label.Size = new Size(70, 20);
            LoginForm_Password_Label.TabIndex = 2;
            LoginForm_Password_Label.Text = "Password";
            // 
            // LoginForm_Username_Textbox
            // 
            LoginForm_Username_Textbox.Location = new Point(101, 37);
            LoginForm_Username_Textbox.MaxLength = 20;
            LoginForm_Username_Textbox.Name = "LoginForm_Username_Textbox";
            LoginForm_Username_Textbox.Size = new Size(258, 27);
            LoginForm_Username_Textbox.TabIndex = 1;
            LoginForm_Username_Textbox.TextChanged += LoginForm_Username_Textbox_TextChanged;
            // 
            // LoginForm_Username_Label
            // 
            LoginForm_Username_Label.AutoSize = true;
            LoginForm_Username_Label.Location = new Point(6, 40);
            LoginForm_Username_Label.Name = "LoginForm_Username_Label";
            LoginForm_Username_Label.Size = new Size(75, 20);
            LoginForm_Username_Label.TabIndex = 0;
            LoginForm_Username_Label.Text = "Username";
            // 
            // LoginForm_Exit_Button
            // 
            LoginForm_Exit_Button.Location = new Point(309, 302);
            LoginForm_Exit_Button.Name = "LoginForm_Exit_Button";
            LoginForm_Exit_Button.Size = new Size(94, 39);
            LoginForm_Exit_Button.TabIndex = 6;
            LoginForm_Exit_Button.Text = "Exit";
            LoginForm_Exit_Button.UseVisualStyleBackColor = true;
            LoginForm_Exit_Button.Click += LoginForm_Exit_Button_Click;
            // 
            // LoginForm_Username_ErrorProvider
            // 
            LoginForm_Username_ErrorProvider.ContainerControl = this;
            // 
            // LoginForm_Password_ErrorProvider
            // 
            LoginForm_Password_ErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 351);
            Controls.Add(LoginForm_Exit_Button);
            Controls.Add(LoginForm_Login_GroupBox);
            Controls.Add(LoginForm_Heading_Label);
            Controls.Add(LoginForm_Image_PictureBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Alogospring Insurance";
            ((System.ComponentModel.ISupportInitialize)LoginForm_Image_PictureBox).EndInit();
            LoginForm_Login_GroupBox.ResumeLayout(false);
            LoginForm_Login_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginForm_Username_ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginForm_Password_ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LoginForm_Image_PictureBox;
        private Label LoginForm_Heading_Label;
        private GroupBox LoginForm_Login_GroupBox;
        private Button LoginForm_Login_Button;
        private Button LoginForm_Clear_Button;
        private TextBox LoginForm_Password_Textbox;
        private Label LoginForm_Password_Label;
        private TextBox LoginForm_Username_Textbox;
        private Label LoginForm_Username_Label;
        private Button LoginForm_Exit_Button;
        private ErrorProvider LoginForm_Username_ErrorProvider;
        private ErrorProvider LoginForm_Password_ErrorProvider;
    }
}
