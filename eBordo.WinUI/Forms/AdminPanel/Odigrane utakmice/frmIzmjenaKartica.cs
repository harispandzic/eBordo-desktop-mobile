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

namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    public partial class frmIzmjenaKartica : UserControl
    {
        private readonly ApiService.ApiService _izmjenaApi = new ApiService.ApiService("UtakmicaIzmjena");

        public int utakmicaIzmjenaId { get; set; }
        public int igracOutId { get; set; }
        public int igracInId { get; set; }
        public Image igracOutSlika { get; set; }
        public Image igracInSlika { get; set; }
        public string igracOutPrezime { get; set; }
        public string igracInPrezime { get; set; }
        public string igracOutPozicija { get; set; }
        public string igracInPozicija { get; set; }
        public string igracOutBroj { get; set; }
        public string igracInBroj { get; set; }
        public int minuta { get; set; }
        public string razlogIzmjene { get; set; }

        FlowLayoutPanel _flowPanelIzmjene;
        frmUpsertIzvjestaj _upsertIzvjestaj;
        bool _isUpdate;

        private List<Model.Models.Igrac> _igraciPrvaPostava = new List<Model.Models.Igrac>();
        private List<Model.Models.Igrac> _igraciKlupa = new List<Model.Models.Igrac>();
        BunifuDropdown _cmbPrvaPostava;
        BunifuDropdown _cmbKlupa;
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
        public frmIzmjenaKartica(FlowLayoutPanel flowPanelIzmjene, frmUpsertIzvjestaj upsertIzvjestaj, List<Model.Models.Igrac> igraciPrvaPostava, List<Model.Models.Igrac> igraciKlupa, BunifuDropdown cmbPrvaPostava, BunifuDropdown cmbKlupa, bool isUpdate)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 365, 41, 8, 8));
            InitializeComponent();
            _flowPanelIzmjene = flowPanelIzmjene;
            _upsertIzvjestaj = upsertIzvjestaj;
            _igraciPrvaPostava = igraciPrvaPostava;
            _igraciKlupa = igraciKlupa;
            _igraciPrvaPostava = igraciPrvaPostava;
            _cmbPrvaPostava = cmbPrvaPostava;
            _cmbKlupa = cmbKlupa;
            _isUpdate = isUpdate;
        }

        private void frmIzmjenaKartica_Load(object sender, EventArgs e)
        {
            pictureIgracOut.Image = igracOutSlika;
            pictureIgracOut.BackgroundImageLayout = ImageLayout.Zoom;

            pictureIgracIn.Image = igracInSlika;
            pictureIgracIn.BackgroundImageLayout = ImageLayout.Zoom;

            txtIgracOutPrezime.Text = igracOutPrezime;
            txtIgracInPrezime.Text = igracInPrezime;

            txtMinuta.Text = minuta.ToString() + "'";
            txtRazlogIzmjene.Text = razlogIzmjene;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _flowPanelIzmjene.Controls.Count; i++)
            {
                var control = (frmIzmjenaKartica)_flowPanelIzmjene.Controls[i];
                if (control.igracOutId == this.igracOutId && control.igracInId == this.igracInId)
                {
                    _flowPanelIzmjene.Controls.Remove(control);
                    if (_isUpdate)
                    {
                        await _izmjenaApi.DeleteById<Model.Models.UtakmicaIzmjena>(control.utakmicaIzmjenaId);
                    }
                }
            }
            _upsertIzvjestaj.UpdateBrojEvidentiranihIzmjena();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _upsertIzvjestaj.filterIzmjene(igracOutId, igracInId);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _upsertIzvjestaj.filterIzmjene(igracOutId, igracInId);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _flowPanelIzmjene.Controls.Count; i++)
            {
                var control = (frmIzmjenaKartica)_flowPanelIzmjene.Controls[i];
                if (control.igracOutId == this.igracOutId && control.igracInId == this.igracInId)
                {
                    _flowPanelIzmjene.Controls.Remove(control);
                    if (_isUpdate)
                    {
                        await _izmjenaApi.DeleteById<Model.Models.UtakmicaIzmjena>(control.utakmicaIzmjenaId);
                    }
                    _upsertIzvjestaj.UpdateBrojEvidentiranihIzmjena();
                }
            }
        }
    }
}
