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
        private byte[] korisnikAvatar { get; set; }
        ByteToImage byteToImage = new ByteToImage();

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
                this.Text = "eBordo | Uredi igrača";
                btnSave.Text = "Spasi izmjene";
                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                dtpDatumRodjenja.Enabled = false;
                nmbrSlabijaNoga.Enabled = false;
                btnUcitajFotografiju.Enabled = false;
                if (_odabraniIgrac.korisnik.Slika.Length != 0)
                {
                    userProflePicture.Image = byteToImage.ConvertByteToImage(_odabraniIgrac.korisnik.Slika);
                    userProflePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                LoadIgrac();
            }
            else
            {
                this.Text = "eBordo | Dodaj igrača";
                btnSave.BackColor = Color.Green;
                btnSave.Text = "Spasi igrača";
            }
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
        private async void LoadDrzave()
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
        private async void LoadGradovi()
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            IgracInsertRequest insertRequest;
            IgracUpdateRequest updateRequest;

            if (_odabraniIgrac != null)
            {
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
                        napomene = txtNapomene.Text
                    },
                    visina = Int32.Parse(txtVisina.Text),
                    tezina = Int32.Parse(txtTezina.Text),
                    brojDresa = Int32.Parse(txtBrojDresa.Text),
                    trzisnaVrijednost = Int32.Parse(txtTrzisnaVrijednost.Text),
                    napomeneOIgracu = txtNapomene.Text,
                    pozicijaId = _pozicije[cmbPozicija.SelectedIndex].pozicijaId,
                };
                await _igrac.Update<Model.Models.Igrac>(_odabraniIgrac.igracId, updateRequest);
                await _prikazIgraca.LoadIgraci(notifikacija: TipNotifikacije.UREĐIVANJE);

            }
            else
            {
                string boljaNoga = "";
                if (radioDesna.Checked)
                {
                    boljaNoga = "DESNA";
                }
                else if (radioLijeva.Checked)
                {
                    boljaNoga = "LIJEVA";
                }

                insertRequest = new IgracInsertRequest
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
                    noga=boljaNoga,
                    jacinaSlabijeNoge = nmbrSlabijaNoga.Value,
                    napomeneOIgracu = txtNapomene.Text,
                    pozicijaId = _pozicije[cmbPozicija.SelectedIndex].pozicijaId,
                };

                await _igrac.Insert<Model.Models.Igrac>(insertRequest);
                await _prikazIgraca.LoadIgraci(notifikacija: TipNotifikacije.DODAVANJE);
            }

            this.Hide();
        }
        private void btnUcitajFotografiju_Click(object sender, EventArgs e)
        {
            var result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = fileDialog.FileName;

                var file = System.IO.File.ReadAllBytes(fileName);

                korisnikAvatar = file;

                Image image = Image.FromFile(fileName);
                userProflePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                userProflePicture.Image = image;
            }
        }
    }
}
