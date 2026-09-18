using System.Drawing;
using System.Windows.Forms;

namespace MDI_CustomDialog
{
    public class ChildForm : Form
    {
        public ChildForm()
        {
            Text = "Child Form";
            Size = new Size(500, 300);

            Label label = new Label
            {
                Text = "This is an MDI Child Form",
                AutoSize = true,
                Location = new Point(120, 100),
                Font = new Font("Arial", 16)
            };

            Controls.Add(label);
        }
    }
}