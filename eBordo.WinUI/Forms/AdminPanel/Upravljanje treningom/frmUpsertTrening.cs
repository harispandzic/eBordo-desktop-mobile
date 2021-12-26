using eBordo.Model.Requests.Trening;
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
    public partial class frmUpsertTrening : Form
    {
        private readonly ApiService.ApiService _treningApi = new ApiService.ApiService("Trening");
        private frmPrikazTreninga _prikazTreninga;
        private Model.Models.Trening _odabraniTrening;

        public frmUpsertTrening(frmPrikazTreninga prikazTreninga, Model.Models.Trening odabraniTrening)
        {
            InitializeComponent();
            _prikazTreninga = prikazTreninga;
            _odabraniTrening = odabraniTrening;
        }

        private void frmUpsertTrening_Load(object sender, EventArgs e)
        {
            LoadLokacijaTreninga();
            if(_odabraniTrening != null)
            {
                UcitajPodatke();
            }
            else
            {
                bunifuToggleSwitch1.Hide();
            }
        }
        private void LoadLokacijaTreninga()
        {
            cmbLokacijaTreninga.Items.Add("Stadion");
            cmbLokacijaTreninga.Items.Add("Trening_centar");
            cmbLokacijaTreninga.SelectedIndex = 0;
        }
        private void UcitajPodatke()
        {
            if(_odabraniTrening.lokacija == "Stadion")
            {
                cmbLokacijaTreninga.SelectedIndex = 0;
            }
            dtpDatumTreninga.Value = _odabraniTrening.datumOdrzavanja;
            txtSatnica.Text = _odabraniTrening.satnica;
            txtFokusTreninga.Text = _odabraniTrening.fokusTreninga;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string lokacijaTreninga = "";
            if (cmbLokacijaTreninga.SelectedIndex == 0)
            {
                lokacijaTreninga = "Stadion";
            }
            else
            {
                lokacijaTreninga = "Trening_centar";
            }
            if (_odabraniTrening == null)
            {
                TreningInsertRequest insertRequest = new TreningInsertRequest
                {
                    datumOdrzavanja = dtpDatumTreninga.Value,
                    satnica = txtSatnica.Text,
                    lokacija = lokacijaTreninga,
                    fokusTreninga = txtFokusTreninga.Text,
                    zabiljezioID = 1
                };
                try
                {
                    await _treningApi.Insert<Model.Models.Trening>(insertRequest);
                    await _prikazTreninga.LoadTrening(notifikacija: TipNotifikacije.DODAVANJE);
                    this.Hide();
                }
                catch
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
                }
            }
            else
            {
                bool isOdradjen = false;
                if (bunifuToggleSwitch1.Checked)
                {
                    isOdradjen = true;
                }
                TreningUpdateRequest updateRequest = new TreningUpdateRequest
                {
                    datumOdrzavanja = dtpDatumTreninga.Value,
                    satnica = txtSatnica.Text,
                    lokacija = lokacijaTreninga,
                    fokusTreninga = txtFokusTreninga.Text,
                    isOdradjen = isOdradjen
                };
                try
                {
                    await _treningApi.Update<Model.Models.Trening>(_odabraniTrening.treningID,updateRequest);
                    await _prikazTreninga.LoadTrening(notifikacija: TipNotifikacije.DODAVANJE);
                    this.Hide();
                }
                catch
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
                }
            }
        }

        private void cmbLokacijaTreninga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
        }
    }
}
