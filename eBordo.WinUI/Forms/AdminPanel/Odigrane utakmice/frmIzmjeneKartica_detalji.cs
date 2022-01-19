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
    public partial class frmIzmjeneKartica_detalji : UserControl
    {
        public Image igracOutSlika { get; set; }
        public Image igracInSlika { get; set; }
        public string igracOutPrezime { get; set; }
        public string igracInPrezime { get; set; }
        public string igracOutPozicija { get; set; }
        public string igracInPozicija { get; set; }
        public string igracOutBroj { get; set; }
        public string igracInBroj { get; set; }
        public string razlogIzmjene { get; set; }
        public int minuta { get; set; }

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
        public frmIzmjeneKartica_detalji()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 280, 33, 8, 8));
            InitializeComponent();
        }

        private void frmIzmjeneKartica_detalji_Load(object sender, EventArgs e)
        {
            pictureIgracOut.Image = igracOutSlika;
            label1.Text = razlogIzmjene[0].ToString().ToUpper();
            pictureIgracIn.Image = igracInSlika;

            txtIgracOutPrezime.Text = igracOutPrezime;
            txtIgracInPrezime.Text = igracInPrezime;

            txtMinuta.Text = minuta.ToString() + "'";
        }
    }
}
