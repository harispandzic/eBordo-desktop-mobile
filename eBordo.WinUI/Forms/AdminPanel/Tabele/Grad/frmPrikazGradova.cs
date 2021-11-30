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
                pnlLoader.Hide();
                loader.Hide();

                frmGradKartica[] listItems = new frmGradKartica[_gradovi.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmGradKartica();
                    listItems[i].nazivGrada = _gradovi[i].nazivGrada;
                    listItems[i].zastavaDrzave = byteToImage.ConvertByteToImage(_gradovi[i].drzava.zastava);

                    pnlPrikazKlubova.Controls.Add(listItems[i]);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private async Task LoadDrzave()
        {
            try
            {
                _drzave = await _drzava.GetAll<List<Model.Models.Drzava>>(null);

                foreach (var item in _drzave)
                {
                    cmbDrzave.Items.Add(item.nazivDrzave);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
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
    }
}
