using System;
using System.Windows.Forms;

namespace CustomerDialogBox
{
    public partial class Form1 : Form
    {
        TextBox txtName, txtAddress, txtPhone, txtEmail;
        Button btnSubmit, btnClear;

        public Form1()
        {
            InitializeComponent();
            CreateCustomerDialog();
        }

        private void CreateCustomerDialog()
        {
            Text = "Customer Dialog Box";
            Width = 450;
            Height = 400;
            StartPosition = FormStartPosition.CenterScreen;

            Label lblName = new Label()
            {
                Text = "Customer Name:",
                Left = 30,
                Top = 40,
                Width = 120
            };

            txtName = new TextBox()
            {
                Left = 160,
                Top = 35,
                Width = 220
            };

            Label lblAddress = new Label()
            {
                Text = "Address:",
                Left = 30,
                Top = 90,
                Width = 120
            };

            txtAddress = new TextBox()
            {
                Left = 160,
                Top = 85,
                Width = 220
            };

            Label lblPhone = new Label()
            {
                Text = "Phone Number:",
                Left = 30,
                Top = 140,
                Width = 120
            };

            txtPhone = new TextBox()
            {
                Left = 160,
                Top = 135,
                Width = 220
            };

            Label lblEmail = new Label()
            {
                Text = "Email:",
                Left = 30,
                Top = 190,
                Width = 120
            };

            txtEmail = new TextBox()
            {
                Left = 160,
                Top = 185,
                Width = 220
            };

            btnSubmit = new Button()
            {
                Text = "Submit",
                Left = 160,
                Top = 240,
                Width = 100
            };

            btnClear = new Button()
            {
                Text = "Clear",
                Left = 280,
                Top = 240,
                Width = 100
            };

            btnSubmit.Click += BtnSubmit_Click;
            btnClear.Click += BtnClear_Click;

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show(
                    "Please enter Customer Name and Phone Number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string details =
                "Customer Name: " + txtName.Text +
                "\nAddress: " + txtAddress.Text +
                "\nPhone: " + txtPhone.Text +
                "\nEmail: " + txtEmail.Text;

            MessageBox.Show(
                details,
                "Customer Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }
    }
}