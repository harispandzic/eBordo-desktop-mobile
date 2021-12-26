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
        }
        public async Task LoadTrening(string lokacijaTreninga="",TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            TreningSearchObject search = new TreningSearchObject
            {
                lokacijaTreninga = lokacijaTreninga
            };

            try
            {
                pnlUtakmiceWrapper.Controls.Clear();

                _podaci = await _treningApi.GetAll<List<Model.Models.Trening>>(search);
                loader.Hide();

                frmTreningKartica[] listItems = new frmTreningKartica[_podaci.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmTreningKartica(this, snackbar);
                    listItems[i].treningID = _podaci[i].treningID;
                    listItems[i].datumOdrzavanja = _podaci[i].datumOdrzavanja;
                    listItems[i].satnica = _podaci[i].satnica;
                    listItems[i].lokacija = _podaci[i].lokacija;
                    listItems[i].fokusTreninga = _podaci[i].fokusTreninga;
                    listItems[i].isOdradjen = _podaci[i].isOdradjen;
                    listItems[i].zabiljezioID = _podaci[i].treningID;
                    listItems[i].igracSlika = byteToImage.ConvertByteToImage(_podaci[i].zabiljezio.korisnik.Slika);
                    listItems[i].igracPrezimeBrojDresa = _podaci[i].zabiljezio.korisnik.ime + " " + _podaci[i].zabiljezio.korisnik.prezime;

                    pnlUtakmiceWrapper.Controls.Add(listItems[i]);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
            frmUpsertTrening insertTrening = new frmUpsertTrening(this, null);
            insertTrening.Show();
        }
    }
}
