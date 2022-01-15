using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using eBordo.WinUI.Helper;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica
{
    public partial class frmPozvaniIgracKartica : UserControl
    {
        private readonly ApiService.ApiService _igracApi = new ApiService.ApiService("Igrac");

        private List<Model.Models.Igrac> _igraci;
        private List<Model.Models.Pozicija> _pozicije;

        public int utakmicaSastavid { get; set; }
        public int igracId { get; set; }
        public int pozicijaId { get; set; }
        public string sastavUloga { get; set; }
        public Image igracSlika { get; set; }
        public string igracPrezime { get; set; }
        public string igracPozicija { get; set; }
        public string brojDresa { get; set; }

        frmUpsertUtakmica _upsertUtakmica;
        FlowLayoutPanel _flowPanelPrvaPostava;
        FlowLayoutPanel _flowPanelKlupa;
        BunifuDropdown _cmbIgraci;
        BunifuDropdown _cmbPozicije;
        BunifuRadioButton _radioBtnPrvihXI;
        BunifuRadioButton _radioBtnKlupa;
        bool _isUredjivanjeUtakmice;
        BunifuSnackbar _snackbar;
        BunifuButton _saveButton;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public frmPozvaniIgracKartica(frmUpsertUtakmica upsertUtakmica, FlowLayoutPanel flowPanelPrvaPostava, FlowLayoutPanel flowPanelKlupa, List<Model.Models.Igrac> igraci, BunifuDropdown cmbIgraci, List<Model.Models.Pozicija> pozicije, BunifuDropdown cmbPozicije,BunifuRadioButton radioBtnPrvihXI, BunifuRadioButton radioBtnKlupa, bool isUredjivanjeUtakmice, BunifuSnackbar snackbar, BunifuButton saveButton)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 270, 35, 8, 8));
            InitializeComponent();
            _upsertUtakmica = upsertUtakmica;
            _flowPanelPrvaPostava = flowPanelPrvaPostava;
            _cmbIgraci = cmbIgraci;
            _igraci = igraci;
            _cmbPozicije = cmbPozicije;
            _pozicije = pozicije;
            _radioBtnPrvihXI = radioBtnPrvihXI;
            _radioBtnKlupa = radioBtnKlupa;
            _flowPanelKlupa = flowPanelKlupa;
            _isUredjivanjeUtakmice = isUredjivanjeUtakmice;
            _snackbar = snackbar;
            _saveButton = saveButton;
        }

        private void frmPozvaniIgracKartica_Load(object sender, EventArgs e)
        {
            pictureIgracSlika.Image = igracSlika;
            lblImePrezimeBrojDresa.Text = igracPrezime;
            lblPozicija.Text = igracPozicija;
            txtBrojDresa.Text = brojDresa;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if(sastavUloga == "PRVA_POSTAVA")
            {
                for (int i = 0; i < _flowPanelPrvaPostava.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)_flowPanelPrvaPostava.Controls[i];
                    if (control.igracId == this.igracId)
                    {
                        _flowPanelPrvaPostava.Controls.Remove(control);
                        if (utakmicaSastavid != 0)
                        {
                            await $"{Properties.Settings.Default.ApiURL}{"UtakmicaSastav"}/{control.utakmicaSastavid}".WithBasicAuth(ApiService.ApiService.username, ApiService.ApiService.password).DeleteAsync().ReceiveJson<Model.Models.UtakmicaSastav>();
                        }
                    }
                }
            }
            else if (sastavUloga == "KLUPA")
            {
                for (int i = 0; i < _flowPanelKlupa.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)_flowPanelKlupa.Controls[i];
                    if (control.igracId == this.igracId)
                    {
                        _flowPanelKlupa.Controls.Remove(control);
                        if (utakmicaSastavid != 0)
                        {
                            try
                            {
                                await $"{Properties.Settings.Default.ApiURL}{"UtakmicaSastav"}/{control.utakmicaSastavid}".WithBasicAuth(ApiService.ApiService.username, ApiService.ApiService.password).DeleteAsync().ReceiveJson<Model.Models.UtakmicaSastav>();
                            }
                            catch
                            {
                                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
                            }
                        }
                    }
                }
            }
            _upsertUtakmica.UpdateBrojEvidentiranih();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIgrac = 0;
            for (int i = 0; i < _igraci.Count; i++)
            {
                if (_igraci[i].igracId == igracId)
                {
                    selectedIgrac = i;
                }
            }

            int selectedPozicija = 0;
            for (int i = 0; i < _pozicije.Count; i++)
            {
                if (_pozicije[i].pozicijaId == pozicijaId)
                {
                    selectedPozicija = i;
                }
            }
            _cmbPozicije.SelectedIndex = selectedPozicija;
            _cmbIgraci.SelectedIndex = selectedIgrac;

            if (sastavUloga == "PRVA_POSTAVA")
            {
                _radioBtnPrvihXI.Checked = true;
                _radioBtnKlupa.Checked = false;

            }
            else if (sastavUloga == "KLUPA")
            {
                _radioBtnKlupa.Checked = true;
                _radioBtnPrvihXI.Checked = false;

            }
            _cmbIgraci.Enabled = false;
            _upsertUtakmica.LoadDetaljiIgraca(_igraci[selectedIgrac]);
            _saveButton.Text = "SPASI";
        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                var igrac = await _igracApi.GetById<Model.Models.Igrac>(igracId);
                frmDetaljiIgraca getById = new frmDetaljiIgraca(igrac);
                getById.Show();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(_snackbar, this.ParentForm, TipNotifikacije.GREŠKA_NA_SERVERU);
            }
            //await _upsertUtakmica.igracPodaci(igracId);
        }
    }
}
