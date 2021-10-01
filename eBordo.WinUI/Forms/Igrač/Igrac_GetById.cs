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
    public partial class Igrac_GetById : Form
    {
        private readonly ApiService.ApiService _igraci = new ApiService.ApiService("Igrac");
        private Model.Models.Igrac igrac { get; set; }
        public Igrac_GetById(Model.Models.Igrac igrac)
        {
            InitializeComponent();
            this.igrac = igrac;
        }

        private async void Igrac_GetById_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = igrac.korisnik.ime + " " + igrac.korisnik.prezime;
            imgUserPicture.ImageLocation = "https://i.ibb.co/P1Qgg3p/215928.jpg";
            lblAdresaPrebivalista.Text = igrac.korisnik.adresa;
            lblTelefon.Text = igrac.korisnik.telefon;
            lblEmail.Text = igrac.korisnik.email;
            lblKorisnickoIme.Text = igrac.korisnik.korisnickoIme;
            lblDatumPocetka.Text = igrac.ugovor.datumPocetka.ToString("dd.MM.yyyy");
            lblDatumZavrsetka.Text = igrac.ugovor.datumPocetka.ToString("dd.MM.yyyy"); ;
            lblDatumPotpisa.Text = igrac.ugovor.datumPocetka.ToString("dd.MM.yyyy");
            lblVrijednostUgovora.Text = igrac.ugovor.iznosPlate.ToString();
        }
    }
}
