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
                pictureGostujucaDomaca.BackgroundImage = Properties.Resources.home;
            }
            else if (_odabranaUtakmica.vrstaUtakmice == "Gostujuća")
            {
                grbDomacin.BackgroundImage = byteToImage.ConvertByteToImage(_odabranaUtakmica.protivnik.grb);
                grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
                lblDomacin.Text = _odabranaUtakmica.protivnik.nazivKluba.ToUpper();
                grbGost.BackgroundImage = Properties.Resources.grbSarajevo;
                grbGost.BackgroundImageLayout = ImageLayout.Zoom;
                lblGost.Text = "FK SARAJEVO";
                pictureGostujucaDomaca.BackgroundImage = Properties.Resources.away;
            }
            lblOpisUtakmice.Text = _odabranaUtakmica.opisUtakmice.ToUpper();
            txtStadion.Text = "STADION " + _odabranaUtakmica.stadion.nazivStadiona.ToUpper();
            txtDatum.Text = _odabranaUtakmica.datumOdigravanja.ToString("dd.MM.yyyy");
            txtSatnica.Text = _odabranaUtakmica.satnica + "h";
            txtSudija.Text = _odabranaUtakmica.sudija;
            pictureTakmicenje.BackgroundImage = byteToImage.ConvertByteToImage(_odabranaUtakmica.takmicenje.logo);
            pictureTakmicenje.BackgroundImageLayout = ImageLayout.Zoom;
            //pictureKapiten.BackgroundImage = byteToImage.ConvertByteToImage(_odabranaUtakmica.kapiten.korisnik.Slika);
            //pictureKapiten.BackgroundImageLayout = ImageLayout.Zoom;
            txtKapiten.Text = (_odabranaUtakmica.kapiten.korisnik.ime[0] + ". " + _odabranaUtakmica.kapiten.korisnik.prezime).ToUpper();
            if (_odabranaUtakmica.tipGarniture == "Domaća")
            {
                pictureDres.BackgroundImage = Properties.Resources.domaci;
                txtGarnitura.Text = "DOMAĆA";
            }
            else if (_odabranaUtakmica.tipGarniture == "Gostujuća")
            {
                pictureDres.BackgroundImage = Properties.Resources.gostujuci;
                txtGarnitura.Text = "GOSTUJUĆA";
            }
            else if (_odabranaUtakmica.tipGarniture == "Rezervna")
            {
                pictureDres.BackgroundImage = Properties.Resources.rezervni;
                txtGarnitura.Text = "REZERVNA";
            }
            if (_odabranaUtakmica.datumOdigravanja.Date == DateTime.Now.Date)
            {
                txtBrojDana.Text = "DANAS";
            }
            else if (_odabranaUtakmica.datumOdigravanja.Date < DateTime.Now.Date)
            {
                txtBrojDana.Text = "ZAVRŠENA PRIJE " + (DateTime.Now.Date - _odabranaUtakmica.datumOdigravanja.Date.Date).TotalDays + " DANA";
            }
            else
            {
                txtBrojDana.Text = "ZA " + (_odabranaUtakmica.datumOdigravanja.Date.Date - DateTime.Now.Date).TotalDays + " DANA";
            }
            foreach (var item in _odabranaUtakmica.sastav)
            {
                frmUtakmicaSastavKartica_detaljiUtakmice pozvaniIgrac = new frmUtakmicaSastavKartica_detaljiUtakmice(snackbar);
                pozvaniIgrac.igracSlika = byteToImage.ConvertByteToImage(item.igrac.korisnik.Slika);
                pozvaniIgrac.igracPozicija = item.pozicija.skracenica;
                pozvaniIgrac.igracImePrezime = item.igrac.korisnik.ime[0] + ". " + item.igrac.korisnik.prezime;
                pozvaniIgrac.brojDresa = "#" + item.igrac.brojDresa.ToString();
                pozvaniIgrac.igracId = item.igracId;
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
