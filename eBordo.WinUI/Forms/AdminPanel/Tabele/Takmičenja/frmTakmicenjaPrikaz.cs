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
        Model.Models.Takmicenje takmicenje;
        bool isNazivTakmicenjaValidated = false, isSlikaValidated = false;

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

                _takmicenja = await _takmicenje.GetAll<List<Model.Models.Takmicenje>>(null);
                loader.Hide();
                loaderIgraci.Hide();

                frmTakmicenjeKartica[] listItems = new frmTakmicenjeKartica[_takmicenja.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmTakmicenjeKartica(this);
                    listItems[i].takmicenjeId = _takmicenja[i].takmicenjeId;
                    listItems[i].nazivTakmicenja = _takmicenja[i].nazivTakmicenja;
                    listItems[i].logoTakmicenja = byteToImage.ConvertByteToImage(_takmicenja[i].logo);

                    pnlPrikazDrzava.Controls.Add(listItems[i]);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
            UpdateBrojDrazva();
            btnSaveUpdate.Hide();
        }
        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if (!isNazivTakmicenjaValidated || !isSlikaValidated)
            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private async void frmTakmicenjaPrikaz_Load(object sender, EventArgs e)
        {
            await LoadTakmicenja();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            
        }
        private void UpdateBrojDrazva()
        {
            txtBrojIgraca.Text = _takmicenja.Count().ToString();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
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
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }

        private void txtNazivTakmicenja_TextChanged(object sender, EventArgs e)
        {
            isNazivTakmicenjaValidated = Validacija.ValidirajInputString(txtNazivTakmicenja, txtTelefonValidator, Field.NAZIV_TAKMICENJA);
        }

        private void btnUcitajPanelPhoto_Click(object sender, EventArgs e)
        {
            var result = grbFileDialog.ShowDialog();
            try
            {

                if (result == DialogResult.OK)
                {
                    var fileName = grbFileDialog.FileName;

                    var file = System.IO.File.ReadAllBytes(fileName);

                    logo = file;

                    Image image = Image.FromFile(fileName);
                    pictureLogo.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureLogo.BackgroundImage = image;

                    isSlikaValidated = Validacija.ValidirajSliku(image, pictureSlikaUtakmicaValidator, Field.SLIKA_AVATAR);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GRESKA_UPLOAD);
            }
        }
        public void filterStadioni(int takmicenjeId)
        {
            bunifuButton1.Hide();
            btnSaveUpdate.Show();
            takmicenje = _takmicenja.Where(s => s.takmicenjeId == takmicenjeId).SingleOrDefault();
            txtNazivTakmicenja.Text = takmicenje.nazivTakmicenja;
            pictureLogo.BackgroundImage = byteToImage.ConvertByteToImage(takmicenje.logo);
            pictureLogo.BackgroundImageLayout = ImageLayout.Zoom;

            isSlikaValidated = true;
            btnUcitajPanelPhoto.Enabled = false;
            pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(204, 204, 204);
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            TakmicenjeUpdateRequest update = new TakmicenjeUpdateRequest
            {
                nazivTakmicenja = txtNazivTakmicenja.Text
            };
            try
            {
                await _takmicenje.Update<Model.Models.Takmicenje>(takmicenje.takmicenjeId, update);
                await LoadTakmicenja(notifikacija: TipNotifikacije.UREĐIVANJE);
                OcistiPolja();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
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
            txtNazivTakmicenja.Text = "";
            txtTelefonValidator.Text = "";
            pictureLogo.BackgroundImage = Properties.Resources.uploadFile;
            pictureLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(64, 5, 7);
            btnUcitajPanelPhoto.Enabled = true;
        }
    }
}
