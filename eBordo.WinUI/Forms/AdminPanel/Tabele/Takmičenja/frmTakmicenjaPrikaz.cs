using eBordo.Model.Requests.Takmicenje;
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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Takmičenja
{
    public partial class frmTakmicenjaPrikaz : UserControl
    {
        private byte[] logo { get; set; }
        private readonly ApiService.ApiService _takmicenje = new ApiService.ApiService("Takmicenje");

        private List<Model.Models.Takmicenje> _takmicenja;

        ByteToImage byteToImage = new ByteToImage();
        public frmTakmicenjaPrikaz()
        {
            InitializeComponent();
        }
        public async Task LoadTakmicenja(TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            try
            {
                pnlPrikazDrzava.Controls.Clear();
                pnlLoader.Hide();
                loader.Hide();

                _takmicenja = await _takmicenje.GetAll<List<Model.Models.Takmicenje>>(null);

                frmTakmicenjeKartica[] listItems = new frmTakmicenjeKartica[_takmicenja.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmTakmicenjeKartica();
                    listItems[i].nazivTakmicenja = _takmicenja[i].nazivTakmicenja;
                    listItems[i].logoTakmicenja = byteToImage.ConvertByteToImage(_takmicenja[i].logo);

                    pnlPrikazDrzava.Controls.Add(listItems[i]);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private async void frmTakmicenjaPrikaz_Load(object sender, EventArgs e)
        {
            await LoadTakmicenja();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            var result = grbFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = grbFileDialog.FileName;

                var file = System.IO.File.ReadAllBytes(fileName);

                logo = file;

                Image image = Image.FromFile(fileName);
                pictureLogo.BackgroundImageLayout = ImageLayout.Zoom;
                pictureLogo.BackgroundImage = image;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            TakmicenjeInsertRequest insertRequest = new TakmicenjeInsertRequest
            {
                nazivTakmicenja = txtNazivTakmicenja.Text,
                logo = this.logo,
            };
            try
            {
                await _takmicenje.Insert<Model.Models.Takmicenje>(insertRequest);
                await LoadTakmicenja(notifikacija: TipNotifikacije.DODAVANJE);
                pictureLogo.BackgroundImage = Properties.Resources.uploadFile;
                pictureLogo.BackgroundImageLayout = ImageLayout.Zoom;
                txtNazivTakmicenja.Text = "";
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
    }
}
