using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_github_with_CSharp.UserControls
{
    public partial class UC_ABOUT_CT : UserControl
    {
        public UC_ABOUT_CT()
        {
            InitializeComponent();
        }

  
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100045384972926");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/lightningflashh");
        }
    }
}
