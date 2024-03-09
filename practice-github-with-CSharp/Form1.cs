using practice_github_with_CSharp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_github_with_CSharp
{
    public partial class Form1 : Form
    {

        bool mouseDown;
        public Form1()
        {
            InitializeComponent();

            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;

            tabHome.FlatStyle = FlatStyle.Flat;
            tabHome.FlatAppearance.BorderSize = 0;

            tabAbout.FlatStyle = FlatStyle.Flat;
            tabAbout.FlatAppearance.BorderSize = 0;

            tabContact.FlatStyle = FlatStyle.Flat;
            tabContact.FlatAppearance.BorderSize = 0;

            UC_HOME uc_home = new UC_HOME();
            AddControlsToPanel(uc_home);
        }


        private void AddControlsToPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(uc);
            uc.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hé lô!!!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void tabHome_Click(object sender, EventArgs e)
        {
            // Hightlight the tab, change font color and reset the other tabs
            tabHome.BackColor = Color.FromArgb(0, 0, 0);
            tabHome.ForeColor = Color.FromArgb(255, 255, 255);
            tabAbout.BackColor = SystemColors.Control;
            tabAbout.ForeColor = Color.FromArgb(0, 0, 0);
            tabContact.BackColor = SystemColors.Control;
            tabContact.ForeColor = Color.FromArgb(0, 0, 0);

            UC_HOME uc_home = new UC_HOME();
            AddControlsToPanel(uc_home);
        }

        private void tabAbout_Click(object sender, EventArgs e)
        {
            // Hightlight the tab, change font color and reset the other tabs
            tabAbout.BackColor = Color.FromArgb(0, 0, 0);
            tabAbout.ForeColor = Color.FromArgb(255, 255, 255);
            tabHome.BackColor = SystemColors.Control;
            tabHome.ForeColor = Color.FromArgb(0, 0, 0);
            tabContact.BackColor = SystemColors.Control;
            tabContact.ForeColor = Color.FromArgb(0, 0, 0);

            UC_ABOUT uc_about = new UC_ABOUT();
            AddControlsToPanel(uc_about);
        }

        private void tabContact_Click(object sender, EventArgs e)
        {
            // Hightlight the tab Home, change font color and reset the other tabs
            tabContact.BackColor = Color.FromArgb(0, 0, 0);
            tabContact.ForeColor = Color.FromArgb(255, 255, 255);
            tabHome.BackColor = SystemColors.Control;
            tabHome.ForeColor = Color.FromArgb(0, 0, 0);
            tabAbout.BackColor = SystemColors.Control;
            tabAbout.ForeColor = Color.FromArgb(0, 0, 0);

            UC_CONTACT uc_contact = new UC_CONTACT();
            AddControlsToPanel(uc_contact);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point(Cursor.Position.X - 400, Cursor.Position.Y - 20);
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
