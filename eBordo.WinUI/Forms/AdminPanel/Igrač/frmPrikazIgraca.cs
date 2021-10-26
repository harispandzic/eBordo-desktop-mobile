using eBordo.Model.Requests.Igrac;
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
        public frmPrikazIgraca()
        {
            InitializeComponent();

        }
        private async void frmPrikazIgraca_Load(object sender, EventArgs e)
        {
            LoadComponents();
            await LoadIgraci();
            await LoadPozicije();
        }
        public void LoadComponents()
        {
            dgvPrikazIgraca.Columns.Add(btnView);
            btnView.Width = 28;
            btnView.HeaderText = " ";
            btnView.Name = "btnView";

            dgvPrikazIgraca.Columns.Add(btnUpdate);
            btnUpdate.Width = 28;
            btnUpdate.HeaderText = " ";
            btnUpdate.Name = "btnUpdate";

            dgvPrikazIgraca.Columns.Add(btnDelete);
            btnDelete.Width = 28;
            btnDelete.HeaderText = " ";
            btnDelete.Name = "btnDelete";

            dataLoader.BackColor = Color.Gainsboro;
            dataLoader.Show();
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

            dgvPrikazIgraca.Rows.Clear();

            IgracSearchObject search = new IgracSearchObject
            {
                ime = pretraga,
                pozicijaId = pozicijaId
            };

            try
            {
                _podaci = await _igraci.GetAll<List<Model.Models.Igrac>>(search);
                dataLoader.Hide();

                if(_podaci.Count == 0 && (pretraga != "" || pozicijaId != -1))
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.NEMA_REZULTATA_PRETRAGE);
                }
                else if(_podaci.Count == 0)
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.NEMA_PODATAKA);
                }

                dgvPrikazIgraca.AutoGenerateColumns = false;

                foreach (var item in _podaci)
                {
                    dgvPrikazIgraca.Rows.Add(new object[]
                    {
                        item.brojDresa,
                        item.korisnik.ime + " " + item.korisnik.prezime,
                        item.korisnik.drzavljanstvo.nazivDrzave,
                        item.pozicija.nazivPozicije,
                        Properties.Resources.view,
                        Properties.Resources.edit,
                        Properties.Resources.delete
                    });
                }
            }
            catch 
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }      
        private async void dgvPrikazIgraca_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    var igracId = _podaci[e.RowIndex].igracId;
                    var igrac = await _igraci.GetById<Model.Models.Igrac>(igracId);
                    frmDetaljiIgraca getById = new frmDetaljiIgraca(igrac);
                    getById.Show();
                }
                catch
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
                }
            }
            else if (e.ColumnIndex == 5)
            {
                try
                {
                    var igracId = _podaci[e.RowIndex].igracId;
                    var result = await _igraci.GetById<Model.Models.Igrac>(igracId);
                    frmUpsertIgraca update = new frmUpsertIgraca(result, this);
                    update.Show();
                }
                catch
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
                }
            }
            else if (e.ColumnIndex == 6)
            {
                try
                {
                    var igracId = _podaci[e.RowIndex].igracId;
                    var result = await _igraci.DeleteById<Model.Models.Igrac>(igracId);
                    await LoadIgraci(notifikacija: TipNotifikacije.BRISANJE);
                }
                catch
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
                }
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
            string pretraga = txtImePrezime.Text;
            await LoadIgraci(pretraga);
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Forms.AdminPanel.frmUpsertIgraca insert = new Forms.AdminPanel.frmUpsertIgraca(null, this);
            insert.Show();
        }
    }
}
