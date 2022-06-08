using Bunifu.UI.WinForms;
using eBordo.Model.Requests.Igrac;
using eBordo.Model.Requests.Izvjestaj;
using eBordo.Model.Requests.Notifikacija;
using eBordo.Model.Requests.Trener;
using eBordo.Model.Requests.Trening;
using eBordo.Model.Requests.Utakmica;
using eBordo.WinUI.Forms.Notifikacije;
using eBordo.WinUI.Forms.Notifikacije;
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

namespace eBordo.WinUI.Forms.AdminPanel.Početna
{
    public partial class frmPočetna : UserControl
    {
        private readonly ApiService.ApiService _notifikacijaApi = new ApiService.ApiService("Notifikacija");
        private readonly ApiService.ApiService _utakmicaApi = new ApiService.ApiService("Utakmica");
        private readonly ApiService.ApiService _treningApi = new ApiService.ApiService("Trening");
        private readonly ApiService.ApiService _izvjestsajApi = new ApiService.ApiService("Izvjestaj");
        private readonly ApiService.ApiService _igracApi = new ApiService.ApiService("Igrac");
        private readonly ApiService.ApiService _trenerApi = new ApiService.ApiService("Trener");

        private List<Model.Models.Notifikacija> _podaciNotifikacija;
        private List<Model.Models.Utakmica> _podaciUtakmiceTop3;
        private List<Model.Models.Trening> _podaciTreningTop3;

        private List<Model.Models.Utakmica> _narednaUtakmica;
        private List<Model.Models.Izvjestaj> _zadnjaUtakmica;

        ByteToImage byteToImage = new ByteToImage();

        public frmPočetna()
        {
            InitializeComponent();
        }

        private async void frmPočetna_Load(object sender, EventArgs e)
        {
            await LoadPodaci();
            pictureSlika.Image = byteToImage.ConvertByteToImage(ApiService.ApiService.logovaniKorisnik.Slika);
            label3.Text = ApiService.ApiService.logovaniKorisnik.ime + " " + ApiService.ApiService.logovaniKorisnik.prezime + ", dobrodošao na eBordo!";
        }
        private async Task LoadPodaci()
        {
            btnSaveIgracSastav.Hide();
            await LoadNarednaUtakmica();
            await LoadZadnjaUtakmica();
            await LoadTop3Utakmice();
            await LoadTreningTop3();
            await LoadNotifikacije();
            await LoadBrojKorisnika();
            await LoadStatistika();
            loaderPocetna.Hide();
            loaderPocetna.Hide();
            panelPocetna.Hide();
            btnSaveIgracSastav.Show();
        }
        public async Task LoadStatistika()
        {
            int pobjede = 0, nerjsene = 0, porazi = 0;
            IzvjestajSearchObject searchPobjeda = new IzvjestajSearchObject
            {
                tipUtakmice = "",
                rezultat = ""
            };

            try
            {
                var _sveUtakmice = await _izvjestsajApi.GetAll<List<Model.Models.Izvjestaj>>(searchPobjeda);
                foreach (var item in _sveUtakmice)
                {
                    if (item.rezultat == Model.Models.Rezultat.POBJEDA)
                    {
                        pobjede++;
                    }
                    else if (item.rezultat == Model.Models.Rezultat.PORAZ)
                    {
                        porazi++;
                    }
                    else if (item.rezultat == Model.Models.Rezultat.NERJEŠENO)
                    {
                        nerjsene++;
                    }
                }
                txtPobjede.Text = pobjede.ToString();
                txtPorazi.Text = porazi.ToString();
                txtNerjesene.Text = nerjsene.ToString();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        public async Task LoadBrojKorisnika()
        {
            IgracSearchObject search = new IgracSearchObject
            {
                ime = "",
                pozicijaId = -1,
                isAktivan = true
            };

            try
            {
                var igraci = await _igracApi.GetAll<List<Model.Models.Igrac>>(search);
                //txtAktivniIgraci.Text = igraci.Count().ToString();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }

            TrenerSearchObject searchTrener = new TrenerSearchObject
            {
                ime = "",
                isAktivan = true
            };

            try
            {

                var igraci = await _trenerApi.GetAll<List<Model.Models.Trener>>(searchTrener);
                //txtAktivniTreneri.Text = igraci.Count().ToString();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        public async Task LoadZadnjaUtakmica()
        {
            IzvjestajSearchObject search = new IzvjestajSearchObject
            {
                isSearchZadnjaUtakmica = true
            };

            try
            {
                _zadnjaUtakmica = await _izvjestsajApi.GetAll<List<Model.Models.Izvjestaj>>(search);

                if (_zadnjaUtakmica.Count > 0)
                {
                    if (_zadnjaUtakmica[0].utakmica.vrstaUtakmice == "Domaća")
                    {
                        grbDomacinZadnjaUtakmica.BackgroundImage = Properties.Resources.grbSarajevo;
                        grbDomacinZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        grbGostZadnjaUtakmica.BackgroundImage = byteToImage.ConvertByteToImage(_zadnjaUtakmica[0].utakmica.protivnik.grb);
                        grbGostZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        //pictureDomacaGostujucaZadnjaUtakmica.BackgroundImage = Properties.Resources.home;
                        //pictureDomacaGostujucaZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        txtRezultat.Text = _zadnjaUtakmica[0].goloviSarajevo.ToString() + " : " + _zadnjaUtakmica[0].goloviProtivnik.ToString();
                    }
                    else if (_zadnjaUtakmica[0].utakmica.vrstaUtakmice == "Gostujuća")
                    {
                        grbGostZadnjaUtakmica.BackgroundImage = Properties.Resources.grbSarajevo;
                        grbGostZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        grbDomacinZadnjaUtakmica.BackgroundImage = byteToImage.ConvertByteToImage(_zadnjaUtakmica[0].utakmica.protivnik.grb);
                        grbDomacinZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        //pictureDomacaGostujucaZadnjaUtakmica.BackgroundImage = Properties.Resources.away;
                        //pictureDomacaGostujucaZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        txtRezultat.Text = _zadnjaUtakmica[0].goloviProtivnik.ToString() + " : " + _zadnjaUtakmica[0].goloviSarajevo.ToString();
                    }
                    if (_zadnjaUtakmica[0].goloviSarajevo > _zadnjaUtakmica[0].goloviProtivnik)
                    {
                        pictureRezultatZadnjaUtakmica.BackgroundImage = Properties.Resources.eBordo_success_notification;
                        pictureRezultatZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    else if (_zadnjaUtakmica[0].goloviSarajevo < _zadnjaUtakmica[0].goloviProtivnik)
                    {
                        pictureRezultatZadnjaUtakmica.BackgroundImage = Properties.Resources.eBordo_error_notification;
                        pictureRezultatZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    else if (_zadnjaUtakmica[0].goloviSarajevo == _zadnjaUtakmica[0].goloviProtivnik)
                    {
                        pictureRezultatZadnjaUtakmica.BackgroundImage = Properties.Resources.eBordo_nerjeseno;
                        pictureRezultatZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    txtDatumZadnjaUtakmica.Text = _zadnjaUtakmica[0].utakmica.datumOdigravanja.ToString("dd.MM.yyyy") + " u " + _zadnjaUtakmica[0].utakmica.satnica + " h";
                    if (_zadnjaUtakmica[0].utakmica.datumOdigravanja.Date == DateTime.Now.Date)
                    {
                        txtPrijeDanaZadnjaUtakmica.Text = "DANAS";
                    }
                    else
                    {
                        txtPrijeDanaZadnjaUtakmica.Text = "prije " + (DateTime.Now.Date - _zadnjaUtakmica[0].utakmica.datumOdigravanja.Date).TotalDays + " dana";
                    }
                    pictureTakmicenjeZadnjaUtakmica.BackgroundImage = byteToImage.ConvertByteToImage(_zadnjaUtakmica[0].utakmica.takmicenje.logo);
                    pictureTakmicenjeZadnjaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        public async Task LoadNarednaUtakmica()
        {
            UtakmicaSearchObject search = new UtakmicaSearchObject
            {
                isNarednaUtakmica = true
            };

            try
            {
                _narednaUtakmica = await _utakmicaApi.GetAll<List<Model.Models.Utakmica>>(search);

                if (_narednaUtakmica.Count > 0)
                {
                    if (_narednaUtakmica[0].vrstaUtakmice == "Domaća")
                    {
                        grbDomacinNarednaUtakmica.BackgroundImage = Properties.Resources.grbSarajevo;
                        grbDomacinNarednaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        grbGostNarednaUtakmica.BackgroundImage = byteToImage.ConvertByteToImage(_narednaUtakmica[0].protivnik.grb);
                        grbGostNarednaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        //pictureDomacaGostujucaNarednaUtakmica.BackgroundImage = Properties.Resources.home;
                        //pictureDomacaGostujucaNarednaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    else if (_narednaUtakmica[0].vrstaUtakmice == "Gostujuća")
                    {
                        grbGostNarednaUtakmica.BackgroundImage = Properties.Resources.grbSarajevo;
                        grbGostNarednaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        grbDomacinNarednaUtakmica.BackgroundImage = byteToImage.ConvertByteToImage(_narednaUtakmica[0].protivnik.grb);
                        grbDomacinNarednaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                        //pictureDomacaGostujucaNarednaUtakmica.BackgroundImage = Properties.Resources.away;
                        //pictureDomacaGostujucaNarednaUtakmica.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    txtSatnicaNaredneUtakmice.Text = _narednaUtakmica[0].datumOdigravanja.ToString("dd.MM.yyyy") + " u " + _narednaUtakmica[0].satnica + " h";
                    if (_narednaUtakmica[0].datumOdigravanja.Date == DateTime.Now.Date)
                    {
                        txtBrojDanaNaredneUtakmice.Text = "DANAS";
                    }
                    else
                    {
                        txtBrojDanaNaredneUtakmice.Text = "za " + (_narednaUtakmica[0].datumOdigravanja.Date - DateTime.Now.Date).TotalDays + " dana";
                    }
                    txtOpisNaredneUtakmice.Text = _narednaUtakmica[0].opisUtakmice;
                    pictureTakmicenje.BackgroundImage = byteToImage.ConvertByteToImage(_narednaUtakmica[0].takmicenje.logo);
                    pictureTakmicenje.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        public async Task LoadNotifikacije(TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            NotifikacijaSearchObject search = new NotifikacijaSearchObject
            {
                korisnikId = 1
            };

            try
            {
                pnlPrikazNotifikacija.Controls.Clear();

                _podaciNotifikacija = await _notifikacijaApi.GetAll<List<Model.Models.Notifikacija>>(search);
                //loaderNotifikacije.Hide();

                if (_podaciNotifikacija.Count > 0)
                {
                    frmNotifikacijaKartica[] listItems = new frmNotifikacijaKartica[_podaciNotifikacija.Count];
                    for (int i = 0; i < listItems.Length; i++)
                    {
                        Image tipNotifikacije = Properties.Resources.eBordo_info_notification;
                        if (_podaciNotifikacija[i].tipNotifikacije == "Upozorenje")
                        {
                            tipNotifikacije = Properties.Resources.eBordo_warning_notification;
                        }
                        else if (_podaciNotifikacija[i].tipNotifikacije == "Greška")
                        {
                            tipNotifikacije = Properties.Resources.eBordo_error_notification;
                        }
                        else if (_podaciNotifikacija[i].tipNotifikacije == "Uspješno")
                        {
                            tipNotifikacije = Properties.Resources.eBordo_success_notification;
                        }
                        listItems[i] = new frmNotifikacijaKartica(this, snackbar);
                        listItems[i].notifikacijaId = _podaciNotifikacija[i].notifikacijaId;
                        listItems[i].tekstNotifikacije = _podaciNotifikacija[i].tekstNotifikacije;
                        listItems[i].datumNotifikacije = _podaciNotifikacija[i].datumNotifikacije;
                        listItems[i].tipNotifikacije = tipNotifikacije;

                        pnlPrikazNotifikacija.Controls.Add(listItems[i]);
                    }
                }
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        public async Task LoadTop3Utakmice()
        {
            UtakmicaSearchObject search = new UtakmicaSearchObject
            {
                isSearchTop3 = true
            };

            try
            {
                pnlLoadUtakmice.Controls.Clear();

                _podaciUtakmiceTop3 = await _utakmicaApi.GetAll<List<Model.Models.Utakmica>>(search);
                bunifuLoader1.Hide();

                if (_podaciUtakmiceTop3.Count > 0)
                {
                    frmPrikazUtakmica[] listItems = new frmPrikazUtakmica[_podaciUtakmiceTop3.Count];
                    for (int i = 0; i < listItems.Length; i++)
                    {
                        listItems[i] = new frmPrikazUtakmica();
                        listItems[i].utakmicaId = _podaciUtakmiceTop3[i].utakmicaId;
                        if (_podaciUtakmiceTop3[i].vrstaUtakmice == "Domaća")
                        {
                            listItems[i].grbDomacinProp = Properties.Resources.grbSarajevo;
                            listItems[i].domacaGostujuca = Properties.Resources.home_bordo;
                            listItems[i].grbGostProp = byteToImage.ConvertByteToImage(_podaciUtakmiceTop3[i].protivnik.grb);
                        }
                        else if (_podaciUtakmiceTop3[i].vrstaUtakmice == "Gostujuća")
                        {
                            listItems[i].grbGostProp = Properties.Resources.grbSarajevo;
                            listItems[i].domacaGostujuca = Properties.Resources.away_bordo;
                            listItems[i].grbDomacinProp = byteToImage.ConvertByteToImage(_podaciUtakmiceTop3[i].protivnik.grb);
                        }
                        listItems[i].opisUtakmice = _podaciUtakmiceTop3[i].opisUtakmice;
                        listItems[i].protivnik = _podaciUtakmiceTop3[i].protivnik.nazivKluba;
                        listItems[i].datum = _podaciUtakmiceTop3[i].datumOdigravanja;
                        listItems[i].satnica = _podaciUtakmiceTop3[i].satnica + " h";
                        listItems[i].takmicenje = byteToImage.ConvertByteToImage(_podaciUtakmiceTop3[i].takmicenje.logo);
                        pnlLoadUtakmice.Controls.Add(listItems[i]);
                    }
                }
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        public async Task LoadTreningTop3()
        {
            TreningSearchObject search = new TreningSearchObject
            {
                isSearchTop3 = true
            };

            try
            {
                flowPanelPrikazTreninga.Controls.Clear();

                _podaciTreningTop3 = await _treningApi.GetAll<List<Model.Models.Trening>>(search);
                treningLoader.Hide();

                if (_podaciTreningTop3.Count > 0)
                {
                    frmPrikazTreninga[] listItems = new frmPrikazTreninga[_podaciTreningTop3.Count];
                    for (int i = 0; i < listItems.Length; i++)
                    {
                        listItems[i] = new frmPrikazTreninga();
                        listItems[i].treningId = _podaciTreningTop3[i].treningID;
                        if (_podaciTreningTop3[i].lokacija == "Stadion")
                        {
                            listItems[i].lokacija = Properties.Resources.eBordo_stadion;
                        }
                        else
                        {
                            listItems[i].lokacija = Properties.Resources.eBordo_treningCentarBordo;
                        }
                        listItems[i].datum = _podaciTreningTop3[i].datumOdrzavanja;
                        listItems[i].satnica = _podaciTreningTop3[i].satnica + " h";
                        listItems[i].trenerSlika = byteToImage.ConvertByteToImage(_podaciTreningTop3[i].zabiljezio.korisnik.Slika);
                        listItems[i].trener = _podaciTreningTop3[i].trajanje + "h";
                        if (_podaciTreningTop3[i].datumOdrzavanja.Date == DateTime.Now.Date)
                        {
                            listItems[i].brojDana = "DANAS";
                        }
                        else
                        {
                            listItems[i].brojDana = "za " + (_podaciTreningTop3[i].datumOdrzavanja.Date - DateTime.Now.Date).TotalDays + " dana";
                        }
                        flowPanelPrikazTreninga.Controls.Add(listItems[i]);
                    }
                }
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        private void pnlBrojIgrača_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel9_Click(object sender, EventArgs e)
        {

        }

        private void notifikacijaLoader_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await LoadPodaci();
        }

        private async void btnSaveIgracSastav_Click(object sender, EventArgs e)
        {
            await LoadPodaci();
        }
    }
}
