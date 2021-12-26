using Bunifu.UI.WinForms;
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
        public Image igracSlika { get; set; }
        public string igracPrezimeBrojDresa { get; set; }

        public frmTreningKartica(frmPrikazTreninga prikazTreninga, BunifuSnackbar snackbar)
        {
            InitializeComponent();
            _prikazTreninga = prikazTreninga;
            _snackbar = snackbar;
        }

        private void frmTreningKartica_Load(object sender, EventArgs e)
        {
            lblDatum.Text = datumOdrzavanja.ToString("dd.MM.yyyy");
            lblSatnica.Text = satnica;
            lblStadion.Text = lokacija;
            lblOpisUtakmice.Text = fokusTreninga;
            label1.Text = igracPrezimeBrojDresa;
            pictureIgracSlika.BackgroundImage = igracSlika;
            pictureIgracSlika.BackgroundImageLayout = ImageLayout.Zoom;
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
