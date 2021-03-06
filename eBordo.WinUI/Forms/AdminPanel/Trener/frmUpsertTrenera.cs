using eBordo.Model.Models;
using eBordo.Model.Requests.Trener;
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

namespace eBordo.WinUI.Forms.AdminPanel.Trener
{
    public partial class frmUpsertTrenera : Form
    {
        private readonly ApiService.ApiService _trener = new ApiService.ApiService("Trener");
        private readonly ApiService.ApiService _drzava = new ApiService.ApiService("Drzava");
        private readonly ApiService.ApiService _grad = new ApiService.ApiService("Grad");
        private readonly ApiService.ApiService _formacija = new ApiService.ApiService("Formacija");
        private readonly ApiService.ApiService _licenca = new ApiService.ApiService("TrenerskaLicenca");

        public List<Model.Models.Drzava> _drzave { get; set; }
        public List<Model.Models.Grad> _gradovi { get; set; }
        public List<Model.Models.Formacija> _formacije { get; set; }
        public List<Model.Models.TrenerskaLicenca> _licence { get; set; }
        public Model.Models.Trener _odabraniTrener { get; set; }

        private frmPrikazTrenera _prikazTrenera;
        private byte[] korisnikPanelPhoto { get; set; }
        private byte[] korisnikAvatar { get; set; }
        ByteToImage byteToImage = new ByteToImage();

        bool isImeValidated = false, isPrezimeValidate = false, isAdresaValidated = false,
            isTelefonValidated, isEmailValidated = false,
            isSlikaAvatarValidated = false, isSlikaPanelValidated = false,
            isDatumRodjenjaValidated = false, isDatumPotpisaValidated = false, isDatumZavrsetkaValidated = false,
            isDrzavljanstvoValidated = false, isGradROdjenjaValidated = false, isFormacijaValidated = false, isPozicijaValidated;


        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            isImeValidated = Validacija.ValidirajInputString(txtIme, txtImeValidator, Field.IME);
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            isPrezimeValidate = Validacija.ValidirajInputString(txtPrezime, txtPrezimeValidator, Field.PREZIME);
        }

        private void dtpDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {
            isDatumRodjenjaValidated = Validacija.ValidirajDatum(dtpDatumRodjenja.Value, txtDatumRodjenjaValidator, pictureDatumRodjenjaValidator, Field.DATUM_RODJENJA_TRENER);
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            isAdresaValidated = Validacija.ValidirajInputString(txtAdresa, txtAdresaValidator, Field.ADRESA);
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            isTelefonValidated = Validacija.ValidirajInputString(txtTelefon, txtTelefonValidator, Field.TELEFON);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            isEmailValidated = Validacija.ValidirajInputString(txtEmail, txtMailValidator, Field.EMAIL);
        }

        private void dtpDatumPotpisaUgovora_ValueChanged(object sender, EventArgs e)
        {
            isDatumPotpisaValidated = Validacija.ValidirajDatum(dtpDatumPotpisaUgovora.Value, txtDatumPotpisaValidator, pictureDatumPotpisaValidator, Field.DATUM_POTPISA);
        }

        private void dtpDatumZavrsetkaUgovora_ValueChanged(object sender, EventArgs e)
        {
            isDatumZavrsetkaValidated = Validacija.ValidirajDatum(dtpDatumZavrsetkaUgovora.Value, txtDatumZavrsetkaValidator, pictureDatumZavrsetkaUgovora, Field.DATUM_ZAVRSETKA);
        }

        public frmUpsertTrenera(Model.Models.Trener odabraniTrener = null, frmPrikazTrenera prikazTrenera = null)
        {
            InitializeComponent();
            _prikazTrenera = prikazTrenera;
            if (odabraniTrener != null)
            {
                _odabraniTrener = odabraniTrener;
            }
        }
        private void frmUpsertTrenera_Load(object sender, EventArgs e)
        {
            LoadDrzave();
            LoadGradovi();
            LoadFormacije();
            LoadLicence();
            if (_odabraniTrener != null)
            {
                btnSaveUpdate.Show();
                this.Text = "eBordo | Uredi trenera";
                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                dtpDatumRodjenja.Enabled = false;
                btnUcitajFotografiju.Enabled = false;
                btnUcitajPanelPhoto.Enabled = false;
                if (_odabraniTrener.korisnik.Slika.Length != 0)
                {
                    userProflePicture.Image = byteToImage.ConvertByteToImage(_odabraniTrener.korisnik.Slika);
                    userProflePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureSlikaIgraca.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniTrener.SlikaPanel);
                    pictureSlikaIgraca.SizeMode = PictureBoxSizeMode.Zoom;
                    isSlikaAvatarValidated = true;
                    isSlikaPanelValidated = true;
                    pictureSlikaAvatarValidator.BackgroundImage = Properties.Resources.eBordo_success_izvjestaj;
                    pictureSlikaAvatarValidator.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureSlikaPanelVAlidator.BackgroundImage = Properties.Resources.eBordo_success_izvjestaj;
                    pictureSlikaPanelVAlidator.BackgroundImageLayout = ImageLayout.Zoom;
                }
                pictureSlikaAvatarValidator.BackColor = Color.FromArgb(204, 204, 204);
                pictureSlikaPanelVAlidator.BackColor = Color.FromArgb(204, 204, 204);
                dtpDatumPotpisaUgovora.Value = _odabraniTrener.ugovor.datumPocetka;
                dtpDatumZavrsetkaUgovora.Value = _odabraniTrener.ugovor.datumZavrsetka;
                LoadTrener();
            }
            else
            {
                btnSave.Show();
                controlIsAktivan.Hide();
                switchIsAktivan.Hide();
                this.Text = "eBordo | Dodaj trenera";
            }
        }
        private void LoadTrener()
        {
            txtIme.Text = _odabraniTrener.korisnik.ime;
            txtPrezime.Text = _odabraniTrener.korisnik.prezime;
            dtpDatumRodjenja.Value = _odabraniTrener.korisnik.datumRodjenja;
            txtEmail.Text = _odabraniTrener.korisnik.email;
            txtAdresa.Text = _odabraniTrener.korisnik.adresa;
            txtTelefon.Text = _odabraniTrener.korisnik.telefon;
            radioBtnGlavni.Enabled = false;
            radioBtnPomocnik.Enabled = false;
            if (_odabraniTrener.korisnik.isAktivan)
            {
                switchIsAktivan.Checked = true;
            }
            else
            {
                switchIsAktivan.Checked = false;
            }
        }
        private async void LoadLicence()
        {
            try
            {
                _licence = await _licenca.GetAll<List<Model.Models.TrenerskaLicenca>>(null);

                foreach (var item in _licence)
                {
                    cmbLicenca.Items.Add(item.nazivLicence);
                }

                if (_odabraniTrener != null)
                {
                    int selectedLicenca = 0;
                    for (int i = 0; i < _licence.Count; i++)
                    {
                        if (_licence[i].trenerskaLicencaId == _odabraniTrener.trenerskaLicenca.trenerskaLicencaId)
                        {
                            selectedLicenca = i;
                        }
                    }
                    cmbLicenca.SelectedIndex = selectedLicenca;
                }
                else
                {
                    cmbLicenca.SelectedIndex = 0;
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private async void LoadFormacije()
        {
            try
            {
                _formacije = await _formacija.GetAll<List<Model.Models.Formacija>>(null);

                foreach (var item in _formacije)
                {
                    cmbFormacija.Items.Add(item.nazivFormacije);
                }

                if (_odabraniTrener != null)
                {
                    int selectedFormacija = 0;
                    for (int i = 0; i < _formacije.Count; i++)
                    {
                        if (_formacije[i].formacijaId == _odabraniTrener.formacija.formacijaId)
                        {
                            selectedFormacija = i;
                        }
                    }
                    cmbFormacija.SelectedIndex = selectedFormacija;
                }
                else
                {
                    cmbFormacija.SelectedIndex = 0;
                }
            }
            catch 
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void switchIsAktivan_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

        }

        private void cmbDrzavljanstvo_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDrzavljanstvoValidated = Validacija.ValidirajDropDown(cmbDrzavljanstvo, "Državljanstvo", txtDrzavljanstvoValidator, pictureDrzavljanstvoSlikaValidator);
        }

        private void cmbGradRodjenja_SelectedIndexChanged(object sender, EventArgs e)
        {
            isGradROdjenjaValidated = Validacija.ValidirajDropDown(cmbGradRodjenja, "Grad rođenja", txtGradValidator, pictureGradSlikaValidator);

        }

        private void cmbFormacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFormacijaValidated = Validacija.ValidirajDropDown(cmbFormacija, "Formacija", txtFormacijaValidator, pictureFormacijaSlikaValidator);

        }

        private async void LoadDrzave()
        {
            try
            {
                _drzave = await _drzava.GetAll<List<Model.Models.Drzava>>(null);

                if (_odabraniTrener != null)
                {
                    cmbDrzavljanstvo.Items.Add(_drzave.Where(s => s.drzavaId == _odabraniTrener.korisnik.drzavljanstvo.drzavaId).SingleOrDefault().nazivDrzave);
                    cmbDrzavljanstvo.SelectedIndex = 0;
                    cmbDrzavljanstvo.Enabled = false;
                }
                else
                {
                    foreach (var item in _drzave)
                    {
                        cmbDrzavljanstvo.Items.Add(item.nazivDrzave);
                    }
                    cmbDrzavljanstvo.SelectedIndex = 0;
                }
            }
            catch 
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private async void LoadGradovi()
        {
            try
            {
                _gradovi = await _grad.GetAll<List<Model.Models.Grad>>(null);

                if (_odabraniTrener != null)
                {
                    cmbGradRodjenja.Items.Add(_gradovi.Where(s => s.gradId == _odabraniTrener.korisnik.gradRodjenja.gradId).SingleOrDefault().nazivGrada);
                    cmbGradRodjenja.SelectedIndex = 0;
                    cmbGradRodjenja.Enabled = false;
                }
                else
                {
                    foreach (var item in _gradovi)
                    {
                        cmbGradRodjenja.Items.Add(item.nazivGrada);
                    }
                    cmbGradRodjenja.SelectedIndex = 0;
                }
            }
            catch 
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private void btnUcitajFotografiju_Click_1(object sender, EventArgs e)
        {
            var result = avatarFileDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK)
                {
                    var fileName = avatarFileDialog.FileName;

                    var file = System.IO.File.ReadAllBytes(fileName);

                    korisnikAvatar = file;

                    Image image = Image.FromFile(fileName);
                    userProflePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    userProflePicture.Image = image;

                    isSlikaAvatarValidated = Validacija.ValidirajSliku(image, pictureSlikaAvatarValidator, Field.SLIKA_AVATAR);
                }
            }
            catch 
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GRESKA_UPLOAD);
            }
        }

        private void btnUcitajPanelPhoto_Click(object sender, EventArgs e)
        {
            var result = panelSlikaFileDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK)
                {
                    var fileName = panelSlikaFileDialog.FileName;

                    var file = System.IO.File.ReadAllBytes(fileName);

                    korisnikPanelPhoto = file;

                    Image image = Image.FromFile(fileName);
                    pictureSlikaIgraca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    pictureSlikaIgraca.BackgroundImage = image;

                    isSlikaPanelValidated = Validacija.ValidirajSliku(image, pictureSlikaPanelVAlidator, Field.SLIKA_PANEL);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GRESKA_UPLOAD);
            }
        }

        private void cmbLicenca_SelectedIndexChanged(object sender, EventArgs e)
        {
            isPozicijaValidated = Validacija.ValidirajDropDown(cmbLicenca, "Licenca", txtLicencaValidator, pictureLicencaSlikaValidator);

        }
        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if (!isImeValidated || !isPrezimeValidate || !isAdresaValidated || 
                !isTelefonValidated || !isEmailValidated ||
                !isDatumRodjenjaValidated || !isDatumPotpisaValidated || !isDatumZavrsetkaValidated ||
                !isSlikaAvatarValidated || !isSlikaPanelValidated || !isDrzavljanstvoValidated ||
                !isGradROdjenjaValidated || !isFormacijaValidated || !isPozicijaValidated
)
            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            int uloga = 0;
            if (radioBtnGlavni.Checked)
            {
                uloga = 1;
            }
            if (radioBtnPomocnik.Checked)
            {
                uloga = 2;
            }
            TrenerInsertRequest insertRequest = new TrenerInsertRequest
            {
                korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                {
                    ime = txtIme.Text,
                    prezime = txtPrezime.Text,
                    datumRodjenja = dtpDatumRodjenja.Value,
                    adresa = txtAdresa.Text,
                    telefon = txtTelefon.Text,
                    email = txtEmail.Text,
                    drzavljanstvoId = _drzave[cmbDrzavljanstvo.SelectedIndex].drzavaId,
                    gradRodjenjaId = _gradovi[cmbGradRodjenja.SelectedIndex].gradId,
                    Slika = korisnikAvatar,
                },
                ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                {
                    datumPocetka = dtpDatumPotpisaUgovora.Value,
                    datumZavrsetka = dtpDatumZavrsetkaUgovora.Value,
                },
                preferiranaFormacijaId = _formacije[cmbFormacija.SelectedIndex].formacijaId,
                trenerskaLicencaId = _licence[cmbLicenca.SelectedIndex].trenerskaLicencaId,
                SlikaPanel = korisnikPanelPhoto,
                ulogaTreneraId = uloga
            };
            try
            {
                await _trener.Insert<Model.Models.Trener>(insertRequest);
                await _prikazTrenera.LoadTreneri(notifikacija: TipNotifikacije.DODAVANJE);
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
            bool isAktivan = true;
            if (switchIsAktivan.Checked)
            {
                isAktivan = true;
            }
            else
            {
                isAktivan = false;
            }
            TrenerUpdateRequest updateRequest = new TrenerUpdateRequest
            {
                korisnikUpdateRequest = new Model.Requests.Korisnik.KorisnikUpdateRequest
                {
                    adresa = txtAdresa.Text,
                    telefon = txtTelefon.Text,
                    email = txtEmail.Text,
                    isAktivan = isAktivan
                },
                ugovorUpdateRequeest = new Model.Requests.Ugovor.UgovorUpdateRequest
                {
                    datumPocetka = dtpDatumPotpisaUgovora.Value,
                    datumZavrsetka = dtpDatumZavrsetkaUgovora.Value,
                },
                preferiranaFormacijaId = _formacije[cmbFormacija.SelectedIndex].formacijaId,
                trenerskaLicencaId = _licence[cmbLicenca.SelectedIndex].trenerskaLicencaId,
            };
            try
            {
                await _trener.Update<Model.Models.Trener>(_odabraniTrener.trenerId, updateRequest);
                await _prikazTrenera.LoadTreneri(notifikacija: TipNotifikacije.UREĐIVANJE);
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void txtDatumZavrsetkaValidator_Click(object sender, EventArgs e)
        {

        }
    }
}
