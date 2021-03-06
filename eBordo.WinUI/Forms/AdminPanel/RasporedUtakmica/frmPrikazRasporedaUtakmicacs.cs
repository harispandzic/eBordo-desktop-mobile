using eBordo.Model.Requests.Utakmica;
using eBordo.WinUI.Helper;
using eBordo.WinUI.Reports;
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
    public partial class frmPrikazRasporedaUtakmicacs : UserControl
    {
        private readonly ApiService.ApiService _utakmice = new ApiService.ApiService("Utakmica");
        private List<Model.Models.Utakmica> _podaci;
        ByteToImage byteToImage = new ByteToImage();

        int brojPonavljanja = 0;

        public frmPrikazRasporedaUtakmicacs()
        {
            InitializeComponent();
        }

        private async void frmPrikazRasporedaUtakmicacs_Load(object sender, EventArgs e)
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
            await LoadUtakmice();
            cmbPozicije.Items.Add("Domaća");
            cmbPozicije.Items.Add("Gostujuća");
        }
        public async Task LoadUtakmice(string tipUtakmice = "", TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            UtakmicaSearchObject search = new UtakmicaSearchObject
            {
                tipUtakmice = tipUtakmice,
                odigrana = false
            };

            try
            {
                pnlUtakmiceWrapper.Controls.Clear();

                _podaci = await _utakmice.GetAll<List<Model.Models.Utakmica>>(search);
                loader.Hide();
                gifLoader.Hide();


                if (_podaci.Count == 0)
                {
                    if (brojPonavljanja < 1)
                    {
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.NEMA_PODATAKA);
                    }
                    noSearchResults.Show();
                    noSearchResultsText.Show();
                    txtNemaRezultataOpis.Show();
                    brojPonavljanja++;
                }
                else
                {
                    noSearchResults.Hide();
                    noSearchResultsText.Hide();
                    txtNemaRezultataOpis.Hide();
                }

                frmUtakmicaKartica[] listItems = new frmUtakmicaKartica[_podaci.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmUtakmicaKartica(this, snackbar);
                    listItems[i].utakmicaId = _podaci[i].utakmicaId;
                    if(_podaci[i].vrstaUtakmice == "Domaća")
                    {
                        listItems[i].domacin = "FK Sarajevo".ToUpper();
                        listItems[i].grbDomacina = Properties.Resources.grbSarajevo;
                        listItems[i].tipUtakmice = Properties.Resources.home;
                        listItems[i].gost = _podaci[i].protivnik.nazivKluba.ToUpper();
                        listItems[i].grbGostiju = byteToImage.ConvertByteToImage(_podaci[i].protivnik.grb);
                    }
                    else if(_podaci[i].vrstaUtakmice == "Gostujuća")
                    {
                        listItems[i].domacin = _podaci[i].protivnik.nazivKluba.ToUpper();
                        listItems[i].grbDomacina = byteToImage.ConvertByteToImage(_podaci[i].protivnik.grb);
                        listItems[i].tipUtakmice = Properties.Resources.away;
                        listItems[i].gost = "FK Sarajevo".ToUpper();
                        listItems[i].grbGostiju = Properties.Resources.grbSarajevo;
                    }
                    if (_podaci[i].tipGarniture == "Domaća")
                    {
                        listItems[i].dres = Properties.Resources.domaci;
                    }
                    else if (_podaci[i].tipGarniture == "Gostujuća")
                    {
                        listItems[i].dres = Properties.Resources.gostujuci;
                    }
                    else if (_podaci[i].tipGarniture == "Rezervna")
                    {
                        listItems[i].dres = Properties.Resources.rezervni;
                    }
                    listItems[i].utakmicaOpis = _podaci[i].opisUtakmice.ToUpper();
                    listItems[i].datum = _podaci[i].datumOdigravanja.ToString("dd.MM.yyyy"); ;
                    listItems[i].satnica = _podaci[i].satnica + " h";
                    listItems[i].stadion = "STADION " + _podaci[i].stadion.nazivStadiona.ToUpper();
                    listItems[i].logoTakmicenja = byteToImage.ConvertByteToImage(_podaci[i].takmicenje.logo);
                    if (_podaci[i].datumOdigravanja.Date == DateTime.Now.Date)
                    {
                        listItems[i].brojDanaDoUtakmice = "DANAS";
                    }
                    else if(_podaci[i].datumOdigravanja.Date < DateTime.Now.Date)
                    {
                        listItems[i].brojDanaDoUtakmice = "ZAVRŠENA PRIJE " + (DateTime.Now.Date - _podaci[i].datumOdigravanja.Date.Date).TotalDays + " DANA";
                    }
                    else
                    {
                        listItems[i].brojDanaDoUtakmice = "ZA " + (_podaci[i].datumOdigravanja.Date.Date - DateTime.Now.Date).TotalDays + " DANA";
                    }
                    if(_podaci[i].sastav.Count() != 20)
                    {
                        listItems[i].statusSlika = Properties.Resources.eBordo_inProgress;
                        listItems[i].statusText = "IN PROGRESS";

                    }
                    else
                    {
                        listItems[i].statusSlika = Properties.Resources.eBordo_success_notification;
                        listItems[i].statusText = "SASTAV ODABRAN";
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
            frmUpsertUtakmica insert = new frmUpsertUtakmica(null, this);
            insert.Show();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbPozicije.Text = "Pozicija";
            await LoadUtakmice();
        }

        private async void cmbPozicije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPozicije.SelectedIndex == 0)
            {
                await LoadUtakmice(tipUtakmice: "Domaća");
            }
            else
            {
                await LoadUtakmice(tipUtakmice: "Gostujuća");
            }
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            cmbPozicije.Text = "Pozicija";
            await LoadUtakmice();
        }

        private void btnSaveIgracSastav_Click(object sender, EventArgs e)
        {
            frmUpsertUtakmica insert = new frmUpsertUtakmica(null, this);
            insert.Show();
        }
        private void UcitajBrojUtakmica()
        {
            txtBrojUtakmica.Text = pnlUtakmiceWrapper.Controls.Count.ToString();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            frmReportPregled pregledIzvjestaja = new frmReportPregled(null, null, null, _podaci, null,null,null, null, null);
            pregledIzvjestaja.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            frmReportPregled pregledIzvjestaja = new frmReportPregled(null, null, null, _podaci, null,null,null, null, null);
            pregledIzvjestaja.Show();
        }
    }
}
