using eBordo.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.Početna
{
    public partial class frmPocetna : Form
    {
        ByteToImage byteToImage = new ByteToImage();

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblUsername.Text = ApiService.ApiService.logovaniKorisnik.korisnickoIme;
            if (ApiService.ApiService.logovaniKorisnik.Slika.Length != 0)
            {
                loggedUserAvatar.Image = byteToImage.ConvertByteToImage(ApiService.ApiService.logovaniKorisnik.Slika);
                loggedUserAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void loggedUserAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
