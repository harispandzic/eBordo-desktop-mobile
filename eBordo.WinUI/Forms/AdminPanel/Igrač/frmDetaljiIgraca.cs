using eBordo.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel
{
    public partial class frmDetaljiIgraca : Form
    {
        Model.Models.Igrac _odabraniIgrac;
        ByteToImage byteToImage = new ByteToImage();

        public frmDetaljiIgraca(Model.Models.Igrac odabraniIgrac)
        {
            InitializeComponent();
            _odabraniIgrac = odabraniIgrac;
        }
        private void frmDetaljiIgraca_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = (_odabraniIgrac.korisnik.ime + " " + _odabraniIgrac.korisnik.prezime).ToUpper();
            userProflePicture.Image = byteToImage.ConvertByteToImage(_odabraniIgrac.korisnik.Slika);
            userProflePicture.BackgroundImageLayout = ImageLayout.Zoom;
            txtImePrezime2.Text = (_odabraniIgrac.korisnik.ime + " " + _odabraniIgrac.korisnik.prezime).ToUpper();
            korisnickaFotografija.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniIgrac.slikaPanel);
            korisnickaFotografija.BackgroundImageLayout = ImageLayout.Zoom;
            pictureZastava.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniIgrac.korisnik.drzavljanstvo.zastava);
            pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniIgrac.korisnik.drzavljanstvo.zastava);
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            lblDresVrijednost.Text = "#" + _odabraniIgrac.brojDresa.ToString();
            lblDrzavljanstvoVrijednost.Text = _odabraniIgrac.korisnik.drzavljanstvo.nazivDrzave;
            lblMjestoRodjenjaVrijednost.Text = _odabraniIgrac.korisnik.gradRodjenja.nazivGrada;
            lblDatumRodjenjaVrijednost.Text = _odabraniIgrac.korisnik.datumRodjenja.ToString("dd.MM.yyyy");
            lblAdresaPrebivalistaVrijednost.Text = _odabraniIgrac.korisnik.adresa;
            lblTelefonVrijednost.Text = _odabraniIgrac.korisnik.telefon;
            lblEmailVrijednost.Text = _odabraniIgrac.korisnik.email;
            lblPozicija.Text = _odabraniIgrac.pozicija.nazivPozicije.ToUpper();
            lblPozicijaVrijednost.Text = _odabraniIgrac.pozicija.nazivPozicije.ToUpper();
            lblBoljaNogaVrijednost.Text = _odabraniIgrac.boljaNoga;
            ratingJacinaSlabijeNogeVrijednost.Value = _odabraniIgrac.jacinaSlabijeNoge;
            lblVisinaVrijednost.Text = _odabraniIgrac.visina.ToString();
            lblTezinaVrijednost.Text = _odabraniIgrac.tezina.ToString();
            lblTrzisnaVrijednostVrijednost.Text = _odabraniIgrac.trzisnaVrijednost.ToString();
            lblNapomeneVrijednost.Text = _odabraniIgrac.napomeneOIgracu;

            lblDatumPocetkaUgovoraVrijednost.Text = _odabraniIgrac.ugovor.datumPocetka.ToString("dd.MM.yyyy");
            lblDatumZavrsetkaUgovoraVrijednost.Text = _odabraniIgrac.ugovor.datumZavrsetka.ToString("dd.MM.yyyy");

            lblBrojNastupa.Text = _odabraniIgrac.igracStatistika.brojNastupa.ToString();
            lblMinute.Text = (_odabraniIgrac.igracStatistika.brojNastupa * 90).ToString();
            lblGolovi.Text = _odabraniIgrac.igracStatistika.golovi.ToString();
            lblAsistencije.Text = _odabraniIgrac.igracStatistika.asistencije.ToString();
            lblZutiKartoni.Text = _odabraniIgrac.igracStatistika.zutiKartoni.ToString();
            lblCrveniKartoni.Text = _odabraniIgrac.igracStatistika.crveniKartoni.ToString();
            lblOcjena.Value = (int)_odabraniIgrac.igracStatistika.prosjecnaOcjena;
            ratingKontrolaLopte.Value = (int)_odabraniIgrac.igracSkills.kontrolaLopte;
            ratingDriblanje.Value = (int)_odabraniIgrac.igracSkills.driblanje;
            ratingDodavanje.Value = (int)_odabraniIgrac.igracSkills.dodavanje;
            ratingKretanje.Value = (int)_odabraniIgrac.igracSkills.kretanje;
            ratingBrzina.Value = (int)_odabraniIgrac.igracSkills.brzina;
            ratingSnaga.Value = (int)_odabraniIgrac.igracSkills.snaga;
            ratingSut.Value = (int)_odabraniIgrac.igracSkills.sut;
            ratingMarkiranje.Value = (int)_odabraniIgrac.igracSkills.markiranje;
            ratingKlizeciStart.Value = (int)_odabraniIgrac.igracSkills.klizeciStart;
            ratingSkok.Value = (int)_odabraniIgrac.igracSkills.skok;
            ratingOdbrana.Value = (int)_odabraniIgrac.igracSkills.odbrana;

            if (!_odabraniIgrac.korisnik.isAktivan)
            {
                pictureAktivan.BackgroundImage = Properties.Resources.eBordo_error_notification;
                pictureAktivan.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                pictureAktivan.BackgroundImage = Properties.Resources.eBordo_success_notification;
                pictureAktivan.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void lblBrojDresa_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
