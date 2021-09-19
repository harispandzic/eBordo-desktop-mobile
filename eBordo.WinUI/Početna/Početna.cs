using eBordo.WinUI.Igrač;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Početna
{
    public partial class frmPočetna : Form
    {
        public frmPočetna()
        {
            InitializeComponent();
        }

        private void btnPrikazIgrača_Click(object sender, EventArgs e)
        {
            PrikazIgrača form = new PrikazIgrača();
            form.ShowDialog();
        }
    }
}
