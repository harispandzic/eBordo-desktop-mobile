using eBordo.Model.Requests.Igrac;
using eBordo.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel
{
    public partial class frmUpsertIgraca : Form
    {
        private readonly ApiService.ApiService _igrac = new ApiService.ApiService("Igrac");
        private readonly ApiService.ApiService _drzava = new ApiService.ApiService("Drzava");
        private readonly ApiService.ApiService _grad = new ApiService.ApiService("Grad");
        private readonly ApiService.ApiService _pozicija = new ApiService.ApiService("Pozicija");

        public List<Model.Models.Drzava> _drzave { get; set; }
        public List<Model.Models.Grad> _gradovi { get; set; }
        public List<Model.Models.Pozicija> _pozicije { get; set; }
        public Model.Models.Igrac _odabraniIgrac { get; set; }

        private frmPrikazIgraca _prikazIgraca;
        private byte[] korisnikPanelPhoto { get; set; }
        private byte[] korisnikAvatar { get; set; }
        ByteToImage byteToImage = new ByteToImage();

        bool isImeValidated = false, isPrezimeValidate = false, isAdresaValidated = false,
            isTelefonValidated, isEmailValidated = false, isTezinaValidated = false, isVisinaValidated = false,
            isBrojDresaValidated = false, isTrzisnaVrijednostValidated = false,
            isSlikaAvatarValidated = false, isSlikaPanelValidated = false,
            isDatumRodjenjaValidated = false, isDatumPotpisaValidated = false, isDatumZavrsetkaValidated = false;

        public frmUpsertIgraca(Model.Models.Igrac odabraniIgrac = null, frmPrikazIgraca prikazIgraca = null)
        {
            InitializeComponent();
            _prikazIgraca = prikazIgraca;
            if (odabraniIgrac != null)
            {
                _odabraniIgrac = odabraniIgrac;
            }
        }
        private void frmUpsertIgraca_Load(object sender, EventArgs e)
        {
            LoadDrzave();
            LoadGradovi();
            LoadPozicije();
            if (_odabraniIgrac != null)
            {
                btnSaveUpdate.Show();
                this.Text = "eBordo | Uredi igrača";
                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                dtpDatumRodjenja.Enabled = false;
                nmbrSlabijaNoga.Enabled = false;
                btnUcitajPanelPhoto.Enabled = false;
                btnUcitajAvatar.Enabled = false;
                if (_odabraniIgrac.korisnik.Slika.Length != 0)
                {
                    userProflePicture.Image = byteToImage.ConvertByteToImage(_odabraniIgrac.korisnik.Slika);
                    userProflePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureSlikaIgraca.Image = byteToImage.ConvertByteToImage(_odabraniIgrac.slikaPanel);
                    pictureSlikaIgraca.SizeMode = PictureBoxSizeMode.Zoom;
                }
                LoadIgrac();
                pictureSlikaAvatarValidator.BackColor = Color.FromArgb(204, 204, 204);
                pictureSlikaPanelVAlidator.BackColor = Color.FromArgb(204, 204, 204);
            }
            else
            {
                btnSave.Show();
                this.Text = "eBordo | Dodaj igrača";
            }
            btnUcitajPanelPhoto.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void LoadIgrac()
        {
            txtIme.Text = _odabraniIgrac.korisnik.ime;
            txtPrezime.Text = _odabraniIgrac.korisnik.prezime;
            dtpDatumRodjenja.Value = _odabraniIgrac.korisnik.datumRodjenja;
            txtEmail.Text = _odabraniIgrac.korisnik.email;
            txtAdresa.Text = _odabraniIgrac.korisnik.adresa;
            txtTelefon.Text = _odabraniIgrac.korisnik.telefon;
            txtVisina.Text =  _odabraniIgrac.visina.ToString();
            txtTezina.Text = _odabraniIgrac.tezina.ToString();
            txtBrojDresa.Text = _odabraniIgrac.brojDresa.ToString();
            txtTrzisnaVrijednost.Text = _odabraniIgrac.trzisnaVrijednost.ToString();
            dtpDatumPotpisaUgovora.Value = _odabraniIgrac.ugovor.datumPocetka;
            dtpDatumZavrsetkaUgovora.Value = _odabraniIgrac.ugovor.datumZavrsetka;
            txtNapomene.Text = _odabraniIgrac.napomeneOIgracu;
            nmbrSlabijaNoga.Value = _odabraniIgrac.jacinaSlabijeNoge;

            LoadBoljaNoga();
        }
        private void LoadBoljaNoga()
        {
            if (_odabraniIgrac != null)
            {
                radioDesna.Enabled = false;
                radioLijeva.Enabled = false;
                if (_odabraniIgrac.boljaNoga == "Desna")
                {
                    radioDesna.Checked = true;
                }
                else if (_odabraniIgrac.boljaNoga == "Lijeva")
                {
                    radioLijeva.Checked = true;
                }
            }
        }
        private async void LoadPozicije()
        {
            try
            {
                _pozicije = await _pozicija.GetAll<List<Model.Models.Pozicija>>(null);

                foreach (var item in _pozicije)
                {
                    cmbPozicija.Items.Add(item.nazivPozicije);
                }

                if (_odabraniIgrac != null)
                {
                    int selectedPozicija = 0;
                    for (int i = 0; i < _pozicije.Count; i++)
                    {
                        if (_pozicije[i].pozicijaId == _odabraniIgrac.pozicija.pozicijaId)
                        {
                            selectedPozicija = i;
                        }
                    }
                    cmbPozicija.SelectedIndex = selectedPozicija;
                }
                else
                {
                    cmbPozicija.SelectedIndex = 0;
                }
            }
            catch 
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }

        }
        private async void LoadDrzave()
        {
            try
            {
                _drzave = await _drzava.GetAll<List<Model.Models.Drzava>>(null);

                if (_odabraniIgrac != null)
                {
                    cmbDrzavljanstvo.Items.Add(_drzave.Where(s => s.drzavaId == _odabraniIgrac.korisnik.drzavljanstvo.drzavaId).SingleOrDefault().nazivDrzave);
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

                if (_odabraniIgrac != null)
                {
                    cmbGradRodjenja.Items.Add(_gradovi.Where(s => s.gradId == _odabraniIgrac.korisnik.gradRodjenja.gradId).SingleOrDefault().nazivGrada);
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

        private void btnUcitajFotografiju_Click(object sender, EventArgs e)
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

        private void btnUcitajAvatar_Click(object sender, EventArgs e)
        {
            var result = panelSlikaFileDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK)
                {
                    btnUcitajPanelPhoto.TextAlign = ContentAlignment.MiddleRight;

                    var fileName = panelSlikaFileDialog.FileName;

                    var file = System.IO.File.ReadAllBytes(fileName);
                    korisnikPanelPhoto = file;

                    Image image = Image.FromFile(fileName);
                    pictureSlikaIgraca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    pictureSlikaIgraca.Image = image;

                    isSlikaPanelValidated = Validacija.ValidirajSliku(image, pictureSlikaPanelVAlidator, Field.SLIKA_PANEL);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GRESKA_UPLOAD);
            }
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            string boljaNoga = "";
            if (radioDesna.Checked)
            {
                boljaNoga = "DESNA";
            }
            else if (radioLijeva.Checked)
            {
                boljaNoga = "LIJEVA";
            }

            IgracInsertRequest insertRequest = new IgracInsertRequest
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
                visina = Int32.Parse(txtVisina.Text),
                tezina = Int32.Parse(txtTezina.Text),
                brojDresa = Int32.Parse(txtBrojDresa.Text),
                trzisnaVrijednost = Int32.Parse(txtTrzisnaVrijednost.Text),
                noga = boljaNoga,
                jacinaSlabijeNoge = nmbrSlabijaNoga.Value,
                napomeneOIgracu = txtNapomene.Text,
                pozicijaId = _pozicije[cmbPozicija.SelectedIndex].pozicijaId,
                SlikaPanel = korisnikPanelPhoto
            };
            try
            {
                await _igrac.Insert<Model.Models.Igrac>(insertRequest);
                await _prikazIgraca.LoadIgraci(notifikacija: TipNotifikacije.DODAVANJE);
                this.Hide();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            IgracUpdateRequest updateRequest;

            updateRequest = new IgracUpdateRequest
            {
                korisnikUpdateRequest = new Model.Requests.Korisnik.KorisnikUpdateRequest
                {
                    adresa = txtAdresa.Text,
                    telefon = txtTelefon.Text,
                    email = txtEmail.Text
                },
                ugovorUpdateRequeest = new Model.Requests.Ugovor.UgovorUpdateRequest
                {
                    datumPocetka = dtpDatumPotpisaUgovora.Value,
                    datumZavrsetka = dtpDatumZavrsetkaUgovora.Value,
                },
                visina = Int32.Parse(txtVisina.Text),
                tezina = Int32.Parse(txtTezina.Text),
                brojDresa = Int32.Parse(txtBrojDresa.Text),
                trzisnaVrijednost = Int32.Parse(txtTrzisnaVrijednost.Text),
                napomeneOIgracu = txtNapomene.Text,
                pozicijaId = _pozicije[cmbPozicija.SelectedIndex].pozicijaId,
            };
            try
            {
                await _igrac.Update<Model.Models.Igrac>(_odabraniIgrac.igracId, updateRequest);
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
            try
            {
                await _prikazIgraca.LoadIgraci(notifikacija: TipNotifikacije.UREĐIVANJE);
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if (!isImeValidated || !isPrezimeValidate || !isAdresaValidated || 
                !isTelefonValidated || !isEmailValidated || !isTezinaValidated || 
                !isVisinaValidated || !isBrojDresaValidated || !isTrzisnaVrijednostValidated || 
                isDatumRodjenjaValidated || isDatumPotpisaValidated || isDatumZavrsetkaValidated ||
                isSlikaAvatarValidated || isSlikaPanelValidated)
            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private void userProflePicture_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureDatumPotpisaValidator_Click(object sender, EventArgs e)
        {

        }

        private void dtpDatumZavrsetkaUgovora_ValueChanged(object sender, EventArgs e)
        {
            isDatumZavrsetkaValidated = Validacija.ValidirajDatum(dtpDatumZavrsetkaUgovora.Value, txtDatumZavrsetkaValidator, pictureDatumZavrsetkaUgovora, Field.DATUM_ZAVRSETKA);
        }

        private void dtpDatumPotpisaUgovora_ValueChanged(object sender, EventArgs e)
        {
            isDatumPotpisaValidated = Validacija.ValidirajDatum(dtpDatumPotpisaUgovora.Value, txtDatumPotpisaValidator, pictureDatumPotpisaValidator, Field.DATUM_POTPISA);
        }

        private void dtpDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {
            isDatumRodjenjaValidated = Validacija.ValidirajDatum(dtpDatumRodjenja.Value, txtDatumRodjenjaValidator, pictureDatumRodjenjaValidator, Field.DATUM_RODJENJA_IGRAC);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            isImeValidated = Validacija.ValidirajInputString(txtIme, txtImeValidator, Field.IME);
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            isPrezimeValidate = Validacija.ValidirajInputString(txtPrezime, txtPrezimeValidator, Field.PREZIME);
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            isAdresaValidated = Validacija.ValidirajInputString(txtAdresa, txtAdresaValidator, Field.ADRESA);
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            isTelefonValidated = Validacija.ValidirajInputString(txtTelefon, txtTelefonValidator, Field.TELEFON);
        }

        private void lblDatumPotpisaUgovora_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            isEmailValidated = Validacija.ValidirajInputString(txtEmail, txtEmailValidator, Field.EMAIL);
        }

        private void txtVisina_TextChanged(object sender, EventArgs e)
        {
            isVisinaValidated = Validacija.ValidirajInputString(txtVisina, txtVisinaValidator, Field.VISINA);
        }

        private void txtTezina_TextChanged(object sender, EventArgs e)
        {
            isTezinaValidated = Validacija.ValidirajInputString(txtTezina, txtTezinaValidator, Field.TEZINA);
        }

        private void txtBrojDresa_TextChanged(object sender, EventArgs e)
        {
            isBrojDresaValidated = Validacija.ValidirajInputString(txtBrojDresa, txtBrojDresaValidator, Field.DRES);
        }

        private void txtTrzisnaVrijednost_TextChanged(object sender, EventArgs e)
        {
            isTrzisnaVrijednostValidated = Validacija.ValidirajInputString(txtTrzisnaVrijednost, txtTrzisnaVrijednostValidator, Field.TRZISNA_VRIJEDNOST);
        }
    }
}
