using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDI_CustomDialog
{
    public partial class Form1 : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newChildMenu;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem toolsMenu;
        private ToolStripMenuItem customDialogMenu;
        private ToolStripMenuItem windowMenu;
        private ToolStripMenuItem cascadeMenu;
        private ToolStripMenuItem tileMenu;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem aboutMenu;

        public Form1()
        {
            InitializeComponent();

            IsMdiContainer = true;
            Text = "MDI Application with Custom Dialog";
            WindowState = FormWindowState.Maximized;

            CreateMenu();
        }

        private void CreateMenu()
        {
            menuStrip = new MenuStrip();

            fileMenu = new ToolStripMenuItem("File");
            newChildMenu = new ToolStripMenuItem("New Child");
            exitMenu = new ToolStripMenuItem("Exit");

            toolsMenu = new ToolStripMenuItem("Tools");
            customDialogMenu = new ToolStripMenuItem("Custom Dialog");

            windowMenu = new ToolStripMenuItem("Window");
            cascadeMenu = new ToolStripMenuItem("Cascade");
            tileMenu = new ToolStripMenuItem("Tile");

            helpMenu = new ToolStripMenuItem("Help");
            aboutMenu = new ToolStripMenuItem("About");

            newChildMenu.Click += NewChildMenu_Click;
            exitMenu.Click += ExitMenu_Click;
            customDialogMenu.Click += CustomDialogMenu_Click;
            cascadeMenu.Click += CascadeMenu_Click;
            tileMenu.Click += TileMenu_Click;
            aboutMenu.Click += AboutMenu_Click;

            fileMenu.DropDownItems.Add(newChildMenu);
            fileMenu.DropDownItems.Add(new ToolStripSeparator());
            fileMenu.DropDownItems.Add(exitMenu);

            toolsMenu.DropDownItems.Add(customDialogMenu);

            windowMenu.DropDownItems.Add(cascadeMenu);
            windowMenu.DropDownItems.Add(tileMenu);

            helpMenu.DropDownItems.Add(aboutMenu);

            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(toolsMenu);
            menuStrip.Items.Add(windowMenu);
            menuStrip.Items.Add(helpMenu);

            MainMenuStrip = menuStrip;
            Controls.Add(menuStrip);
        }

        private void NewChildMenu_Click(object? sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Show();
        }

        private void CustomDialogMenu_Click(object? sender, EventArgs e)
        {
            using (CustomDialog dialog = new CustomDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Details submitted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void CascadeMenu_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileMenu_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void AboutMenu_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "C# MDI Application\nCustom Dialog Box",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ExitMenu_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}