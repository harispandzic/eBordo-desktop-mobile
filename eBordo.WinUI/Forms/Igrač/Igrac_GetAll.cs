using eBordo.Model.Requests.Igrac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.UserControls
{
    public partial class PrikazIgraca : UserControl
    {
        private readonly ApiService.ApiService _igraci = new ApiService.ApiService("Igrac");
        private readonly ApiService.ApiService _pozicija = new ApiService.ApiService("Pozicija");
        //private readonly ApiService.ApiService _korisnik = new ApiService.ApiService("Korisnik");

        private List<Model.Models.Igrac> _podaci;
        private List<Model.Models.Pozicija> _pozicije;

        DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();

        public PrikazIgraca()
        {
            InitializeComponent();
        }
        public void LoadComponents()
        {
            dgvPrikazIgraca.Columns.Add(btnView);
            btnView.HeaderText = " ";
            btnView.Text = "Pregled";
            btnView.Name = "btnView";
            btnView.UseColumnTextForButtonValue = true;

            dgvPrikazIgraca.Columns.Add(btnUpdate);
            btnUpdate.HeaderText = " ";
            btnUpdate.Text = "Uredi";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseColumnTextForButtonValue = true;

            dgvPrikazIgraca.Columns.Add(btnDelete);
            btnDelete.HeaderText = " ";
            btnDelete.Text = "Obriši";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
        }
        private async void PrikazIgraca_Load(object sender, EventArgs e)
        {
            if (ApiService.ApiService.logovaniKorisnik.isAdmin)
            {
                LoadComponents();
            }
            await LoadPozicije();
            await LoadIgraci();
        }
        private async Task LoadPozicije()
        {
            _pozicije = await _pozicija.GetAll<List<Model.Models.Pozicija>>(null);

            foreach (var item in _pozicije)
            {
                cmbPozicije.Items.Add(item.nazivPozicije);
            }
        }
        public async Task LoadIgraci(string pretraga = "", int pozicijaId = -1)
        {
            dgvPrikazIgraca.Rows.Clear();

            IgracSearchObject search = new IgracSearchObject
            {
                ime = pretraga,
                pozicijaId = pozicijaId
            };

            _podaci = await _igraci.GetAll<List<Model.Models.Igrac>>(search);

            //if(_podaci.Count == 0)
            //{
            //    MessageBox.Show("Nema rezultata pretrage!");
            //    LoadIgraci();
            //}


            dgvPrikazIgraca.AutoGenerateColumns = false;

            foreach (var item in _podaci)
            {
                dgvPrikazIgraca.Rows.Add(new object[]
                {
                    item.brojDresa,
                    item.korisnik.ime + " " + item.korisnik.prezime,
                    item.korisnik.drzavljanstvo.nazivDrzave,
                    item.pozicija.nazivPozicije,
                    btnView,
                    btnUpdate,
                    btnDelete
                });
            }
        }
        private async void dgvPrikazIgraca_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var igracId = _podaci[e.RowIndex].igracId;
                var igrac = await _igraci.GetById<Model.Models.Igrac>(igracId);
                Igrač.Igrac_GetById getById = new Igrač.Igrac_GetById(igrac);
                getById.Show();
            }
            else if (e.ColumnIndex == 5)
            {
                var igracId = _podaci[e.RowIndex].igracId;
                var result = await _igraci.GetById<Model.Models.Igrac>(igracId);
                Igrač.Igrac_Upsert update = new Igrač.Igrac_Upsert(result, this);
                update.Show();
            }
            else if (e.ColumnIndex == 6)
            {
                var igracId = _podaci[e.RowIndex].igracId;
                var result = await _igraci.DeleteById<Model.Models.Igrac>(igracId);
                MessageBox.Show("Brisanje igrača: " + result.korisnik.ime + " je uspješno");
                await LoadIgraci();
            }
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            string pretraga = txtImePrezime.Text;
            await LoadIgraci(pretraga);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtImePrezime.Text = "";
            await LoadIgraci();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Igrač.Igrac_Upsert insert = new Igrač.Igrac_Upsert(null, this);
            insert.Show();
        }


        private async  void cmbPozicije_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pozicijaId = _pozicije[cmbPozicije.SelectedIndex].pozicijaId;
            await LoadIgraci("", pozicijaId);
        }
    }
}
