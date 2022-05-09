using eBordo.WinUI.Forms.AdminPanel;
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
        bool isEmailValidated = false, isPasswordValidated = false;
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
            visibilityOn.Hide();
        }
        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(bnfSnackBar, this, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            btnPrijava.Hide();
            loader.Show();

            ApiService.ApiService.username = txtKorisnickoIme.Text;
            ApiService.ApiService.password = txtLozinka.Text;

            try
            {
                ApiService.ApiService.logovaniKorisnik = await _apiService.Auth<Model.Models.Korisnik>();
                loader.Hide();


                Forms.Igrač.fromAdminPanel panel = new Forms.Igrač.fromAdminPanel();
                this.Hide();
                panel.Show();

                frmAbout_eBordo about = new frmAbout_eBordo();
                about.Show();
                about.BringToFront();
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(bnfSnackBar, this, TipNotifikacije.NEISPRAVNI_KREDENCIJALI);
                loader.Hide();
                btnPrijava.Show();
            } 
        }
        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if (!isEmailValidated || !isPasswordValidated)

            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            loader.Hide();
            txtKorisnickoIme.Text = "haris.pandzic@fksarajevo.ba";
            txtLozinka.Text = "Test1234!";
            isEmailValidated = true;
            isPasswordValidated = true;
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            isEmailValidated = Validacija.ValidirajInputString(txtKorisnickoIme, txtKorisnickoImeValidator, Field.KORISNICKO_IME);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureDrzavljanstvoSlikaValidator_Click(object sender, EventArgs e)
        {
            txtLozinka.PasswordChar = '\0';
            visibilityOff.Hide();
            visibilityOn.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtLozinka.UseSystemPasswordChar = false;
            txtLozinka.PasswordChar = '●';
            visibilityOff.Show();
            visibilityOn.Hide();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            txtLozinka.UseSystemPasswordChar = true;
            isPasswordValidated = Validacija.ValidirajInputString(txtLozinka, txtLozinkaValidator, Field.PASSWORD);
        }
    }
}
