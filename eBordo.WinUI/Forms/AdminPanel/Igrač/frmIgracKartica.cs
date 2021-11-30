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

namespace eBordo.WinUI.Forms.AdminPanel.Igrač
{
    public partial class frmIgracKartica : UserControl
    {
        private readonly ApiService.ApiService _igraci = new ApiService.ApiService("Igrac");
        BunifuSnackbar _snackbar;

        private frmPrikazIgraca _prikazIgraca;

        public int igracId { get; set; }
        public string imePrezime { get; set; }
        public int ocjena { get; set; }
        public string brojDresa { get; set; }
        public string pozicija { get; set; }
        public Image slika { get; set; }
        public Image zastava { get; set; }
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
        public frmIgracKartica(BunifuSnackbar snackbar, frmPrikazIgraca prikazIgraca)
        {
            InitializeComponent();
            //this.BorderStyle = BorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 12, 12));
            _snackbar = snackbar;
            _prikazIgraca = prikazIgraca;
        }
        private void frmIgracKartica_Load(object sender, EventArgs e)
        {
            korisnickaFotografija.BackgroundImage = slika;
            korisnickaFotografija.BackgroundImageLayout = ImageLayout.Zoom;
            pictureZastava.BackgroundImage = zastava;
            pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
            lblImePrezime.Text = imePrezime.ToUpper();
            igracOcjena.Value = ocjena;
            lblBrojDresa.Text = brojDresa;
            lblPozicija.Text = pozicija.ToUpper();
        }

        private async void btnView_Click_1(object sender, EventArgs e)
        {
            try
            {
                var igrac = await _igraci.GetById<Model.Models.Igrac>(igracId);
                frmDetaljiIgraca getById = new frmDetaljiIgraca(igrac);
                getById.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                var result = await _igraci.DeleteById<Model.Models.Igrac>(igracId);
                await _prikazIgraca.LoadIgraci(notifikacija: TipNotifikacije.BRISANJE);
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                var result = await _igraci.GetById<Model.Models.Igrac>(igracId);
                frmUpsertIgraca update = new frmUpsertIgraca(result, _prikazIgraca);
                update.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
    }
}
