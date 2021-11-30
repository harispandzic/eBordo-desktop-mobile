using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Takmičenja
{
    public partial class frmTakmicenjeKartica : UserControl
    {
        public string nazivTakmicenja { get; set; }
        public Image logoTakmicenja { get; set; }
        public frmTakmicenjeKartica()
        {
            InitializeComponent();
        }

        private void frmTakmicenjeKartica_Load(object sender, EventArgs e)
        {
            picureLogo.BackgroundImage = logoTakmicenja;
            picureLogo.BackgroundImageLayout = ImageLayout.Zoom;
            lblNazivTakmicenja.Text = nazivTakmicenja;
        }
    }
}
