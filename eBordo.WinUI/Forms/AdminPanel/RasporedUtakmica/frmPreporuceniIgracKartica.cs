using eBordo.WinUI.Helper;
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

namespace eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica
{
    public partial class frmPreporuceniIgracKartica : UserControl
    {

        public Model.Models.Igrac igrac { get; set; }
        ByteToImage byteToImage = new ByteToImage();

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
        public frmPreporuceniIgracKartica()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 408, 39, 8, 8));
            InitializeComponent();
        }

        private void frmPreporuceniIgracKartica_Load(object sender, EventArgs e)
        {
            txtBrojDresa.Text = "#" + igrac.brojDresa.ToString();
            pictureIgracSlika.Image = byteToImage.ConvertByteToImage(igrac.korisnik.Slika);
            lblImePrezimeBrojDresa.Text = igrac.korisnik.ime[0] + ". " + igrac.korisnik.prezime;
            lblPozicija.Text = igrac.pozicija.skracenica;
            txtMinute.Text = (igrac.igracStatistika.brojNastupa * 90).ToString();
            txtGolovi.Text = igrac.igracStatistika.golovi.ToString();
            txtAsistencije.Text = igrac.igracStatistika.asistencije.ToString();
            txtZutiKartoni.Text = igrac.igracStatistika.zutiKartoni.ToString();
            txtCrveniKartoni.Text = igrac.igracStatistika.crveniKartoni.ToString();
            ratingSnaga.Value = (int)igrac.igracStatistika.prosjecnaOcjena;
        }

        private void frmIgracUtakmice_detaljiUtakmice1_Load(object sender, EventArgs e)
        {

        }
    }
}
