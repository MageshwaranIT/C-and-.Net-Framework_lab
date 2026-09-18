using System;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = "";

            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";

            string course = cmbCourse.Text;

            string hobbies = "";

            if (chkReading.Checked)
                hobbies += "Reading ";

            if (chkSports.Checked)
                hobbies += "Sports ";

            MessageBox.Show(
                "Name : " + name +
                "\nGender : " + gender +
                "\nCourse : " + course +
                "\nHobbies : " + hobbies,
                "Student Details");
        }
    }
}