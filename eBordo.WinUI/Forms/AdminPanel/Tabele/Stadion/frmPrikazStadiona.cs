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
        Model.Models.Stadion stadion;
        ByteToImage byteToImage = new ByteToImage();

        bool isNazivTakmicenjaValidated = false, isSlikaValidated = false, isGradValidated = false;

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
                pictureBox1.Hide();
                loaderIgraci.Hide();

                frmStadionKartica[] listItems = new frmStadionKartica[_stadioni.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmStadionKartica(this);
                    listItems[i].stadionId = _stadioni[i].stadionId;
                    listItems[i].nazivStadiona = _stadioni[i].nazivStadiona;
                    listItems[i].grad = _stadioni[i].lokacijaStadiona.nazivGrada;
                    listItems[i].slikaStadiona = byteToImage.ConvertByteToImage(_stadioni[i].slikaStadiona);

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
            if (!isNazivTakmicenjaValidated || !isSlikaValidated || !isGradValidated)
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
            txtBrojIgraca.Text = _stadioni.Count().ToString();
        }
        private async Task LoadGradovi()
        {
            try
            {
                _gradovi = await _grad.GetAll<List<Model.Models.Grad>>(null);

                if(_gradovi.Count() > 0)
                {
                    foreach (var item in _gradovi)
                    {
                        cmbGrad.Items.Add(item.nazivGrada);
                    }
                    cmbGrad.SelectedIndex = 0;
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
            try
            {

                if (result == DialogResult.OK)
                {
                    var fileName = grbFileDialog.FileName;

                    var file = System.IO.File.ReadAllBytes(fileName);

                    slikaStadiona = file;

                    Image image = Image.FromFile(fileName);
                    pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBox2.BackgroundImage = image;

                    isSlikaValidated = Validacija.ValidirajSliku(image, pictureSlikaUtakmicaValidator, Field.SLIKA_AVATAR);

                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GRESKA_UPLOAD);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNazivKluba_TextChanged(object sender, EventArgs e)
        {
            isNazivTakmicenjaValidated = Validacija.ValidirajInputString(txtNazivKluba, txtTelefonValidator, Field.NAZIV_KLUBA);
        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrad.SelectedText != "Grad")
            {
                isGradValidated = true;
            }
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
                pictureBox2.BackgroundImage = Properties.Resources.uploadFile;
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                txtNazivKluba.Text = "";
                cmbGrad.SelectedIndex = 0;
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            StadionUpdateRequest update = new StadionUpdateRequest
            {
                nazivStadiona = txtNazivKluba.Text,
            };
            try
            {
                await _stadion.Update<Model.Models.Stadion>(stadion.stadionId, update);
                await LoadStadioni(notifikacija: TipNotifikacije.UREĐIVANJE);
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

        public void filterStadioni(int stadionId)
        {
            bunifuButton1.Hide();
            btnSaveUpdate.Show();
            stadion = _stadioni.Where(s => s.stadionId == stadionId).SingleOrDefault();
            txtNazivKluba.Text = stadion.nazivStadiona;
            int selectedGrad = 0;
            for (int i = 0; i < _gradovi.Count; i++)
            {
                if (_gradovi[i].gradId == stadion.lokacijaStadionaId)
                {
                    selectedGrad = i;
                }
            }
            cmbGrad.SelectedIndex = selectedGrad;
            cmbGrad.Enabled = false;

            pictureBox2.BackgroundImage = byteToImage.ConvertByteToImage(stadion.slikaStadiona);
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;

            isSlikaValidated = true;
            btnUcitajPanelPhoto.Enabled = false;
            pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(204, 204, 204);
        }
        public void OcistiPolja()
        {
            btnSaveUpdate.Hide();
            bunifuButton1.Show();
            txtNazivKluba.Text = "";
            txtTelefonValidator.Text = "";
            cmbGrad.SelectedIndex = 0;
            cmbGrad.Enabled = true;
            pictureBox2.BackgroundImage = Properties.Resources.uploadFile;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(64, 5, 7);
            btnUcitajPanelPhoto.Enabled = true;
        }
    }
}
