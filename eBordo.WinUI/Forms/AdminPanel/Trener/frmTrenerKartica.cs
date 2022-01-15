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

namespace eBordo.WinUI.Forms.AdminPanel.Trener
{
    public partial class frmTrenerKartica : UserControl
    {
        private readonly ApiService.ApiService _treneri = new ApiService.ApiService("Trener");
        BunifuSnackbar _snackbar;

        private frmPrikazTrenera _prikazTrenera;

        public int trenerId { get; set; }
        public string imePrezime { get; set; }
        public string uloga { get; set; }
        public string licenca { get; set; }
        public Image slika { get; set; }
        public bool isAktivan { get; set; }
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
        public frmTrenerKartica(BunifuSnackbar snackbar, frmPrikazTrenera prikazTrenera)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 188, 281, 12, 12));
            InitializeComponent();
            _snackbar = snackbar;
            _prikazTrenera = prikazTrenera;
        }

        private void frmTrenerKartica_Load(object sender, EventArgs e)
        {
            korisnickaFotografija.BackgroundImage = slika;
            korisnickaFotografija.BackgroundImageLayout = ImageLayout.Zoom;
            lblImePrezime.Text = imePrezime.ToUpper();
            lblUloga.Text = uloga.ToUpper();
            txtLicenca.Text = licenca.ToUpper();
            if (!isAktivan)
            {
                btnDelete.Hide();
                btnEdit.Location = new Point(94, 251);
                btnView.Location = new Point(72, 251);
                pictureAktivan.BackgroundImage = Properties.Resources.eBordo_error_notification;
                pictureAktivan.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                pictureAktivan.BackgroundImage = Properties.Resources.eBordo_success_notification;
                pictureAktivan.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                var trener = await _treneri.GetById<Model.Models.Trener>(trenerId);
                frmDetaljiTrenera getById = new frmDetaljiTrenera(trener);
                getById.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _treneri.GetById<Model.Models.Trener>(trenerId);
                frmUpsertTrenera update = new frmUpsertTrenera(result, _prikazTrenera);
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
                var result = await _treneri.DeleteById<Model.Models.Trener>(trenerId);
                await _prikazTrenera.LoadTreneri(notifikacija: TipNotifikacije.BRISANJE);
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
    }
}
