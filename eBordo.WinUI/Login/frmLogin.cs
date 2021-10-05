using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly ApiService.ApiService _apiService = new ApiService.ApiService("Korisnik");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            ApiService.ApiService.username = txtUsername.Text;
            ApiService.ApiService.password = txtPassword.Text;

            try
            {
                //List<Model.Models.Igrac> podaci = await _apiService.GetAll<List<Model.Models.Igrac>>(null);
                ApiService.ApiService.logovaniKorisnik = await _apiService.Auth<Model.Models.Korisnik>();
                Forms.Početna.frmPocetna frmPocetna = new Forms.Početna.frmPocetna();
                this.Hide();
                frmPocetna.Show();
            }
            catch
            {
                MessageBox.Show("Neispravan username i password");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
