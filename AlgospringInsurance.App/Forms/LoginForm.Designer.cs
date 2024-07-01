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
            LogoImagePictureBox = new PictureBox();
            HeadingLabel = new Label();
            LoginGroupBox = new GroupBox();
            LoginButton = new Button();
            ClearButton = new Button();
            Password = new TextBox();
            PasswordLabel = new Label();
            Username = new TextBox();
            UsernameLabel = new Label();
            ExitButton = new Button();
            UsernameErrorProvider = new ErrorProvider(components);
            PasswordErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)LogoImagePictureBox).BeginInit();
            LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsernameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // LogoImagePictureBox
            // 
            LogoImagePictureBox.Image = (Image)resources.GetObject("LogoImagePictureBox.Image");
            LogoImagePictureBox.Location = new Point(113, 14);
            LogoImagePictureBox.Name = "LogoImagePictureBox";
            LogoImagePictureBox.Size = new Size(185, 50);
            LogoImagePictureBox.TabIndex = 0;
            LogoImagePictureBox.TabStop = false;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadingLabel.Location = new Point(18, 67);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(362, 46);
            HeadingLabel.TabIndex = 1;
            HeadingLabel.Text = "Algospring Insurance";
            // 
            // LoginGroupBox
            // 
            LoginGroupBox.Controls.Add(LoginButton);
            LoginGroupBox.Controls.Add(ClearButton);
            LoginGroupBox.Controls.Add(Password);
            LoginGroupBox.Controls.Add(PasswordLabel);
            LoginGroupBox.Controls.Add(Username);
            LoginGroupBox.Controls.Add(UsernameLabel);
            LoginGroupBox.Location = new Point(12, 128);
            LoginGroupBox.Name = "LoginGroupBox";
            LoginGroupBox.Size = new Size(391, 168);
            LoginGroupBox.TabIndex = 2;
            LoginGroupBox.TabStop = false;
            LoginGroupBox.Text = "Login";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(265, 121);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 39);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButtonClick;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(165, 121);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 39);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButtonClick;
            // 
            // Password
            // 
            Password.Location = new Point(101, 79);
            Password.Name = "Password";
            Password.Size = new Size(258, 27);
            Password.TabIndex = 3;
            Password.TextChanged += PasswordTextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(6, 82);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // Username
            // 
            Username.Location = new Point(101, 37);
            Username.MaxLength = 20;
            Username.Name = "Username";
            Username.Size = new Size(258, 27);
            Username.TabIndex = 1;
            Username.TextChanged += UsernameTextChanged;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(6, 40);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(75, 20);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(309, 302);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 39);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButtonClick;
            // 
            // UsernameErrorProvider
            // 
            UsernameErrorProvider.ContainerControl = this;
            // 
            // PasswordErrorProvider
            // 
            PasswordErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 351);
            Controls.Add(ExitButton);
            Controls.Add(LoginGroupBox);
            Controls.Add(HeadingLabel);
            Controls.Add(LogoImagePictureBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Alogospring Insurance";
            ((System.ComponentModel.ISupportInitialize)LogoImagePictureBox).EndInit();
            LoginGroupBox.ResumeLayout(false);
            LoginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsernameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoImagePictureBox;
        private Label HeadingLabel;
        private GroupBox LoginGroupBox;
        private Button LoginButton;
        private Button ClearButton;
        private TextBox Password;
        private Label PasswordLabel;
        private TextBox Username;
        private Label UsernameLabel;
        private Button ExitButton;
        private ErrorProvider UsernameErrorProvider;
        private ErrorProvider PasswordErrorProvider;
    }
}
