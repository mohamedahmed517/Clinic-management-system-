namespace DentalManagmentSystem
{
    partial class Form2
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
            panel1 = new Panel();
            exit = new Label();
            medvantageLabel = new Label();
            panel2 = new Panel();
            signoutLabel = new Label();
            signoutBtn = new Button();
            dashboardBtn = new Button();
            addNurseBtn = new Button();
            addPatientBtn = new Button();
            medvantageLogo = new PictureBox();
            panel3 = new Panel();
            nurseData1 = new NurseData();
            dashboard1 = new Dashboard();
            addPatient3 = new AddPatient();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medvantageLogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 27, 0);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(medvantageLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1389, 75);
            panel1.TabIndex = 0;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ButtonFace;
            exit.Location = new Point(1349, 16);
            exit.Name = "exit";
            exit.Size = new Size(28, 31);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // medvantageLabel
            // 
            medvantageLabel.AutoSize = true;
            medvantageLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medvantageLabel.ForeColor = SystemColors.ButtonFace;
            medvantageLabel.Location = new Point(23, 23);
            medvantageLabel.Name = "medvantageLabel";
            medvantageLabel.Size = new Size(242, 22);
            medvantageLabel.TabIndex = 1;
            medvantageLabel.Text = "Clinic Managment System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 27, 0);
            panel2.Controls.Add(signoutLabel);
            panel2.Controls.Add(signoutBtn);
            panel2.Controls.Add(dashboardBtn);
            panel2.Controls.Add(addNurseBtn);
            panel2.Controls.Add(addPatientBtn);
            panel2.Controls.Add(medvantageLogo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 692);
            panel2.TabIndex = 1;
            // 
            // signoutLabel
            // 
            signoutLabel.AutoSize = true;
            signoutLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signoutLabel.ForeColor = SystemColors.ButtonFace;
            signoutLabel.Location = new Point(32, 616);
            signoutLabel.Name = "signoutLabel";
            signoutLabel.Size = new Size(89, 28);
            signoutLabel.TabIndex = 2;
            signoutLabel.Text = "Sign out";
            // 
            // signoutBtn
            // 
            signoutBtn.Cursor = Cursors.Hand;
            signoutBtn.FlatStyle = FlatStyle.Flat;
            signoutBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signoutBtn.ForeColor = Color.FromArgb(236, 27, 0);
            signoutBtn.Image = Properties.Resources.icons8_sign_out_25;
            signoutBtn.Location = new Point(219, 614);
            signoutBtn.Name = "signoutBtn";
            signoutBtn.Size = new Size(35, 33);
            signoutBtn.TabIndex = 5;
            signoutBtn.UseVisualStyleBackColor = false;
            signoutBtn.Click += signoutBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Cursor = Cursors.Hand;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = SystemColors.ButtonFace;
            dashboardBtn.Image = Properties.Resources.icons8_dashboard_25;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(32, 432);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(222, 50);
            dashboardBtn.TabIndex = 4;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // addNurseBtn
            // 
            addNurseBtn.Cursor = Cursors.Hand;
            addNurseBtn.FlatStyle = FlatStyle.Flat;
            addNurseBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNurseBtn.ForeColor = SystemColors.ButtonFace;
            addNurseBtn.Image = Properties.Resources.icons8_nurse_25;
            addNurseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addNurseBtn.Location = new Point(32, 335);
            addNurseBtn.Name = "addNurseBtn";
            addNurseBtn.Size = new Size(222, 50);
            addNurseBtn.TabIndex = 3;
            addNurseBtn.Text = "Add Nurse";
            addNurseBtn.UseVisualStyleBackColor = false;
            addNurseBtn.Click += addNurseBtn_Click;
            // 
            // addPatientBtn
            // 
            addPatientBtn.Cursor = Cursors.Hand;
            addPatientBtn.FlatStyle = FlatStyle.Flat;
            addPatientBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPatientBtn.ForeColor = SystemColors.ButtonFace;
            addPatientBtn.Image = Properties.Resources.icons8_dental_25;
            addPatientBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addPatientBtn.Location = new Point(32, 242);
            addPatientBtn.Name = "addPatientBtn";
            addPatientBtn.Size = new Size(222, 50);
            addPatientBtn.TabIndex = 2;
            addPatientBtn.Text = "Add Patient";
            addPatientBtn.UseVisualStyleBackColor = false;
            addPatientBtn.Click += addPatientBtn_Click;
            // 
            // medvantageLogo
            // 
            medvantageLogo.Image = Properties.Resources._4;
            medvantageLogo.Location = new Point(32, 6);
            medvantageLogo.Name = "medvantageLogo";
            medvantageLogo.Size = new Size(222, 196);
            medvantageLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            medvantageLogo.TabIndex = 2;
            medvantageLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(addPatient3);
            panel3.Controls.Add(nurseData1);
            panel3.Controls.Add(dashboard1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(289, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(1100, 692);
            panel3.TabIndex = 2;
            // 
            // nurseData1
            // 
            nurseData1.Location = new Point(0, 0);
            nurseData1.Name = "nurseData1";
            nurseData1.Size = new Size(1100, 692);
            nurseData1.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1100, 692);
            dashboard1.TabIndex = 2;
            // 
            // addPatient3
            // 
            addPatient3.Location = new Point(0, 0);
            addPatient3.Name = "addPatient3";
            addPatient3.Size = new Size(1100, 692);
            addPatient3.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 767);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medvantageLogo).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label medvantageLabel;
        private Panel panel2;
        private PictureBox medvantageLogo;
        private Button addPatientBtn;
        private Button dashboardBtn;
        private Button addNurseBtn;
        private Label exit;
        private Label signoutLabel;
        private Button signoutBtn;
        private Panel panel3;
        private AddPatient addPatient1;
        private AddPatient addPatient2;
        private NurseData nurseData1;
        private Dashboard dashboard1;
        private AddPatient addPatient3;
    }
}