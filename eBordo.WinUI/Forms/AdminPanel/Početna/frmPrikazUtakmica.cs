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

namespace eBordo.WinUI.Forms.AdminPanel.Početna
{
    public partial class frmPrikazUtakmica : UserControl
    {
        public int utakmicaId { get; set; }
        public Image grbDomacinProp { get; set; }
        public Image grbGostProp { get; set; }
        public string brojDana { get; set; }
        public string protivnik { get; set; }
        public string opisUtakmice { get; set; }
        public DateTime datum { get; set; }
        public string satnica { get; set; }
        public Image takmicenje { get; set; }
        public Image domacaGostujuca { get; set; }
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
        public frmPrikazUtakmica()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 160, 57, 10, 10));
            InitializeComponent();
        }

        private void frmPrikazUtakmica_Load(object sender, EventArgs e)
        {
            grbDomacin.BackgroundImage = grbDomacinProp;
            grbDomacin.BackgroundImageLayout = ImageLayout.Zoom;
            grbGost.BackgroundImage = grbGostProp;
            grbGost.BackgroundImageLayout = ImageLayout.Zoom;
            txtBrojDana.Text = brojDana;
            txtDatum.Text = datum.ToString("dd.MM.yyyy");
            txtStadion.Text = satnica;
            pictureTakmicenje.BackgroundImage = takmicenje;
            pictureTakmicenje.BackgroundImageLayout = ImageLayout.Zoom;
            //pictureGostujucaDomaca.BackgroundImage = domacaGostujuca;
            //pictureGostujucaDomaca.BackgroundImageLayout = ImageLayout.Zoom;
            if(datum.Date == DateTime.Now.Date)
            {
                txtBrojDana.Text = "DANAS";
            }
            else
            {
                txtBrojDana.Text = "za " + (datum.Date - DateTime.Now.Date).TotalDays + " dana";
            }
            txtOpisUtakmice.Text = opisUtakmice;
        }
    }
}
