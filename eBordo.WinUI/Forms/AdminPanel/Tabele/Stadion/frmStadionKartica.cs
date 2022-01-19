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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Stadion
{
    public partial class frmStadionKartica : UserControl
    {
        public int stadionId { get; set; }
        public string nazivStadiona { get; set; }
        public string grad { get; set; }
        public Image slikaStadiona { get; set; }
        public Image imgZastava { get; set; }
        frmPrikazStadiona _prikazStadiona { get; set; }
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

        public frmStadionKartica(frmPrikazStadiona prikazStadiona)
        {
            _prikazStadiona = prikazStadiona;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 115, 98, 10, 10));
            InitializeComponent();
        }

        private void frmStadionKartica_Load(object sender, EventArgs e)
        {
            lblNazivKluba.Text = nazivStadiona;
            pictureSlikaStadiona.BackgroundImage = slikaStadiona;
            pictureSlikaStadiona.BackgroundImageLayout = ImageLayout.Stretch;
            pictureZastava.BackgroundImage = imgZastava;
            pictureZastava.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _prikazStadiona.filterStadioni(stadionId);
        }

        private void pictureSlikaStadiona_Click(object sender, EventArgs e)
        {

        }
    }
}
