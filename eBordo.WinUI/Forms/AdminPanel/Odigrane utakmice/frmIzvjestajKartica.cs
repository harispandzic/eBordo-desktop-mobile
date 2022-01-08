using Bunifu.UI.WinForms;
using eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica;
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

namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    public partial class frmIzvjestajKartica : UserControl
    {
        private readonly ApiService.ApiService _izvjestaj = new ApiService.ApiService("Izvještaj");
        BunifuSnackbar _snackbar;

        private frmPrikazOdigranihUtakmica _prikazOdigranihUtakmica;

        public int izvjestajId { get; set; }
        public int utakmicaId { get; set; }
        public string utakmicaOpis { get; set; }
        public string domacin { get; set; }
        public Image grbDomacina { get; set; }
        public string gost { get; set; }
        public Image grbGostiju { get; set; }
        public string datum { get; set; }
        public string satnica { get; set; }
        public string stadion { get; set; }
        public Image logoTakmicenja { get; set; }
        public Image tipUtakmice { get; set; }
        public Image dres { get; set; }
        public string goloviDomacin { get; set; }
        public string goloviGost { get; set; }
        public string brojDanaString { get; set; }
        public Image rezultat { get; set; }
        public string rezultatOpis { get; set; }
        public Image statusSlika { get; set; }
        public string statusText { get; set; }

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

        public frmIzvjestajKartica(frmPrikazOdigranihUtakmica prikazOdigranihUtakmica, BunifuSnackbar snackbar)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 285,249, 12, 12));
            InitializeComponent();
            _prikazOdigranihUtakmica = prikazOdigranihUtakmica;
            _snackbar = snackbar;
        }

        private void frmIzvjestajKartica_Load(object sender, EventArgs e)
        {
            lblOpisUtakmice.Text = utakmicaOpis;
            lblDomacin.Text = domacin;
            lblGost.Text = gost;
            grbDomacin.BackgroundImage = grbDomacina;
            grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
            grbGost.BackgroundImage = grbGostiju;
            grbGost.BackgroundImageLayout = ImageLayout.Zoom;
            pictureGostujucaDomaca.BackgroundImage = tipUtakmice;
            pictureGostujucaDomaca.BackgroundImageLayout = ImageLayout.Zoom;
            pictureDres.BackgroundImage = dres;
            pictureGostujucaDomaca.BackgroundImageLayout = ImageLayout.Zoom;
            pictureTakmicenje.BackgroundImage = logoTakmicenja;
            pictureTakmicenje.BackgroundImageLayout = ImageLayout.Zoom;
            lblDatum.Text = datum;
            lblSatnica.Text = satnica;
            lblStadion.Text = stadion;
            lblGoloviDomacin.Text = goloviDomacin;
            lblGoloviGost.Text = goloviGost;
            pictureRezultat.BackgroundImage = rezultat;
            pictureRezultat.BackgroundImageLayout = ImageLayout.Zoom;
            lblRezultatOpis.Text = rezultatOpis;
            brojDana.Text = brojDanaString;
            pictureStatus.BackgroundImage = statusSlika;
            pictureStatus.BackgroundImageLayout = ImageLayout.Zoom;
            txtStatus.Text = statusText;
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _izvjestaj.GetById<Model.Models.Izvještaj>(izvjestajId);
                frmUpsertIzvjestaj update = new frmUpsertIzvjestaj(result.utakmicaID, _prikazOdigranihUtakmica, result);
                update.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await _izvjestaj.DeleteById<Model.Models.Izvještaj>(izvjestajId);
                await _prikazOdigranihUtakmica.LoadIzvještaj(notifikacija: TipNotifikacije.BRISANJE);
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmDetaljiOdigraneUtakmice detalji = new frmDetaljiOdigraneUtakmice();
            detalji.Show();
        }
    }
}
