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
        Model.Models.Klub klub;
        ByteToImage byteToImage = new ByteToImage();

        bool isNazivTakmicenjaValidated = false, isSlikaValidated = false, isGradValidated = false, isStadionValidated = false;

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
                loaderIgraci.Hide();
                loader.Hide();

                frmKlubKartica[] listItems = new frmKlubKartica[_klubovi.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmKlubKartica(this);
                    listItems[i].klubId = _klubovi[i].klubId;
                    listItems[i].nazivKluba = _klubovi[i].nazivKluba;
                    listItems[i].igracSlika = byteToImage.ConvertByteToImage(_klubovi[i].grb);

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
            if (!isNazivTakmicenjaValidated || !isSlikaValidated || !isGradValidated || !isStadionValidated)
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
            txtBrojIgraca.Text = _klubovi.Count().ToString();
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
        private async Task LoadStadioni()
        {
            try
            {
                _stadioni = await _stadion.GetAll<List<Model.Models.Stadion>>(null);

                if(_stadioni.Count() > 0)
                {
                    foreach (var item in _stadioni)
                    {
                        cmbStadion.Items.Add(item.nazivStadiona);
                    }
                    cmbStadion.SelectedIndex = 0;
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbStadion_SelectedIndexChanged(object sender, EventArgs e)
        {
            isStadionValidated = Validacija.ValidirajDropDown(cmbStadion, "Stadion", txtStadionValidator, pictureStadionValidator);
        }

        private void txtNazivKluba_TextChanged(object sender, EventArgs e)
        {
            isNazivTakmicenjaValidated = Validacija.ValidirajInputString(txtNazivKluba, txtTelefonValidator, Field.NAZIV_KLUBA);
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            KlubUpdateRequest update = new KlubUpdateRequest
            {
                nazivKluba = txtNazivKluba.Text,
            };
            try
            {
                await _klub.Update<Model.Models.Klub>(klub.klubId, update);
                await LoadKlubovi(notifikacija: TipNotifikacije.UREĐIVANJE);
                OcistiPolja();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            isGradValidated = Validacija.ValidirajDropDown(cmbGrad, "Grad", txtGradValidator, pictureGradValidator);
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

                    grb = file;

                    Image image = Image.FromFile(fileName);
                    pictureGrb.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureGrb.BackgroundImage = image;

                    isSlikaValidated = Validacija.ValidirajSliku(image, pictureSlikaUtakmicaValidator, Field.SLIKA_AVATAR);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GRESKA_UPLOAD);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
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
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        public void filterKlubovi(int klubId)
        {
            bunifuButton1.Hide();
            btnSaveUpdate.Show(); 
            klub = _klubovi.Where(s => s.klubId == klubId).SingleOrDefault();
            txtNazivKluba.Text = klub.nazivKluba;
            int selectedGrad = 0;
            for (int i = 0; i < _gradovi.Count; i++)
            {
                if(_gradovi[i].gradId == klub.gradId)
                {
                    selectedGrad = i;
                }
            }
            cmbGrad.SelectedIndex = selectedGrad;
            cmbGrad.Enabled = false;
            int selectedStadion = 0;
            for (int i = 0; i < _stadioni.Count; i++)
            {
                if (_stadioni[i].stadionId == klub.stadionId)
                {
                    selectedStadion = i;
                }
            }
            cmbStadion.SelectedIndex = selectedStadion;
            cmbStadion.Enabled = false;

            pictureGrb.BackgroundImage = byteToImage.ConvertByteToImage(klub.grb);
            pictureGrb.BackgroundImageLayout = ImageLayout.Zoom;

            isSlikaValidated = true;
            btnUcitajPanelPhoto.Enabled = false;
            pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(204, 204, 204);
        }
        public void OcistiPolja ()
        {
            btnSaveUpdate.Hide();
            bunifuButton1.Show();
            txtNazivKluba.Text = "";
            txtTelefonValidator.Text = "";
            cmbGrad.SelectedIndex = 0;
            cmbGrad.Enabled = true;
            cmbStadion.SelectedIndex = 0;
            cmbStadion.Enabled = true;
            pictureGrb.BackgroundImage = Properties.Resources.uploadFile;
            pictureGrb.BackgroundImageLayout = ImageLayout.Zoom;
            pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(64, 5, 7);
            btnUcitajPanelPhoto.Enabled = true;
        }
    }
}
