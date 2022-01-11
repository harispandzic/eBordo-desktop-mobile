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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Države
{
    public partial class frmDrzavaKartica : UserControl
    {
        public int drzavaid { get; set; }
        public string nazivDrzave { get; set; }
        public Image zastavaDrzave { get; set; }

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
        frmPrikazDrzava _prikazDrzava { get; set; }
        public frmDrzavaKartica(frmPrikazDrzava prikazDrzava)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 207, 35, 10, 10));
            InitializeComponent();
            _prikazDrzava = prikazDrzava;
        }

        private void frmDrzavaKartica_Load(object sender, EventArgs e)
        {
            picureZastava.BackgroundImage = zastavaDrzave;
            picureZastava.BackgroundImageLayout = ImageLayout.Zoom;
            lblNazivDrzave.Text = nazivDrzave;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _prikazDrzava.filterStadioni(drzavaid);
        }
    }
}
