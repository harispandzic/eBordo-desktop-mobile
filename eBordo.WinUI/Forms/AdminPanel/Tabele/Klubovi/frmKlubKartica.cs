using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Klubovi
{
    public partial class frmKlubKartica : UserControl
    {
        public int klubId { get; set; }
        public string nazivKluba { get; set; }
        public Image igracSlika { get; set; }
        public Image zastava { get; set; }

        frmPrikazKlubova _prikazKlubova { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public frmKlubKartica(frmPrikazKlubova prikazKlubova)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 115, 98, 10, 10));
            InitializeComponent();
            _prikazKlubova = prikazKlubova;
        }

        private void frmKlubKartica_Load(object sender, EventArgs e)
        {
            picureGrb.BackgroundImage = igracSlika;
            picureGrb.BackgroundImageLayout = ImageLayout.Zoom;
            lblNazivKluba.Text = nazivKluba;
            pictureZastava.BackgroundImage = zastava;
            pictureZastava.BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            _prikazKlubova.filterKlubovi(klubId);
        }
    }
}
