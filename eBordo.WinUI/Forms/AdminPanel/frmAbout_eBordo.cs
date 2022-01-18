using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel
{
    public partial class frmAbout_eBordo : Form
    {
        public frmAbout_eBordo()
        {
            InitializeComponent();
        }

        private void frmAbout_eBordo_Load(object sender, EventArgs e)
        {
            //Forms.Igrač.fromAdminPanel prikazIgraca = new Forms.Igrač.fromAdminPanel();
            //prikazIgraca.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/harispandzic");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/haris-pand%C5%BEi%C4%87-3680951ab/?originalSubdomain=ba");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:", "pandzicharis@hotmail.com");
        }
    }
}
