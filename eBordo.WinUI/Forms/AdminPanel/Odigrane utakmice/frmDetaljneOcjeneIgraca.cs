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
    public partial class frmDetaljneOcjeneIgraca : Form
    {
        private readonly ApiService.ApiService _igraci = new ApiService.ApiService("Igrac");

        public Model.Models.Igrac _igrac { get; set; }
        public int _igracId { get; set; }
        public int _kontrolaLopte { get; set; }
        public int _driblanje { get; set; }
        public int _dodavanje { get; set; }
        public int _kretanje { get; set; }
        public int _brzina { get; set; }
        public int _sut { get; set; }
        public int _snaga { get; set; }
        public int _markiranje { get; set; }
        public int _klizeciStart { get; set; }
        public int _skok { get; set; }
        public int _odbrana { get; set; }
        public int _ocjena { get; set; }
        public string _igracKomentar { get; set; }
        int _brojMinuta { get; set; }
        int _brojGolova { get; set; }
        int _brojAsistencija { get; set; }
        int _brojZutih { get; set; }
        int _brojCrvenih { get; set; }

        ByteToImage byteToImage = new ByteToImage();

        public frmDetaljneOcjeneIgraca(int igracId, int kontrolaLopte,
                int driblanje, int dodavanje, int kretanje, int brzina,int
                sut, int snaga, int markiranje, int klizeciStart, int skok, int odbrana,string igracKomentar, int ocjena, int brojMinuta, int brojGolova, int brojAsistencija, int brojZutih, int brojCrvenih)
        {
            InitializeComponent();
            _igracId = igracId;
            _kontrolaLopte = kontrolaLopte;
            _driblanje = driblanje;
            _dodavanje = dodavanje;
            _kretanje = kretanje;
            _brzina = brzina;
            _sut = sut;
            _snaga = snaga;
            _markiranje = markiranje;
            _klizeciStart = klizeciStart;
            _skok = skok;
            _odbrana = odbrana;
            _igracKomentar = igracKomentar;
            _ocjena = ocjena;
            _brojMinuta = brojMinuta;
            _brojGolova = brojGolova;
            _brojAsistencija = brojAsistencija;
            _brojZutih = brojZutih;
            _brojCrvenih = brojCrvenih;
        }

        private async void frmDetaljneOcjeneIgraca_Load(object sender, EventArgs e)
        {
            try
            {
                _igrac = await _igraci.GetById<Model.Models.Igrac>(_igracId);
                lblBrojDresa.Text = "#" + _igrac.brojDresa.ToString();
                pictureZastava.BackgroundImage = byteToImage.ConvertByteToImage(_igrac.korisnik.drzavljanstvo.zastava);
                pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
                pictureSlikaIgraca.BackgroundImage = byteToImage.ConvertByteToImage(_igrac.slikaPanel);
                pictureSlikaIgraca.BackgroundImageLayout = ImageLayout.Zoom;
                lblPrezime.Text = (_igrac.korisnik.ime[0] + ". " + _igrac.korisnik.prezime).ToUpper();
                lblPozicija.Text = _igrac.pozicija.nazivPozicije.ToUpper();
                lblOcjena.Value = (int)_igrac.igracStatistika.prosjecnaOcjena;
                ratingKontrolaLopte.Value = _kontrolaLopte;
                ratingDriblanje.Value = _driblanje;
                ratingDodavanje.Value = _dodavanje;
                ratingKretanje.Value = _kretanje;
                ratingBrzina.Value = _brzina;
                ratingSut.Value = _sut;
                ratingSnaga.Value = _snaga;
                ratingMarkiranje.Value = _markiranje;
                ratingKlizeciStart.Value = _klizeciStart;
                ratingSkok.Value = _skok;
                ratingOdbrana.Value = _odbrana;
                ocjenaNastupa.Value = _ocjena;
                txtKomentar.Text = _igracKomentar;
                lblMinute.Text = _brojMinuta.ToString();
                lblGolovi.Text = _brojGolova.ToString();
                lblAsistencije.Text = _brojAsistencija.ToString();
                lblZutiKartoni.Text = _brojZutih.ToString();
                lblCrveniKartoni.Text = _brojCrvenih.ToString();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void lblPrezime_Click(object sender, EventArgs e)
        {

        }
    }
}
