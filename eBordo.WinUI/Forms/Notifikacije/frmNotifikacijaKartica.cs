using Bunifu.UI.WinForms;
using eBordo.WinUI.Forms.AdminPanel.Početna;
using eBordo.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public frmNotifikacijaKartica(frmPočetna prikazNotifikacija, BunifuSnackbar snackbar)
        {
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
                await _prikazNotifikacija.LoadNotifikacije(notifikacija: TipNotifikacije.BRISANJE);
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
