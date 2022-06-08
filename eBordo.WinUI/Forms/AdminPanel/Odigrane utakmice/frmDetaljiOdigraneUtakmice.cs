using eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica;
using eBordo.WinUI.Helper;
using eBordo.WinUI.Reports;
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
    public partial class frmDetaljiOdigraneUtakmice : Form
    {
        private readonly ApiService.ApiService _nastupiApi = new ApiService.ApiService("UtakmicaNastup");
        private readonly ApiService.ApiService _igracApi = new ApiService.ApiService("Igrac");
        private readonly ApiService.ApiService _utakmica = new ApiService.ApiService("Utakmica");

        Model.Models.Izvjestaj _odabraniIzvjestaj { get; set; }
        ByteToImage byteToImage = new ByteToImage();

        public frmDetaljiOdigraneUtakmice(Model.Models.Izvjestaj odabraniIzvjestaj)
        {
            InitializeComponent();
            _odabraniIzvjestaj = odabraniIzvjestaj;
        }

        private async void frmDetaljiOdigraneUtakmice_Load(object sender, EventArgs e)
        {
            if (_odabraniIzvjestaj.utakmica.vrstaUtakmice == "Domaća")
            {
                lblDomacin.Text = "FK Sarajevo".ToUpper();
                grbDomacin.BackgroundImage = Properties.Resources.grbSarajevo;
                grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
                pictureGostujucaDomaca.BackgroundImage = Properties.Resources.home_bordo;
                lblGost.Text = _odabraniIzvjestaj.utakmica.protivnik.nazivKluba.ToUpper();
                grbGost.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniIzvjestaj.utakmica.protivnik.grb);
                grbGost.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (_odabraniIzvjestaj.utakmica.vrstaUtakmice == "Gostujuća")
            {
                lblDomacin.Text = _odabraniIzvjestaj.utakmica.protivnik.nazivKluba.ToUpper();
                grbDomacin.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniIzvjestaj.utakmica.protivnik.grb);
                grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
                pictureGostujucaDomaca.BackgroundImage = Properties.Resources.away_bordo;
                lblGost.Text = "FK Sarajevo".ToUpper();
                grbGost.BackgroundImage = Properties.Resources.grbSarajevo;
                grbGost.BackgroundImageLayout = ImageLayout.Zoom;
            }
            if (_odabraniIzvjestaj.utakmica.tipGarniture == "Domaća")
            {
                pictureDres.BackgroundImage = Properties.Resources.domaci;
                pictureDres.BackgroundImageLayout = ImageLayout.Zoom;
                txtGarnitura.Text = "DOMAĆA";
            }
            else if (_odabraniIzvjestaj.utakmica.tipGarniture == "Gostujuća")
            {
                pictureDres.BackgroundImage = Properties.Resources.gostujuci;
                pictureDres.BackgroundImageLayout = ImageLayout.Zoom;
                txtGarnitura.Text = "GOSTUJUĆA";
            }
            else if (_odabraniIzvjestaj.utakmica.tipGarniture == "Rezervna")
            {
                pictureDres.BackgroundImage = Properties.Resources.rezervni;
                pictureDres.BackgroundImageLayout = ImageLayout.Zoom;
                txtGarnitura.Text = "REZERVNA";
            }
            lblOpisUtakmice.Text = _odabraniIzvjestaj.utakmica.opisUtakmice.ToUpper();
            txtDatum.Text = _odabraniIzvjestaj.utakmica.datumOdigravanja.ToString("dd.MM.yyyy"); ;
            txtSatnica.Text = _odabraniIzvjestaj.utakmica.satnica + " h";
            txtStadion.Text = "STADION " + _odabraniIzvjestaj.utakmica.stadion.nazivStadiona.ToUpper();
            pictureTakmicenje.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniIzvjestaj.utakmica.takmicenje.logo);
            pictureTakmicenje.BackgroundImageLayout = ImageLayout.Zoom;
            //txtKapiten.Text = (_odabraniIzvjestaj.utakmica.kapiten.korisnik.ime + " " + _odabraniIzvjestaj.utakmica.kapiten.korisnik.prezime).ToUpper();
            pictureBox1.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniIzvjestaj.slikaSaUtakmice);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            txtBrojEvidentiranih.Text = _odabraniIzvjestaj.nastupi.Count().ToString();

            if (_odabraniIzvjestaj.utakmica.datumOdigravanja.Date == DateTime.Now.Date)
            {
                txtBrojDana.Text = "DANAS";
            }
            else if (_odabraniIzvjestaj.utakmica.datumOdigravanja.Date < DateTime.Now.Date)
            {
                txtBrojDana.Text = "ZAVRŠENA PRIJE " + (DateTime.Now.Date - _odabraniIzvjestaj.utakmica.datumOdigravanja.Date.Date).TotalDays + " DANA";
            }
            else
            {
                txtBrojDana.Text = "ZA " + (_odabraniIzvjestaj.utakmica.datumOdigravanja.Date.Date - DateTime.Now.Date).TotalDays + " DANA";
            }
            frmKratkiIzvjestajKartica kratkiNastup;
            foreach (var item in _odabraniIzvjestaj.nastupi)
            {
                kratkiNastup = new frmKratkiIzvjestajKartica();
                kratkiNastup.brojGolova = item.golovi;
                kratkiNastup.brojAsistencija = item.asistencije;
                kratkiNastup.brojZutih = item.zutiKartoni;
                kratkiNastup.brojCrvenih = item.crveniKartoni;
                kratkiNastup.igracId = item.igracId;
                kratkiNastup.igracSlika = byteToImage.ConvertByteToImage(item.igrac.korisnik.Slika);
                kratkiNastup.igracImePrezime = item.igrac.korisnik.ime[0] + ". " + item.igrac.korisnik.prezime;
                kratkiNastup.brojDresa = "#" + item.igrac.brojDresa.ToString();
                kratkiNastup.igracPozicija = item.igrac.pozicija.skracenica;
                kratkiNastup.minute = item.minute;
                kratkiNastup.ocjena = item.ocjena;
                kratkiNastup.kontrolaLopte = item.kontrolaLopte;
                kratkiNastup.driblanje = item.driblanje;
                kratkiNastup.dodavanje = item.dodavanje;
                kratkiNastup.kretanje = item.kretanje;
                kratkiNastup.brzina = item.brzina;
                kratkiNastup.sut = item.sut;
                kratkiNastup.snaga = item.snaga;
                kratkiNastup.markiranje = item.markiranje;
                kratkiNastup.klizeciStart = item.klizeciStart;
                kratkiNastup.skok = item.skok;
                kratkiNastup.odbrana = item.odbrana;
                kratkiNastup.igracKomentar = item.komentar;
                flowPanelOcjene.Controls.Add(kratkiNastup);
            }
            foreach (var item in _odabraniIzvjestaj.izmjene)
            {
                frmIzmjeneKartica_detalji izmjena = new frmIzmjeneKartica_detalji();
                izmjena.igracOutSlika = byteToImage.ConvertByteToImage(item.igracOut.korisnik.Slika);
                izmjena.igracInSlika = byteToImage.ConvertByteToImage(item.igracIn.korisnik.Slika);
                izmjena.igracOutPrezime = item.igracOut.korisnik.ime[0] + ". " + item.igracOut.korisnik.prezime;
                izmjena.igracInPrezime = item.igracIn.korisnik.ime[0] + ". " + item.igracIn.korisnik.prezime;
                izmjena.igracOutPozicija = item.igracOut.pozicija.skracenica;
                izmjena.igracInPozicija = item.igracIn.pozicija.skracenica;
                izmjena.razlogIzmjene = item.izmjenaRazlog.ToString();
                izmjena.igracOutBroj = "#" + item.igracOut.brojDresa.ToString();
                izmjena.igracInBroj = "#" + item.igracIn.brojDresa.ToString();
                izmjena.minuta = item.minuta;
                izmjena.razlogIzmjene = item.izmjenaRazlog.ToString();
                flowPanelIzmjene.Controls.Add(izmjena);
            }
            Model.Models.Igrac igracKorisnik = _odabraniIzvjestaj.igracUtakmica; ;
            //try
            //{
            //    igracKorisnik = await _igracApi.GetById<Model.Models.Igrac>(podaciIgracUtakmice.igracId);
            //}
            //catch
            //{
            //    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            //}
            lblDresVrijednost.Text = "#" + igracKorisnik.brojDresa.ToString();
            korisnickaFotoagrafija.BackgroundImage = byteToImage.ConvertByteToImage(igracKorisnik.slikaPanel);
            korisnickaFotoagrafija.BackgroundImageLayout = ImageLayout.Zoom;
            lblImePrezime.Text = (igracKorisnik.korisnik.ime[0] + " " + igracKorisnik.korisnik.prezime).ToUpper();
            lblOcjena.Value = (int)igracKorisnik.igracStatistika.prosjecnaOcjena;
            ratingKontrolaLopte.Value = (int)igracKorisnik.igracSkills.kontrolaLopte;
            ratingDriblanje.Value = (int)igracKorisnik.igracSkills.driblanje;
            ratingDodavanje.Value = (int)igracKorisnik.igracSkills.dodavanje;
            ratingKretanje.Value = (int)igracKorisnik.igracSkills.kretanje;
            ratingBrzina.Value = (int)igracKorisnik.igracSkills.brzina;
            ratingSut.Value = (int)igracKorisnik.igracSkills.sut;
            ratingSnaga.Value = (int)igracKorisnik.igracSkills.snaga;
            ratingMarkiranje.Value = (int)igracKorisnik.igracSkills.markiranje;
            ratingKlizeciStart.Value = (int)igracKorisnik.igracSkills.klizeciStart;
            ratingSkok.Value = (int)igracKorisnik.igracSkills.skok;
            ratingOdbrana.Value = (int)igracKorisnik.igracSkills.odbrana;
            ocjenaNastupa.Value = (int)igracKorisnik.igracSkills.prosjekOcjena;
            lblMinute.Text = (igracKorisnik.igracStatistika.brojNastupa * 90).ToString(); ;
            lblGolovi.Text = igracKorisnik.igracStatistika.golovi.ToString();
            lblAsistencije.Text = igracKorisnik.igracStatistika.asistencije.ToString();
            lblZutiKartoni.Text = igracKorisnik.igracStatistika.zutiKartoni.ToString();
            lblCrveniKartoni.Text = igracKorisnik.igracStatistika.crveniKartoni.ToString();
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _utakmica.GetById<Model.Models.Utakmica>(_odabraniIzvjestaj.utakmicaID);
                frmDetaljiUtakmice detalji = new frmDetaljiUtakmice(result);
                detalji.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            frmReportPregled pregledIzvjestaja = new frmReportPregled(null, null, null, null, null, null, null, _odabraniIzvjestaj, null);
            pregledIzvjestaja.Show();
        }
    }
}
