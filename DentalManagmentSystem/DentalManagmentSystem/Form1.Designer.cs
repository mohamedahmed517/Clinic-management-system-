namespace DentalManagmentSystem
{
    partial class Form1
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
            panel1 = new Panel();
            manageSystem = new Label();
            medvantageLogo = new PictureBox();
            loginAccount = new Label();
            usernameLabel = new Label();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            passwordLabel = new Label();
            showHidePassword = new CheckBox();
            login = new Button();
            exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medvantageLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 27, 0);
            panel1.Controls.Add(manageSystem);
            panel1.Controls.Add(medvantageLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 447);
            panel1.TabIndex = 0;
            // 
            // manageSystem
            // 
            manageSystem.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageSystem.ForeColor = SystemColors.ButtonHighlight;
            manageSystem.Location = new Point(22, 267);
            manageSystem.Name = "manageSystem";
            manageSystem.Size = new Size(293, 31);
            manageSystem.TabIndex = 1;
            manageSystem.Text = "Clinic Managment System";
            // 
            // medvantageLogo
            // 
            medvantageLogo.Image = Properties.Resources._4;
            medvantageLogo.Location = new Point(69, 91);
            medvantageLogo.Name = "medvantageLogo";
            medvantageLogo.Size = new Size(200, 200);
            medvantageLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            medvantageLogo.TabIndex = 0;
            medvantageLogo.TabStop = false;
            // 
            // loginAccount
            // 
            loginAccount.AutoSize = true;
            loginAccount.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAccount.Location = new Point(354, 54);
            loginAccount.Name = "loginAccount";
            loginAccount.Size = new Size(175, 27);
            loginAccount.TabIndex = 1;
            loginAccount.Text = "Login Account";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(354, 150);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(80, 18);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            // 
            // usernameInput
            // 
            usernameInput.BorderStyle = BorderStyle.None;
            usernameInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameInput.Location = new Point(354, 180);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(326, 31);
            usernameInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(354, 265);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(326, 31);
            passwordInput.TabIndex = 5;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Tahoma", 9F);
            passwordLabel.Location = new Point(354, 233);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(74, 18);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // showHidePassword
            // 
            showHidePassword.AutoSize = true;
            showHidePassword.Cursor = Cursors.Hand;
            showHidePassword.Location = new Point(546, 323);
            showHidePassword.Name = "showHidePassword";
            showHidePassword.Size = new Size(134, 24);
            showHidePassword.TabIndex = 6;
            showHidePassword.Text = "Show password";
            showHidePassword.UseVisualStyleBackColor = true;
            showHidePassword.CheckedChanged += showHidePassword_CheckedChanged;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(236, 27, 0);
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ButtonFace;
            login.Location = new Point(354, 370);
            login.Name = "login";
            login.Size = new Size(138, 48);
            login.TabIndex = 7;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(666, 9);
            exit.Name = "exit";
            exit.Size = new Size(22, 24);
            exit.TabIndex = 8;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 447);
            Controls.Add(exit);
            Controls.Add(login);
            Controls.Add(showHidePassword);
            Controls.Add(passwordInput);
            Controls.Add(passwordLabel);
            Controls.Add(usernameInput);
            Controls.Add(usernameLabel);
            Controls.Add(loginAccount);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)medvantageLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox medvantageLogo;
        private Label manageSystem;
        private Label loginAccount;
        private Label usernameLabel;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label passwordLabel;
        private CheckBox showHidePassword;
        private Button login;
        private Label exit;
    }
}
