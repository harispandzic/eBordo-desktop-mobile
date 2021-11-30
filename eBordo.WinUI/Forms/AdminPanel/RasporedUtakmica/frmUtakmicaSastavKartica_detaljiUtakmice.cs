using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica
{
    public partial class frmUtakmicaSastavKartica_detaljiUtakmice : UserControl
    {
        public string sastavUloga { get; set; }
        public Image igracSlika { get; set; }
        public string igracImePrezime { get; set; }
        public string igracPozicija { get; set; }
        public string brojDresa { get; set; }
        public bool isKapiten { get; set; }

        public frmUtakmicaSastavKartica_detaljiUtakmice()
        {
            InitializeComponent();
        }

        private void frmUtakmicaSastavKartica_detaljiUtakmice_Load(object sender, EventArgs e)
        {
            pictureIgracSlika.BackgroundImage = igracSlika;
            pictureIgracSlika.BackgroundImageLayout = ImageLayout.Zoom;
            lblImePrezime.Text = igracImePrezime;
            lblPozicija.Text = igracPozicija;
            lblBrojDresa.Text = brojDresa;
            if (!isKapiten)
            {
                lblKapiten.Visible = false;
            }
        }
    }
}
