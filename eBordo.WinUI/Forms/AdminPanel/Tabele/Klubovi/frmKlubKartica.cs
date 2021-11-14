using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Klubovi
{
    public partial class frmKlubKartica : UserControl
    {
        public string nazivKluba { get; set; }
        public Image igracSlika { get; set; }
        public frmKlubKartica()
        {
            InitializeComponent();
        }

        private void frmKlubKartica_Load(object sender, EventArgs e)
        {
            picureGrb.BackgroundImage = igracSlika;
            picureGrb.BackgroundImageLayout = ImageLayout.Stretch;
            lblNazivKluba.Text = nazivKluba;
        }
    }
}
