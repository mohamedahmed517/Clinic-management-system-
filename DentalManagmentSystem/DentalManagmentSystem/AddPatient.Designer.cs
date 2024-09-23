namespace DentalManagmentSystem
{
    partial class AddPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            clearBtn = new Button();
            displayBtn = new Button();
            PatientsDataGridView = new DataGridView();
            patientDataLabel = new Label();
            panel2 = new Panel();
            idInput = new TextBox();
            idLabel = new Label();
            deleteDataBtn = new Button();
            updateDataBtn = new Button();
            addDataBtn = new Button();
            remainInput = new TextBox();
            remainLabel = new Label();
            genderLabel = new Label();
            genderInput = new ComboBox();
            teethInput = new TextBox();
            teethLabel = new Label();
            phoneInput = new TextBox();
            phoneLabel = new Label();
            dateInput = new TextBox();
            dateLabel = new Label();
            amountInput = new TextBox();
            amountLabel = new Label();
            ageInput = new TextBox();
            ageLabel = new Label();
            nameInput = new TextBox();
            nameLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientsDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(displayBtn);
            panel1.Controls.Add(PatientsDataGridView);
            panel1.Controls.Add(patientDataLabel);
            panel1.Location = new Point(16, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 451);
            panel1.TabIndex = 0;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(236, 27, 0);
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = SystemColors.ButtonFace;
            clearBtn.Location = new Point(813, 7);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(118, 38);
            clearBtn.TabIndex = 21;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // displayBtn
            // 
            displayBtn.BackColor = Color.FromArgb(236, 27, 0);
            displayBtn.Cursor = Cursors.Hand;
            displayBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayBtn.ForeColor = SystemColors.ButtonFace;
            displayBtn.Location = new Point(937, 7);
            displayBtn.Name = "displayBtn";
            displayBtn.Size = new Size(118, 38);
            displayBtn.TabIndex = 20;
            displayBtn.Text = "Display";
            displayBtn.UseVisualStyleBackColor = false;
            displayBtn.Click += displayBtn_Click;
            // 
            // PatientsDataGridView
            // 
            PatientsDataGridView.AllowUserToAddRows = false;
            PatientsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 27, 0);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PatientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PatientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientsDataGridView.EnableHeadersVisualStyles = false;
            PatientsDataGridView.Location = new Point(14, 51);
            PatientsDataGridView.MultiSelect = false;
            PatientsDataGridView.Name = "PatientsDataGridView";
            PatientsDataGridView.ReadOnly = true;
            PatientsDataGridView.RowHeadersVisible = false;
            PatientsDataGridView.RowHeadersWidth = 70;
            PatientsDataGridView.Size = new Size(1041, 383);
            PatientsDataGridView.TabIndex = 1;
            PatientsDataGridView.CellClick += PatientsDataGridView_CellClick;
            // 
            // patientDataLabel
            // 
            patientDataLabel.AutoSize = true;
            patientDataLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientDataLabel.ForeColor = Color.Black;
            patientDataLabel.Location = new Point(14, 7);
            patientDataLabel.Name = "patientDataLabel";
            patientDataLabel.Size = new Size(155, 31);
            patientDataLabel.TabIndex = 0;
            patientDataLabel.Text = "Patient's Data";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(idInput);
            panel2.Controls.Add(idLabel);
            panel2.Controls.Add(deleteDataBtn);
            panel2.Controls.Add(updateDataBtn);
            panel2.Controls.Add(addDataBtn);
            panel2.Controls.Add(remainInput);
            panel2.Controls.Add(remainLabel);
            panel2.Controls.Add(genderLabel);
            panel2.Controls.Add(genderInput);
            panel2.Controls.Add(teethInput);
            panel2.Controls.Add(teethLabel);
            panel2.Controls.Add(phoneInput);
            panel2.Controls.Add(phoneLabel);
            panel2.Controls.Add(dateInput);
            panel2.Controls.Add(dateLabel);
            panel2.Controls.Add(amountInput);
            panel2.Controls.Add(amountLabel);
            panel2.Controls.Add(ageInput);
            panel2.Controls.Add(ageLabel);
            panel2.Controls.Add(nameInput);
            panel2.Controls.Add(nameLabel);
            panel2.Location = new Point(16, 476);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 199);
            panel2.TabIndex = 1;
            // 
            // idInput
            // 
            idInput.Location = new Point(108, 26);
            idInput.Name = "idInput";
            idInput.ReadOnly = true;
            idInput.Size = new Size(195, 27);
            idInput.TabIndex = 23;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(55, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(34, 25);
            idLabel.TabIndex = 22;
            idLabel.Text = "ID:";
            // 
            // deleteDataBtn
            // 
            deleteDataBtn.BackColor = Color.FromArgb(236, 27, 0);
            deleteDataBtn.Cursor = Cursors.Hand;
            deleteDataBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteDataBtn.ForeColor = SystemColors.ButtonFace;
            deleteDataBtn.Location = new Point(937, 134);
            deleteDataBtn.Name = "deleteDataBtn";
            deleteDataBtn.Size = new Size(118, 38);
            deleteDataBtn.TabIndex = 21;
            deleteDataBtn.Text = "Delete";
            deleteDataBtn.UseVisualStyleBackColor = false;
            deleteDataBtn.Click += deleteDataBtn_Click;
            // 
            // updateDataBtn
            // 
            updateDataBtn.BackColor = Color.FromArgb(236, 27, 0);
            updateDataBtn.Cursor = Cursors.Hand;
            updateDataBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateDataBtn.ForeColor = SystemColors.ButtonFace;
            updateDataBtn.Location = new Point(937, 74);
            updateDataBtn.Name = "updateDataBtn";
            updateDataBtn.Size = new Size(118, 38);
            updateDataBtn.TabIndex = 20;
            updateDataBtn.Text = "Update";
            updateDataBtn.UseVisualStyleBackColor = false;
            updateDataBtn.Click += updateDataBtn_Click;
            // 
            // addDataBtn
            // 
            addDataBtn.BackColor = Color.FromArgb(236, 27, 0);
            addDataBtn.Cursor = Cursors.Hand;
            addDataBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDataBtn.ForeColor = SystemColors.ButtonFace;
            addDataBtn.Location = new Point(937, 18);
            addDataBtn.Name = "addDataBtn";
            addDataBtn.Size = new Size(118, 38);
            addDataBtn.TabIndex = 19;
            addDataBtn.Text = "Add";
            addDataBtn.UseVisualStyleBackColor = false;
            addDataBtn.Click += addDataBtn_Click;
            // 
            // remainInput
            // 
            remainInput.Location = new Point(721, 143);
            remainInput.Name = "remainInput";
            remainInput.Size = new Size(195, 27);
            remainInput.TabIndex = 18;
            // 
            // remainLabel
            // 
            remainLabel.AutoSize = true;
            remainLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remainLabel.Location = new Point(634, 144);
            remainLabel.Name = "remainLabel";
            remainLabel.Size = new Size(74, 25);
            remainLabel.TabIndex = 17;
            remainLabel.Text = "Remain:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderLabel.Location = new Point(323, 26);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(73, 25);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // genderInput
            // 
            genderInput.FormattingEnabled = true;
            genderInput.Items.AddRange(new object[] { "Male", "Female" });
            genderInput.Location = new Point(412, 25);
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(195, 28);
            genderInput.TabIndex = 15;
            // 
            // teethInput
            // 
            teethInput.Location = new Point(721, 29);
            teethInput.Name = "teethInput";
            teethInput.Size = new Size(195, 27);
            teethInput.TabIndex = 14;
            // 
            // teethLabel
            // 
            teethLabel.AutoSize = true;
            teethLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teethLabel.Location = new Point(648, 31);
            teethLabel.Name = "teethLabel";
            teethLabel.Size = new Size(57, 25);
            teethLabel.TabIndex = 13;
            teethLabel.Text = "Teeth:";
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(412, 142);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(195, 27);
            phoneInput.TabIndex = 12;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(334, 141);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(66, 25);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // dateInput
            // 
            dateInput.Location = new Point(412, 85);
            dateInput.Name = "dateInput";
            dateInput.Size = new Size(195, 27);
            dateInput.TabIndex = 9;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(343, 84);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(53, 25);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // amountInput
            // 
            amountInput.Location = new Point(721, 81);
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(195, 27);
            amountInput.TabIndex = 7;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(627, 83);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(81, 25);
            amountLabel.TabIndex = 6;
            amountLabel.Text = "Amount:";
            // 
            // ageInput
            // 
            ageInput.Location = new Point(108, 142);
            ageInput.Name = "ageInput";
            ageInput.Size = new Size(195, 27);
            ageInput.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageLabel.Location = new Point(41, 144);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(48, 25);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "Age:";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(108, 85);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(195, 27);
            nameInput.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(26, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddPatient";
            Size = new Size(1100, 692);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientsDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label patientDataLabel;
        private DataGridView PatientsDataGridView;
        private Panel panel2;
        private TextBox nameInput;
        private Label nameLabel;
        private TextBox dateInput;
        private Label dateLabel;
        private TextBox amountInput;
        private Label amountLabel;
        private TextBox ageInput;
        private Label ageLabel;
        private TextBox remainInput;
        private Label remainLabel;
        private Label genderLabel;
        private ComboBox genderInput;
        private TextBox teethInput;
        private Label teethLabel;
        private TextBox phoneInput;
        private Label phoneLabel;
        private Button addDataBtn;
        private Button deleteDataBtn;
        private Button updateDataBtn;
        private Button displayBtn;
        private TextBox idInput;
        private Label idLabel;
        private Button clearBtn;
    }
}
