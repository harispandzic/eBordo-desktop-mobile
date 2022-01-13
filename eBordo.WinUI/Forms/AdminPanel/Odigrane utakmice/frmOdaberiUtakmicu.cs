using eBordo.Model.Requests.Utakmica;
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
    public partial class frmOdaberiUtakmicu : Form
    {
        private readonly ApiService.ApiService _utakmica = new ApiService.ApiService("Utakmica");
        private List<Model.Models.Utakmica> _utakmice;
        frmPrikazOdigranihUtakmica _prikazUtakmica;

        bool isOdaberiUtakmicaValidated = false;

        public frmOdaberiUtakmicu(frmPrikazOdigranihUtakmica prikazUtakmica)
        {
            InitializeComponent();
            _prikazUtakmica = prikazUtakmica;
        }

        private async void frmOdaberiUtakmicu_Load(object sender, EventArgs e)
        {
            await LoadUtakmice();
        }
        private async Task LoadUtakmice()
        {
            try
            {
                UtakmicaSearchObject search = new UtakmicaSearchObject
                {
                    tipUtakmice = "",
                    odigrana = false
                };

                _utakmice = await _utakmica.GetAll<List<Model.Models.Utakmica>>(search);

                if(_utakmice.Count() != 0)
                {
                    foreach (var item in _utakmice)
                    {
                        if (item.vrstaUtakmice == "Domaća")
                        {
                            cmbUtakmica.Items.Add("FK Sarajevo - " + item.protivnik.nazivKluba + " - " + item.datumOdigravanja.ToString("dd.MM.yyyy"));
                        }
                        else
                        {
                            cmbUtakmica.Items.Add(item.protivnik.nazivKluba + " - FK Sarajevo - " + item.datumOdigravanja.ToString("dd.MM.yyyy"));
                        }
                    }
                    cmbUtakmica.SelectedIndex = 0;
                }
                else
                {
                    cmbUtakmica.Text = "Nema utakmica!";
                    PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.BEZ_UTAKMICA);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
            frmUpsertIzvjestaj insert = new frmUpsertIzvjestaj(_utakmice[cmbUtakmica.SelectedIndex].utakmicaId, _prikazUtakmica, null);
            insert.Show();
        }

        private void btnSaveIgracSastav_Click(object sender, EventArgs e)
        {
            if(!isOdaberiUtakmicaValidated)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this, TipNotifikacije.BEZ_UTAKMICA);
                return;
            }
            frmUpsertIzvjestaj insert = new frmUpsertIzvjestaj(_utakmice[cmbUtakmica.SelectedIndex].utakmicaId, _prikazUtakmica, null);
            this.Hide();
            insert.Show();
        }

        private void cmbUtakmica_SelectedIndexChanged(object sender, EventArgs e)
        {
            isOdaberiUtakmicaValidated = Validacija.ValidirajDropDown(cmbUtakmica, "Utakmica", txtOdaberiUtakmicuValidator, pictureOdaberiUtakmicuValidator);
        }
    }
}
