namespace TextFileApplication
{
    partial class FrmRegistration
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
			lblTitle = new Label();
			lblStudentNo = new Label();
			txtStudentNo = new TextBox();
			lblProgram = new Label();
			cboProgram = new ComboBox();
			lblLastName = new Label();
			lblFirstName = new Label();
			txtLastName = new TextBox();
			txtFirstName = new TextBox();
			lblMI = new Label();
			txtMI = new TextBox();
			txtAge = new TextBox();
			lblAge = new Label();
			lblGender = new Label();
			cboGender = new ComboBox();
			lblBirthday = new Label();
			dtpBirthday = new DateTimePicker();
			lblContact = new Label();
			txtContact = new TextBox();
			btnRegister = new Button();
			SuspendLayout();
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.BackColor = SystemColors.ControlLight;
			lblTitle.Font = new Font("Rubik", 12F);
			lblTitle.ForeColor = Color.Black;
			lblTitle.Location = new Point(0, 19);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(100, 19);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Registration";
			// 
			// lblStudentNo
			// 
			lblStudentNo.AutoSize = true;
			lblStudentNo.Font = new Font("Rubik", 12F);
			lblStudentNo.ForeColor = Color.Black;
			lblStudentNo.Location = new Point(5, 65);
			lblStudentNo.Name = "lblStudentNo";
			lblStudentNo.Size = new Size(98, 19);
			lblStudentNo.TabIndex = 1;
			lblStudentNo.Text = "Student No.";
			// 
			// txtStudentNo
			// 
			txtStudentNo.Font = new Font("Rubik", 12F);
			txtStudentNo.Location = new Point(100, 62);
			txtStudentNo.MaxLength = 11;
			txtStudentNo.Name = "txtStudentNo";
			txtStudentNo.Size = new Size(160, 26);
			txtStudentNo.TabIndex = 2;
			// 
			// lblProgram
			// 
			lblProgram.AutoSize = true;
			lblProgram.Font = new Font("Rubik", 12F);
			lblProgram.ForeColor = Color.Black;
			lblProgram.Location = new Point(294, 65);
			lblProgram.Name = "lblProgram";
			lblProgram.Size = new Size(73, 19);
			lblProgram.TabIndex = 3;
			lblProgram.Text = "Program";
			// 
			// cboProgram
			// 
			cboProgram.DropDownStyle = ComboBoxStyle.DropDownList;
			cboProgram.FlatStyle = FlatStyle.Flat;
			cboProgram.Font = new Font("Rubik", 12F);
			cboProgram.FormattingEnabled = true;
			cboProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Business Administration", "BS Computer Engineering", "BS Criminology", "BS Tourism Management", "BS Hospitality Management" });
			cboProgram.Location = new Point(370, 61);
			cboProgram.Name = "cboProgram";
			cboProgram.Size = new Size(246, 27);
			cboProgram.TabIndex = 4;
			// 
			// lblLastName
			// 
			lblLastName.AutoSize = true;
			lblLastName.Font = new Font("Rubik", 12F);
			lblLastName.ForeColor = Color.Black;
			lblLastName.Location = new Point(11, 95);
			lblLastName.Name = "lblLastName";
			lblLastName.Size = new Size(88, 19);
			lblLastName.TabIndex = 5;
			lblLastName.Text = "Last Name";
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.Font = new Font("Rubik", 12F);
			lblFirstName.ForeColor = Color.Black;
			lblFirstName.Location = new Point(282, 95);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new Size(89, 19);
			lblFirstName.TabIndex = 6;
			lblFirstName.Text = "First Name";
			// 
			// txtLastName
			// 
			txtLastName.Font = new Font("Rubik", 12F);
			txtLastName.Location = new Point(100, 92);
			txtLastName.MaxLength = 100;
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(160, 26);
			txtLastName.TabIndex = 7;
			// 
			// txtFirstName
			// 
			txtFirstName.Font = new Font("Rubik", 12F);
			txtFirstName.Location = new Point(370, 92);
			txtFirstName.MaxLength = 100;
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(160, 26);
			txtFirstName.TabIndex = 8;
			// 
			// lblMI
			// 
			lblMI.AutoSize = true;
			lblMI.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblMI.ForeColor = Color.Black;
			lblMI.Location = new Point(536, 95);
			lblMI.Name = "lblMI";
			lblMI.Size = new Size(34, 19);
			lblMI.TabIndex = 9;
			lblMI.Text = "M.I.";
			// 
			// txtMI
			// 
			txtMI.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtMI.Location = new Point(572, 92);
			txtMI.MaxLength = 2;
			txtMI.Name = "txtMI";
			txtMI.Size = new Size(44, 26);
			txtMI.TabIndex = 10;
			// 
			// txtAge
			// 
			txtAge.Font = new Font("Rubik", 12F);
			txtAge.Location = new Point(100, 124);
			txtAge.MaxLength = 3;
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(71, 26);
			txtAge.TabIndex = 11;
			// 
			// lblAge
			// 
			lblAge.AutoSize = true;
			lblAge.Font = new Font("Rubik", 12F);
			lblAge.ForeColor = Color.Black;
			lblAge.Location = new Point(51, 127);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(39, 19);
			lblAge.TabIndex = 12;
			lblAge.Text = "Age";
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Font = new Font("Rubik", 12F);
			lblGender.ForeColor = Color.Black;
			lblGender.Location = new Point(301, 126);
			lblGender.Name = "lblGender";
			lblGender.Size = new Size(64, 19);
			lblGender.TabIndex = 13;
			lblGender.Text = "Gender";
			// 
			// cboGender
			// 
			cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
			cboGender.FlatStyle = FlatStyle.Flat;
			cboGender.Font = new Font("Rubik", 12F);
			cboGender.FormattingEnabled = true;
			cboGender.Items.AddRange(new object[] { "Male", "Female" });
			cboGender.Location = new Point(370, 122);
			cboGender.Name = "cboGender";
			cboGender.Size = new Size(120, 27);
			cboGender.TabIndex = 14;
			// 
			// lblBirthday
			// 
			lblBirthday.AutoSize = true;
			lblBirthday.Font = new Font("Rubik", 12F);
			lblBirthday.ForeColor = Color.Black;
			lblBirthday.Location = new Point(23, 159);
			lblBirthday.Name = "lblBirthday";
			lblBirthday.Size = new Size(74, 19);
			lblBirthday.TabIndex = 15;
			lblBirthday.Text = "Birthday";
			// 
			// dtpBirthday
			// 
			dtpBirthday.Font = new Font("Rubik", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpBirthday.Location = new Point(100, 156);
			dtpBirthday.Name = "dtpBirthday";
			dtpBirthday.Size = new Size(230, 23);
			dtpBirthday.TabIndex = 16;
			// 
			// lblContact
			// 
			lblContact.AutoSize = true;
			lblContact.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblContact.ForeColor = Color.Black;
			lblContact.Location = new Point(336, 161);
			lblContact.Name = "lblContact";
			lblContact.Size = new Size(97, 19);
			lblContact.TabIndex = 17;
			lblContact.Text = "Contact No.";
			// 
			// txtContact
			// 
			txtContact.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtContact.Location = new Point(443, 158);
			txtContact.MaxLength = 11;
			txtContact.Name = "txtContact";
			txtContact.Size = new Size(183, 26);
			txtContact.TabIndex = 18;
			// 
			// btnRegister
			// 
			btnRegister.BackColor = Color.White;
			btnRegister.Cursor = Cursors.Hand;
			btnRegister.FlatAppearance.BorderSize = 0;
			btnRegister.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
			btnRegister.FlatStyle = FlatStyle.Flat;
			btnRegister.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnRegister.ForeColor = Color.Black;
			btnRegister.Location = new Point(262, 213);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(118, 33);
			btnRegister.TabIndex = 19;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = false;
			btnRegister.Click += btnRegister_Click;
			// 
			// FrmRegistration
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLight;
			ClientSize = new Size(638, 268);
			Controls.Add(btnRegister);
			Controls.Add(txtContact);
			Controls.Add(lblContact);
			Controls.Add(dtpBirthday);
			Controls.Add(lblBirthday);
			Controls.Add(cboGender);
			Controls.Add(lblGender);
			Controls.Add(lblAge);
			Controls.Add(txtAge);
			Controls.Add(txtMI);
			Controls.Add(lblMI);
			Controls.Add(txtFirstName);
			Controls.Add(txtLastName);
			Controls.Add(lblFirstName);
			Controls.Add(lblLastName);
			Controls.Add(cboProgram);
			Controls.Add(lblProgram);
			Controls.Add(txtStudentNo);
			Controls.Add(lblStudentNo);
			Controls.Add(lblTitle);
			Font = new Font("Segoe UI", 10F);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "FrmRegistration";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FrmRegistration";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTitle;
        private Label lblStudentNo;
        private TextBox txtStudentNo;
        private Label lblProgram;
        private ComboBox cboProgram;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblMI;
        private TextBox txtMI;
        private TextBox txtAge;
        private Label lblAge;
        private Label lblGender;
        private ComboBox cboGender;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private Label lblContact;
        private TextBox txtContact;
        private Button btnRegister;
    }
}