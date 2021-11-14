using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.AdminPanel.Tabele
{
    public partial class frmTabelePocetna : UserControl
    {
        private string[] opcije = { "Klubovi", "Stadioni", "Države", "Gradovi", "Takmičenja", "Pozicije", "Formacije" };
        public frmTabelePocetna()
        {
            InitializeComponent();
        }

        private void cmbTabele_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbTabele.SelectedIndex;
            tabelePages.SetPage(opcije[selectedIndex]);
        }

        private void frmTabelePocetna_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < opcije.Length; i++)
            {
                cmbTabele.Items.Add(opcije[i]);
            }
            cmbTabele.SelectedIndex = 0;
        }
    }
}
