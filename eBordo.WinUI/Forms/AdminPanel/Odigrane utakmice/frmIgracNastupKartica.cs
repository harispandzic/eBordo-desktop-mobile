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
    public partial class frmIgracNastupKartica : UserControl
    {
        private readonly ApiService.ApiService _nastupiApi = new ApiService.ApiService("UtakmicaNastup");

        public int utakmicaNastupId { get; set; }
        public int utakmicaOcjenaId { get; set; }
        public int igracId { get; set; }
        public Image igracSlika { get; set; }
        public string igracImePrezime { get; set; }
        public string brojDresa { get; set; }
        public string igracPozicija { get; set; }
        public int igracMinute { get; set; }
        public int igracGolovi { get; set; }
        public int igracAsistencije { get; set; }
        public int igracZutiKartoni { get; set; }
        public int igracCrveniKartoni { get; set; }
        public int ocjenaRating { get; set; }
        public string igracKomentar { get; set; }

        public int kontrolaLopte { get; set; }
        public int driblanje { get; set; }
        public int dodavanje { get; set; }
        public int kretanje { get; set; }
        public int brzina { get; set; }
        public int sut { get; set; }
        public int snaga { get; set; }
        public int markiranje { get; set; }
        public int klizeciStart { get; set; }
        public int skok { get; set; }
        public int odbrana { get; set; }

        frmUpsertIzvjestaj _upsertIzvjestaj;
        FlowLayoutPanel _flowPanelOcjene;
        bool _isUpdate;

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
        public frmIgracNastupKartica(frmUpsertIzvjestaj upsertIzvjestaj = null, FlowLayoutPanel flowPanelOcjene = null, List<Model.Models.Igrac> igraciSastav = null, bool isUpdate = false)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 632, 37, 8, 8));
            InitializeComponent();
            _upsertIzvjestaj = upsertIzvjestaj;
            _flowPanelOcjene = flowPanelOcjene;
        }

        private void frmIgracNastupKartica_Load(object sender, EventArgs e)
        {
            pictureIgracSlika.Image = igracSlika;
            //pictureIgracSlika.BackgroundImageLayout = ImageLayout.Zoom;
            txtImePrezimeBrojDresa.Text = igracImePrezime;
            txtBrojDresa.Text = brojDresa;
            lblPozicija.Text = igracPozicija;
            txtBrojMinuta.Text = igracMinute.ToString();
            txtZutiKartoni.Text = igracZutiKartoni.ToString();
            txtGolovi.Text = igracGolovi.ToString();
            txtAsistencije.Text = igracAsistencije.ToString();
            txtCrveniKartoni.Text = igracCrveniKartoni.ToString();
            ratingOcjena.Value = ocjenaRating;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int igracId = 0;
            if(_flowPanelOcjene != null)
            {
                for (int i = 0; i < _flowPanelOcjene.Controls.Count; i++)
                {
                    var control = (frmIgracNastupKartica)_flowPanelOcjene.Controls[i];
                    if (control.igracId == this.igracId)
                    {
                        igracId = control.igracId;
                        _flowPanelOcjene.Controls.Remove(control);
                        if (_isUpdate)
                        {
                            await _nastupiApi.DeleteById<Model.Models.UtakmicaNastup>(control.utakmicaNastupId);
                        }
                    }
                }
                if(_upsertIzvjestaj != null)
                {
                    _upsertIzvjestaj.filterIgraci(TipFiltera.Brisanje, igracId);
                    _upsertIzvjestaj.UpdateBrojEvidentiranih();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(_upsertIzvjestaj != null)
            {
                _upsertIzvjestaj.filterIgraci(TipFiltera.Uredjivanje, igracId);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmDetaljneOcjeneIgraca frmDetaljneOcjene = new frmDetaljneOcjeneIgraca(igracId, kontrolaLopte, 
                driblanje, dodavanje, kretanje, brzina, sut,
                snaga, markiranje, klizeciStart, skok, odbrana, igracKomentar, ocjenaRating,igracMinute, igracGolovi, igracAsistencije, igracZutiKartoni, igracCrveniKartoni);
            frmDetaljneOcjene.Show();
    }
    }
}
