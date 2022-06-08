using eBordo.WinUI.Reports.Datasets;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace eBordo.WinUI.Reports
{
    public partial class frmReportPregled : Form
    {
        Model.Models.Igrac _odabraniIgrac;
        Model.Models.Trener _odabraniTrener;
        List<Model.Models.Igrac> _listaIgraca;
        Model.Models.Utakmica _odabranaUtakmica;
        List<Model.Models.Utakmica> _listaUtakmica;
        List<Model.Models.Trener> _listaTrenera;
        List<Model.Models.Izvjestaj> _listaRezultata;
        Model.Models.Izvjestaj _odabraniRezultat;
        List<Model.Models.Trening> _listaTreninga;

        public frmReportPregled(Model.Models.Igrac odabraniIgrac, 
            List<Model.Models.Igrac> listaIgraca,
            Model.Models.Utakmica odabranaUtakmica,
            List<Model.Models.Utakmica> listaUtakmica,
            List<Model.Models.Trener> listaTrenera,
            Model.Models.Trener odabraniTrener,
            List<Model.Models.Izvjestaj> listaRezultata,
            Model.Models.Izvjestaj odabraniRezultat,
            List<Model.Models.Trening> listaTreninga)
        {
            InitializeComponent();
            _odabraniIgrac = odabraniIgrac;
            _listaIgraca = listaIgraca;
            _odabranaUtakmica = odabranaUtakmica;
            _listaUtakmica = listaUtakmica;
            _listaTrenera = listaTrenera;
            _odabraniTrener = odabraniTrener;
            _listaRezultata = listaRezultata;
            _odabraniRezultat = odabraniRezultat;
            _listaTreninga = listaTreninga;
        }
        byte[] GetGrbSarajevo()
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\fksarajevo.png";
            Image slika = Image.FromFile(path);
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(slika, typeof(byte[]));
            return xByte;
        }
        byte[] getPutanja(int ocjena)
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\pet.png";
            if(ocjena == 0)
            {
                path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\nula.png";
            }
            if (ocjena == 1)
            {
                path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\jedan.png";
            }
            if (ocjena == 2)
            {
                path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\dva.png";
            }
            if (ocjena == 3)
            {
                path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\tri.png";
            }
            if (ocjena == 4)
            {
                path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\cetiri.png";
            };
            Image slika = Image.FromFile(path);
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(slika, typeof(byte[]));
            return xByte;
        }
        byte[] getRezultatSlika(int goloviSarajevo, int goloviProtivnik)
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\nerjeseno.png";
            if (goloviSarajevo > goloviProtivnik)
            {
                path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\pobjeda.png";
            }
            if (goloviSarajevo < goloviProtivnik)
            {
                path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Reports\\Slike\\poraz.png";
            }
            Image slika = Image.FromFile(path);
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(slika, typeof(byte[]));
            return xByte;
        }
        string getRezultat(int goloviSarajevo, int goloviProtivnik)
        {
            string rezultat = "NERJEŠENO";
            if (goloviSarajevo > goloviProtivnik)
            {
                rezultat = "POBJEDA";
            }
            if (goloviSarajevo < goloviProtivnik)
            {
                rezultat = "PORAZ";
            }
            return rezultat;
        }
        string getRazlogIzmjene(int razlog)
        {
            string razlogIzmjene = "OSTALO";
            if (razlog == 1)
            {
                razlogIzmjene = "POVREDA";
            }
            if (razlog == 2)
            {
                razlogIzmjene = "TAKTIČKI";
            }
            if (razlog == 3)
            {
                razlogIzmjene = "FORMA";
            }
            return razlogIzmjene;
        }
        private void frmReportPregled_Load(object sender, EventArgs e)
        {
            if(_odabraniIgrac != null)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptDetaljiIgraca.rdlc";
                var prikazDetalja = new dsIgrac.IgracDataTable();
                for (int i = 0; i < 1; i++)
                {
                    var red = prikazDetalja.NewIgracRow();
                    red.ImePrezime = _odabraniIgrac.korisnik.ime.ToUpper() + " " + _odabraniIgrac.korisnik.prezime.ToUpper();
                    red.BrojDresa = "#" + _odabraniIgrac.brojDresa;
                    red.Slika = _odabraniIgrac.slikaPanel;
                    red.DrzavljanstvoZastava = _odabraniIgrac.korisnik.drzavljanstvo.zastava;
                    red.Drzavljanstvo = _odabraniIgrac.korisnik.drzavljanstvo.nazivDrzave.ToUpper();
                    red.MjestoRodjenja = _odabraniIgrac.korisnik.gradRodjenja.nazivGrada.ToUpper();
                    red.DatumRodjenja = _odabraniIgrac.korisnik.datumRodjenja.ToString("dd.mm.yyyy").ToUpper();
                    red.Adresa = _odabraniIgrac.korisnik.adresa.ToUpper();
                    red.Telefon = _odabraniIgrac.korisnik.telefon.ToUpper();
                    red.Email = _odabraniIgrac.korisnik.email;
                    red.PocetakUgovora = _odabraniIgrac.ugovor.datumPocetka.ToString("dd.mm.yyyy").ToUpper();
                    red.KrajUgovora = _odabraniIgrac.ugovor.datumZavrsetka.ToString("dd.mm.yyyy").ToUpper();
                    red.Pozicija = (_odabraniIgrac.pozicija.nazivPozicije + " - " + _odabraniIgrac.pozicija.skracenica).ToUpper();
                    red.BoljaNoga = _odabraniIgrac.boljaNoga;
                    red.Visina = _odabraniIgrac.visina + " cm";
                    red.Tezina = _odabraniIgrac.tezina + " kg";
                    red.TrzisnaVrijednosot = _odabraniIgrac.trzisnaVrijednost + " €";
                    red.Napomene = _odabraniIgrac.napomeneOIgracu;
                    red.Nastupi = _odabraniIgrac.igracStatistika.brojNastupa.ToString();
                    red.Minute = (_odabraniIgrac.igracStatistika.brojNastupa * 90).ToString();
                    red.Golovi = _odabraniIgrac.igracStatistika.golovi.ToString();
                    red.Asistencije = _odabraniIgrac.igracStatistika.asistencije.ToString();
                    red.ZutiKartoni = _odabraniIgrac.igracStatistika.zutiKartoni.ToString();
                    red.CrveniKartoni = _odabraniIgrac.igracStatistika.crveniKartoni.ToString();
                    red.KontrolaLopte = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte));
                    red.KontrolaLopteBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Driblanje = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.driblanje));
                    red.DriblanjeBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Dodavanje = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.dodavanje));
                    red.DodavanjeBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Kretanje = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.kretanje));
                    red.KretanjeBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Brzina = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.brzina));
                    red.BrzinaBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Sut = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.sut));
                    red.SutBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Snaga = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.snaga));
                    red.SnagaBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Markiranje = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.markiranje));
                    red.MarkiranjeBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Klizeci = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.klizeciStart));
                    red.KlizeciBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Skok = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.skok));
                    red.SkokBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Odbrana = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.odbrana));
                    red.OdbranaBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Ocjena = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.prosjekOcjena));

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsIgracDetalji";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.RefreshReport();
            }
            if (_odabraniIgrac != null)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptDetaljiIgraca.rdlc";
                var prikazDetalja = new dsIgrac.IgracDataTable();
                for (int i = 0; i < 1; i++)
                {
                    var red = prikazDetalja.NewIgracRow();
                    red.ImePrezime = _odabraniIgrac.korisnik.ime.ToUpper() + " " + _odabraniIgrac.korisnik.prezime.ToUpper();
                    red.BrojDresa = "#" + _odabraniIgrac.brojDresa;
                    red.Slika = _odabraniIgrac.slikaPanel;
                    red.DrzavljanstvoZastava = _odabraniIgrac.korisnik.drzavljanstvo.zastava;
                    red.Drzavljanstvo = _odabraniIgrac.korisnik.drzavljanstvo.nazivDrzave.ToUpper();
                    red.MjestoRodjenja = _odabraniIgrac.korisnik.gradRodjenja.nazivGrada.ToUpper();
                    red.DatumRodjenja = _odabraniIgrac.korisnik.datumRodjenja.ToString("dd.mm.yyyy").ToUpper();
                    red.Adresa = _odabraniIgrac.korisnik.adresa.ToUpper();
                    red.Telefon = _odabraniIgrac.korisnik.telefon.ToUpper();
                    red.Email = _odabraniIgrac.korisnik.email;
                    red.PocetakUgovora = _odabraniIgrac.ugovor.datumPocetka.ToString("dd.mm.yyyy").ToUpper();
                    red.KrajUgovora = _odabraniIgrac.ugovor.datumZavrsetka.ToString("dd.mm.yyyy").ToUpper();
                    red.Pozicija = (_odabraniIgrac.pozicija.nazivPozicije + " - " + _odabraniIgrac.pozicija.skracenica).ToUpper();
                    red.BoljaNoga = _odabraniIgrac.boljaNoga;
                    red.Visina = _odabraniIgrac.visina + " cm";
                    red.Tezina = _odabraniIgrac.tezina + " kg";
                    red.TrzisnaVrijednosot = _odabraniIgrac.trzisnaVrijednost + " €";
                    red.Napomene = _odabraniIgrac.napomeneOIgracu;
                    red.Nastupi = _odabraniIgrac.igracStatistika.brojNastupa.ToString();
                    red.Minute = (_odabraniIgrac.igracStatistika.brojNastupa * 90).ToString();
                    red.Golovi = _odabraniIgrac.igracStatistika.golovi.ToString();
                    red.Asistencije = _odabraniIgrac.igracStatistika.asistencije.ToString();
                    red.ZutiKartoni = _odabraniIgrac.igracStatistika.zutiKartoni.ToString();
                    red.CrveniKartoni = _odabraniIgrac.igracStatistika.crveniKartoni.ToString();
                    red.KontrolaLopte = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte));
                    red.KontrolaLopteBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Driblanje = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.driblanje));
                    red.DriblanjeBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Dodavanje = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.dodavanje));
                    red.DodavanjeBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Kretanje = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.kretanje));
                    red.KretanjeBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Brzina = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.brzina));
                    red.BrzinaBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Sut = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.sut));
                    red.SutBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Snaga = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.snaga));
                    red.SnagaBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Markiranje = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.markiranje));
                    red.MarkiranjeBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Klizeci = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.klizeciStart));
                    red.KlizeciBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Skok = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.skok));
                    red.SkokBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Odbrana = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.odbrana));
                    red.OdbranaBroj = (int)Math.Round(_odabraniIgrac.igracSkills.kontrolaLopte);
                    red.Ocjena = getPutanja((int)Math.Round(_odabraniIgrac.igracSkills.prosjekOcjena));

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsIgracDetalji";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.RefreshReport();
            }
            if (_listaIgraca != null)
            {
                var rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("BrojZapisa", _listaIgraca.Count().ToString()));
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptPrikazIgraca.rdlc";
                var prikazDetalja = new dsIgrac.IgracDataTable();
                for (int i = 0; i < _listaIgraca.Count(); i++)
                {
                    var red = prikazDetalja.NewIgracRow();
                    red.ImePrezime = _listaIgraca[i].korisnik.ime.ToUpper() + " " + _listaIgraca[i].korisnik.prezime.ToUpper();
                    red.BrojDresa = "#" + _listaIgraca[i].brojDresa;
                    red.Drzavljanstvo = _listaIgraca[i].korisnik.drzavljanstvo.nazivDrzave.ToUpper();                 
                    red.Pozicija = (_listaIgraca[i].pozicija.nazivPozicije + " - " + _listaIgraca[i].pozicija.skracenica).ToUpper();
                    red.Starost = (DateTime.Now.Year - _listaIgraca[i].korisnik.datumRodjenja.Year).ToString();
                    red.Ocjena = getPutanja((int)Math.Round(_listaIgraca[i].igracSkills.prosjekOcjena));

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsPrikazIgraca";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(rpc);
                this.reportViewer1.RefreshReport();
            }
            if (_odabranaUtakmica != null)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptDetaljiUtakmice.rdlc";
                var prikazDetalja = new dsUtakmica.UtakmicaDataTable();
                for (int i = 0; i < 1; i++)
                {
                    var red = prikazDetalja.NewUtakmicaRow();
                    if(_odabranaUtakmica.vrstaUtakmice == "Domaća")
                    {
                        red.DomacinGrb = GetGrbSarajevo();
                        red.DomacinNaziv = "FK SARAJEVO";
                        red.GostGrb = _odabranaUtakmica.protivnik.grb;
                        red.GostNaziv = _odabranaUtakmica.protivnik.nazivKluba.ToUpper().ToString();

                    }
                    else
                    {
                        red.GostGrb = GetGrbSarajevo();
                        red.GostNaziv = "FK SARAJEVO";
                        red.DomacinGrb = _odabranaUtakmica.protivnik.grb;
                        red.DomacinNaziv = _odabranaUtakmica.protivnik.nazivKluba.ToUpper().ToString();
                    }
                    red.OpisUtakmice = _odabranaUtakmica.opisUtakmice.ToString();
                    red.Stadion = "STADION " + _odabranaUtakmica.stadion.nazivStadiona.ToUpper();
                    red.LogoTakmicenje = _odabranaUtakmica.takmicenje.logo;
                    red.Datum = _odabranaUtakmica.datumOdigravanja.ToString("dd.MM.yyyy") + " u " + _odabranaUtakmica.satnica + " h";

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsPrikazDetaljaUtakmice";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);

                var sastav = new dsSastav.NastupDataTable();
                foreach (var item in _odabranaUtakmica.sastav.Where((s) => s.uloga == "PRVA_POSTAVA"))
                {
                    var red = sastav.NewNastupRow();
                    red.BrojDresa = "#"+item.igrac.brojDresa.ToString();
                    red.ImePrezime = item.igrac.korisnik.ime + " " + item.igrac.korisnik.prezime;
                    red.Pozicija = item.pozicija.skracenica;
                    red.Ocjena = getPutanja((int)Math.Round(item.igrac.igracSkills.prosjekOcjena));
                    sastav.Rows.Add(red);
                }
                var rds1 = new ReportDataSource();
                rds1.Name = "dsSastav";
                rds1.Value = sastav;
                reportViewer1.LocalReport.DataSources.Add(rds1);

                var klupa = new dsSastav.NastupDataTable();
                foreach (var item in _odabranaUtakmica.sastav.Where((s) => s.uloga == "KLUPA"))
                {
                    var red = klupa.NewNastupRow();
                    red.BrojDresa = "#" + item.igrac.brojDresa.ToString();
                    red.ImePrezime = item.igrac.korisnik.ime + " " + item.igrac.korisnik.prezime;
                    red.Pozicija = item.pozicija.skracenica;
                    red.Ocjena = getPutanja((int)Math.Round(item.igrac.igracSkills.prosjekOcjena));
                    klupa.Rows.Add(red);
                }
                var rds2 = new ReportDataSource();
                rds2.Name = "dsKlupa";
                rds2.Value = klupa;
                reportViewer1.LocalReport.DataSources.Add(rds2);

                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.RefreshReport();
            }
            if (_listaUtakmica != null)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptPrikazUtakmica.rdlc";
                var prikazDetalja = new dsUtakmica.UtakmicaDataTable();
                for (int i = 0; i < _listaUtakmica.Count(); i++)
                {
                    var red = prikazDetalja.NewUtakmicaRow();
                    red.LogoTakmicenje = _listaUtakmica[i].takmicenje.logo;
                    red.Protivnik = _listaUtakmica[i].protivnik.grb;
                    red.OpisUtakmice = _listaUtakmica[i].opisUtakmice;
                    red.Utakmica = _listaUtakmica[i].protivnik.nazivKluba.ToUpper();
                    red.Datum = _listaUtakmica[i].datumOdigravanja.ToString("dd.mm.yyyy");
                    red.Satnica = _listaUtakmica[i].satnica + " h";
                    red.Stadion = "STADION " + _listaUtakmica[i].stadion.nazivStadiona;

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "DataSet1";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.RefreshReport();
            }
            if (_listaTrenera != null)
            {
                var rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("BrojZapisa", _listaTrenera.Count().ToString()));
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptPrikazTrenera.rdlc";
                var prikazDetalja = new dsTrener.TrenerDataTable();
                for (int i = 0; i < _listaTrenera.Count(); i++)
                {
                    var red = prikazDetalja.NewTrenerRow();
                    red.ImePrezime = _listaTrenera[i].korisnik.ime.ToUpper() + " " + _listaTrenera[i].korisnik.prezime.ToUpper();
                    red.Drzavljanstvo = _listaTrenera[i].korisnik.drzavljanstvo.nazivDrzave.ToUpper();
                    red.Uloga = _listaTrenera[i].ulogaTrenera + " TRENER";
                    red.Starost = (DateTime.Now.Year - _listaTrenera[i].korisnik.datumRodjenja.Year).ToString();
                    red.Licenca = _listaTrenera[i].trenerskaLicenca.nazivLicence;

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsPrikazTrenera";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(rpc);
                this.reportViewer1.RefreshReport();
            }
            if (_odabraniTrener != null)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptDetaljiTrenera.rdlc";
                var prikazDetalja = new dsTrener.TrenerDataTable();
                for (int i = 0; i < 1; i++)
                {
                    var red = prikazDetalja.NewTrenerRow();
                    red.ImePrezime = _odabraniTrener.korisnik.ime.ToUpper() + " " + _odabraniTrener.korisnik.prezime.ToUpper();
                    red.Slika = _odabraniTrener.SlikaPanel;
                    red.DrzavljanstvoZastava = _odabraniTrener.korisnik.drzavljanstvo.zastava;
                    red.Drzavljanstvo = _odabraniTrener.korisnik.drzavljanstvo.nazivDrzave.ToUpper();
                    red.MjestoRodjenja = _odabraniTrener.korisnik.gradRodjenja.nazivGrada.ToUpper();
                    red.DatumRodjenja = _odabraniTrener.korisnik.datumRodjenja.ToString("dd.mm.yyyy").ToUpper();
                    red.Adresa = _odabraniTrener.korisnik.adresa.ToUpper();
                    red.Telefon = _odabraniTrener.korisnik.telefon.ToUpper();
                    red.Email = _odabraniTrener.korisnik.email;
                    red.PocetakUgovora = _odabraniTrener.ugovor.datumPocetka.ToString("dd.mm.yyyy").ToUpper();
                    red.KrajUgovora = _odabraniTrener.ugovor.datumZavrsetka.ToString("dd.mm.yyyy").ToUpper();
                    red.Uloga = _odabraniTrener.ulogaTrenera + " TRENER";
                    red.Licenca = _odabraniTrener.trenerskaLicenca.nazivLicence;
                    red.Formacija = _odabraniTrener.formacija.nazivFormacije;
                    red.Nastupi = _odabraniTrener.trenerStatistika.brojUtakmica.ToString();
                    red.Pobjede = _odabraniTrener.trenerStatistika.brojPobjeda.ToString();
                    red.Porazi = _odabraniTrener.trenerStatistika.brojPoraza.ToString();
                    red.Nerješene = _odabraniTrener.trenerStatistika.brojNerjesenih.ToString();

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsTrener";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.RefreshReport();
            }
            if (_listaRezultata != null)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptPrikazRezultata.rdlc";
                var prikazDetalja = new dsIzvjestaj.IzvjestajDataTable();
                for (int i = 0; i < _listaRezultata.Count(); i++)
                {
                    var red = prikazDetalja.NewIzvjestajRow();
                    red.LogoTakmicenje = _listaRezultata[i].utakmica.takmicenje.logo;
                    red.Protivnik = _listaRezultata[i].utakmica.protivnik.grb;
                    red.OpisUtakmice = _listaRezultata[i].utakmica.opisUtakmice;
                    red.Utakmica = _listaRezultata[i].utakmica.protivnik.nazivKluba.ToUpper();
                    red.Datum = _listaRezultata[i].utakmica.datumOdigravanja.ToString("dd.mm.yyyy");
                    red.Satnica = _listaRezultata[i].utakmica.satnica + " h";
                    red.Stadion = "STADION " + _listaRezultata[i].utakmica.stadion.nazivStadiona;
                    red.Rezultat = getRezultat(_listaRezultata[i].goloviSarajevo, _listaRezultata[i].goloviProtivnik);
                    red.RezultatSlika = getRezultatSlika(_listaRezultata[i].goloviSarajevo, _listaRezultata[i].goloviProtivnik);

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsPrikazUtakmica";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.RefreshReport();
            }
            if (_odabraniRezultat != null)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptDetaljiIzvjestaja.rdlc";
                var prikazDetalja = new dsIzvjestaj.IzvjestajDataTable();
                for (int i = 0; i < 1; i++)
                {
                    var red = prikazDetalja.NewIzvjestajRow();
                    if (_odabraniRezultat.utakmica.vrstaUtakmice == "Domaća")
                    {
                        red.DomacinGrb = GetGrbSarajevo();
                        red.DomacinNaziv = "FK SARAJEVO";
                        red.GostGrb = _odabraniRezultat.utakmica.protivnik.grb;
                        red.GostNaziv = _odabraniRezultat.utakmica.protivnik.nazivKluba.ToUpper().ToString();
                        red.RezultatGolovi = _odabraniRezultat.goloviSarajevo + ":" + _odabraniRezultat.goloviProtivnik;
                    }
                    else
                    {
                        red.GostGrb = GetGrbSarajevo();
                        red.GostNaziv = "FK SARAJEVO";
                        red.DomacinGrb = _odabraniRezultat.utakmica.protivnik.grb;
                        red.DomacinNaziv = _odabraniRezultat.utakmica.protivnik.nazivKluba.ToUpper().ToString();
                        red.RezultatGolovi = _odabraniRezultat.goloviProtivnik + ":" + _odabraniRezultat.goloviSarajevo;
                    }
                    red.OpisUtakmice = _odabraniRezultat.utakmica.opisUtakmice.ToString();
                    red.Stadion = "STADION " + _odabraniRezultat.utakmica.stadion.nazivStadiona.ToUpper();
                    red.LogoTakmicenje = _odabraniRezultat.utakmica.takmicenje.logo;
                    red.Datum = _odabraniRezultat.utakmica.datumOdigravanja.ToString("dd.MM.yyyy") + " u " + _odabraniRezultat.utakmica.satnica + " h";
                    red.Rezultat = getRezultat(_odabraniRezultat.goloviSarajevo, _odabraniRezultat.goloviProtivnik);
                    red.RezultatSlika = getRezultatSlika(_odabraniRezultat.goloviSarajevo, _odabraniRezultat.goloviProtivnik);
                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsDetaljiOdigraneUtakmice";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);

                var sastav = new dsUtakmicaUcinak.IgracDataTable();
                foreach (var item in _odabraniRezultat.nastupi)
                {
                    var red = sastav.NewIgracRow();
                    red.BrojDresa = "#" + item.igrac.brojDresa.ToString();
                    red.ImePrezime = item.igrac.korisnik.ime + " " + item.igrac.korisnik.prezime;
                    red.Pozicija = item.igrac.pozicija.skracenica;
                    red.Minute = item.minute > 0 ? item.minute.ToString() : "";
                    red.Golovi = item.golovi > 0 ? item.golovi.ToString() : "";
                    red.Asistencije = item.asistencije > 0 ? item.asistencije.ToString() : "";
                    red.ZutiKartoni = item.zutiKartoni > 0 ? item.zutiKartoni.ToString() : "";
                    red.CrveniKartoni = item.crveniKartoni > 0 ? item.crveniKartoni.ToString() : "";
                    red.Ocjena = getPutanja(item.ocjena);
                    sastav.Rows.Add(red);
                }
                var rds1 = new ReportDataSource();
                rds1.Name = "dsUcinak";
                rds1.Value = sastav;
                reportViewer1.LocalReport.DataSources.Add(rds1);

                var klupa = new dsIzmjena.IzmjenaDataTable();
                foreach (var item in _odabraniRezultat.izmjene)
                {
                    var red = klupa.NewIzmjenaRow();
                    red.IgracOUT = "#" + item.igracOut.brojDresa + " - " + item.igracOut.korisnik.ime + " " + item.igracOut.korisnik.prezime;
                    red.IgracIN = "#" + item.igracIn.brojDresa + " - " + item.igracIn.korisnik.ime + " " + item.igracIn.korisnik.prezime;
                    red.Minuta = item.minuta + "'";
                    red.RazlogIzmjene = getRazlogIzmjene((int)item.izmjenaRazlog);
                    klupa.Rows.Add(red);
                }
                var rds2 = new ReportDataSource();
                rds2.Name = "dsIzmjene";
                rds2.Value = klupa;
                reportViewer1.LocalReport.DataSources.Add(rds2);

                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.RefreshReport();
            }
            if (_listaTreninga != null)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBordo.WinUI.Reports.rptPrikazTreninga.rdlc";
                var prikazDetalja = new dsTrening.TreningDataTable();
                for (int i = 0; i < _listaTreninga.Count(); i++)
                {
                    var red = prikazDetalja.NewTreningRow();
                    red.Datum = _listaTreninga[i].datumOdrzavanja.ToString("dd.mm.yyyy");
                    red.Satnica = _listaTreninga[i].satnica + "h";
                    red.Trajanje = _listaTreninga[i].trajanje + "h";
                    red.Trener = _listaTreninga[i].zabiljezio.korisnik.ime + " " + _listaTreninga[i].zabiljezio.korisnik.prezime;
                    red.Lokacija = _listaTreninga[i].lokacija;
                    red.OpisTreninga = _listaTreninga[i].fokusTreninga;

                    prikazDetalja.Rows.Add(red);
                }
                var rds = new ReportDataSource();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                rds.Name = "dsPrikazTreninga";
                rds.Value = prikazDetalja;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.RefreshReport();
            }
        }
    
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
