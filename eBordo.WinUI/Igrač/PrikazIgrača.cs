using eBordo.WinUI.ApiService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Igrač
{
    public partial class PrikazIgrača : Form
    {
        ApiService.ApiService igracService = new ApiService.ApiService("Igrac");
        public PrikazIgrača()
        {
            InitializeComponent();
        }

        private async void PrikazIgrača_Load(object sender, EventArgs e)
        {

            var list = igracService.GetAll<eBordo.Model.Models.Igrac>(null); 
            //var prvi = list[0];

            dgvPrikazIgraca.DataSource = list;
        }
    }
}
