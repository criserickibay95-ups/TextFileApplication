using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TextFileApplication
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var validationErrors = ValidateInputs();

            if (validationErrors.Any())
            {
                MessageBox.Show(
                    string.Join(Environment.NewLine, validationErrors),
                    "Validation Warnings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveStudentRecord();
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(
                    $"File save error: {ioEx.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private List<string> ValidateInputs()
        {
            var errors = new List<string>();

            if (!long.TryParse(txtStudentNo.Text, out _))
                errors.Add("• Student No.: Only numeric values are allowed.");

            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                !txtLastName.Text.All(c => char.IsLetter(c) || c == ' '))
                errors.Add("• Last Name: Only letters and spaces are allowed.");

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                !txtFirstName.Text.All(c => char.IsLetter(c) || c == ' '))
                errors.Add("• First Name: Only letters and spaces are allowed.");

            if (!int.TryParse(txtAge.Text, out int ageVal) || ageVal <= 0)
                errors.Add("• Age: Enter a valid positive number.");

            if (cboGender.SelectedIndex == -1)
                errors.Add("• Gender: Please select an option.");

            if (cboProgram.SelectedIndex == -1)
                errors.Add("• Program: Please select an option.");

            if (dtpBirthday.Value.Date > DateTime.Today)
                errors.Add("• Birthday: Date cannot be in the future.");

            if (string.IsNullOrWhiteSpace(txtContact.Text) ||
                !txtContact.Text.All(char.IsDigit))
                errors.Add("• Contact No.: Only digits are allowed.");

            return errors;
        }

        private void SaveStudentRecord()
        {
            string docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = $"{txtStudentNo.Text}.txt";
            string fullPath = Path.Combine(docsPath, fileName);

            var recordLines = new List<string>
            {
                $"Student No.: {txtStudentNo.Text}",
                $"Full Name: {txtLastName.Text.Trim()}, {txtFirstName.Text.Trim()} {txtMI.Text.Trim()}.",
                $"Program: {cboProgram.Text}",
                $"Gender: {cboGender.Text}",
                $"Age: {txtAge.Text}",
                $"Birthday: {dtpBirthday.Value:yyyy-MM-dd}",
                $"Contact No.: {txtContact.Text}"
            };

            File.WriteAllLines(fullPath, recordLines);

            MessageBox.Show(
                $"Registration successful!\nFile saved to:\n{docsPath}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
