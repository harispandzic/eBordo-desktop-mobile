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

namespace eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica
{
    public partial class frmUtakmicaKartica : UserControl
    {
        private readonly ApiService.ApiService _utakmica = new ApiService.ApiService("Utakmica");
        BunifuSnackbar _snackbar;

        private frmPrikazRasporedaUtakmicacs _prikazRasporeda;

        public int utakmicaId { get; set; }
        public string utakmicaOpis { get; set; }
        public string domacin { get; set; }
        public string brojDanaDoUtakmice { get; set; }
        public Image grbDomacina { get; set; }
        public string gost { get; set; }
        public Image grbGostiju { get; set; }
        public string datum { get; set; }
        public string satnica{ get; set; }
        public string stadion { get; set; }
        public Image logoTakmicenja { get; set; }
        public Image tipUtakmice { get; set; }
        public Image dres { get; set; }
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
        public frmUtakmicaKartica(frmPrikazRasporedaUtakmicacs prikazRasporeda, BunifuSnackbar snackbar)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 285, 232, 12, 12));
            InitializeComponent();
            _prikazRasporeda = prikazRasporeda;
            _snackbar = snackbar;
        }
        private void frmUtakmicaKartica_Load(object sender, EventArgs e)
        {
            panelDelete.Hide();
            loader.Hide();
            gifLoader.Hide();

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
            brojDana.Text = brojDanaDoUtakmice;
            pictureStatus.BackgroundImage = statusSlika;
            pictureTakmicenje.BackgroundImageLayout = ImageLayout.Zoom;
            txtStatus.Text = statusText;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                panelDelete.Show();
                loader.Show();
                gifLoader.Show();
                var result = await _utakmica.DeleteById<Model.Models.Igrac>(utakmicaId);
                await _prikazRasporeda.LoadUtakmice(notifikacija: TipNotifikacije.BRISANJE);
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
                var result = await _utakmica.GetById<Model.Models.Utakmica>(utakmicaId);
                frmUpsertUtakmica update = new frmUpsertUtakmica(result, _prikazRasporeda);
                update.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void panelDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _utakmica.GetById<Model.Models.Utakmica>(utakmicaId);
                frmDetaljiUtakmice detalji = new frmDetaljiUtakmice(result);
                detalji.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void brojDana_Click(object sender, EventArgs e)
        {

        }
    }
}
