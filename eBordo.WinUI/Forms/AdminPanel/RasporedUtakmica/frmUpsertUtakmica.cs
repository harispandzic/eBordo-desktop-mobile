using eBordo.Model.Requests.Igrac;
using eBordo.Model.Requests.Utakmica;
using eBordo.Model.Requests.UtakmicaSastav;
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

namespace eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica
{
    public partial class frmUpsertUtakmica : Form
    {
        private readonly ApiService.ApiService _utakmica = new ApiService.ApiService("Utakmica");
        private readonly ApiService.ApiService _klub = new ApiService.ApiService("Klub");
        private readonly ApiService.ApiService _takmicenje = new ApiService.ApiService("Takmicenje");
        private readonly ApiService.ApiService _stadion = new ApiService.ApiService("Stadion");
        private readonly ApiService.ApiService _igrac = new ApiService.ApiService("Igrac");
        private readonly ApiService.ApiService _pozicija = new ApiService.ApiService("Pozicija");

        private List<Model.Models.Klub> _klubovi;
        private List<Model.Models.Takmicenje> _takmicenja;
        private List<Model.Models.Stadion> _stadioni;
        private List<Model.Models.Igrac> _igraci;
        private List<Model.Models.Pozicija> _pozicije;

        private List<Model.Models.Igrac> _ostaliIgraci = new List<Model.Models.Igrac>();
        private List<int> _pozvaniIgraci = new List<int>();

        frmPrikazRasporedaUtakmicacs _prikazUtakmica;
        public Model.Models.Utakmica _odabranaUtakmica { get; set; }

        ByteToImage byteToImage = new ByteToImage();

        public frmUpsertUtakmica(Model.Models.Utakmica odabranaUtakmica, frmPrikazRasporedaUtakmicacs prikazUtakmica)
        {
            InitializeComponent();
            _prikazUtakmica = prikazUtakmica;
            _odabranaUtakmica = odabranaUtakmica;
        }
        private async void frmUpsertUtakmica_Load(object sender, EventArgs e)
        {
            LoadVrstaUtakmice();
            await LoadIgraci();
            await LoadPozicije();
            await LoadKlubovi();
            await LoadTakmicenja();
            await LoadStadioni();
            if (_odabranaUtakmica != null)
            {
                this.Text = "eBordo | Uredi utakmicu";
                btnSave.Text = "Spasi izmjene";
                txtOpisUtakmice.Enabled = false;
                txtSudija.Enabled = false;
                radioBtnDomacaGarnitura.Enabled = false;
                radioBtnGostujucaGarnitura.Enabled = false;
                radioBtnRezervnaGarnitura.Enabled = false;
                if (_odabranaUtakmica.tipGarniture == "Domaća")
                {
                    radioBtnDomacaGarnitura.Checked = true;
                }
                else if (_odabranaUtakmica.tipGarniture == "Gostujuća")
                {
                    radioBtnGostujucaGarnitura.Checked = true;
                }
                else if (_odabranaUtakmica.tipGarniture == "Rezervna")
                {
                    radioBtnRezervnaGarnitura.Checked = true;
                }
                if (_odabranaUtakmica.vrstaUtakmice ==  "Domaća")
                {
                    cmbVrstaUtakmice.SelectedIndex = 0;
                }
                else if (_odabranaUtakmica.vrstaUtakmice == "Gostujuća")
                {
                    cmbVrstaUtakmice.SelectedIndex = 1;
                }
                cmbVrstaUtakmice.Enabled = false;
                cmbIgraciSastav.Enabled = false;
                cmbPozicije.Enabled = false;
                LoadPodaciUtakmica();
            }
            else
            {
                this.Text = "eBordo | Dodaj utakmicu";
                btnSave.BackColor = Color.Green;
                btnSave.Text = "Spasi utakmicu";
            }
        }
        private void LoadPodaciUtakmica()
        {
            txtOpisUtakmice.Text = _odabranaUtakmica.opisUtakmice;
            txtSudija.Text = _odabranaUtakmica.sudija;
            txtSatnica.Text = _odabranaUtakmica.satnica;
            txtNapomene.Text = _odabranaUtakmica.napomene;
            dtpDatumOdigravanja.Value = _odabranaUtakmica.datumOdigravanja;
            foreach (var item in _odabranaUtakmica.sastav)
            {
                frmPozvaniIgracKartica pozvaniIgrac = new frmPozvaniIgracKartica(this, flowPanelPrvaPostava, flowPanelKlupa, _igraci, cmbIgraciSastav, _pozicije, cmbPozicije, radioBtnPrvihXI, radioBtnKlupa, true);
                pozvaniIgrac.igracId = item.igracId;
                pozvaniIgrac.pozicijaId = item.pozicijaId;
                pozvaniIgrac.igracSlika = byteToImage.ConvertByteToImage(item.igrac.korisnik.Slika);
                pozvaniIgrac.igracPozicija = item.pozicija.skracenica;
                pozvaniIgrac.igracPrezimeBrojDresa = item.igrac.korisnik.ime[0] + ". " + item.igrac.korisnik.prezime + " #" + item.igrac.brojDresa;
                if(item.uloga == "PRVA_POSTAVA")
                {
                    flowPanelPrvaPostava.Controls.Add(pozvaniIgrac);
                }
                else
                {
                    flowPanelKlupa.Controls.Add(pozvaniIgrac);
                }
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

                if (_odabranaUtakmica != null)
                {
                    int selectedStadion = 0;
                    for (int i = 0; i < _stadioni.Count; i++)
                    {
                        if (_stadioni[i].stadionId == _odabranaUtakmica.stadionId)
                        {
                            selectedStadion = i;
                        }
                    }
                    cmbStadion.SelectedIndex = selectedStadion;
                    cmbStadion.Enabled = false;
                }
                else
                {
                    cmbStadion.SelectedIndex = 0;
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }

        }
        private async Task LoadTakmicenja()
        {
            try
            {
                _takmicenja = await _takmicenje.GetAll<List<Model.Models.Takmicenje>>(null);

                foreach (var item in _takmicenja)
                {
                    cmbTakmicenja.Items.Add(item.nazivTakmicenja);
                }

                if (_odabranaUtakmica != null)
                {
                    int selectedTakmicenja = 0;
                    for (int i = 0; i < _takmicenja.Count; i++)
                    {
                        if (_takmicenja[i].takmicenjeId == _odabranaUtakmica.takmicenjeId)
                        {
                            selectedTakmicenja = i;
                        }
                    }
                    cmbTakmicenja.SelectedIndex = selectedTakmicenja;
                    cmbTakmicenja.Enabled = false;
                }
                else
                {
                    cmbTakmicenja.SelectedIndex = 0;
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }

        }
        private void LoadVrstaUtakmice()
        {
            cmbVrstaUtakmice.Items.Add("Domaća");
            cmbVrstaUtakmice.Items.Add("Gostujuća");
        }
        private async Task LoadKlubovi()
        {
            try
            {
                _klubovi = await _klub.GetAll<List<Model.Models.Klub>>(null);

                foreach (var item in _klubovi)
                {
                    cmbProtivnik.Items.Add(item.nazivKluba);
                }

                if (_odabranaUtakmica != null)
                {
                    int selectedProtivnik = 0;
                    for (int i = 0; i < _klubovi.Count; i++)
                    {
                        if (_klubovi[i].klubId == _odabranaUtakmica.protivnikId)
                        {
                            selectedProtivnik = i;
                        }
                    }
                    cmbProtivnik.SelectedIndex = selectedProtivnik;
                    cmbProtivnik.Enabled = false;
                }
                else
                {
                    cmbProtivnik.SelectedIndex = 0;
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }

        }
        private async Task LoadPozicije()
        {
            try
            {
                _pozicije = await _pozicija.GetAll<List<Model.Models.Pozicija>>(null);

                foreach (var item in _pozicije)
                {
                    cmbPozicije.Items.Add(item.nazivPozicije);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }

        }
        private async Task LoadIgraci()
        {
            IgracSearchObject search = new IgracSearchObject
            {
                ime = "",
                pozicijaId = -1
            };

            try
            {
                _igraci = await _igrac.GetAll<List<Model.Models.Igrac>>(search);

                foreach (var item in _igraci)
                {
                    _ostaliIgraci.Add(item);
                }
                
                foreach (var item in _igraci)
                {
                    string imePrezime = item.korisnik.ime + " " + item.korisnik.prezime;
                    cmbIgraciSastav.Items.Add(imePrezime);
                    cmbKapiten.Items.Add(imePrezime);
                }

                if (_odabranaUtakmica != null)
                {
                    int selectedKapiten = 0;
                    for (int i = 0; i < _igraci.Count; i++)
                    {
                        if (_igraci[i].igracId == _odabranaUtakmica.kapitenId)
                        {
                            selectedKapiten = i;
                        }
                    }
                    cmbKapiten.SelectedIndex = selectedKapiten;
                }
                else
                {
                    cmbKapiten.SelectedIndex = 0;
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        public async Task igracPodaci(int igracId)
        {
            try
            {
                Model.Models.Igrac _selectedIgrac;_selectedIgrac = await _igrac.GetById<Model.Models.Igrac>(igracId);
                frmDetaljiIgraca detaljiIgraca = new frmDetaljiIgraca(_selectedIgrac);
                detaljiIgraca.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmPozvaniIgracKartica pozvaniIgrac;
            int igracId = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].igracId;
            int pozicijaId = _pozicije[cmbPozicije.SelectedIndex].pozicijaId;
            string sastavUloga = "";
            if (radioBtnPrvihXI.Checked)
            {
                sastavUloga = "PRVA_POSTAVA";
            }
            else if (radioBtnKlupa.Checked)
            {
                sastavUloga = "KLUPA";
            }

            for (int i = 0; i < flowPanelPrvaPostava.Controls.Count; i++)
            {
                var control = (frmPozvaniIgracKartica)flowPanelPrvaPostava.Controls[i];
                if(control.igracId == igracId)
                {
                    flowPanelPrvaPostava.Controls.Remove(control);
                }
            };

            for (int i = 0; i < flowPanelKlupa.Controls.Count; i++)
            {
                var control = (frmPozvaniIgracKartica)flowPanelKlupa.Controls[i];
                if (control.igracId == igracId)
                {
                    flowPanelKlupa.Controls.Remove(control);
                }
            };

            if(_odabranaUtakmica != null)
            {
                pozvaniIgrac = new frmPozvaniIgracKartica(this, flowPanelPrvaPostava, flowPanelKlupa, _igraci, cmbIgraciSastav, _pozicije, cmbPozicije, radioBtnPrvihXI, radioBtnKlupa, true);
            }
            else
            {
                pozvaniIgrac = new frmPozvaniIgracKartica(this,flowPanelPrvaPostava, flowPanelKlupa, _igraci, cmbIgraciSastav, _pozicije, cmbPozicije, radioBtnPrvihXI, radioBtnKlupa, false);
            }
            pozvaniIgrac.igracId = igracId;
            pozvaniIgrac.pozicijaId = pozicijaId;
            pozvaniIgrac.igracSlika = byteToImage.ConvertByteToImage(_ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.Slika);
            pozvaniIgrac.igracPozicija = _pozicije[cmbPozicije.SelectedIndex].skracenica;
            pozvaniIgrac.igracPrezimeBrojDresa = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.ime[0] + ". " + _ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.prezime + " #" + _ostaliIgraci[cmbIgraciSastav.SelectedIndex].brojDresa;
            pozvaniIgrac.sastavUloga = sastavUloga;

            if (radioBtnPrvihXI.Checked)
            {
                flowPanelPrvaPostava.Controls.Add(pozvaniIgrac);
            }
            else if (radioBtnKlupa.Checked)
            {
                flowPanelKlupa.Controls.Add(pozvaniIgrac);
            }

            filterIgraci(TipFiltera.Dodavanje);
        }
        public void filterIgraci(TipFiltera tipFiltera, int igracId = -1)
        {
            cmbIgraciSastav.Enabled = true;
            cmbIgraciSastav.Items.Clear();

            if (tipFiltera == TipFiltera.Uredjivanje || (tipFiltera == TipFiltera.Dodavanje))
            {
                _pozvaniIgraci.Clear();
                for (int i = 0; i < flowPanelPrvaPostava.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)flowPanelPrvaPostava.Controls[i];
                    _pozvaniIgraci.Add(control.igracId);
                }

                for (int i = 0; i < flowPanelKlupa.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)flowPanelKlupa.Controls[i];
                    _pozvaniIgraci.Add(control.igracId);
                }
            }

            foreach (var item in _igraci)
            {
                if (((tipFiltera == TipFiltera.Uredjivanje) || (tipFiltera == TipFiltera.Brisanje)) && igracId != -1)
                {
                    if(item.igracId == igracId)
                    {
                        _ostaliIgraci.Add(item);
                        _pozvaniIgraci.Remove(item.igracId);
                    }
                }
                else if (_pozvaniIgraci.Contains(item.igracId))
                {
                    _ostaliIgraci.Remove(item);
                }
            }

            foreach (var item in _ostaliIgraci)
            {
                string imePrezime = item.korisnik.ime + " " + item.korisnik.prezime;
                cmbIgraciSastav.Items.Add(imePrezime);
            }
            if (_ostaliIgraci.Count != 0)
            {
                if ((tipFiltera == TipFiltera.Uredjivanje) && igracId != -1)
                {
                    cmbIgraciSastav.SelectedIndex = _ostaliIgraci.Count() - 1;
                }
                else
                {
                    cmbIgraciSastav.SelectedIndex = 0;
                }
            }
            if(tipFiltera == TipFiltera.Uredjivanje)
            {
                cmbIgraciSastav.Enabled = false;
            }
            if (_ostaliIgraci.Count() == 0)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.DODAVANJE);
                cmbIgraciSastav.Enabled = false;
                cmbPozicije.Enabled = false;
                return;
            }
            else
            {
                if(tipFiltera != TipFiltera.Uredjivanje)
                {
                    cmbIgraciSastav.Enabled = true;
                }
                cmbPozicije.Enabled = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(flowPanelPrvaPostava.Controls.Count != 3)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.BROJ_IGRACA_PRVA_POSTAVA);
                return;
            }
            if (flowPanelKlupa.Controls.Count != 1)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.BROJ_IGRACA_KLUPA);
                return;
            }

            UtakmicaInsertRequest insertRequest;
            UtakmicaUpdateRequest updateRequest;

            if (_odabranaUtakmica != null)
            {
                List<UtakmicaSastavUpdateRequest> sastav = new List<UtakmicaSastavUpdateRequest>();

                for (int i = 0; i < flowPanelPrvaPostava.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)flowPanelPrvaPostava.Controls[i];
                    UtakmicaSastavUpdateRequest prvaPostavaIgrac = new UtakmicaSastavUpdateRequest
                    {
                        igracId = control.igracId,
                        pozicijaId = control.pozicijaId,
                        uloga = "PRVA_POSTAVA"
                    };
                    sastav.Add(prvaPostavaIgrac);
                };

                for (int i = 0; i < flowPanelKlupa.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)flowPanelKlupa.Controls[i];
                    UtakmicaSastavUpdateRequest klupaIgrac = new UtakmicaSastavUpdateRequest
                    {
                        igracId = control.igracId,
                        pozicijaId = control.pozicijaId,
                        uloga = "KLUPA"
                    };
                    sastav.Add(klupaIgrac);
                };

                updateRequest = new UtakmicaUpdateRequest
                {
                    datumOdigravanja = dtpDatumOdigravanja.Value,
                    satnica = txtSatnica.Text,
                    kapitenId = _igraci[cmbKapiten.SelectedIndex].igracId,
                    napomene = txtNapomene.Text,
                    sastav = sastav
                };

                try
                {
                    await _utakmica.Update<Model.Models.Utakmica>(_odabranaUtakmica.utakmicaId, updateRequest);
                    await _prikazUtakmica.LoadUtakmice(notifikacija: TipNotifikacije.UREĐIVANJE);
                    this.Hide();
                }
                catch
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
                }
            }
            else
            {
                string tipGarniture = "", tipUtakmice = "";
                if (radioBtnDomacaGarnitura.Checked)
                {
                    tipGarniture = "Domaća";
                }
                else if (radioBtnGostujucaGarnitura.Checked)
                {
                    tipGarniture = "Gostujuća";

                }
                else if (radioBtnRezervnaGarnitura.Checked)
                {
                    tipGarniture = "Rezervna";

                }
                if (cmbVrstaUtakmice.SelectedIndex == 0)
                {
                    tipUtakmice = "Domaća";
                }
                else
                {
                    tipUtakmice = "Gostujuća";
                }
                List<UtakmicaSastavInsertRequest> sastav = new List<UtakmicaSastavInsertRequest>();

                for (int i = 0; i < flowPanelPrvaPostava.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)flowPanelPrvaPostava.Controls[i];
                    UtakmicaSastavInsertRequest prvaPostavaIgrac = new UtakmicaSastavInsertRequest
                    {
                        igracId = control.igracId,
                        pozicijaId = control.pozicijaId,
                        uloga = "PRVA_POSTAVA"
                    };
                    sastav.Add(prvaPostavaIgrac);
                };

                for (int i = 0; i < flowPanelKlupa.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)flowPanelKlupa.Controls[i];
                    UtakmicaSastavInsertRequest klupaIgrac = new UtakmicaSastavInsertRequest
                    {
                        igracId = control.igracId,
                        pozicijaId = control.pozicijaId,
                        uloga = "KLUPA"
                    };
                    sastav.Add(klupaIgrac);
                };

                insertRequest = new UtakmicaInsertRequest
                {
                    datumOdigravanja = dtpDatumOdigravanja.Value,
                    satnica = txtSatnica.Text,
                    sudija = txtSudija.Text,
                    opisUtakmice = txtOpisUtakmice.Text,
                    stadionId = _stadioni[cmbStadion.SelectedIndex].stadionId,
                    takmicenjeId = _takmicenja[cmbTakmicenja.SelectedIndex].takmicenjeId,
                    kapitenId = _igraci[cmbKapiten.SelectedIndex].igracId,
                    trenerId = 3,
                    protivnikId = _klubovi[cmbProtivnik.SelectedIndex].klubId,
                    tipGarniture = tipGarniture,
                    tipUtakmice = tipUtakmice,
                    odigrana = false,
                    napomene = txtNapomene.Text,
                    sastav = sastav
                };

                try
                {
                    await _utakmica.Insert<Model.Models.Utakmica>(insertRequest);
                    await _prikazUtakmica.LoadUtakmice(notifikacija: TipNotifikacije.DODAVANJE);
                    this.Hide();
                }
                catch
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
                }
            }
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            int igracId = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].igracId;
            await igracPodaci(igracId);
        }
    }
}
