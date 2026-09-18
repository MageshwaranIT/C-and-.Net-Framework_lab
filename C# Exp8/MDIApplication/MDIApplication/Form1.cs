using System;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IsMdiContainer = true;

            MenuStrip menu = new MenuStrip();

            ToolStripMenuItem file = new ToolStripMenuItem("File");
            ToolStripMenuItem newWindow = new ToolStripMenuItem("New");
            ToolStripMenuItem exit = new ToolStripMenuItem("Exit");

            ToolStripMenuItem window = new ToolStripMenuItem("Window");
            ToolStripMenuItem cascade = new ToolStripMenuItem("Cascade");
            ToolStripMenuItem tile = new ToolStripMenuItem("Tile");

            newWindow.Click += NewWindow_Click;
            exit.Click += (s, e) => Application.Exit();

            cascade.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            tile.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);

            file.DropDownItems.Add(newWindow);
            file.DropDownItems.Add(exit);

            window.DropDownItems.Add(cascade);
            window.DropDownItems.Add(tile);

            menu.Items.Add(file);
            menu.Items.Add(window);

            MainMenuStrip = menu;
            Controls.Add(menu);
        }

        private void NewWindow_Click(object? sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Show();
        }
    }
}