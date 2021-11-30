using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Grad
{
    public partial class frmGradKartica : UserControl
    {
        public string nazivGrada { get; set; }
        public Image zastavaDrzave { get; set; }

        public frmGradKartica()
        {
            InitializeComponent();
        }

        private void frmGradKartica_Load(object sender, EventArgs e)
        {
            picureZastava.BackgroundImage = zastavaDrzave;
            picureZastava.BackgroundImageLayout = ImageLayout.Zoom;
            lblNazivDrzave.Text = nazivGrada;
        }
    }
}
