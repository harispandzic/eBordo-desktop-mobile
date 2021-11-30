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
    public partial class frmDetaljiUtakmice : Form
    {
        frmPrikazRasporedaUtakmicacs _prikazUtakmica;
        public Model.Models.Utakmica _odabranaUtakmica { get; set; }
        ByteToImage byteToImage = new ByteToImage();

        public frmDetaljiUtakmice(Model.Models.Utakmica odabranaUtakmica, frmPrikazRasporedaUtakmicacs prikazUtakmica)
        {
            InitializeComponent();
            _prikazUtakmica = prikazUtakmica;
            _odabranaUtakmica = odabranaUtakmica;
        }

        private void frmDetaljiUtakmice_Load(object sender, EventArgs e)
        {
            if (_odabranaUtakmica.vrstaUtakmice == "Domaća")
            {
                grbDomacin.BackgroundImage = Properties.Resources.grbSarajevo;
                grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
                lblDomacin.Text = "FK SARAJEVO";
                grbGost.BackgroundImage = byteToImage.ConvertByteToImage(_odabranaUtakmica.protivnik.grb);
                grbGost.BackgroundImageLayout = ImageLayout.Zoom;
                lblGost.Text = _odabranaUtakmica.protivnik.nazivKluba.ToUpper();
                pictureVrstaUtakmice.BackgroundImage = Properties.Resources.home_bordo;
            }
            else if (_odabranaUtakmica.vrstaUtakmice == "Gostujuća")
            {
                grbDomacin.BackgroundImage = byteToImage.ConvertByteToImage(_odabranaUtakmica.protivnik.grb);
                grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
                lblDomacin.Text = _odabranaUtakmica.protivnik.nazivKluba.ToUpper();
                grbGost.BackgroundImage = Properties.Resources.grbSarajevo;
                grbGost.BackgroundImageLayout = ImageLayout.Zoom;
                lblGost.Text = "FK SARAJEVO";
                pictureVrstaUtakmice.BackgroundImage = Properties.Resources.away_bordo;
            }
            lblUtakmicaOpis.Text = _odabranaUtakmica.opisUtakmice;
            lblStadion.Text = _odabranaUtakmica.stadion.nazivStadiona;
            lblDatum.Text = _odabranaUtakmica.datumOdigravanja.ToString("dd.MM.yyyy");
            lblSatnica.Text = _odabranaUtakmica.satnica + "h";
            lblKapiten.Text = _odabranaUtakmica.kapiten.korisnik.ime + " " + _odabranaUtakmica.kapiten.korisnik.prezime;
            lblSudija.Text = _odabranaUtakmica.sudija;
            pictureSlikaStadiona.BackgroundImage = byteToImage.ConvertByteToImage(_odabranaUtakmica.stadion.slikaStadiona);
            pictureSlikaStadiona.BackgroundImageLayout = ImageLayout.Zoom;
            if (_odabranaUtakmica.tipGarniture == "Domaća")
            {
                pictureDres.BackgroundImage = Properties.Resources.domaci;
            }
            else if (_odabranaUtakmica.tipGarniture == "Gostujuća")
            {
                pictureDres.BackgroundImage = Properties.Resources.gostujuci;
            }
            else if (_odabranaUtakmica.tipGarniture == "Rezervna")
            {
                pictureDres.BackgroundImage = Properties.Resources.rezervni;
            }
            foreach (var item in _odabranaUtakmica.sastav)
            {
                frmUtakmicaSastavKartica_detaljiUtakmice pozvaniIgrac = new frmUtakmicaSastavKartica_detaljiUtakmice();
                pozvaniIgrac.igracSlika = byteToImage.ConvertByteToImage(item.igrac.korisnik.Slika);
                pozvaniIgrac.igracPozicija = item.pozicija.skracenica;
                pozvaniIgrac.igracImePrezime = item.igrac.korisnik.ime[0] + ". " + item.igrac.korisnik.prezime;
                pozvaniIgrac.brojDresa = "#" + item.igrac.brojDresa.ToString();
                if(item.igrac.igracId == _odabranaUtakmica.kapitenId)
                {
                    pozvaniIgrac.isKapiten = true;
                }
                else
                {
                    pozvaniIgrac.isKapiten = false;
                }
                if (item.uloga == "PRVA_POSTAVA")
                {
                    flowPanelPrvaPostava.Controls.Add(pozvaniIgrac);
                }
                else
                {
                    flowPanelKlupa.Controls.Add(pozvaniIgrac);
                }
            }
        }
    }
}
