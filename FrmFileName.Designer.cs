namespace TextFileApplication
{
    partial class FrmFileName
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
			lblFileName = new Label();
			txtFileName = new TextBox();
			btnOkay = new Button();
			SuspendLayout();
			// 
			// lblFileName
			// 
			lblFileName.AutoSize = true;
			lblFileName.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblFileName.ForeColor = Color.Black;
			lblFileName.Location = new Point(25, 29);
			lblFileName.Name = "lblFileName";
			lblFileName.Size = new Size(126, 19);
			lblFileName.TabIndex = 0;
			lblFileName.Text = "Enter File Name";
			// 
			// txtFileName
			// 
			txtFileName.BackColor = Color.White;
			txtFileName.BorderStyle = BorderStyle.FixedSingle;
			txtFileName.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtFileName.Location = new Point(25, 62);
			txtFileName.Name = "txtFileName";
			txtFileName.Size = new Size(275, 26);
			txtFileName.TabIndex = 1;
			// 
			// btnOkay
			// 
			btnOkay.BackColor = Color.White;
			btnOkay.Cursor = Cursors.Hand;
			btnOkay.FlatAppearance.BorderSize = 0;
			btnOkay.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
			btnOkay.FlatStyle = FlatStyle.Flat;
			btnOkay.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnOkay.ForeColor = SystemColors.ActiveCaptionText;
			btnOkay.Location = new Point(98, 109);
			btnOkay.Name = "btnOkay";
			btnOkay.Size = new Size(120, 30);
			btnOkay.TabIndex = 2;
			btnOkay.Text = "Okay";
			btnOkay.UseVisualStyleBackColor = false;
			btnOkay.Click += btnOkay_Click;
			// 
			// FrmFileName
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLight;
			ClientSize = new Size(324, 156);
			Controls.Add(btnOkay);
			Controls.Add(txtFileName);
			Controls.Add(lblFileName);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FrmFileName";
			StartPosition = FormStartPosition.CenterParent;
			Text = "frmFileName";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblFileName;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}