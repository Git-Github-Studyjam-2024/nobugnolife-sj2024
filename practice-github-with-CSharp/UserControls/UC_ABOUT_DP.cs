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
    public partial class UC_ABOUT_DP : UserControl
    {
        public UC_ABOUT_DP()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/duyphuong0k");
        }
    }
}
