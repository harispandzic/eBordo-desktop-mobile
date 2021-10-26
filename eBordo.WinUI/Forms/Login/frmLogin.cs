using eBordo.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.Login
{
    public partial class frmLogin : Form
    {
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
        private readonly ApiService.ApiService _apiService = new ApiService.ApiService("Korisnik");
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 12, 12));
        }
        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            btnPrijava.Hide();
            loader.Show();

            ApiService.ApiService.username = txtKorisnickoIme.Text;
            ApiService.ApiService.password = txtLozinka.Text;

            try
            {
                ApiService.ApiService.logovaniKorisnik = await _apiService.Auth<Model.Models.Korisnik>();
                loader.Hide();
                if (ApiService.ApiService.logovaniKorisnik.isIgrac)
                {
                    Forms.Igrač.fromAdminPanel prikazIgraca = new Forms.Igrač.fromAdminPanel();
                    this.Hide();
                    prikazIgraca.Show();
                }
                if (ApiService.ApiService.logovaniKorisnik.isTrener)
                {
                    Forms.TrenerPanel.frmTrenerPanel prikazTrenera = new Forms.TrenerPanel.frmTrenerPanel();
                    this.Hide();
                    prikazTrenera.Show();
                } 
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(bnfSnackBar, this, TipNotifikacije.NEISPRAVNI_KREDENCIJALI);             
                loader.Hide();
                btnPrijava.Show();
            } 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            loader.Hide();
        }
    }
}
