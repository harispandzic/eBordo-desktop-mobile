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
            trenerFotografija.Image = byteToImage.ConvertByteToImage(_odabraniTrener.korisnik.Slika);
            lblDrzavljanstvoVrijednost.Text = _odabraniTrener.korisnik.drzavljanstvo.nazivDrzave;
            lblMjestoRodjenjaVrijednost.Text = _odabraniTrener.korisnik.gradRodjenja.nazivGrada;
            lblDatumRodjenjaVrijednost.Text = _odabraniTrener.korisnik.datumRodjenja.ToString("dd.MM.yyyy");
            lblAdresaPrebivalistaVrijednost.Text = _odabraniTrener.korisnik.adresa;
            lblTelefonVrijednost.Text = _odabraniTrener.korisnik.telefon;
            lblEmailVrijednost.Text = _odabraniTrener.korisnik.email;

            lblDatumPocetkaUgovoraVrijednost.Text = _odabraniTrener.ugovor.datumPocetka.ToString("dd.MM.yyyy");
            lblDatumZavrsetkaUgovoraVrijednost.Text = _odabraniTrener.ugovor.datumZavrsetka.ToString("dd.MM.yyyy");

            lblLicencaVrijednost.Text = _odabraniTrener.trenerskaLicenca.nazivLicence;
            lblFormacijaVrijednost.Text = _odabraniTrener.formacija.nazivFormacije;

            progresBarNastupi.Maximum = 10; //zamijeniti u odigrane utakmice
            progresBarNastupi.Value = _odabraniTrener.trenerStatistika.brojUtakmica;
            lblNastupiVrijednost.Text = _odabraniTrener.trenerStatistika.brojUtakmica.ToString();

            progresBarPobjede.Maximum = 10; //zamijeniti u broj utakmica pomnožen sa 90
            progresBarPobjede.Value = _odabraniTrener.trenerStatistika.brojPobjeda;
            lblPobjedeVrijednost.Text = _odabraniTrener.trenerStatistika.brojPobjeda.ToString();

            progresBarPorazi.Maximum = 10; //zamijeniti u broj utakmica pomnožen sa 90
            progresBarPorazi.Value = _odabraniTrener.trenerStatistika.brojPoraza;
            lblPoraziVrijednost.Text = _odabraniTrener.trenerStatistika.brojPoraza.ToString();

            progresBarNerješene.Maximum = 10; //zamijeniti u broj utakmica pomnožen sa 90
            progresBarNerješene.Value = _odabraniTrener.trenerStatistika.brojNerjesenih;
            lblNerjeseneVrijednosti.Text = _odabraniTrener.trenerStatistika.brojNerjesenih.ToString();
        }
    }
}
