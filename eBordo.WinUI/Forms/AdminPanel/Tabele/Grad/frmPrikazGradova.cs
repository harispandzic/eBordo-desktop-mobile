using eBordo.Model.Requests.Grad;
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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Grad
{
    public partial class frmPrikazGradova : UserControl
    {
        private readonly ApiService.ApiService _grad = new ApiService.ApiService("Grad");
        private readonly ApiService.ApiService _drzava = new ApiService.ApiService("Drzava");

        private List<Model.Models.Grad> _gradovi;
        private List<Model.Models.Drzava> _drzave;
        ByteToImage byteToImage = new ByteToImage();
        Model.Models.Grad grad;
        bool isNazivGradaValidated = false, isDrzavaValidated = false;

        public frmPrikazGradova()
        {
            InitializeComponent();
        }
         
        private async void frmPrikazGradova_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
            await LoadDrzave();
        }
        public async Task LoadGradovi(TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            try
            {
                pnlPrikazKlubova.Controls.Clear();

                _gradovi = await _grad.GetAll<List<Model.Models.Grad>>(null);
                loader.Hide();
                loaderIgraci.Hide();

                frmGradKartica[] listItems = new frmGradKartica[_gradovi.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmGradKartica(this);
                    listItems[i].gradId = _gradovi[i].gradId;
                    listItems[i].nazivGrada = _gradovi[i].nazivGrada;
                    listItems[i].zastavaDrzave = byteToImage.ConvertByteToImage(_gradovi[i].drzava.zastava);

                    pnlPrikazKlubova.Controls.Add(listItems[i]);
                }
                UpdateBrojDrazva();
                btnSaveUpdate.Hide();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if (!isNazivGradaValidated || !isDrzavaValidated)
            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private void UpdateBrojDrazva()
        {
            txtBrojIgraca.Text = _gradovi.Count().ToString();
        }
        private async Task LoadDrzave()
        {
            try
            {
                _drzave = await _drzava.GetAll<List<Model.Models.Drzava>>(null);

                if(_drzave.Count > 0)
                {
                    foreach (var item in _drzave)
                    {
                        cmbDrzave.Items.Add(item.nazivDrzave);
                    }
                    cmbDrzave.SelectedIndex = 0;
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void loaderIgraci_Click(object sender, EventArgs e)
        {

        }

        private void txtBrojIgraca_Click(object sender, EventArgs e)
        {

        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            GradInsertRequest insertRequest = new GradInsertRequest
            {
                nazivGrada = txtNazivKluba.Text,
                drzavaId = _drzave[cmbDrzave.SelectedIndex].drzavaId
            };
            try
            {
                await _grad.Insert<Model.Models.Grad>(insertRequest);
                await LoadGradovi(notifikacija: TipNotifikacije.DODAVANJE);
                txtNazivKluba.Text = "";
                cmbDrzave.SelectedIndex = 0;
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDrzave.SelectedText != "Grad")
            {
                isDrzavaValidated = true;
            }
        }

        private void txtNazivKluba_TextChanged(object sender, EventArgs e)
        {
            isNazivGradaValidated = Validacija.ValidirajInputString(txtNazivKluba, txtTelefonValidator, Field.NAZIV_TAKMICENJA);
        }
        public void filterStadioni(int gradId)
        {
            bunifuButton1.Hide();
            btnSaveUpdate.Show();
            grad = _gradovi.Where(s => s.gradId == gradId).SingleOrDefault();
            txtNazivKluba.Text = grad.nazivGrada;
            int selectedGrad = 0;
            for (int i = 0; i < _drzave.Count; i++)
            {
                if (_drzave[i].drzavaId == grad.drzavaId)
                {
                    selectedGrad = i;
                }
            }
            cmbDrzave.SelectedIndex = selectedGrad;
            cmbDrzave.Enabled = false;
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            GradUpdateRequest upadte = new GradUpdateRequest
            {
                nazivGrada = txtNazivKluba.Text,
            };
            try
            {
                await _grad.Update<Model.Models.Grad>(grad.gradId, upadte);
                await LoadGradovi(notifikacija: TipNotifikacije.UREĐIVANJE);
                OcistiPolja();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        public void OcistiPolja()
        {
            btnSaveUpdate.Hide();
            bunifuButton1.Show();
            txtNazivKluba.Text = "";
            txtTelefonValidator.Text = "";
            cmbDrzave.SelectedIndex = 0;
            cmbDrzave.Enabled = true;
        }
    }
}
