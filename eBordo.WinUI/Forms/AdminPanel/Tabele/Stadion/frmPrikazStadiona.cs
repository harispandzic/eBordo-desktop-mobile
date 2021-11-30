using eBordo.Model.Requests.Stadion;
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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Stadion
{
    public partial class frmPrikazStadiona : UserControl
    {
        private byte[] slikaStadiona { get; set; }
        private readonly ApiService.ApiService _grad = new ApiService.ApiService("Grad");
        private readonly ApiService.ApiService _stadion = new ApiService.ApiService("Stadion");

        private List<Model.Models.Grad> _gradovi;
        private List<Model.Models.Stadion> _stadioni;

        ByteToImage byteToImage = new ByteToImage();
        public frmPrikazStadiona()
        {
            InitializeComponent();
        }
        private async void frmPrikazStadiona_Load(object sender, EventArgs e)
        {
            await LoadStadioni();
            await LoadGradovi();
        }
        public async Task LoadStadioni(TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            try
            {
                pnlPrikazKlubova.Controls.Clear();

                _stadioni = await _stadion.GetAll<List<Model.Models.Stadion>>(null);
                pnlLoader.Hide();
                loader.Hide();

                frmStadionKartica[] listItems = new frmStadionKartica[_stadioni.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmStadionKartica();
                    listItems[i].nazivStadiona = _stadioni[i].nazivStadiona;
                    listItems[i].grad = _stadioni[i].lokacijaStadiona.nazivGrada;
                    listItems[i].slikaStadiona = byteToImage.ConvertByteToImage(_stadioni[i].slikaStadiona);

                    pnlPrikazKlubova.Controls.Add(listItems[i]);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private async Task LoadGradovi()
        {
            try
            {
                _gradovi = await _grad.GetAll<List<Model.Models.Grad>>(null);

                foreach (var item in _gradovi)
                {
                    cmbGrad.Items.Add(item.nazivGrada);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void pictureGrb_Click(object sender, EventArgs e)
        {
            var result = grbFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = grbFileDialog.FileName;

                var file = System.IO.File.ReadAllBytes(fileName);

                slikaStadiona = file;

                Image image = Image.FromFile(fileName);
                pictureGrb.BackgroundImageLayout = ImageLayout.Zoom;
                pictureGrb.BackgroundImage = image;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            StadionInsertRequest insertRequest = new StadionInsertRequest
            {
                nazivStadiona = txtNazivKluba.Text,
                lokacijaStadionaId = _gradovi[cmbGrad.SelectedIndex].gradId,
                slikaStadiona = this.slikaStadiona
            };
            try
            {
                await _stadion.Insert<Model.Models.Stadion>(insertRequest);
                await LoadStadioni(notifikacija: TipNotifikacije.DODAVANJE);
                pictureGrb.BackgroundImage = Properties.Resources.uploadFile;
                pictureGrb.BackgroundImageLayout = ImageLayout.Zoom;
                txtNazivKluba.Text = "";
                cmbGrad.SelectedIndex = 0;
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
    }
}
