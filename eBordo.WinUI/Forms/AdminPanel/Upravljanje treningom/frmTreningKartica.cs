using Bunifu.UI.WinForms;
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

namespace eBordo.WinUI.Forms.AdminPanel.Upravljanje_treningom
{
    public partial class frmTreningKartica : UserControl
    {
        private readonly ApiService.ApiService _treningApi = new ApiService.ApiService("Trening");

        private frmPrikazTreninga _prikazTreninga;
        BunifuSnackbar _snackbar;

        public int treningID { get; set; }
        public DateTime datumOdrzavanja { get; set; }
        public string satnica { get; set; }
        public string lokacija { get; set; }
        public string fokusTreninga { get; set; }
        public bool isOdradjen { get; set; }
        public int zabiljezioID { get; set; }
        public Image igracSlikaAvatar { get; set; }
        public Image igracSlikaPanel { get; set; }
        public Image treningLokacija { get; set; }
        public string trener { get; set; }
        public string trajanjeTrenera { get; set; }
        public string brojTreninga { get; set; }
        public string brojDanaString { get; set; }

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
        public frmTreningKartica(frmPrikazTreninga prikazTreninga, BunifuSnackbar snackbar)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 284, 150, 12, 12));
            InitializeComponent();
            _prikazTreninga = prikazTreninga;
            _snackbar = snackbar;
        }
        
        private void frmTreningKartica_Load(object sender, EventArgs e)
        {
            if (ApiService.ApiService.logovaniKorisnik.isAdmin)
            {
                btnEdit.Hide();
            }
            else if (ApiService.ApiService.logovaniKorisnik.isTrener)
            {
                btnDelete.Hide();
                btnEdit.Location = new Point(260, 7);
            }
            else if (ApiService.ApiService.logovaniKorisnik.isIgrac)
            {
                btnEdit.Hide();
                btnDelete.Hide();
            }
            lblDatum.Text = datumOdrzavanja.ToString("dd.MM.yyyy");
            lblSatnica.Text = satnica;
            lblLokacija.Text = lokacija;
            lblFokusTreninga.Text = fokusTreninga;
            txtImePrezimeTrener.Text = trener.ToUpper();
            pictureIgracSlika.Image = igracSlikaAvatar;
            pictureIgracSlika.BackgroundImageLayout = ImageLayout.Zoom;
            pictureSlikaPanelIgraca.BackgroundImage = igracSlikaPanel;
            pictureSlikaPanelIgraca.BackgroundImageLayout = ImageLayout.Zoom;
            txtTrajanjeTreninga.Text = trajanjeTrenera;
            txtBrojTreninga.Text = brojTreninga;
            pictureLokacija.BackgroundImage = treningLokacija;
            pictureLokacija.BackgroundImageLayout = ImageLayout.Zoom;
            brojDana.Text = brojDanaString;
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _treningApi.GetById<Model.Models.Trening>(treningID);
                frmUpsertTrening insertTrening = new frmUpsertTrening(_prikazTreninga, result);
                insertTrening.Show();
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
                var result = await _treningApi.DeleteById<Model.Models.Trening>(treningID);
                await _prikazTreninga.LoadTrening(notifikacija: TipNotifikacije.BRISANJE);
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
    }
}
