using eBordo.Model.Requests.Igrac;
using eBordo.WinUI.Forms.AdminPanel.Igrač;
using eBordo.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel
{
    public partial class frmPrikazIgraca : UserControl
    {
        private readonly ApiService.ApiService _igraci = new ApiService.ApiService("Igrac");
        private readonly ApiService.ApiService _pozicija = new ApiService.ApiService("Pozicija");

        private List<Model.Models.Igrac> _podaci;
        private List<Model.Models.Pozicija> _pozicije;

        DataGridViewImageColumn btnView = new DataGridViewImageColumn();
        DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
        DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();

        ByteToImage byteToImage = new ByteToImage();

        public frmPrikazIgraca()
        {
            InitializeComponent();

        }
        private async void frmPrikazIgraca_Load(object sender, EventArgs e)
        {
            await LoadIgraci();
            await LoadPozicije();
        }
        private async Task LoadPozicije()
        {
            try
            {
                _pozicije = await _pozicija.GetAll<List<Model.Models.Pozicija>>(null);

                foreach (var item in _pozicije)
                {
                    cmbPozicije.Items.Add(item.nazivPozicije);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }
        
        public async Task LoadIgraci(string pretraga = "", int pozicijaId = -1,TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if(notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }


            IgracSearchObject search = new IgracSearchObject
            {
                ime = pretraga,
                pozicijaId = pozicijaId
            };

            try
            {
                _podaci = await _igraci.GetAll<List<Model.Models.Igrac>>(search);
                dataLoader.Hide();
                noSearchResult.Hide();

                pnlIgraciWrapper.Controls.Clear();

                if (_podaci.Count == 0 && (pretraga != "" || pozicijaId != -1))
                {
                    //PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.NEMA_REZULTATA_PRETRAGE);
                    noSearchResult.Show();
                    noSearchResult.BringToFront();
                }
                else if(_podaci.Count == 0)
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.NEMA_PODATAKA);
                    noSearchResult.Show();
                    noSearchResult.BringToFront();
                }

                frmIgracKartica[] listItems = new frmIgracKartica[_podaci.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmIgracKartica(snackbar, this);
                    listItems[i].slika = byteToImage.ConvertByteToImage(_podaci[i].korisnik.Slika);
                    listItems[i].igracId = _podaci[i].igracId;
                    listItems[i].imePrezime = _podaci[i].korisnik.ime + " " + _podaci[i].korisnik.prezime;
                    listItems[i].ocjena = (int)_podaci[i].igracStatistika.prosjecnaOcjena;
                    listItems[i].brojDresa = "#" + _podaci[i].brojDresa;
                    listItems[i].pozicija = _podaci[i].pozicija.nazivPozicije;
                    listItems[i].zastava = byteToImage.ConvertByteToImage(_podaci[i].korisnik.drzavljanstvo.zastava);
                    pnlIgraciWrapper.Controls.Add(listItems[i]);
                }
            }
            catch 
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        } 

        private async void cmbPozicije_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pozicijaId = _pozicije[cmbPozicije.SelectedIndex].pozicijaId;
            await LoadIgraci("", pozicijaId);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtImePrezime.Text = "";
            cmbPozicije.Text = "Pozicija";
            await LoadIgraci();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Forms.AdminPanel.frmUpsertIgraca insert = new Forms.AdminPanel.frmUpsertIgraca(null, this);
            insert.Show();
        }

        private async void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            string pretraga = txtImePrezime.Text;
            await LoadIgraci(pretraga);
        }
    }
}
