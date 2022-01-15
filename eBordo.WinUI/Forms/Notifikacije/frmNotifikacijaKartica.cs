using Bunifu.UI.WinForms;
using eBordo.WinUI.Forms.AdminPanel.Početna;
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

namespace eBordo.WinUI.Forms.Notifikacije
{
    public partial class frmNotifikacijaKartica : UserControl
    {
        private readonly ApiService.ApiService _notifikacija = new ApiService.ApiService("Notifikacija");

        public int notifikacijaId { get; set; }
        public Image tipNotifikacije { get; set; }
        public string tekstNotifikacije { get; set; }
        public DateTime datumNotifikacije { get; set; }

        private frmPočetna _prikazNotifikacija;
        BunifuSnackbar _snackbar;

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
        public frmNotifikacijaKartica(frmPočetna prikazNotifikacija, BunifuSnackbar snackbar)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 269, 57, 10, 10));

            InitializeComponent();
            _prikazNotifikacija = prikazNotifikacija;
            _snackbar = snackbar;
        }

        private void frmNotifikacijaKartica_Load(object sender, EventArgs e)
        {
            pictureTipNotifikacije.BackgroundImage = tipNotifikacije;
            pictureTipNotifikacije.BackgroundImageLayout = ImageLayout.Zoom;
            txtDatumNotifikacije.Text = datumNotifikacije.ToString();
            txtTekstNotifikacije.Text = tekstNotifikacije;
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _notifikacija.DeleteById<Model.Models.Notifikacija>(notifikacijaId);
                await _prikazNotifikacija.LoadNotifikacije(notifikacija: TipNotifikacije.NOTIFIKACIJA_PROČITANA);
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void txtTekstNotifikacije_Click(object sender, EventArgs e)
        {

        }
    }
}
