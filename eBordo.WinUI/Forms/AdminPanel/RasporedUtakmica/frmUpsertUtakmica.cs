using eBordo.Model.Models;
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

        bool isOpisUtakmiceValidated = false, isDatumOdigravanjaValidated = false, isSatnicaValidated = false,
            isSudijaValidated = false, isProtivnikValidated = false, isVRstaUtakmiceValidated = false,
            isTakmicenjeValidated = false, isStadionValidated = false, isKapitenValidated,
            isIgracSastavValidated = false, isIgracPozicijaValidated = false;


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
                btnSaveUpdate.Show();
                this.Text = "eBordo | Uredi utakmicu";
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
                LoadPodaciUtakmica();
            }
            else
            {
                btnSave.Show();
                this.Text = "eBordo | Dodaj utakmicu";
                cmbVrstaUtakmice.SelectedIndex = 0;
                radioBtnDomacaGarnitura.Checked = true;
            }
            radioBtnPrvihXI.Checked = true;
            radioBtnKlupa.Checked = false;
            UpdateBrojEvidentiranih();
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
                frmPozvaniIgracKartica pozvaniIgrac = new frmPozvaniIgracKartica(this, flowPanelPrvaPostava, flowPanelKlupa, _igraci, cmbIgraciSastav, _pozicije, cmbPozicije, radioBtnPrvihXI, radioBtnKlupa, true, snackbar, btnSaveIgracSastav);
                pozvaniIgrac.utakmicaSastavid = item.utakmicaSastavId;
                pozvaniIgrac.igracId = item.igracId;
                pozvaniIgrac.pozicijaId = item.pozicijaId;
                pozvaniIgrac.igracSlika = byteToImage.ConvertByteToImage(item.igrac.korisnik.Slika);
                pozvaniIgrac.igracPozicija = item.pozicija.skracenica;
                pozvaniIgrac.igracPrezime = item.igrac.korisnik.ime[0] + ". " + item.igrac.korisnik.prezime;
                pozvaniIgrac.brojDresa = "#" + item.igrac.brojDresa.ToString(); ;
                if(item.uloga == "PRVA_POSTAVA")
                {
                    flowPanelPrvaPostava.Controls.Add(pozvaniIgrac);
                    pozvaniIgrac.sastavUloga = "PRVA_POSTAVA";
                }
                else
                {
                    flowPanelKlupa.Controls.Add(pozvaniIgrac);
                    pozvaniIgrac.sastavUloga = "KLUPA";
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
                cmbPozicije.SelectedIndex = 0;
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
                pozicijaId = -1,
                isAktivan = true
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
                cmbIgraciSastav.SelectedIndex = 0;
                LoadDetaljiIgraca(_igraci[0]);
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
            if(!isIgracSastavValidated || !isIgracPozicijaValidated)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            btnSaveIgracSastav.Text = "DODAJ";  
            frmPozvaniIgracKartica pozvaniIgrac;
            int igracId = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].igracId;
            int pozicijaId = _pozicije[cmbPozicije.SelectedIndex].pozicijaId;
            string sastavUloga = "";
            int utakmicaSastavId = 0;
            bool flag = false;
            bool flagDodanaPrvaPostava = false;
            bool flagDodanaKlupa = false;

            bool odabranSastav = false;
            bool vecBila = false;

            if (flowPanelPrvaPostava.Controls.Count == 11 && flowPanelKlupa.Controls.Count == 9)
            {
                odabranSastav = true;
                vecBila = true;
            }
            if (odabranSastav)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.SASTAV_ODABRAN);
                return;
            }

            if (radioBtnPrvihXI.Checked)
            {
                if(flowPanelPrvaPostava.Controls.Count == 11 && cmbIgraciSastav.Enabled)
                {
                    flagDodanaPrvaPostava = true;
                }
                sastavUloga = "PRVA_POSTAVA";
            }
            else if (radioBtnKlupa.Checked)
            {
                if (flowPanelKlupa.Controls.Count == 9 && cmbIgraciSastav.Enabled)
                {
                    flagDodanaKlupa = true;
                }
                sastavUloga = "KLUPA";
            }

            if (flagDodanaPrvaPostava)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.POPUNJENA_PRVA_POSTAVA);
                return;
            }
            if (flagDodanaKlupa)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.POPUNJENA_PRVA_POSTAVA);
                return;
            }

            for (int i = 0; i < flowPanelPrvaPostava.Controls.Count; i++)
            {
                var control = (frmPozvaniIgracKartica)flowPanelPrvaPostava.Controls[i];

                if(control.igracId == igracId)
                {
                    if (cmbIgraciSastav.Enabled)
                    {
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.IGRAC_DODAN_U_SASTAV);
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        utakmicaSastavId = control.utakmicaSastavid;
                        flowPanelPrvaPostava.Controls.Remove(control);
                        foreach (var item in flowPanelKlupa.Controls)
                        {
                            var controlKlupa = (frmPozvaniIgracKartica)item;
                            if (controlKlupa.igracId == igracId)
                            {
                                flowPanelKlupa.Controls.Remove(controlKlupa);
                            }
                        }
                    }
                }
            };

            for (int i = 0; i < flowPanelKlupa.Controls.Count; i++)
            {
                var control = (frmPozvaniIgracKartica)flowPanelKlupa.Controls[i];
                if (control.igracId == igracId)
                {
                    if (cmbIgraciSastav.Enabled)
                    {
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.IGRAC_DODAN_U_SASTAV);
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        utakmicaSastavId = control.utakmicaSastavid;
                        flowPanelKlupa.Controls.Remove(control);
                        foreach (var item in flowPanelPrvaPostava.Controls)
                        {
                            var controlKlupa = (frmPozvaniIgracKartica)item;
                            if (controlKlupa.igracId == igracId)
                            {
                                flowPanelPrvaPostava.Controls.Remove(controlKlupa);
                            }
                        }
                    }
                }
            };

            if (!flag)
            {
                if (_odabranaUtakmica != null)
                {
                    pozvaniIgrac = new frmPozvaniIgracKartica(this, flowPanelPrvaPostava, flowPanelKlupa, _igraci, cmbIgraciSastav, _pozicije, cmbPozicije, radioBtnPrvihXI, radioBtnKlupa, true, snackbar, btnSaveIgracSastav);
                }
                else
                {
                    pozvaniIgrac = new frmPozvaniIgracKartica(this, flowPanelPrvaPostava, flowPanelKlupa, _igraci, cmbIgraciSastav, _pozicije, cmbPozicije, radioBtnPrvihXI, radioBtnKlupa, false, snackbar, btnSaveIgracSastav);
                }
                pozvaniIgrac.utakmicaSastavid = utakmicaSastavId;
                pozvaniIgrac.igracId = igracId;
                pozvaniIgrac.pozicijaId = pozicijaId;
                pozvaniIgrac.igracSlika = byteToImage.ConvertByteToImage(_ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.Slika);
                pozvaniIgrac.igracPozicija = _pozicije[cmbPozicije.SelectedIndex].skracenica;
                pozvaniIgrac.igracPrezime = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.ime[0] + ". " + _ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.prezime;
                pozvaniIgrac.brojDresa = " #" + _ostaliIgraci[cmbIgraciSastav.SelectedIndex].brojDresa;
                pozvaniIgrac.sastavUloga = sastavUloga;

                if (radioBtnPrvihXI.Checked)
                {
                    flowPanelPrvaPostava.Controls.Add(pozvaniIgrac);
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.IGRAC_USPJESNO_DODAN_U_SASTAV);
                }
                else if (radioBtnKlupa.Checked)
                {
                    flowPanelKlupa.Controls.Add(pozvaniIgrac);
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.IGRAC_USPJESNO_DODAN_U_SASTAV);
                }
                cmbIgraciSastav.Enabled = true;

                //odabranSastav = false;

                if (flowPanelPrvaPostava.Controls.Count == 11 && flowPanelKlupa.Controls.Count == 9 && cmbIgraciSastav.Enabled && !vecBila)
                {
                    odabranSastav = true;
                }
                if (odabranSastav)
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.SASTAV_ODABRAN);
                }
            }
            UpdateBrojEvidentiranih();
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            int igracId = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].igracId;
            await igracPodaci(igracId);
        }

        private void cmbIgraciSastav_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIgracSastavValidated = Validacija.ValidirajDropDown(cmbIgraciSastav, "Igrač", txtIgracSastavValidator, pictureIgracSastavSlikaValidator);
            Model.Models.Igrac igrac = _ostaliIgraci[cmbIgraciSastav.SelectedIndex];
            LoadDetaljiIgraca(igrac);
        }
        public void LoadDetaljiIgraca(Model.Models.Igrac igrac)
        {
            txtBrojDresa.Text = "#" + igrac.brojDresa.ToString();
            pictureSlikaIgraca.BackgroundImage = byteToImage.ConvertByteToImage(igrac.slikaPanel);
            pictureSlikaIgraca.BackgroundImageLayout = ImageLayout.Zoom;
            txtPrezime.Text = (igrac.korisnik.ime[0] + ". " + igrac.korisnik.prezime).ToUpper();
            igracOcjena.Value = (int)igrac.igracStatistika.prosjecnaOcjena;
            ratingKontrolaLopte.Value = (int)igrac.igracSkills.kontrolaLopte;
            ratingDriblanje.Value = (int)igrac.igracSkills.driblanje;
            ratingDodavanje.Value = (int)igrac.igracSkills.dodavanje;
            ratingKretanje.Value = (int)igrac.igracSkills.kretanje;
            ratingBrzina.Value = (int)igrac.igracSkills.brzina;
            ratingSut.Value = (int)igrac.igracSkills.sut;
            ratingSnaga.Value = (int)igrac.igracSkills.sut;
            ratingMarkiranje.Value = (int)igrac.igracSkills.sut;
            ratingKlizeciStart.Value = (int)igrac.igracSkills.klizeciStart;
            ratingSkok.Value = (int)igrac.igracSkills.skok;
            ratingOdbrana.Value = (int)igrac.igracSkills.odbrana;
            txtNastupi.Text = igrac.igracStatistika.brojNastupa.ToString();
            txtMinute.Text = (igrac.igracStatistika.brojNastupa * 90).ToString();
            txtGolovi.Text = igrac.igracStatistika.golovi.ToString();
            txtAsistencije.Text = igrac.igracStatistika.asistencije.ToString();
            txtZutiKartoni.Text = igrac.igracStatistika.zutiKartoni.ToString();
            txtCrveniKartoni.Text = igrac.igracStatistika.crveniKartoni.ToString();
            txtPozicija.Text = igrac.pozicija.skracenica;
        }
        public void UpdateBrojEvidentiranih()
        {
            txtBrojIgracaPrvaPostava.Text = flowPanelPrvaPostava.Controls.Count.ToString() + " od 11";
            txtBrojIgracaKlupa.Text = flowPanelKlupa.Controls.Count.ToString() + " od 9";

            if(flowPanelPrvaPostava.Controls.Count >= 5)
            {
                pictureValidacijaPrvaPOstavaka.BackgroundImage = Properties.Resources.eBordo_success_notification;
                pictureValidacijaPrvaPOstavaka.BackgroundImageLayout = ImageLayout.Zoom;
                txtPrvaPostavaValidator.Text = "Odabran minimalan broj";
            }
            else
            {
                pictureValidacijaPrvaPOstavaka.BackgroundImage = Properties.Resources.eBordo_required3;
                pictureValidacijaPrvaPOstavaka.BackgroundImageLayout = ImageLayout.Zoom;
                txtPrvaPostavaValidator.Text = "Minimalno 5 igrača";
            }

            if (flowPanelKlupa.Controls.Count >= 4)
            {
                pictureKlupaValidator.BackgroundImage = Properties.Resources.eBordo_success_notification;
                pictureKlupaValidator.BackgroundImageLayout = ImageLayout.Zoom;
                txtKlupaValidator.Text = "Odabran minimalan broj";
            }
            else
            {
                pictureKlupaValidator.BackgroundImage = Properties.Resources.eBordo_required3;
                pictureKlupaValidator.BackgroundImageLayout = ImageLayout.Zoom;
                txtKlupaValidator.Text = "Minimalno 5 igrača";
            }

            if (flowPanelPrvaPostava.Controls.Count == 11)
            {
                txtPrvaPostavaValidator.Text = "Odabrana prva postava";
            }
            if (flowPanelKlupa.Controls.Count == 9)
            {
                txtKlupaValidator.Text = "Odabrana klupa";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ratingSut_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void ratingBrzina_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void ratingKretanje_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void ratingDodavanje_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void ratingDriblanje_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void ratingKontrolaLopte_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            cmbIgraciSastav.Enabled = true;
            cmbIgraciSastav.SelectedIndex = 0;
            cmbPozicije.SelectedIndex = 0;
            radioBtnPrvihXI.Checked = true;
            radioBtnKlupa.Checked = false;
            btnSaveIgracSastav.Text = "DODAJ";
        }

        private async void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            try
            {
                var igrac = await _igrac.GetById<Model.Models.Igrac>(_ostaliIgraci[cmbIgraciSastav.SelectedIndex].igracId);
                frmDetaljiIgraca getById = new frmDetaljiIgraca(igrac);
                getById.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if (!isOpisUtakmiceValidated || !isDatumOdigravanjaValidated || !isSatnicaValidated ||
                !isSudijaValidated || flowPanelPrvaPostava.Controls.Count < 5 || flowPanelKlupa.Controls.Count < 4 ||
                !isProtivnikValidated || !isVRstaUtakmiceValidated || !isTakmicenjeValidated || !isStadionValidated ||
                !isKapitenValidated)

            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
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

            UtakmicaInsertRequest insertRequest = new UtakmicaInsertRequest
            {
                datumOdigravanja = dtpDatumOdigravanja.Value,
                satnica = txtSatnica.Text,
                sudija = txtSudija.Text,
                opisUtakmice = txtOpisUtakmice.Text,
                stadionId = _stadioni[cmbStadion.SelectedIndex].stadionId,
                takmicenjeId = _takmicenja[cmbTakmicenja.SelectedIndex].takmicenjeId,
                kapitenId = _igraci[cmbKapiten.SelectedIndex].igracId,
                trenerId = 1,
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
            List<UtakmicaSastavUpdateRequest> sastav = new List<UtakmicaSastavUpdateRequest>();

            for (int i = 0; i < flowPanelPrvaPostava.Controls.Count; i++)
            {
                var control = (frmPozvaniIgracKartica)flowPanelPrvaPostava.Controls[i];
                UtakmicaSastavUpdateRequest prvaPostavaIgrac = new UtakmicaSastavUpdateRequest
                {
                    utakmicaSastavid = control.utakmicaSastavid,
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
                    utakmicaSastavid = control.utakmicaSastavid,
                    igracId = control.igracId,
                    pozicijaId = control.pozicijaId,
                    uloga = "KLUPA"
                };
                sastav.Add(klupaIgrac);
            };

            UtakmicaUpdateRequest updateRequest = new UtakmicaUpdateRequest
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
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, tipNotifikacije);
            }
        }

        private void txtOpisUtakmice_TextChanged(object sender, EventArgs e)
        {
            isOpisUtakmiceValidated = Validacija.ValidirajInputString(txtOpisUtakmice, txtOpisUtakmiceValidator, Field.OPIS_UTAKMICE);
        }

        private void cmbPozicije_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIgracPozicijaValidated = Validacija.ValidirajDropDown(cmbPozicije, "Pozicija", txtIgracPozicijaValidator, pictureIgracSastavPozicijaSlikaValidator);
        }

        private void cmbProtivnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            isProtivnikValidated = Validacija.ValidirajDropDown(cmbProtivnik, "Protivnik", txtProtivnikValidator, pictureProtivnikSlikaValidator);

        }

        private void cmbVrstaUtakmice_SelectedIndexChanged(object sender, EventArgs e)
        {
            isVRstaUtakmiceValidated = Validacija.ValidirajDropDown(cmbVrstaUtakmice, "Vrsta utakmice", txtVrstaUtakmiceValidator, pictureVrstaUtakmiceSlikaValidator);

        }

        private void cmbTakmicenja_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTakmicenjeValidated = Validacija.ValidirajDropDown(cmbTakmicenja, "Takmičenje", txtTakmicenjeValidator, pictureTakmicenjeSlikaValidator);

        }

        private void cmbStadion_SelectedIndexChanged(object sender, EventArgs e)
        {
            isStadionValidated = Validacija.ValidirajDropDown(cmbStadion, "Stadion", txtStadionValidator, pictureStadionSlikaValidator);

        }

        private void cmbKapiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            isKapitenValidated = Validacija.ValidirajDropDown(cmbKapiten, "Kapiten", txtKapitenValidator, pictureKapitenSlikaValidator);

        }

        private void txtSudija_TextChanged(object sender, EventArgs e)
        {
            isSudijaValidated = Validacija.ValidirajInputString(txtSudija, txtSudijaValidator, Field.SUDIJA);
        }

        private void txtSatnica_TextChanged(object sender, EventArgs e)
        {
            isSatnicaValidated = Validacija.ValidirajInputString(txtSatnica, txtSatnicaValidator, Field.SATNICA);
        }

        private void dtpDatumOdigravanja_ValueChanged(object sender, EventArgs e)
        {
            isDatumOdigravanjaValidated = Validacija.ValidirajDatum(dtpDatumOdigravanja.Value,txtDatumOdigravanjaValidator, pictureDatumOdigravanjaValidator, Field.DATUM_ODIGRAVANJA);
        }
    }
}
