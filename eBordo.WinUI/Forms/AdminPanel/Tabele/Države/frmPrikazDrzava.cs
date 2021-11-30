using eBordo.Model.Requests.Drzava;
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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Države
{
    public partial class frmPrikazDrzava : UserControl
    {
        private byte[] zastava { get; set; }
        private readonly ApiService.ApiService _drzava = new ApiService.ApiService("Drzava");

        private List<Model.Models.Drzava> _drzave;

        ByteToImage byteToImage = new ByteToImage();

        public frmPrikazDrzava()
        {
            InitializeComponent();
        }
        public async Task LoadDrzave(TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            try
            {
                pnlPrikazDrzava.Controls.Clear();

                _drzave = await _drzava.GetAll<List<Model.Models.Drzava>>(null);
                pnlLoader.Hide();
                loader.Hide();

                frmDrzavaKartica[] listItems = new frmDrzavaKartica[_drzave.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmDrzavaKartica();
                    listItems[i].nazivDrzave = _drzave[i].nazivDrzave;
                    listItems[i].zastavaDrzave = byteToImage.ConvertByteToImage(_drzave[i].zastava);

                    pnlPrikazDrzava.Controls.Add(listItems[i]);
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

                zastava = file;

                Image image = Image.FromFile(fileName);
                pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
                pictureZastava.BackgroundImage = image;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DrzavaInsertRequest insertRequest = new DrzavaInsertRequest
            {
                nazivDrzave = txtNazivDrzave.Text,
                zastava = this.zastava,
            };
            try
            {
                await _drzava.Insert<Model.Models.Drzava>(insertRequest);
                await LoadDrzave(notifikacija: TipNotifikacije.DODAVANJE);
                pictureZastava.BackgroundImage = Properties.Resources.uploadFile;
                pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
                txtNazivDrzave.Text = "";
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void frmPrikazDrzava_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
        }
    }
}
