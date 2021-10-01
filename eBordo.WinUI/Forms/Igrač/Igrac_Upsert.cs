using eBordo.Model.Requests.Igrac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.UserControls.Igrač
{
    public partial class Igrac_Upsert : Form
    {
        private readonly ApiService.ApiService _igrac = new ApiService.ApiService("Igrac");
        private readonly ApiService.ApiService _drzava = new ApiService.ApiService("Drzava");
        private readonly ApiService.ApiService _grad = new ApiService.ApiService("Grad");
        private readonly ApiService.ApiService _pozicija = new ApiService.ApiService("Pozicija");

        private PrikazIgraca _prikazIgraca;

        public List<Model.Models.Drzava> _drzave { get; set; }
        public List<Model.Models.Grad> _gradovi { get; set; }
        public List<Model.Models.Pozicija> _pozicije { get; set; }
        public Model.Models.Igrac _odabraniIgrac { get; set; }

        public Igrac_Upsert(Model.Models.Igrac odabraniIgrac = null, PrikazIgraca prikazIgraca = null)
        {
            InitializeComponent();
            _prikazIgraca = prikazIgraca;

            if(odabraniIgrac != null)
            {
                _odabraniIgrac = odabraniIgrac;
            }
        }
        private async void Igrac_Insert_Load(object sender, EventArgs e)
        {
            LoadDrzave();
            LoadGradovi();
            LoadPozicije();
            if (_odabraniIgrac != null)
            {
                this.Text = "eBordo | Uredi igrača";
                btnSave.FillColor = Color.Orange;
                btnSave.Text = "Spasi izmjene";
                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                dtpDatumRodjenja.Enabled = false;
                dtpDatumDolaska.Enabled = false;
                dtpDatumPotpisa.Enabled = false;
                LoadIgrac();
            }
            else
            {
                this.Text = "eBordo | Dodaj igrača";
                btnSave.FillColor = Color.Green;
                btnSave.Text = "Spasi igrača";
            }
        }
        private async void LoadIgrac()
        {
            txtIme.Text = _odabraniIgrac.korisnik.ime;
            txtPrezime.Text = _odabraniIgrac.korisnik.prezime;
            dtpDatumRodjenja.Value = _odabraniIgrac.korisnik.datumRodjenja;
            txtEmail.Text = _odabraniIgrac.korisnik.email;
            txtAdresa.Text = _odabraniIgrac.korisnik.adresa;
            txtTelefon.Text = _odabraniIgrac.korisnik.telefon;
            txtVisina.Value = Convert.ToDecimal(_odabraniIgrac.visina);
            txtTežina.Value = Convert.ToDecimal(_odabraniIgrac.tezina);
            txtDres.Value = _odabraniIgrac.brojDresa;
            txtVrijednost.Value = Convert.ToDecimal(_odabraniIgrac.trzisnaVrijednost);
            dtpDatumDolaska.Value = _odabraniIgrac.ugovor.datumPotpisa;
            dtpDatumPocetka.Value = _odabraniIgrac.ugovor.datumPocetka;
            dtpDatumKraja.Value = _odabraniIgrac.ugovor.datumZavrsetka;
            txtIznosPlate.Value =Convert.ToDecimal(_odabraniIgrac.ugovor.iznosPlate);
            txtNapomene.Text = _odabraniIgrac.ugovor.napomene;
            LoadBoljaNoga();
        }
        private async void LoadBoljaNoga()
        {
            if(_odabraniIgrac != null)
            {
                rbtnDesna.Enabled = false;
                rbtnLijeva.Enabled = false;
                if(_odabraniIgrac.boljaNoga == "DESNA")
                {
                    rbtnDesna.Checked = true;
                }
                else if (_odabraniIgrac.boljaNoga == "LIJEVA")
                {
                    rbtnLijeva.Checked = true;
                }
            }
        }
        
        private async void LoadDrzave()
        {
            _drzave = await _drzava.GetAll<List<Model.Models.Drzava>>(null);

            if(_odabraniIgrac != null)
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
                    if(_pozicije[i].pozicijaId == _odabraniIgrac.pozicija.pozicijaId)
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
        private async void LoadGradovi()
        {
            _gradovi = await _grad.GetAll<List<Model.Models.Grad>>(null);
            
            if(_odabraniIgrac != null)
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
        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            IgracInsertRequest insertRequest;
            IgracUpdateRequest updateRequest;

            if(_odabraniIgrac != null)
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
                        datumPocetka = dtpDatumPocetka.Value,
                        datumZavrsetka = dtpDatumKraja.Value,
                        plata = Decimal.ToInt32(txtIznosPlate.Value),
                        napomene = txtNapomene.Text
                    },
                    visina = Decimal.ToInt32(txtVisina.Value),
                    tezina = Decimal.ToInt32(txtTežina.Value),
                    brojDresa = Decimal.ToInt32(txtDres.Value),
                    trzisnaVrijednost = Decimal.ToInt32(txtVrijednost.Value),
                    slika = "nema",
                    pozicijaId = _pozicije[cmbPozicija.SelectedIndex].pozicijaId,
                };
                var result = await _igrac.Update<Model.Models.Igrac>(_odabraniIgrac.igracId, updateRequest);
            }
            else
            {
                string boljaNoga = "";
                if (rbtnDesna.Checked)
                {
                    boljaNoga = "DESNA";
                }
                else if (rbtnLijeva.Checked)
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
                        gradRodjenjaId = _gradovi[cmbGradRodjenja.SelectedIndex].gradId
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = dtpDatumPocetka.Value,
                        datumZavrsetka = dtpDatumKraja.Value,
                        datumPotpisa = dtpDatumPotpisa.Value,
                        plata = Decimal.ToInt32(txtIznosPlate.Value),
                        napomene = txtNapomene.Text
                    },
                    pozicijaId = _pozicije[cmbPozicija.SelectedIndex].pozicijaId,
                    noga = boljaNoga,
                    visina = Decimal.ToInt32(txtVisina.Value),
                    tezina = Decimal.ToInt32(txtTežina.Value),
                    brojDresa = Decimal.ToInt32(txtDres.Value),
                    trzisnaVrijednost = Decimal.ToInt32(txtVrijednost.Value),
                    slika = "nema",
                    datumPristupaKlubu =dtpDatumDolaska.Value
                };

                var result = await _igrac.Insert<Model.Models.Igrac>(insertRequest);
            }
            
            await _prikazIgraca.LoadIgraci();

            this.Hide();
        }
    }
}
