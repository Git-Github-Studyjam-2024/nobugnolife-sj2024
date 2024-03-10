using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_github_with_CSharp.UserControls
{
    public partial class UC_CONTACT : UserControl
    {
        public UC_CONTACT()
        {
            InitializeComponent();
        }

        private void tabHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi!");
        }
    }
}
