using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_github_with_CSharp.UserControls
{
    public partial class UC_ABOUT : UserControl
    {
        public UC_ABOUT()
        {
            InitializeComponent();

            tabDP.FlatStyle = FlatStyle.Flat;
            tabDP.FlatAppearance.BorderSize = 0;

            tabVP.FlatStyle = FlatStyle.Flat;
            tabVP.FlatAppearance.BorderSize = 0;

            tabTD.FlatStyle = FlatStyle.Flat;
            tabTD.FlatAppearance.BorderSize = 0;

            tabCT.FlatStyle = FlatStyle.Flat;
            tabCT.FlatAppearance.BorderSize = 0;
        }

        private void AddControlsToPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlAbout.Controls.Clear();
            pnlAbout.Controls.Add(uc);
            uc.BringToFront();
        }

        private void tabDP_Click(object sender, EventArgs e)
        {
            // Hightlight the tab, change font color and reset the other tabs
            tabDP.BackColor = Color.FromArgb(0, 0, 0);
            tabDP.ForeColor = Color.FromArgb(255, 255, 255);
            tabVP.BackColor = Color.Gainsboro;
            tabVP.ForeColor = Color.FromArgb(0, 0, 0);
            tabTD.BackColor = Color.Gainsboro;
            tabTD.ForeColor = Color.FromArgb(0, 0, 0);
            tabCT.BackColor = Color.Gainsboro;
            tabCT.ForeColor = Color.FromArgb(0, 0, 0);

            UC_ABOUT_DP uc = new UC_ABOUT_DP();
            AddControlsToPanel(uc);
        }

        private void tabVP_Click(object sender, EventArgs e)
        {
            tabVP.BackColor = Color.FromArgb(0, 0, 0);
            tabVP.ForeColor = Color.FromArgb(255, 255, 255);
            tabDP.BackColor = Color.Gainsboro;
            tabDP.ForeColor = Color.FromArgb(0, 0, 0);
            tabTD.BackColor = Color.Gainsboro;
            tabTD.ForeColor = Color.FromArgb(0, 0, 0);
            tabCT.BackColor = Color.Gainsboro;
            tabCT.ForeColor = Color.FromArgb(0, 0, 0);

            UC_ABOUT_VP uc = new UC_ABOUT_VP();
            AddControlsToPanel(uc);
        }

        private void tabTD_Click(object sender, EventArgs e)
        {
            tabTD.BackColor = Color.FromArgb(0, 0, 0);
            tabTD.ForeColor = Color.FromArgb(255, 255, 255);
            tabDP.BackColor = Color.Gainsboro;
            tabDP.ForeColor = Color.FromArgb(0, 0, 0);
            tabVP.BackColor = Color.Gainsboro;
            tabVP.ForeColor = Color.FromArgb(0, 0, 0);
            tabCT.BackColor = Color.Gainsboro;
            tabCT.ForeColor = Color.FromArgb(0, 0, 0);

            UC_ABOUT_TD uc = new UC_ABOUT_TD();
            AddControlsToPanel(uc);
        }

        private void tabCT_Click(object sender, EventArgs e)
        {
            tabCT.BackColor = Color.FromArgb(0, 0, 0);
            tabCT.ForeColor = Color.FromArgb(255, 255, 255);
            tabDP.BackColor = Color.Gainsboro;
            tabDP.ForeColor = Color.FromArgb(0, 0, 0);
            tabVP.BackColor = Color.Gainsboro;
            tabVP.ForeColor = Color.FromArgb(0, 0, 0);
            tabTD.BackColor = Color.Gainsboro;
            tabTD.ForeColor = Color.FromArgb(0, 0, 0);

            UC_ABOUT_CT uc = new UC_ABOUT_CT();
            AddControlsToPanel(uc);
        }
    }
}
