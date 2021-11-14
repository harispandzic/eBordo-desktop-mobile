using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Države
{
    public partial class frmDrzavaKartica : UserControl
    {
        public string nazivDrzave { get; set; }
        public Image zastavaDrzave { get; set; }
        public frmDrzavaKartica()
        {
            InitializeComponent();
        }

        private void frmDrzavaKartica_Load(object sender, EventArgs e)
        {
            picureZastava.BackgroundImage = zastavaDrzave;
            picureZastava.BackgroundImageLayout = ImageLayout.Stretch;
            lblNazivDrzave.Text = nazivDrzave;
        }
    }
}
