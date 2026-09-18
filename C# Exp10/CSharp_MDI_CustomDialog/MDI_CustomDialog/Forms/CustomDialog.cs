using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDI_CustomDialog
{
    public class CustomDialog : Form
    {
        private Label nameLabel;
        private Label departmentLabel;
        private TextBox nameTextBox;
        private ComboBox departmentComboBox;
        private Button okButton;
        private Button cancelButton;

        public CustomDialog()
        {
            Text = "Custom Dialog Box";
            Size = new Size(450, 300);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            nameLabel = new Label
            {
                Text = "Name:",
                Location = new Point(40, 40),
                AutoSize = true
            };

            nameTextBox = new TextBox
            {
                Location = new Point(150, 35),
                Width = 220
            };

            departmentLabel = new Label
            {
                Text = "Department:",
                Location = new Point(40, 90),
                AutoSize = true
            };

            departmentComboBox = new ComboBox
            {
                Location = new Point(150, 85),
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            departmentComboBox.Items.Add("Information Technology");
            departmentComboBox.Items.Add("Computer Science");
            departmentComboBox.Items.Add("Electronics");
            departmentComboBox.Items.Add("Mechanical");

            okButton = new Button
            {
                Text = "OK",
                Location = new Point(150, 160),
                Width = 90
            };

            cancelButton = new Button
            {
                Text = "Cancel",
                Location = new Point(260, 160),
                Width = 90
            };

            okButton.Click += OkButton_Click;
            cancelButton.Click += CancelButton_Click;

            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(departmentLabel);
            Controls.Add(departmentComboBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);

            AcceptButton = okButton;
            CancelButton = cancelButton;
        }

        private void OkButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show(
                    "Please enter your name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (departmentComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a department.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}