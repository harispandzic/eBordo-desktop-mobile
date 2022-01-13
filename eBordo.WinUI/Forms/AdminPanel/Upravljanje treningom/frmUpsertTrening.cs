using eBordo.Model.Requests.Trening;
using eBordo.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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

        bool isFokusTreningaValidated = false, isDatumTreningaValidated = false, isSatnicaValidated = false,
            isTrajanjeValidated = false;

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
                btnSaveUpdate.Show();
                bunifuToggleSwitch1.Checked = false;
                this.Text = "eBordo | Uredi trening";
            }
            else
            {
                lblOdradjen.Hide();
                bunifuToggleSwitch1.Hide();
                btnSave.Show();
                this.Text = "eBordo | Dodaj trening";
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
            txtTrajanjeTreninga.Text = _odabraniTrening.trajanje.ToString();
        }

        private void cmbLokacijaTreninga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
        }

        private void txtFokusTreninga_TextChanged(object sender, EventArgs e)
        {
            isFokusTreningaValidated = Validacija.ValidirajInputString(txtFokusTreninga, txtFokusTreningaValidator, Field.FOKUS_TRENINGA);
        }

        private void dtpDatumTreninga_ValueChanged(object sender, EventArgs e)
        {
            isDatumTreningaValidated = Validacija.ValidirajDatum(dtpDatumTreninga.Value, txtDatumOdrzavanjaValidator, pictureDatumOdigravanjaValidator, Field.DATUM_ODRZAVANJA);
        }

        private void txtSatnica_TextChanged(object sender, EventArgs e)
        {
            isSatnicaValidated = Validacija.ValidirajInputString(txtSatnica, txtSatnicaValidator, Field.SATNICA);
        }

        private void txtTrajanjeTreninga_TextChanged(object sender, EventArgs e)
        {
            isTrajanjeValidated = Validacija.ValidirajInputString(txtTrajanjeTreninga, txtTrajanjeValidator, Field.TRAJANJE_TRENERA);
        }

        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if (!isFokusTreningaValidated || !isDatumTreningaValidated || !isSatnicaValidated ||
                !isTrajanjeValidated)
            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            string lokacijaTreninga = "";
            if (cmbLokacijaTreninga.SelectedIndex == 0)
            {
                lokacijaTreninga = "Stadion";
            }
            else
            {
                lokacijaTreninga = "Trening_centar";
            }
            TreningInsertRequest insertRequest = new TreningInsertRequest
            {
                datumOdrzavanja = dtpDatumTreninga.Value,
                satnica = txtSatnica.Text,
                lokacija = lokacijaTreninga,
                fokusTreninga = txtFokusTreninga.Text,
                trajanje = Int32.Parse(txtTrajanjeTreninga.Text),
                zabiljezioID = 1
            };
            try
            {
                await _treningApi.Insert<Model.Models.Trening>(insertRequest);
                await _prikazTreninga.LoadTrening(notifikacija: TipNotifikacije.DODAVANJE);
                _prikazTreninga.UcitajBrojTreninga();
                this.Hide();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, tipNotifikacije);
            }
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            string lokacijaTreninga = "";

            if (cmbLokacijaTreninga.SelectedIndex == 0)
            {
                lokacijaTreninga = "Stadion";
            }
            else
            {
                lokacijaTreninga = "Trening_centar";
            }
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
                trajanje = Int32.Parse(txtTrajanjeTreninga.Text),
                isOdradjen = isOdradjen
            };
            try
            {
                await _treningApi.Update<Model.Models.Trening>(_odabraniTrening.treningID, updateRequest);
                await _prikazTreninga.LoadTrening(notifikacija: TipNotifikacije.DODAVANJE);
                _prikazTreninga.UcitajBrojTreninga();
                this.Hide();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, tipNotifikacije);
            }
        }
    }
}
