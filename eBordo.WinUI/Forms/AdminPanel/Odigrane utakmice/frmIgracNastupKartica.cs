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
        public string igracImePrezimeBrojDresa { get; set; }
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
        public frmIgracNastupKartica(frmUpsertIzvjestaj upsertIzvjestaj, FlowLayoutPanel flowPanelOcjene, List<Model.Models.Igrac> igraciSastav, bool isUpdate)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 632, 37, 8, 8));
            InitializeComponent();
            _upsertIzvjestaj = upsertIzvjestaj;
            _flowPanelOcjene = flowPanelOcjene;
        }

        private void frmIgracNastupKartica_Load(object sender, EventArgs e)
        {
            pictureIgracSlika.BackgroundImage = igracSlika;
            pictureIgracSlika.BackgroundImageLayout = ImageLayout.Zoom;
            txtImePrezimeBrojDresa.Text = igracImePrezimeBrojDresa;
            lblPozicija.Text = igracPozicija;
            label1.Text = igracGolovi.ToString();
            label2.Text = igracAsistencije.ToString();
            label3.Text = igracMinute.ToString();
            label4.Text = igracZutiKartoni.ToString();
            label5.Text = igracCrveniKartoni.ToString();
            ratingSnaga.Value = ocjenaRating;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int igracId = 0;
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
            _upsertIzvjestaj.filterIgraci(TipFiltera.Brisanje, igracId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _upsertIzvjestaj.filterIgraci(TipFiltera.Uredjivanje, igracId);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmDetaljneOcjeneIgraca frmDetaljneOcjene = new frmDetaljneOcjeneIgraca(igracId, kontrolaLopte, 
                driblanje, dodavanje, kretanje, brzina, sut,
                snaga, markiranje, klizeciStart, skok, odbrana, igracKomentar);
            frmDetaljneOcjene.Show();
    }
    }
}
