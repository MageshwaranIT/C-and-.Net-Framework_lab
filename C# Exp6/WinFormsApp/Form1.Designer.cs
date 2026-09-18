namespace WindowsFormsControls
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            chkReading = new CheckBox();
            chkSports = new CheckBox();
            cmbCourse = new ComboBox();
            btnSubmit = new Button();

            SuspendLayout();

            // Label
            lblName.Text = "Name";
            lblName.Location = new System.Drawing.Point(30,30);

            // TextBox
            txtName.Location = new System.Drawing.Point(120,30);
            txtName.Width = 150;

            // Radio Buttons
            rbMale.Text = "Male";
            rbMale.Location = new System.Drawing.Point(30,70);

            rbFemale.Text = "Female";
            rbFemale.Location = new System.Drawing.Point(120,70);

            // Check Boxes
            chkReading.Text = "Reading";
            chkReading.Location = new System.Drawing.Point(30,110);

            chkSports.Text = "Sports";
            chkSports.Location = new System.Drawing.Point(120,110);

            // ComboBox
            cmbCourse.Location = new System.Drawing.Point(30,150);
            cmbCourse.Items.AddRange(new object[]
            {
                "B.Tech IT",
                "CSE",
                "ECE",
                "EEE"
            });

            // Button
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new System.Drawing.Point(30,200);
            btnSubmit.Click += btnSubmit_Click;

            // Form
            ClientSize = new System.Drawing.Size(350,280);

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(chkReading);
            Controls.Add(chkSports);
            Controls.Add(cmbCourse);
            Controls.Add(btnSubmit);

            Text = "Windows Forms Controls";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}