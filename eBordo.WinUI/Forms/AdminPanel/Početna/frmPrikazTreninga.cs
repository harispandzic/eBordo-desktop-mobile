using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.Početna
{
    public partial class frmPrikazTreninga : UserControl
    {
        public int treningId { get; set; }
        public Image lokacija { get; set; }
        public DateTime datum { get; set; }
        public string satnica { get; set; }
        public Image trenerSlika { get; set; }
        public string trener { get; set; }
        public string brojDana { get; set; }

        public frmPrikazTreninga()
        {
            InitializeComponent();
        }

        private void frmPrikazTreninga_Load(object sender, EventArgs e)
        {
            txtDatum.Text = datum.ToString("dd.MM.yyyy");
            txtSatnica.Text = satnica;
            pictureLokacija.BackgroundImage = lokacija;
            pictureLokacija.BackgroundImageLayout = ImageLayout.Zoom;
            pictureTrenerSlika.BackgroundImage = trenerSlika;
            pictureTrenerSlika.BackgroundImageLayout = ImageLayout.Zoom;
            txtBrojDana.Text = brojDana;
            txtTrener.Text = trener;
        }

        private void txtTrener_Click(object sender, EventArgs e)
        {

        }
    }
}
