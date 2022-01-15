using eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice.frmPictures;
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

namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    public partial class frmKratkiIzvjestajKartica : UserControl
    {
        public int igracId { get; set; }
        public Image igracSlika { get; set; }
        public string igracImePrezime { get; set; }
        public string brojDresa { get; set; }
        public string igracPozicija { get; set; }
        public int minute { get; set; }
        public int ocjena { get; set; }
        public int brojZutih { get; set; }
        public int brojCrvenih { get; set; }
        public int brojGolova { get; set; }
        public int brojAsistencija { get; set; }

        public int kontrolaLopte { get; set; }
        public int driblanje { get; set; }
        public int dodavanje { get; set; }
        public int kretanje { get; set; }
        public int brzina { get; set; }
        public int sut { get; set; }
        public int snaga { get; set; }
        public int markiranje { get; set; }
        public int klizeciStart { get; set; }
        public int skok { get; set; }
        public int odbrana { get; set; }
        public string igracKomentar { get; set; }

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

        public frmKratkiIzvjestajKartica()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 484, 33, 10, 10));
            InitializeComponent();
        }

        private void frmKratkiIzvjestajKartica_Load(object sender, EventArgs e)
        {
            pictureIgracSlika.BackgroundImage = igracSlika;
            pictureIgracSlika.BackgroundImageLayout = ImageLayout.Zoom;
            txtImePrezimeBrojDresa.Text = igracImePrezime;
            txtMinute.Text = minute.ToString();
            txtBrojDresa.Text = brojDresa;
            lblPozicija.Text = igracPozicija;
            ratingSnaga.Value = ocjena;
            getOcjene();
        }
        private void getOcjene()
        {
            for (int i = 0; i < brojZutih; i++)
            {
                flowPanel.Controls.Add((Control)new frmZutiKartonControl());
            }
            for (int i = 0; i < brojCrvenih; i++)
            {
                flowPanel.Controls.Add((Control)new frmCrveniKartonControl());
            }
            for (int i = 0; i < brojGolova; i++)
            {
                flowPanel.Controls.Add((Control)new frmGoloviControl());
            }
            for (int i = 0; i < brojAsistencija; i++)
            {
                flowPanel.Controls.Add((Control)new frmAsistencijeControl());
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmDetaljneOcjeneIgraca frmDetaljneOcjene = new frmDetaljneOcjeneIgraca(igracId, kontrolaLopte,
                driblanje, dodavanje, kretanje, brzina, sut,
                snaga, markiranje, klizeciStart, skok, odbrana, igracKomentar, ocjena, minute, brojGolova, brojAsistencija, brojZutih, brojCrvenih);
            frmDetaljneOcjene.Show();
        }
    }
}
