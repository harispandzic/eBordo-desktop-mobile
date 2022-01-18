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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Takmičenja
{
    public partial class frmTakmicenjeKartica : UserControl
    {
        public int takmicenjeId { get; set; }
        public string nazivTakmicenja { get; set; }
        public Image logoTakmicenja { get; set; }
        frmTakmicenjaPrikaz _prikazTakmicenje { get; set; }

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

        public frmTakmicenjeKartica(frmTakmicenjaPrikaz prikazTakmicenje)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 115, 98, 10, 10));
            InitializeComponent();
            _prikazTakmicenje = prikazTakmicenje;
        }

        private void frmTakmicenjeKartica_Load(object sender, EventArgs e)
        {
            picureLogo.BackgroundImage = logoTakmicenja;
            picureLogo.BackgroundImageLayout = ImageLayout.Zoom;
            lblNazivTakmicenja.Text = nazivTakmicenja;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _prikazTakmicenje.filterStadioni(takmicenjeId);
        }
    }
}
