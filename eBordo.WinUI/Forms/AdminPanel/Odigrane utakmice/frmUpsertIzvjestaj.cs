using eBordo.Model.Models;
using eBordo.Model.Requests.Izvještaj;
using eBordo.Model.Requests.UtakmicaIzmjena;
using eBordo.Model.Requests.UtakmicaNastup;
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

namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    public partial class frmUpsertIzvjestaj : Form
    {
        private readonly ApiService.ApiService _utakmicaApi = new ApiService.ApiService("Utakmica");
        private readonly ApiService.ApiService _utakmicaSastavApi = new ApiService.ApiService("UtakmicaSastav");
        private readonly ApiService.ApiService _izvjestajApi = new ApiService.ApiService("Izvještaj");

        private byte[] utakmicaSlika{ get; set; }
        ByteToImage byteToImage = new ByteToImage();
        frmPrikazOdigranihUtakmica _prikazUtakmica;

        private int _utakmicaId;
        private Utakmica _utakmica = new Utakmica();
        private Izvještaj _izvještaj = new Izvještaj();
        private List<Model.Models.UtakmicaSastav> _utakmicaSastav = new List<Model.Models.UtakmicaSastav>();
        private List<Model.Models.Igrac> _igraciPrvaPostava = new List<Model.Models.Igrac>();
        private List<Model.Models.Igrac> _igraciKlupa = new List<Model.Models.Igrac>();
        private List<string> _izmjenaRazlog = new List<string>();

        private List<Model.Models.Igrac> _igraci = new List<Model.Models.Igrac>();
        private List<Model.Models.Igrac> _ostaliIgraci = new List<Model.Models.Igrac>();
        private List<int> _pozvaniIgraci = new List<int>();

        bool isMinuteValidated = false, isGoloviValidated = false, isAsistencijeValidated = false,
            isZutKartoniValidated = false, isCrveniKartoniValidated = false, isIgracValidated = false,
            isIgracUtakmiceValidated = false,isIgracOUTValidated = false,isIgracINValidated = false,isRazlogIzmjeneVAlidated;


        bool isMinutaIzmjenaValidirana = false;

        bool isSlikaUtakmiceValidated = false, isGoloviDomacinValidated = false, isGoloviGostValidated = false;

        public frmUpsertIzvjestaj(int utakmicaId, frmPrikazOdigranihUtakmica prikazUtakmica, Izvještaj izvještaj)
        {
            InitializeComponent();
            _utakmicaId = utakmicaId;
            _prikazUtakmica = prikazUtakmica;
            _izvještaj = izvještaj;
        }
       
        private async void frmUpsertIzvjestaj_Load(object sender, EventArgs e)
        {
            await LoadIgraci();
            await UcitajUtakmicu();
            LoadRazlogIzmjene();
            if (_izvještaj != null)
            {
                btnSaveUpdate.Show();
                this.Text = "eBordo | Uredi izvještaj";
                txtGoloviDomacin.Enabled = false;
                txtGoloviGost.Enabled = false;
                radioBtnKisa.Enabled = false;
                radioBtnOblacno.Enabled = false;
                radioBtnSunce.Enabled = false;
                if (_izvještaj.vrijeme == Vrijeme.KIŠA)
                {
                    radioBtnKisa.Checked = true;
                }
                else if (_izvještaj.vrijeme == Vrijeme.OBLAČNO)
                {
                    radioBtnOblacno.Checked = true;
                }
                else if (_izvještaj.vrijeme == Vrijeme.SUNCE)
                {
                    radioBtnSunce.Checked = true;
                }
                cmbIgracUtakmice.Enabled = false;
                pictureSlikaUtakmicaValidator.BackgroundImage = Properties.Resources.eBordo_success_notification;
                pictureSlikaUtakmicaValidator.BackgroundImageLayout = ImageLayout.Stretch;
                isSlikaUtakmiceValidated = true;
                btnUcitajPanelPhoto.Enabled = false;
                pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(204, 204, 204);
                LoadPodaci();
            }
            else
            {
                btnSave.Show();
                this.Text = "eBordo | Dodaj izvještaj";
                txtGoloviDomacinhUredjivanje.Visible = false;
                txtGoloviGostijuUredjivanje.Visible = false;
                pictureRezultat.Visible = false;
                radioBtnSunce.Checked = true;
                cmbIgracUtakmice.SelectedIndex = 1;
            }
            txtIzmjenaMinutaValidator.Hide();
            LoadDetaljiIgraca(_ostaliIgraci[0]);
            UpdateBrojEvidentiranih();
            UpdateBrojEvidentiranihIzmjena();
        }
        private void LoadPodaci()
        {
            pictureSlikaUtakmice.BackgroundImage = byteToImage.ConvertByteToImage(_izvještaj.slikaSaUtakmice);
            pictureSlikaUtakmice.BackgroundImageLayout = ImageLayout.Zoom;
            if (_izvještaj != null)
            {
                int selectedStadion = 0;
                for (int i = 0; i < _igraci.Count; i++)
                {
                    if (_igraci[i].igracId == _izvještaj.igracUtakmicaID)
                    {
                        selectedStadion = i;
                    }
                }
                cmbIgracUtakmice.SelectedIndex = selectedStadion;
                cmbIgracUtakmice.Enabled = false;
            }
            txtZapisnik.Text = _izvještaj.zapisnik;
            if(_izvještaj.izmjene.Count() != 0)
            {
                foreach (var item in _izvještaj.izmjene)
                {
                    frmIzmjenaKartica izmjena = new frmIzmjenaKartica(flowPanelIzmjene, this, _igraciPrvaPostava, _igraciKlupa, cmbIgracOut, cmbIgracIn, true);
                    izmjena.utakmicaIzmjenaId = item.utakmicaIzmjenaID;
                    izmjena.igracOutId = item.igracOutId;
                    izmjena.igracInId = item.igracInId;
                    izmjena.igracOutSlika = byteToImage.ConvertByteToImage(item.igracOut.korisnik.Slika);
                    izmjena.igracInSlika = byteToImage.ConvertByteToImage(item.igracIn.korisnik.Slika);
                    izmjena.igracOutPrezime = item.igracOut.korisnik.ime[0] + ". " + item.igracOut.korisnik.prezime;
                    izmjena.igracInPrezime = item.igracIn.korisnik.ime[0] + ". " + item.igracIn.korisnik.prezime;
                    izmjena.igracOutPozicija = item.igracOut.pozicija.skracenica;
                    izmjena.igracInPozicija = item.igracIn.pozicija.skracenica;
                    izmjena.igracOutBroj = "#" + item.igracOut.brojDresa.ToString();
                    izmjena.igracInBroj = "#" + item.igracIn.brojDresa.ToString();
                    izmjena.minuta = item.minuta;
                    izmjena.razlogIzmjene = item.izmjenaRazlog.ToString();
                    flowPanelIzmjene.Controls.Add(izmjena);
                }
            }
            if(_izvještaj.nastupi.Count() > 0)
            {
                frmIgracNastupKartica nastup;
                foreach (var item in _izvještaj.nastupi)
                {
                    nastup = new frmIgracNastupKartica(this, flowPanelOcjene, _igraci, true);
                    nastup.utakmicaNastupId = item.utakmicaNastupId;
                    nastup.igracId = item.igracId;
                    nastup.igracSlika = byteToImage.ConvertByteToImage(item.igrac.korisnik.Slika);
                    nastup.igracImePrezime = item.igrac.korisnik.ime[0] + ". " + item.igrac.korisnik.prezime;
                    nastup.brojDresa = "#" + item.igrac.brojDresa.ToString();
                    nastup.igracPozicija = item.igrac.pozicija.skracenica;
                    nastup.igracMinute = item.minute;
                    nastup.igracGolovi = item.golovi;
                    nastup.igracAsistencije = item.asistencije;
                    nastup.igracZutiKartoni = item.zutiKartoni;
                    nastup.igracCrveniKartoni = item.crveniKartoni;
                    nastup.ocjenaRating = item.ocjena;
                    nastup.kontrolaLopte = item.kontrolaLopte;
                    nastup.driblanje = item.driblanje;
                    nastup.dodavanje = item.dodavanje;
                    nastup.kretanje = item.kretanje;
                    nastup.brzina = item.brzina;
                    nastup.sut = item.sut;
                    nastup.snaga = item.snaga;
                    nastup.markiranje = item.markiranje;
                    nastup.klizeciStart = item.klizeciStart;
                    nastup.skok = item.skok;
                    nastup.odbrana = item.odbrana;
                    nastup.igracKomentar = item.komentar;

                    flowPanelOcjene.Controls.Add(nastup);
                }
                txtGoloviDomacin.Visible = false;
                txtGoloviGost.Visible = false;
                if (_izvještaj.utakmica.vrstaUtakmice == "Domaća")
                {
                    txtGoloviDomacinhUredjivanje.Text = _izvještaj.goloviSarajevo.ToString();
                    txtGoloviGostijuUredjivanje.Text = _izvještaj.goloviProtivnik.ToString();
                }
                else if (_izvještaj.utakmica.vrstaUtakmice == "Gostujuća")
                {
                    txtGoloviGostijuUredjivanje.Text = _izvještaj.goloviSarajevo.ToString();
                    txtGoloviDomacinhUredjivanje.Text = _izvještaj.goloviProtivnik.ToString();
                }
                if (_izvještaj.goloviSarajevo > _izvještaj.goloviProtivnik)
                {
                    pictureRezultat.BackgroundImage = Properties.Resources.eBordo_success_notification;
                    pictureRezultat.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else if (_izvještaj.goloviSarajevo < _izvještaj.goloviProtivnik)
                {
                    pictureRezultat.BackgroundImage = Properties.Resources.eBordo_error_notification;
                    pictureRezultat.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else if (_izvještaj.goloviSarajevo == _izvještaj.goloviProtivnik)
                {
                    pictureRezultat.BackgroundImage = Properties.Resources.eBordo_nerjeseno;
                    pictureRezultat.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }
        private void LoadRazlogIzmjene()
        {
            cmbRazlogIzmjena.Items.Add("Forma");
            _izmjenaRazlog.Add("FORMA");
            cmbRazlogIzmjena.Items.Add("Taktički");
            _izmjenaRazlog.Add("TAKTIČKI");
            cmbRazlogIzmjena.Items.Add("Povreda");
            _izmjenaRazlog.Add("POVREDA");
            cmbRazlogIzmjena.SelectedIndex = 0;
        }
        private async Task UcitajUtakmicu()
        {
            _utakmica = await _utakmicaApi.GetById<Model.Models.Utakmica>(_utakmicaId);
            if (_utakmica.vrstaUtakmice == "Domaća")
            {
                grbDomacin.BackgroundImage = Properties.Resources.grbSarajevo;
                grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
                lblDomacin.Text = "FK SARAJEVO";
                grbGost.BackgroundImage = byteToImage.ConvertByteToImage(_utakmica.protivnik.grb);
                grbGost.BackgroundImageLayout = ImageLayout.Zoom;
                lblGost.Text = _utakmica.protivnik.nazivKluba.ToUpper();
                pictureGostujucaDomaca.BackgroundImage = Properties.Resources.home_bordo;
            }
            else if (_utakmica.vrstaUtakmice == "Gostujuća")
            {
                grbDomacin.BackgroundImage = byteToImage.ConvertByteToImage(_utakmica.protivnik.grb);
                grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
                lblDomacin.Text = _utakmica.protivnik.nazivKluba.ToUpper();
                grbGost.BackgroundImage = Properties.Resources.grbSarajevo;
                grbGost.BackgroundImageLayout = ImageLayout.Zoom;
                lblGost.Text = "FK SARAJEVO";
                pictureGostujucaDomaca.BackgroundImage = Properties.Resources.away_bordo;
            }
            lblOpisUtakmice.Text = _utakmica.opisUtakmice.ToUpper();
            lblStadion.Text = _utakmica.stadion.nazivStadiona.ToUpper();
            lblDatum.Text = _utakmica.datumOdigravanja.ToString("dd.MM.yyyy");
            lblSatnica.Text = _utakmica.satnica + "h";
            if (_utakmica.tipGarniture == "Domaća")
            {
                pictureDres.BackgroundImage = Properties.Resources.domaci;
            }
            else if (_utakmica.tipGarniture == "Gostujuća")
            {
                pictureDres.BackgroundImage = Properties.Resources.gostujuci;
            }
            else if (_utakmica.tipGarniture == "Rezervna")
            {
                pictureDres.BackgroundImage = Properties.Resources.rezervni;
            }
            pictureTakmicenje.BackgroundImage = byteToImage.ConvertByteToImage(_utakmica.takmicenje.logo);
            pictureTakmicenje.BackgroundImageLayout = ImageLayout.Zoom;
            if (_utakmica.datumOdigravanja.Date == DateTime.Now.Date)
            {
                txtBrojDana.Text = "DANAS";
            }
            else if (_utakmica.datumOdigravanja.Date < DateTime.Now.Date)
            {
                txtBrojDana.Text = "PRIJE " + (DateTime.Now.Date - _utakmica.datumOdigravanja.Date.Date).TotalDays + " DANA";
            }
            else
            {
                txtBrojDana.Text = "ZA " + (_utakmica.datumOdigravanja.Date.Date - DateTime.Now.Date).TotalDays + " DANA";
            }
        }
        private async Task LoadIgraci()
        {
            try
            {
                UtakmicaSastavSearchObject search = new UtakmicaSastavSearchObject
                {
                    utakmicaId = _utakmicaId
                };

                _utakmicaSastav = await _utakmicaSastavApi.GetAll<List<Model.Models.UtakmicaSastav>>(search);

                foreach (var item in _utakmicaSastav)
                {
                    if (item.uloga == "PRVA_POSTAVA")
                    {
                        cmbIgracOut.Items.Add(item.igrac.korisnik.ime[0] + "." + item.igrac.korisnik.prezime);
                        cmbIgraciSastav.Items.Add(item.igrac.korisnik.ime[0] + "." + item.igrac.korisnik.prezime);
                        cmbIgracUtakmice.Items.Add(item.igrac.korisnik.ime[0] + "." + item.igrac.korisnik.prezime);
                        _igraciPrvaPostava.Add(item.igrac);
                        _igraci.Add(item.igrac);
                        _ostaliIgraci.Add(item.igrac);
                    }
                    else if (item.uloga == "KLUPA")
                    {
                        cmbIgracIn.Items.Add(item.igrac.korisnik.ime[0] + "." + item.igrac.korisnik.prezime);
                        cmbIgraciSastav.Items.Add(item.igrac.korisnik.ime[0] + "." + item.igrac.korisnik.prezime);
                        cmbIgracUtakmice.Items.Add(item.igrac.korisnik.ime[0] + "." + item.igrac.korisnik.prezime);
                        _igraciKlupa.Add(item.igrac);
                        _igraci.Add(item.igrac);
                        _ostaliIgraci.Add(item.igrac);
                    }
                }
                cmbIgracOut.SelectedIndex = 0;
                cmbIgracIn.SelectedIndex = 0;
                cmbIgraciSastav.SelectedIndex = 0;
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        public void filterIzmjene(int igracOutId, int igracInId)
        {
            string minute = "";
            int razlogIzmjene = 0;
            for (int i = 0; i < flowPanelIzmjene.Controls.Count; i++)
            {
                var control = (frmIzmjenaKartica)flowPanelIzmjene.Controls[i];
                if (control.igracOutId == igracOutId && control.igracInId == igracInId)
                {
                    igracOutId = control.igracOutId;
                    igracInId = control.igracInId;
                    minute = control.minuta.ToString();
                    razlogIzmjene = _izmjenaRazlog.IndexOf(control.razlogIzmjene);
                }
            }
            int igracOutIndex = 0;
            int igracInIndex = 0;
            for (int i = 0; i < _igraciPrvaPostava.Count(); i++)
            {
                if (_igraciPrvaPostava[i].igracId == igracOutId)
                {
                    igracOutIndex = i;
                }
            }
            for (int i = 0; i < _igraciKlupa.Count(); i++)
            {
                if (_igraciKlupa[i].igracId == igracInId)
                {
                    igracInIndex = i;
                }
            }
            cmbIgracOut.SelectedIndex = igracOutIndex;
            cmbIgracIn.SelectedIndex = igracInIndex;
            txtIzmjenaMinuta.Text = minute;
            cmbRazlogIzmjena.SelectedIndex = razlogIzmjene;
            cmbIgracOut.Enabled = false;
            cmbIgracIn.Enabled = false;
        }
        public void filterIgraci(TipFiltera tipFiltera, int igracId = -1)
        {
            cmbIgraciSastav.Enabled = true;           

            if (tipFiltera == TipFiltera.Uredjivanje)
            {
                for (int i = 0; i < flowPanelOcjene.Controls.Count; i++)
                {
                    var control = (frmIgracNastupKartica)flowPanelOcjene.Controls[i];
                    if (control.igracId == igracId)
                    {
                        cmbIgraciSastav.SelectedIndex = _igraci.IndexOf(_igraci.Where(s => s.igracId == control.igracId).SingleOrDefault());
                        txtMinute.Text = control.igracMinute.ToString();
                        txtGolovi.Text = control.igracGolovi.ToString();
                        txtAsistencije.Text = control.igracAsistencije.ToString();
                        txtZutiKartoni.Text = control.igracZutiKartoni.ToString();
                        txtCrveniKartoni.Text = control.igracCrveniKartoni.ToString();
                        ratingOcjenaNastup.Value = control.ocjenaRating;
                        ratingKontrolaLopte.Value = control.kontrolaLopte;
                        ratingDriblanje.Value = control.driblanje;
                        ratingDodavanje.Value = control.dodavanje;
                        ratingKretanje.Value = control.kretanje;
                        ratingBrzina.Value = control.brzina;
                        ratingSut.Value = control.sut;
                        ratingSnaga.Value = control.snaga;
                        ratingMarkiranje.Value = control.markiranje;
                        ratingKlizeciStart.Value = control.klizeciStart;
                        ratingSkok.Value = control.skok;
                        ratingOdbrana.Value = control.odbrana;
                        ratingOcjenaNastup.Value = control.ocjenaRating;
                        txtKomentar.Text = control.igracKomentar;
                        cmbIgraciSastav.Enabled = false;
                    }
                }
            }
            if (_ostaliIgraci.Count() == 0)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.DODAVANJE); 
                return;
            }
            else
            {
                if (tipFiltera != TipFiltera.Uredjivanje)
                {
                    cmbIgraciSastav.Enabled = true;
                }
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            cmbIgracOut.Enabled = true;
            cmbIgracIn.Enabled = true;
            txtIzmjenaMinuta.Clear();
            cmbRazlogIzmjena.SelectedIndex = 0;
        }
        private bool ValidirajOcjenu()
        {
            bool isUspjesno = true;
            if (!isMinuteValidated || !isGoloviValidated || !isAsistencijeValidated ||
                !isZutKartoniValidated || !isCrveniKartoniValidated || !isIgracValidated)
            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private bool ValidirajIzmjneu()
        {
            bool isUspjesno = true;
            if (!isMinutaIzmjenaValidirana || !isIgracOUTValidated || !isIgracINValidated || !isRazlogIzmjeneVAlidated)
            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if(_izvještaj != null)
            {
                if (!isSlikaUtakmiceValidated || !isIgracUtakmiceValidated)
                {
                    isUspjesno = false;
                }
                else
                {
                    isUspjesno = true;
                }
            }
            else
            {
                if (!isSlikaUtakmiceValidated || !isGoloviGostValidated || !isGoloviDomacinValidated || !isIgracUtakmiceValidated)
                {
                    isUspjesno = false;
                }
                else
                {
                    isUspjesno = true;
                }
            }

            return isUspjesno;
        }
        private void btnSaveIgracSastav_Click(object sender, EventArgs e)
        {
            if (!ValidirajOcjenu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            frmIgracNastupKartica nastup;
            int igracId = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].igracId;
            int nastupId = 0;
            bool flag = false;
            for (int i = 0; i < flowPanelOcjene.Controls.Count; i++)
            {
                var control = (frmIgracNastupKartica)flowPanelOcjene.Controls[i];
                if (control.igracId == igracId)
                {
                    if (cmbIgraciSastav.Enabled)
                    {
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.IGRAC_OCJENJEN);
                        flag = true;
                    }
                    else
                    {
                        nastupId = control.utakmicaNastupId;
                        flowPanelOcjene.Controls.Remove(control);
                    }
                }
            };
            if (!flag)
            {
                nastup = new frmIgracNastupKartica(this, flowPanelOcjene, _igraci, false);
                nastup.igracId = igracId;
                nastup.igracSlika = byteToImage.ConvertByteToImage(_ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.Slika);
                nastup.igracImePrezime = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.ime[0] + ". " + _ostaliIgraci[cmbIgraciSastav.SelectedIndex].korisnik.prezime;
                nastup.brojDresa = "#" + _ostaliIgraci[cmbIgraciSastav.SelectedIndex].brojDresa;
                nastup.igracPozicija = _ostaliIgraci[cmbIgraciSastav.SelectedIndex].pozicija.skracenica;
                nastup.igracMinute = int.Parse(txtMinute.Text);
                nastup.igracGolovi = int.Parse(txtGolovi.Text);
                nastup.igracAsistencije = int.Parse(txtAsistencije.Text);
                nastup.igracZutiKartoni = int.Parse(txtZutiKartoni.Text);
                nastup.igracCrveniKartoni = int.Parse(txtCrveniKartoni.Text);
                nastup.kontrolaLopte = ratingKontrolaLopte.Value;
                nastup.driblanje = ratingDriblanje.Value;
                nastup.dodavanje = ratingDodavanje.Value;
                nastup.kretanje = ratingKretanje.Value;
                nastup.brzina = ratingBrzina.Value;
                nastup.sut = ratingSut.Value;
                nastup.snaga = ratingSnaga.Value;
                nastup.markiranje = ratingMarkiranje.Value;
                nastup.klizeciStart = ratingKlizeciStart.Value;
                nastup.skok = ratingSkok.Value;
                nastup.odbrana = ratingOdbrana.Value;
                nastup.ocjenaRating = ratingOcjenaNastup.Value;
                nastup.utakmicaNastupId = nastupId;
                nastup.igracKomentar = txtKomentar.Text;
                flowPanelOcjene.Controls.Add(nastup);
                if (cmbIgraciSastav.Enabled)
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.IGRAC_USPJESNO_OCJENJEN);
                }
                else
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.UREĐIVANJE);
                }
                filterIgraci(TipFiltera.Dodavanje);
                cmbIgraciSastav.SelectedIndex = 0;
                txtMinute.Clear();
                txtGolovi.Clear();
                txtAsistencije.Clear();
                txtZutiKartoni.Clear();
                txtCrveniKartoni.Clear();
                ratingOcjenaNastup.Value = 1;
                ratingKontrolaLopte.Value = 1;
                ratingDriblanje.Value = 1;
                ratingDodavanje.Value = 1;
                ratingKretanje.Value = 1;
                ratingBrzina.Value = 1;
                ratingSut.Value = 1;
                ratingSnaga.Value = 1;
                ratingMarkiranje.Value = 1;
                ratingKlizeciStart.Value = 1;
                ratingSkok.Value = 1;
                ratingOdbrana.Value = 1;
                ratingOcjenaNastup.Value = 1;
                txtKomentar.Clear();
                UpdateBrojEvidentiranih();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            cmbIgraciSastav.SelectedIndex = 0;
            cmbIgraciSastav.Enabled = true;
            txtMinute.Clear();
            txtGolovi.Clear();
            txtAsistencije.Clear();
            txtZutiKartoni.Clear();
            txtCrveniKartoni.Clear();
            ratingOcjenaNastup.Value = 1;
            ratingKontrolaLopte.Value = 1;
            ratingDriblanje.Value = 1;
            ratingDodavanje.Value = 1;
            ratingKretanje.Value = 1;
            ratingBrzina.Value = 1;
            ratingSut.Value = 1;
            ratingSnaga.Value = 1;
            ratingMarkiranje.Value = 1;
            ratingKlizeciStart.Value = 1;
            ratingSkok.Value = 1;
            ratingOdbrana.Value = 1;
            ratingOcjenaNastup.Value = 1;
            txtKomentar.Clear();
        }
        public void LoadDetaljiIgraca(Model.Models.Igrac igrac)
        {
            txtBrojDresa.Text = "#" + igrac.brojDresa.ToString();
            pictureSlikaIgraca.BackgroundImage = byteToImage.ConvertByteToImage(igrac.slikaPanel);
            pictureSlikaIgraca.BackgroundImageLayout = ImageLayout.Zoom;
            txtPrezime.Text = (igrac.korisnik.ime[0] + ". " + igrac.korisnik.prezime).ToUpper();
            igracOcjena.Value = (int)igrac.igracStatistika.prosjecnaOcjena;           
        }
        private void cmbIgraciSastav_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIgracValidated = Validacija.ValidirajDropDown(cmbIgraciSastav, "Igrač", txtIgracOcjenaValidator, pictureIgracOcjenaValidator);
            Model.Models.Igrac igrac = _ostaliIgraci[cmbIgraciSastav.SelectedIndex];
            LoadDetaljiIgraca(igrac);
        }
        public void UpdateBrojEvidentiranih()
        {
            txtBrojEvidentiranih.Text = flowPanelOcjene.Controls.Count.ToString() + " od " + (11 + flowPanelIzmjene.Controls.Count).ToString();
        }
        public void UpdateBrojEvidentiranihIzmjena()
        {
            txtBrojIzmjena.Text = flowPanelIzmjene.Controls.Count.ToString() + " od 3";
        }
        private void txtPrezime_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            cmbIgracOut.Enabled = true;
            cmbIgracIn.Enabled = true;
            txtIzmjenaMinuta.Clear();
            cmbRazlogIzmjena.SelectedIndex = 0;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!ValidirajIzmjneu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            frmIzmjenaKartica izmjena;
            int igracOutId = _igraciPrvaPostava[cmbIgracOut.SelectedIndex].igracId;
            int igracInId = _igraciKlupa[cmbIgracIn.SelectedIndex].igracId;
            int minuta = int.Parse(txtIzmjenaMinuta.Text);
            string razlogIzmjene = _izmjenaRazlog[cmbRazlogIzmjena.SelectedIndex];
            int izmjenaId = 0;
            bool flag = false;

            for (int i = 0; i < flowPanelIzmjene.Controls.Count; i++)
            {
                var control = (frmIzmjenaKartica)flowPanelIzmjene.Controls[i];
                if (control.igracOutId == igracOutId || control.igracInId == igracInId)
                {
                    if (cmbIgracOut.Enabled && cmbIgracIn.Enabled)
                    {
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.IZMJENA_VEC_EVIDENTIRANA);
                        flag = true;
                    }
                    else
                    {
                        izmjenaId = control.utakmicaIzmjenaId;
                        flowPanelIzmjene.Controls.Remove(control);
                    }
                }
            };
            if (!flag)
            {
                izmjena = new frmIzmjenaKartica(flowPanelIzmjene, this, _igraciPrvaPostava, _igraciKlupa, cmbIgracOut, cmbIgracIn, false);
                izmjena.igracOutId = igracOutId;
                izmjena.igracInId = igracInId;
                izmjena.igracOutSlika = byteToImage.ConvertByteToImage(_igraciPrvaPostava[cmbIgracOut.SelectedIndex].korisnik.Slika);
                izmjena.igracInSlika = byteToImage.ConvertByteToImage(_igraciKlupa[cmbIgracIn.SelectedIndex].korisnik.Slika);
                izmjena.igracOutPrezime = _igraciPrvaPostava[cmbIgracOut.SelectedIndex].korisnik.ime[0] + ". " + _igraciPrvaPostava[cmbIgracOut.SelectedIndex].korisnik.prezime;
                izmjena.igracInPrezime = _igraciKlupa[cmbIgracIn.SelectedIndex].korisnik.ime[0] + ". " + _igraciKlupa[cmbIgracIn.SelectedIndex].korisnik.prezime;
                izmjena.igracOutPozicija = _igraciPrvaPostava[cmbIgracOut.SelectedIndex].pozicija.skracenica;
                izmjena.igracInPozicija = _igraciKlupa[cmbIgracIn.SelectedIndex].pozicija.skracenica;
                izmjena.igracOutBroj = "#" + _igraciPrvaPostava[cmbIgracOut.SelectedIndex].brojDresa.ToString();
                izmjena.igracInBroj = "#" + _igraciKlupa[cmbIgracIn.SelectedIndex].brojDresa.ToString();
                izmjena.minuta = minuta;
                izmjena.razlogIzmjene = razlogIzmjene.ToUpper();
                izmjena.utakmicaIzmjenaId = izmjenaId;
                flowPanelIzmjene.Controls.Add(izmjena);
                if(cmbIgracIn.Enabled && cmbIgracOut.Enabled)
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.IZMJENA_USPJEŠNO_EVIDENTIRANA);
                }
                else
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.UREĐIVANJE);
                }
                cmbIgracOut.Enabled = true;
                cmbIgracIn.Enabled = true;
                cmbRazlogIzmjena.SelectedIndex = 0;
                txtIzmjenaMinuta.Clear();
                UpdateBrojEvidentiranihIzmjena();
            }
        }

        private void txtAsistencije_TextChanged_1(object sender, EventArgs e)
        {
            isAsistencijeValidated = Validacija.ValidirajOcjene(txtAsistencije, Field.ASISTENCIJE);
        }

        private void txtZutiKartoni_TextChanged_1(object sender, EventArgs e)
        {
            isZutKartoniValidated = Validacija.ValidirajOcjene(txtZutiKartoni, Field.ZUTI_KARTONI);
            if(txtZutiKartoni.Text == "2")
            {
                txtCrveniKartoni.Text = "1";
            }
        }

        private void txtCrveniKartoni_TextChanged_1(object sender, EventArgs e)
        {
            isCrveniKartoniValidated = Validacija.ValidirajOcjene(txtCrveniKartoni, Field.CRVENI_KARTONI);
        }

        private void txtIzmjenaMinuta_TextChanged(object sender, EventArgs e)
        {
            isMinutaIzmjenaValidirana = Validacija.ValidirajInputString(txtIzmjenaMinuta, txtIzmjenaMinutaValidator, Field.MINUTA_IZMJENA);
        }

        private void btnUcitajPanelPhoto_Click(object sender, EventArgs e)
        {
            if (_izvještaj != null)
            {
                return;
            }
            else
            {
                try
                {
                    var result = fileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        var fileName = fileDialog.FileName;

                        var file = System.IO.File.ReadAllBytes(fileName);

                        utakmicaSlika = file;

                        Image image = Image.FromFile(fileName);
                        pictureSlikaUtakmice.BackgroundImage = image;
                        pictureSlikaUtakmice.BackgroundImageLayout = ImageLayout.Stretch;

                        isSlikaUtakmiceValidated = Validacija.ValidirajSliku(image, pictureSlikaUtakmicaValidator, Field.SLIKA_UTAKMICA);
                    }
                }
                catch
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GRESKA_UPLOAD);
                }
            }
        }

        private void txtGoloviGost_TextChanged(object sender, EventArgs e)
        {
            isGoloviGostValidated = Validacija.ValidirajOcjene(txtGoloviGost, Field.GOLOVI_GOST);
        }

        private void bunifuPanel7_Click(object sender, EventArgs e)
        {

        }

        private void txtGoloviDomacin_TextChanged(object sender, EventArgs e)
        {
            isGoloviDomacinValidated = Validacija.ValidirajOcjene(txtGoloviDomacin, Field.GOLOVI_DOMACIN);
        }

        private void cmbIgracUtakmice_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIgracUtakmiceValidated = Validacija.ValidirajDropDown(cmbIgracUtakmice, "Igrač utakmice", txtIgracUtakmiceValidator, pictureIgracUtakmiceValidator);
        }

        private void cmbIgracOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIgracOUTValidated = Validacija.ValidirajDropDown(cmbIgracOut, "Igrač OUT", txtIgracOutValidator, pictureIgracOutValidator);

        }

        private void cmbIgracIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIgracINValidated = Validacija.ValidirajDropDown(cmbIgracIn, "Igrač IN", txtIgracInValidator, pictureIgracInValidator);

        }

        private void cmbRazlogIzmjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            isRazlogIzmjeneVAlidated = Validacija.ValidirajDropDown(cmbRazlogIzmjena, "Razlog", txtRazlogValidator, pictureRazlogValidator);

        }

        private void pictureSlikaUtakmice_Click(object sender, EventArgs e)
        {

        }

        private void xtGoloviDomacin_TextChanged(object sender, EventArgs e)
        {
            isGoloviDomacinValidated = Validacija.ValidirajOcjene(txtGoloviDomacin, Field.GOLOVI_DOMACIN);
        }

        private async void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            List<UtakmicaNastupInsertRequest> nastupi = new List<UtakmicaNastupInsertRequest>();
            List<UtakmicaIzmjenaInsertRequest> izmjene = new List<UtakmicaIzmjenaInsertRequest>();
            Vrijeme vrijeme = Vrijeme.KIŠA;
            int goloviSarajevo = 0;
            int goloviProtivnik = 0;

            if (_utakmica.vrstaUtakmice == "Domaća")
            {
                goloviSarajevo = int.Parse(txtGoloviDomacin.Text);
                goloviProtivnik = int.Parse(txtGoloviGost.Text);
            }
            else if (_utakmica.vrstaUtakmice == "Gostujuća")
            {
                goloviProtivnik = int.Parse(txtGoloviDomacin.Text);
                goloviSarajevo = int.Parse(txtGoloviGost.Text);
            }

            for (int i = 0; i < flowPanelOcjene.Controls.Count; i++)
            {
                var controlNastup = (frmIgracNastupKartica)flowPanelOcjene.Controls[i];
                UtakmicaNastupInsertRequest nastup = new UtakmicaNastupInsertRequest
                {
                    igracId = controlNastup.igracId,
                    trenerId = 1,
                    utakmicaId = _utakmicaId,
                    minute = controlNastup.igracMinute,
                    golovi = controlNastup.igracGolovi,
                    asistencije = controlNastup.igracAsistencije,
                    zutiKartoni = controlNastup.igracZutiKartoni,
                    crveniKartoni = controlNastup.igracCrveniKartoni,
                    ocjena = controlNastup.ocjenaRating,
                    komentar = controlNastup.igracKomentar,
                    kontrolaLopte = controlNastup.kontrolaLopte,
                    driblanje = controlNastup.driblanje,
                    dodavanje = controlNastup.dodavanje,
                    kretanje = controlNastup.kretanje,
                    brzina = controlNastup.brzina,
                    sut = controlNastup.sut,
                    snaga = controlNastup.snaga,
                    markiranje = controlNastup.markiranje,
                    klizeciStart = controlNastup.klizeciStart,
                    skok = controlNastup.skok,
                    odbrana = controlNastup.odbrana
                };
                nastupi.Add(nastup);
            };
            for (int i = 0; i < flowPanelIzmjene.Controls.Count; i++)
            {
                var controlIzmjene = (frmIzmjenaKartica)flowPanelIzmjene.Controls[i];
                UtakmicaIzmjenaInsertRequest izmjena = new UtakmicaIzmjenaInsertRequest
                {
                    utakmicaId = _utakmicaId,
                    igracOutId = controlIzmjene.igracOutId,
                    igracInId = controlIzmjene.igracInId,
                    minuta = controlIzmjene.minuta,
                    izmjenaRazlog = controlIzmjene.razlogIzmjene
                };
                izmjene.Add(izmjena);
            };
            if (radioBtnSunce.Checked)
            {
                vrijeme = Vrijeme.SUNCE;
            }
            else if (radioBtnOblacno.Checked)
            {
                vrijeme = Vrijeme.OBLAČNO;
            }

            IzvjetajInsertRequest insertRequest = new IzvjetajInsertRequest
            {
                goloviSarajevo = goloviSarajevo,
                goloviProtivnik = goloviProtivnik,
                zapisnik = txtZapisnik.Text,
                slikaSaUtakmice = utakmicaSlika,
                vrijeme = vrijeme,
                igracUtakmicaID = _igraci[cmbIgracUtakmice.SelectedIndex].igracId,
                utakmicaID = _utakmicaId,
                trenerID = 1,
                izmjene = izmjene,
                utakmicaNastup = nastupi
            };
            try
            {
                await _izvjestajApi.Insert<Model.Models.Izvještaj>(insertRequest);
                await _prikazUtakmica.LoadIzvještaj(notifikacija: TipNotifikacije.DODAVANJE);
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
            List<UtakmicaNastupUpdateRequest> nastupi = new List<UtakmicaNastupUpdateRequest>();
            List<UtakmicaIzmjenaUpdateRequest> izmjene = new List<UtakmicaIzmjenaUpdateRequest>();

            for (int i = 0; i < flowPanelOcjene.Controls.Count; i++)
            {
                var controlNastup = (frmIgracNastupKartica)flowPanelOcjene.Controls[i];
                UtakmicaNastupUpdateRequest nastup = new UtakmicaNastupUpdateRequest
                {
                    utakmicaNastupId = controlNastup.utakmicaNastupId,
                    igracId = controlNastup.igracId,
                    trenerId = 1,
                    utakmicaId = _utakmicaId,
                    minute = controlNastup.igracMinute,
                    golovi = controlNastup.igracGolovi,
                    asistencije = controlNastup.igracAsistencije,
                    zutiKartoni = controlNastup.igracZutiKartoni,
                    crveniKartoni = controlNastup.igracCrveniKartoni,
                    ocjena = controlNastup.ocjenaRating,
                    komentar = controlNastup.igracKomentar,
                    kontrolaLopte = controlNastup.kontrolaLopte,
                    driblanje = controlNastup.driblanje,
                    dodavanje = controlNastup.dodavanje,
                    kretanje = controlNastup.kretanje,
                    brzina = controlNastup.brzina,
                    sut = controlNastup.sut,
                    snaga = controlNastup.snaga,
                    markiranje = controlNastup.markiranje,
                    klizeciStart = controlNastup.klizeciStart,
                    skok = controlNastup.skok,
                    odbrana = controlNastup.odbrana
                };
                nastupi.Add(nastup);
                var controlOcjene = (frmIgracNastupKartica)flowPanelOcjene.Controls[i];
            };
            for (int i = 0; i < flowPanelIzmjene.Controls.Count; i++)
            {
                var controlIzmjene = (frmIzmjenaKartica)flowPanelIzmjene.Controls[i];
                UtakmicaIzmjenaUpdateRequest izmjena = new UtakmicaIzmjenaUpdateRequest
                {
                    utakmicaIzmjenaId = controlIzmjene.utakmicaIzmjenaId,
                    utakmicaId = _utakmicaId,
                    igracOutId = controlIzmjene.igracOutId,
                    igracInId = controlIzmjene.igracInId,
                    minuta = controlIzmjene.minuta,
                    izmjenaRazlog = controlIzmjene.razlogIzmjene
                };
                izmjene.Add(izmjena);
            };

            IzvjestajUpdateRequest updateRequest = new IzvjestajUpdateRequest
            {
                zapisnik = txtZapisnik.Text,
                izmjene = izmjene,
                utakmicaNastup = nastupi,
                utakmicaId = _utakmicaId
            };
            try
            {
                await _izvjestajApi.Update<Model.Models.Izvještaj>(_izvještaj.izvještajId, updateRequest);
                await _prikazUtakmica.LoadIzvještaj(notifikacija: TipNotifikacije.UREĐIVANJE);
                this.Hide();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void txtMinute_TextChanged_1(object sender, EventArgs e)
        {
            isMinuteValidated = Validacija.ValidirajOcjene(txtMinute, Field.MINUTE);          
        }

        private void txtGolovi_TextChanged_1(object sender, EventArgs e)
        {
            isGoloviValidated = Validacija.ValidirajOcjene(txtGolovi, Field.GOLOVI);

        }
    }
}
