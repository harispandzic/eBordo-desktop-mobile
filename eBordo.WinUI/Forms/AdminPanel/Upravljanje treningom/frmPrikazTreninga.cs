using eBordo.Model.Requests.Trening;
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

namespace eBordo.WinUI.Forms.AdminPanel.Upravljanje_treningom
{
    public partial class frmPrikazTreninga : UserControl
    {
        private readonly ApiService.ApiService _treningApi = new ApiService.ApiService("Trening");
        private List<Model.Models.Trening> _podaci;
        ByteToImage byteToImage = new ByteToImage();

        public frmPrikazTreninga()
        {
            InitializeComponent();
        }

        private async void frmPrikazTreninga_Load(object sender, EventArgs e)
        {
            await LoadTrening();
            UcitajBrojTreninga();
            checkBoxZavrseniTreninzi.Checked = false;
            cmbLokacija.Items.Add("Stadion");
            cmbLokacija.Items.Add("Trening_centar");
        }
        public async Task LoadTrening(string lokacijaTreninga="",bool zavrsen = false, TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            TreningSearchObject search = new TreningSearchObject
            {
                lokacijaTreninga = lokacijaTreninga,
                zavrsen = zavrsen
            };

            try
            {
                pnlUtakmiceWrapper.Controls.Clear();

                _podaci = await _treningApi.GetAll<List<Model.Models.Trening>>(search);
                loader.Hide();
                gifLoader.Hide();

                frmTreningKartica[] listItems = new frmTreningKartica[_podaci.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmTreningKartica(this, snackbar);
                    listItems[i].treningID = _podaci[i].treningID;
                    listItems[i].datumOdrzavanja = _podaci[i].datumOdrzavanja;
                    listItems[i].satnica = _podaci[i].satnica;
                    listItems[i].fokusTreninga = _podaci[i].fokusTreninga;
                    listItems[i].isOdradjen = _podaci[i].isOdradjen;
                    listItems[i].zabiljezioID = _podaci[i].treningID;
                    listItems[i].igracSlikaAvatar = byteToImage.ConvertByteToImage(_podaci[i].zabiljezio.korisnik.Slika);
                    listItems[i].igracSlikaPanel = byteToImage.ConvertByteToImage(_podaci[i].zabiljezio.SlikaPanel);
                    listItems[i].trener = _podaci[i].zabiljezio.korisnik.ime + " " + _podaci[i].zabiljezio.korisnik.prezime;
                    listItems[i].brojTreninga = "TRENING #" + (i + 1).ToString();
                    listItems[i].trajanjeTrenera = _podaci[i].trajanje.ToString() + "h";

                    if(_podaci[i].lokacija == "Stadion")
                    {
                        listItems[i].treningLokacija = Properties.Resources.eBordo_stadion_white;
                        listItems[i].lokacija = "STADION KOŠEVO";
                    }
                    else
                    {
                        listItems[i].treningLokacija = Properties.Resources.eBordo_TC;
                        listItems[i].lokacija = "TRENING CENTAR BUTMIR";
                    }

                    if (_podaci[i].datumOdrzavanja.Date == DateTime.Now.Date)
                    {
                        listItems[i].brojDanaString = "DANAS";
                    }
                    else if (_podaci[i].datumOdrzavanja.Date < DateTime.Now.Date)
                    {
                        listItems[i].brojDanaString = "ZAVRŠEN PRIJE " + (DateTime.Now.Date - _podaci[i].datumOdrzavanja.Date).TotalDays + " DANA";
                    }
                    else
                    {
                        listItems[i].brojDanaString = "ZA " + (_podaci[i].datumOdrzavanja.Date - DateTime.Now.Date).TotalDays + " DANA";
                    }
                    pnlUtakmiceWrapper.Controls.Add(listItems[i]);
                }
                loaderBrojIgraca.Hide();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        public void UcitajBrojTreninga()
        {
            txtBrojTreninga.Text = pnlUtakmiceWrapper.Controls.Count.ToString();
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
            frmUpsertTrening insertTrening = new frmUpsertTrening(this, null);
            insertTrening.Show();
        }

        private void btnSaveIgracSastav_Click(object sender, EventArgs e)
        {
            frmUpsertTrening insertTrening = new frmUpsertTrening(this, null);
            insertTrening.Show();
        }

        private async void cmbLokacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLokacija.SelectedIndex == 0)
            {
                await LoadTrening(lokacijaTreninga: "Stadion");
            }
            else
            {
                await LoadTrening(lokacijaTreninga: "Trening_centar");
            }
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            cmbLokacija.Text = "Lokacija treninga";
            await LoadTrening();
        }

        private async void checkBoxZavrseniTreninzi_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkBoxZavrseniTreninzi.Checked)
            {
                await LoadTrening(zavrsen:true);
            }
            else
            {
                await LoadTrening(zavrsen: false);
            }
        }
    }
}
