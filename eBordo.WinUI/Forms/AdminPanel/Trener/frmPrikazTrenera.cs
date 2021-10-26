
using eBordo.Model.Requests.Trener;
using eBordo.WinUI.Forms.AdminPanel.Trener;
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
    public partial class frmPrikazTrenera : UserControl
    {
        private readonly ApiService.ApiService _treneri = new ApiService.ApiService("Trener");

        private List<Model.Models.Trener> _podaci;

        DataGridViewImageColumn btnView = new DataGridViewImageColumn();
        DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
        DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();

        public frmPrikazTrenera()
        {
            InitializeComponent();
        }

        private async void frmPrikazTrenera_Load(object sender, EventArgs e)
        {
            LoadComponents();
            await LoadTreneri();
        }
        public void LoadComponents()
        {
            dgvPrikazTrenera.Columns.Add(btnView);
            btnView.Width = 28;
            btnView.HeaderText = " ";
            btnView.Name = "btnView";

            dgvPrikazTrenera.Columns.Add(btnUpdate);
            btnUpdate.Width = 28;
            btnUpdate.HeaderText = " ";
            btnUpdate.Name = "btnUpdate";

            dgvPrikazTrenera.Columns.Add(btnDelete);
            btnDelete.Width = 28;
            btnDelete.HeaderText = " ";
            btnDelete.Name = "btnDelete";

            dataLoader.BackColor = Color.Gainsboro;
            dataLoader.Show();
        }
        public async Task LoadTreneri(string pretraga = "", TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if(notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            dgvPrikazTrenera.Rows.Clear();

            TrenerSearchObject search = new TrenerSearchObject
            {
                ime = pretraga,
            };

            try
            {
                _podaci = await _treneri.GetAll<List<Model.Models.Trener>>(search);

                dataLoader.Hide();

                if (_podaci.Count == 0 && (pretraga != ""))
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.NEMA_REZULTATA_PRETRAGE);
                }
                else if (_podaci.Count == 0)
                {
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.NEMA_PODATAKA);
                }

                dgvPrikazTrenera.AutoGenerateColumns = false;

                foreach (var item in _podaci)
                {
                    dgvPrikazTrenera.Rows.Add(new object[]
                    {
                        item.korisnik.ime + " " + item.korisnik.prezime,
                        item.korisnik.drzavljanstvo.nazivDrzave,
                        item.trenerskaLicenca.nazivLicence,
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

        private void btnDodajTrenera_Click(object sender, EventArgs e)
        {
            Forms.AdminPanel.Trener.frmUpsertTrenera insert = new Forms.AdminPanel.Trener.frmUpsertTrenera(null, this);
            insert.Show();
        }

        private async void dgvPrikazTrenera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.ColumnIndex == 3)
                {
                    try
                    {
                        var trenerId = _podaci[e.RowIndex].trenerId;
                        var trener = await _treneri.GetById<Model.Models.Trener>(trenerId);
                        frmDetaljiTrenera getById = new frmDetaljiTrenera(trener);
                        getById.Show();
                    }
                    catch 
                    {
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    try
                    {
                        var trenerId = _podaci[e.RowIndex].trenerId;
                        var result = await _treneri.GetById<Model.Models.Trener>(trenerId);
                        frmUpsertTrenera update = new frmUpsertTrenera(result, this);
                        update.Show();
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
                        var trenerId = _podaci[e.RowIndex].trenerId;
                        var result = await _treneri.DeleteById<Model.Models.Trener>(trenerId);
                        await LoadTreneri(notifikacija: TipNotifikacije.BRISANJE);
                    }
                    catch 
                    {
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
                    }
                }
            }
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            string pretraga = txtImePrezime.Text;
            await LoadTreneri(pretraga);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtImePrezime.Text = "";
            await LoadTreneri();
        }
    }
}
