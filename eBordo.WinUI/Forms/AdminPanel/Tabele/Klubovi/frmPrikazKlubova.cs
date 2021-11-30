using eBordo.Model.Requests.Klub;
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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Klubovi
{
    public partial class frmPrikazKlubova : UserControl
    {
        private byte[] grb { get; set; }
        private readonly ApiService.ApiService _grad = new ApiService.ApiService("Grad");
        private readonly ApiService.ApiService _stadion = new ApiService.ApiService("Stadion");
        private readonly ApiService.ApiService _klub = new ApiService.ApiService("Klub");

        private List<Model.Models.Grad> _gradovi;
        private List<Model.Models.Stadion> _stadioni;
        private List<Model.Models.Klub> _klubovi;

        ByteToImage byteToImage = new ByteToImage();

        public frmPrikazKlubova()
        {
            InitializeComponent();
        }
        private async void frmPrikazKlubova_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
            await LoadStadioni();
            await LoadKlubovi();
        }
        public async Task LoadKlubovi(TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            try
            {
                pnlPrikazKlubova.Controls.Clear();

                _klubovi = await _klub.GetAll<List<Model.Models.Klub>>(null);
                pnlLoader.Hide();
                loader.Hide();

                frmKlubKartica[] listItems = new frmKlubKartica[_klubovi.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmKlubKartica();
                    listItems[i].nazivKluba = _klubovi[i].nazivKluba;
                    listItems[i].igracSlika = byteToImage.ConvertByteToImage(_klubovi[i].grb);

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
        private async Task LoadStadioni()
        {
            try
            {
                _stadioni = await _stadion.GetAll<List<Model.Models.Stadion>>(null);

                foreach (var item in _stadioni)
                {
                    cmbStadion.Items.Add(item.nazivStadiona);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = grbFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = grbFileDialog.FileName;

                var file = System.IO.File.ReadAllBytes(fileName);

                grb = file;

                Image image = Image.FromFile(fileName);
                pictureGrb.BackgroundImageLayout = ImageLayout.Zoom;
                pictureGrb.BackgroundImage = image;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            KlubInsertRequest insertRequest = new KlubInsertRequest
            {
                nazivKluba = txtNazivKluba.Text,
                gradId = _gradovi[cmbGrad.SelectedIndex].gradId,
                stadionId = _stadioni[cmbStadion.SelectedIndex].stadionId,
                grb = this.grb
            };
            try
            {
                await _klub.Insert<Model.Models.Klub>(insertRequest);
                await LoadKlubovi(notifikacija: TipNotifikacije.DODAVANJE);
                pictureGrb.BackgroundImage = Properties.Resources.uploadFile;
                pictureGrb.BackgroundImageLayout = ImageLayout.Zoom;
                txtNazivKluba.Text = "";
                cmbGrad.SelectedIndex = 0;
                cmbStadion.SelectedIndex = 0;
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
    }
}
