
using eBordo.Model.Requests.Trener;
using eBordo.WinUI.Forms.AdminPanel.Trener;
using eBordo.WinUI.Helper;
using eBordo.WinUI.Reports;
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

        ByteToImage byteToImage = new ByteToImage();
        int brojPonavljanja = 0;

        public frmPrikazTrenera()
        {
            InitializeComponent();
        }

        private async void frmPrikazTrenera_Load(object sender, EventArgs e)
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
            await LoadTreneri();
        }
        public async Task LoadTreneri(string pretraga = "",bool isAktivan = true, TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if(notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            TrenerSearchObject search = new TrenerSearchObject
            {
                ime = pretraga,
                isAktivan = isAktivan
            };

            try
            {
                _podaci = await _treneri.GetAll<List<Model.Models.Trener>>(search);
                dataLoader.Hide();
                noSearchResult.Hide();
                gifLoader.Hide();
                pnlTreneriWrapper.Controls.Clear();

                if (_podaci.Count == 0)
                {
                    if(brojPonavljanja < 1)
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

                frmTrenerKartica[] listItems = new frmTrenerKartica[_podaci.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmTrenerKartica(snackbar, this);
                    listItems[i].slika = byteToImage.ConvertByteToImage(_podaci[i].SlikaPanel);
                    listItems[i].trenerId = _podaci[i].trenerId;
                    listItems[i].imePrezime = _podaci[i].korisnik.ime + " " + _podaci[i].korisnik.prezime;
                    listItems[i].uloga = _podaci[i].ulogaTrenera.ToString() + " TRENER";
                    listItems[i].licenca = _podaci[i].trenerskaLicenca.nazivLicence;
                    listItems[i].isAktivan = _podaci[i].korisnik.isAktivan;
                    pnlTreneriWrapper.Controls.Add(listItems[i]);
                }
                loaderBrojIgraca.Hide();
                UcitajBrojTrenera();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
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
                    catch (Flurl.Http.FlurlHttpException ex)
                    {
                        var message = await ex.GetResponseStringAsync();
                        TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
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
                    catch (Flurl.Http.FlurlHttpException ex)
                    {
                        var message = await ex.GetResponseStringAsync();
                        TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
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
                    catch (Flurl.Http.FlurlHttpException ex)
                    {
                        var message = await ex.GetResponseStringAsync();
                        TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                        PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
                    }
                }
            }
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtImePrezime.Text = "";
            await LoadTreneri();
        }

        private async void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            string pretraga = txtImePrezime.Text;
            await LoadTreneri(pretraga);
        }

        private void btnSaveIgracSastav_Click(object sender, EventArgs e)
        {
            Forms.AdminPanel.Trener.frmUpsertTrenera insert = new Forms.AdminPanel.Trener.frmUpsertTrenera(null, this);
            insert.Show();
        }
        private void UcitajBrojTrenera()
        {
            bunifuLabel1.Text = pnlTreneriWrapper.Controls.Count.ToString();
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            txtImePrezime.Text = "";
            await LoadTreneri();
        }

        private async void checkBoxZavrseniTreninzi_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkBoxZavrseniTreninzi.Checked)
            {
                await LoadTreneri(isAktivan: true);
            }
            else
            {
                await LoadTreneri(isAktivan: false);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            frmReportPregled pregledIzvjestaja = new frmReportPregled(null, null, null, null, _podaci,null,null, null, null);
            pregledIzvjestaja.Show();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            frmReportPregled pregledIzvjestaja = new frmReportPregled(null, null, null, null, _podaci,null,null, null, null);
            pregledIzvjestaja.Show();
        }
    }
}
