using eBordo.Model.Requests.Izvještaj;
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
    public partial class frmPrikazOdigranihUtakmica : UserControl
    {
        private readonly ApiService.ApiService _izvjestaj = new ApiService.ApiService("Izvještaj");
        private List<Model.Models.Izvještaj> _podaci;
        ByteToImage byteToImage = new ByteToImage();

        public frmPrikazOdigranihUtakmica()
        {
            InitializeComponent();
        }

        private async void frmPrikazOdigranihUtakmica_Load(object sender, EventArgs e)
        {
            if (!ApiService.ApiService.logovaniKorisnik.isAdmin)
            {
                btnSaveUpdate.Hide();
                btnSaveIgracSastav.Hide();
            }
            else
            {
                bunifuButton2.Hide();
            }
            await LoadIzvještaj();
            UcitajPodatke();
        }
        public void UcitajPodatke()
        {
            cmbVrstaUtakmkce.Items.Add("Domaća");
            cmbVrstaUtakmkce.Items.Add("Gostujuća");
            cmbRezultat.Items.Add("Pobjeda");
            cmbRezultat.Items.Add("Poraz");
            cmbRezultat.Items.Add("Nerješeno");
        }
        public async Task LoadIzvještaj(string tipUtakmice = "", string rezultat = "", TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            IzvjestajSearchObject search = new IzvjestajSearchObject
            {
                tipUtakmice = tipUtakmice,
                rezultat = rezultat
            };

            try
            {
                pnlUtakmiceWrapper.Controls.Clear();

                _podaci = await _izvjestaj.GetAll<List<Model.Models.Izvještaj>>(search);
                loader.Hide();
                gifLoader.Hide();

                frmIzvjestajKartica[] listItems = new frmIzvjestajKartica[_podaci.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmIzvjestajKartica(this, snackbar);
                    listItems[i].izvjestajId = _podaci[i].izvještajId;
                    listItems[i].utakmicaId = _podaci[i].utakmicaID;
                    if (_podaci[i].utakmica.vrstaUtakmice == "Domaća")
                    {
                        listItems[i].domacin = "FK Sarajevo".ToUpper();
                        listItems[i].grbDomacina = Properties.Resources.grbSarajevo;
                        listItems[i].tipUtakmice = Properties.Resources.home;
                        listItems[i].gost = _podaci[i].utakmica.protivnik.nazivKluba.ToUpper();
                        listItems[i].grbGostiju = byteToImage.ConvertByteToImage(_podaci[i].utakmica.protivnik.grb);
                        listItems[i].goloviDomacin = _podaci[i].goloviSarajevo.ToString();
                        listItems[i].goloviGost = _podaci[i].goloviProtivnik.ToString();
                    }
                    else if (_podaci[i].utakmica.vrstaUtakmice == "Gostujuća")
                    {
                        listItems[i].domacin = _podaci[i].utakmica.protivnik.nazivKluba.ToUpper();
                        listItems[i].grbDomacina = byteToImage.ConvertByteToImage(_podaci[i].utakmica.protivnik.grb);
                        listItems[i].tipUtakmice = Properties.Resources.away;
                        listItems[i].gost = "FK Sarajevo".ToUpper();
                        listItems[i].grbGostiju = Properties.Resources.grbSarajevo;
                        listItems[i].goloviDomacin = _podaci[i].goloviProtivnik.ToString();
                        listItems[i].goloviGost = _podaci[i].goloviSarajevo.ToString();
                    }
                    if (_podaci[i].utakmica.tipGarniture == "Domaća")
                    {
                        listItems[i].dres = Properties.Resources.domaci;
                    }
                    else if (_podaci[i].utakmica.tipGarniture == "Gostujuća")
                    {
                        listItems[i].dres = Properties.Resources.gostujuci;
                    }
                    else if (_podaci[i].utakmica.tipGarniture == "Rezervna")
                    {
                        listItems[i].dres = Properties.Resources.rezervni;
                    }
                    if(_podaci[i].goloviSarajevo > _podaci[i].goloviProtivnik)
                    {
                        listItems[i].rezultat = Properties.Resources.eBordo_success_notification;
                        listItems[i].rezultatOpis = "POBJEDA";
                    }
                    else if (_podaci[i].goloviSarajevo < _podaci[i].goloviProtivnik)
                    {
                        listItems[i].rezultat = Properties.Resources.eBordo_error_notification;
                        listItems[i].rezultatOpis = "PORAZ";
                    }
                    else if (_podaci[i].goloviSarajevo == _podaci[i].goloviProtivnik)
                    {
                        listItems[i].rezultat = Properties.Resources.eBordo_nerjeseno;
                        listItems[i].rezultatOpis = "NERJEŠENO";
                    }
                    listItems[i].utakmicaOpis = _podaci[i].utakmica.opisUtakmice.ToUpper();
                    listItems[i].datum = _podaci[i].utakmica.datumOdigravanja.ToString("dd.MM.yyyy"); ;
                    listItems[i].satnica = _podaci[i].utakmica.satnica + " h";
                    listItems[i].stadion = "STADION " + _podaci[i].utakmica.stadion.nazivStadiona.ToUpper();
                    listItems[i].logoTakmicenja = byteToImage.ConvertByteToImage(_podaci[i].utakmica.takmicenje.logo);
                    if (_podaci[i].utakmica.datumOdigravanja.Date == DateTime.Now.Date)
                    {
                        listItems[i].brojDanaString = "DANAS";
                    }
                    else if (_podaci[i].utakmica.datumOdigravanja.Date < DateTime.Now.Date)
                    {
                        listItems[i].brojDanaString = "ZAVRŠENA PRIJE " + (DateTime.Now.Date - _podaci[i].utakmica.datumOdigravanja.Date.Date).TotalDays + " DANA";
                    }
                    else
                    {
                        listItems[i].brojDanaString = "ZA " + (_podaci[i].utakmica.datumOdigravanja.Date.Date - DateTime.Now.Date).TotalDays + " DANA";
                    }
                    int brojNastupa = 11 + _podaci[i].izmjene.Count();
                    if (_podaci[i].nastupi.Count() != brojNastupa)
                    {
                        listItems[i].statusSlika = Properties.Resources.eBordo_inProgress;
                        listItems[i].statusText = "IN PROGRESS";

                    }
                    else
                    {
                        listItems[i].statusSlika = Properties.Resources.eBordo_success_notification;
                        listItems[i].statusText = "ZAVRŠEN";
                    }
                    pnlUtakmiceWrapper.Controls.Add(listItems[i]);
                }
                loaderBrojIgraca.Hide();
                UcitajBrojUtakmica();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
            frmOdaberiUtakmicu odaberiUtakmicu = new frmOdaberiUtakmicu(this);
            odaberiUtakmicu.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void UcitajBrojUtakmica()
        {
            txtBrojUtakmica.Text = pnlUtakmiceWrapper.Controls.Count.ToString();
        }
        private void btnSaveIgracSastav_Click(object sender, EventArgs e)
        {
            frmOdaberiUtakmicu odaberiUtakmicu = new frmOdaberiUtakmicu(this);
            odaberiUtakmicu.Show();
        }

        private async void cmbVrstaUtakmkce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVrstaUtakmkce.SelectedIndex == 0)
            {
                await LoadIzvještaj(tipUtakmice: "Domaća");
            }
            else
            {
                await LoadIzvještaj(tipUtakmice: "Gostujuća");
            }
        }

        private async void cmbRezultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRezultat.SelectedIndex == 0)
            {
                await LoadIzvještaj(rezultat: "Pobjeda");
            }
            else if (cmbRezultat.SelectedIndex == 1)
            {
                await LoadIzvještaj(rezultat: "Poraz");
            }
            else if (cmbRezultat.SelectedIndex == 2)
            {
                await LoadIzvještaj(rezultat: "Nerješeno");
            }
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            cmbVrstaUtakmkce.Text = "Vrsta utakmice";
            cmbRezultat.Text = "Rezultat";
            await LoadIzvještaj();
        }
    }
}
