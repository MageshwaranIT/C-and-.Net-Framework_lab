using System;
using System.Windows.Forms;

namespace WindowsValidation
{
    public partial class Form1 : Form
    {
        TextBox nameBox = new TextBox();
        TextBox ageBox = new TextBox();
        Button btn = new Button();

        public Form1()
        {
            Text = "Data Validation";
            nameBox.PlaceholderText = "Enter Name";
            ageBox.PlaceholderText = "Enter Age";
            btn.Text = "Validate";

            nameBox.SetBounds(30, 30, 200, 30);
            ageBox.SetBounds(30, 70, 200, 30);
            btn.SetBounds(30, 110, 100, 30);

            btn.Click += ValidateData;

            Controls.Add(nameBox);
            Controls.Add(ageBox);
            Controls.Add(btn);
        }

        void ValidateData(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
                MessageBox.Show("Name is required.");
            else if (!int.TryParse(ageBox.Text, out int age) || age < 1 || age > 100)
                MessageBox.Show("Enter a valid age.");
            else
                MessageBox.Show("Data is Valid!");
        }
    }
}