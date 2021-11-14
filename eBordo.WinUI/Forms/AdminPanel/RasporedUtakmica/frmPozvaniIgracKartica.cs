using Bunifu.UI.WinForms;
using eBordo.WinUI.Helper;
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
        private List<Model.Models.Igrac> _igraci;
        private List<Model.Models.Pozicija> _pozicije;

        public int igracId { get; set; }
        public int pozicijaId { get; set; }
        public string sastavUloga { get; set; }
        public Image igracSlika { get; set; }
        public string igracPrezimeBrojDresa { get; set; }
        public string igracPozicija { get; set; }

        frmUpsertUtakmica _upsertUtakmica;
        FlowLayoutPanel _flowPanelPrvaPostava;
        FlowLayoutPanel _flowPanelKlupa;
        BunifuDropdown _cmbIgraci;
        BunifuDropdown _cmbPozicije;
        BunifuRadioButton _radioBtnPrvihXI;
        BunifuRadioButton _radioBtnKlupa;
        bool _isUredjivanjeUtakmice;
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
        public frmPozvaniIgracKartica(frmUpsertUtakmica upsertUtakmica, FlowLayoutPanel flowPanelPrvaPostava, FlowLayoutPanel flowPanelKlupa, List<Model.Models.Igrac> igraci, BunifuDropdown cmbIgraci, List<Model.Models.Pozicija> pozicije, BunifuDropdown cmbPozicije,BunifuRadioButton radioBtnPrvihXI, BunifuRadioButton radioBtnKlupa, bool isUredjivanjeUtakmice)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 233, 35, 8, 8));
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
        }

        private void frmPozvaniIgracKartica_Load(object sender, EventArgs e)
        {
            pictureIgracSlika.Image = igracSlika;
            lblImePrezimeBrojDresa.Text = igracPrezimeBrojDresa;
            lblPozicija.Text = igracPozicija;
            if (_isUredjivanjeUtakmice)
            {
                btnDelete.Hide();
                btnEdit.Location = new Point(205, 8);
                btnView.Location = new Point(183, 8);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Control selectedControl;
            int igracId = 0;
            if(sastavUloga == "PRVA_POSTAVA")
            {
                for (int i = 0; i < _flowPanelPrvaPostava.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)_flowPanelPrvaPostava.Controls[i];
                    if (control.igracPrezimeBrojDresa == this.igracPrezimeBrojDresa)
                    {
                        selectedControl = control;
                        igracId = control.igracId;
                        _flowPanelPrvaPostava.Controls.Remove(control);
                    }
                }
            }
            else if (sastavUloga == "KLUPA")
            {
                for (int i = 0; i < _flowPanelKlupa.Controls.Count; i++)
                {
                    var control = (frmPozvaniIgracKartica)_flowPanelKlupa.Controls[i];
                    if (control.igracPrezimeBrojDresa == this.igracPrezimeBrojDresa)
                    {
                        selectedControl = control;
                        igracId = control.igracId;
                        _flowPanelKlupa.Controls.Remove(control);
                    }
                }
            }
            _upsertUtakmica.filterIgraci(TipFiltera.Brisanje, igracId);
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

            _upsertUtakmica.filterIgraci(TipFiltera.Uredjivanje, igracId);

            int selectedPozicija = 0;
            for (int i = 0; i < _pozicije.Count; i++)
            {
                if (_pozicije[i].pozicijaId == pozicijaId)
                {
                    selectedPozicija = i;
                }
            }
            _cmbPozicije.SelectedIndex = selectedPozicija;

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
        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            await _upsertUtakmica.igracPodaci(igracId);
        }
    }
}
