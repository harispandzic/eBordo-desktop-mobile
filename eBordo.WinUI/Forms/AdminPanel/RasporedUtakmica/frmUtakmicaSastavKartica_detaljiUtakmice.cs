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
    public partial class frmUtakmicaSastavKartica_detaljiUtakmice : UserControl
    {
        private readonly ApiService.ApiService _igraci = new ApiService.ApiService("Igrac");
        BunifuSnackbar _snackbar;

        public int igracId { get; set; }
        public string sastavUlogaa { get; set; }
        public Image igracSlika { get; set; }
        public string igracImePrezime { get; set; }
        public string igracPozicija { get; set; }
        public string brojDresa { get; set; }
        public bool isKapiten { get; set; }
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
        public frmUtakmicaSastavKartica_detaljiUtakmice(BunifuSnackbar snackbar)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 235, 35, 8, 8));
            InitializeComponent();
            _snackbar = snackbar;
        }

        private void frmUtakmicaSastavKartica_detaljiUtakmice_Load(object sender, EventArgs e)
        {
            pictureIgracSlika.BackgroundImage = igracSlika;
            pictureIgracSlika.BackgroundImageLayout = ImageLayout.Zoom;
            lblImePrezime.Text = igracImePrezime;
            lblPozicija.Text = igracPozicija;
            lblBrojDresa.Text = brojDresa;
        }

        private async void btnView_Click(object sender, EventArgs e)
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
    }
}
