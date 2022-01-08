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
    public partial class frmDetaljiTrenera : Form
    {
        Model.Models.Trener _odabraniTrener;
        ByteToImage byteToImage = new ByteToImage();
        public frmDetaljiTrenera(Model.Models.Trener odabraniTrener)
        {
            InitializeComponent();
            _odabraniTrener = odabraniTrener;
        }

        private void frmDetaljiTrenera_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = (_odabraniTrener.korisnik.ime + " " + _odabraniTrener.korisnik.prezime).ToUpper();
            txtImePrezime.Text = (_odabraniTrener.korisnik.ime + " " + _odabraniTrener.korisnik.prezime).ToUpper();
            txtLicenca.Text = _odabraniTrener.trenerskaLicenca.nazivLicence.ToUpper();
            userProflePicture.Image = byteToImage.ConvertByteToImage(_odabraniTrener.korisnik.Slika);
            lblDrzavljanstvoVrijednost.Text = _odabraniTrener.korisnik.drzavljanstvo.nazivDrzave;
            pictureZastava.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniTrener.korisnik.drzavljanstvo.zastava);
            pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniTrener.korisnik.drzavljanstvo.zastava);
            pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.BackgroundImage = byteToImage.ConvertByteToImage(_odabraniTrener.SlikaPanel);
            pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
            lblMjestoRodjenjaVrijednost.Text = _odabraniTrener.korisnik.gradRodjenja.nazivGrada;
            lblDatumRodjenjaVrijednost.Text = _odabraniTrener.korisnik.datumRodjenja.ToString("dd.MM.yyyy");
            lblAdresaPrebivalistaVrijednost.Text = _odabraniTrener.korisnik.adresa;
            lblTelefonVrijednost.Text = _odabraniTrener.korisnik.telefon;
            lblEmailVrijednost.Text = _odabraniTrener.korisnik.email;
            txtUloga.Text = _odabraniTrener.trenerskaLicenca.nazivLicence.ToUpper();
            lblDatumPocetkaUgovoraVrijednost.Text = _odabraniTrener.ugovor.datumPocetka.ToString("dd.MM.yyyy");
            lblDatumZavrsetkaUgovoraVrijednost.Text = _odabraniTrener.ugovor.datumZavrsetka.ToString("dd.MM.yyyy");

            lblLicencaVrijednost.Text = _odabraniTrener.trenerskaLicenca.nazivLicence;
            lblFormacijaVrijednost.Text = _odabraniTrener.formacija.nazivFormacije;

            lblNastupiVrijednost.Text = _odabraniTrener.trenerStatistika.brojUtakmica.ToString();

            lblPobjedeVrijednost.Text = _odabraniTrener.trenerStatistika.brojPobjeda.ToString();

            lblPoraziVrijednost.Text = _odabraniTrener.trenerStatistika.brojPoraza.ToString();

            lblNerjeseneVrijednosti.Text = _odabraniTrener.trenerStatistika.brojNerjesenih.ToString();
        }

        private void pictureZastava_Click(object sender, EventArgs e)
        {

        }
    }
}
