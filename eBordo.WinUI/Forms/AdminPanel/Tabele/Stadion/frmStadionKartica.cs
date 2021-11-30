using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Stadion
{
    public partial class frmStadionKartica : UserControl
    {
        public string nazivStadiona { get; set; }
        public string grad { get; set; }
        public Image slikaStadiona { get; set; }

        public frmStadionKartica()
        {
            InitializeComponent();
        }

        private void frmStadionKartica_Load(object sender, EventArgs e)
        {
            lblNazivKluba.Text = nazivStadiona + ", " + grad;
            pictureSlikaStadiona.BackgroundImage = slikaStadiona;
            pictureSlikaStadiona.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
