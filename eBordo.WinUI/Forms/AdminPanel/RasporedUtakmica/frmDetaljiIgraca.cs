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
    public partial class frmDetaljiIgraca : Form
    {
        private Model.Models.Igrac _selectedIgrac;

        ByteToImage byteToImage = new ByteToImage();

        public frmDetaljiIgraca(Model.Models.Igrac selectedIgrac)
        {
            InitializeComponent();
            _selectedIgrac = selectedIgrac;
        }

        private void frmDetaljiIgraca_Load(object sender, EventArgs e)
        {
            lblBrojDresa.Text = "#" + _selectedIgrac.brojDresa.ToString();
            pictureSlikaIgraca.BackgroundImage = byteToImage.ConvertByteToImage(_selectedIgrac.korisnik.Slika);
            lblPrezime.Text = (_selectedIgrac.korisnik.ime[0] + ". " + _selectedIgrac.korisnik.prezime).ToUpper();
            pictureSlikaIgraca.BackgroundImageLayout = ImageLayout.Zoom;
            igracOcjena.Value = (int)_selectedIgrac.igracStatistika.prosjecnaOcjena;
            ratingKontrolaLopte.Value = (int)_selectedIgrac.igracSkills.kontrolaLopte;
            ratingDriblanje.Value = (int)_selectedIgrac.igracSkills.driblanje;
            ratingDodavanje.Value = (int)_selectedIgrac.igracSkills.dodavanje;
            ratingKretanje.Value = (int)_selectedIgrac.igracSkills.kretanje;
            ratingBrzina.Value = (int)_selectedIgrac.igracSkills.brzina;
            ratingSut.Value = (int)_selectedIgrac.igracSkills.sut;
            ratingSnaga.Value = (int)_selectedIgrac.igracSkills.sut;
            ratingMarkiranje.Value = (int)_selectedIgrac.igracSkills.sut;
            ratingKlizeciStart.Value = (int)_selectedIgrac.igracSkills.klizeciStart;
            ratingSkok.Value = (int)_selectedIgrac.igracSkills.skok;
            ratingOdbrana.Value = (int)_selectedIgrac.igracSkills.odbrana;
            lblBrojNastupa.Text = _selectedIgrac.igracStatistika.brojNastupa.ToString();
            lblGolovi.Text = _selectedIgrac.igracStatistika.golovi.ToString();
            lblAsistencije.Text = _selectedIgrac.igracStatistika.asistencije.ToString();
            lblZutiKartoni.Text = _selectedIgrac.igracStatistika.zutiKartoni.ToString();
            lblCrveniKartoni.Text = _selectedIgrac.igracStatistika.crveniKartoni.ToString();
        }
    }
}
