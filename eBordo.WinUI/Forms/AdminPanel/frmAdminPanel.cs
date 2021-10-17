using eBordo.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Forms.Igrač
{
    public partial class fromAdminPanel : Form
    {
        private ByteToImage byteToImage = new ByteToImage();
        private bool isKorisniciPanelCollapsed; 
        public fromAdminPanel()
        {
            InitializeComponent();
        }
        private void frmPrikazIgraca_Load(object sender, EventArgs e)
        {
            hideActiveLabels("Početna");
            igracTabs.SetPage("tabPocetna");
            //korisnickaFotografija.Image = byteToImage.ConvertByteToImage(ApiService.ApiService.logovaniKorisnik.Slika);
            //lblLogovaniKorisnik.Text = (ApiService.ApiService.logovaniKorisnik.ime + " " + ApiService.ApiService.logovaniKorisnik.prezime).ToUpper();
            //snackbar.Show(this,
            //        lblLogovaniKorisnik.Text + ", dobrodošao na eBordo!",
            //        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
            //        3000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight);
            //SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.success);
            //simpleSound.Play();
        }
        void hideActiveLabels(string opcija)
        {
            switch (opcija)
            {
                case "Početna":
                    {
                        pnlPocetna.Show();
                        pnlIgraci.Hide();
                        pnlTreneri.Hide();
                        pnlRasporedUtakmica.Hide();
                        pnlOdigraneUtakmice.Hide();
                        pnlRasporedTreninga.Hide();
                        break;
                    }
                case "Igrači":
                    {
                        pnlPocetna.Hide();
                        pnlIgraci.Show();
                        pnlTreneri.Hide();
                        pnlRasporedUtakmica.Hide();
                        pnlOdigraneUtakmice.Hide();
                        pnlRasporedTreninga.Hide();
                        break;
                    }
                case "Treneri":
                    {
                        pnlPocetna.Hide();
                        pnlIgraci.Hide();
                        pnlTreneri.Show();
                        pnlRasporedUtakmica.Hide();
                        pnlOdigraneUtakmice.Hide();
                        pnlRasporedTreninga.Hide();
                        break;
                    }
                case "RasporedUtakmica":
                    {
                        pnlPocetna.Hide();
                        pnlIgraci.Hide();
                        pnlTreneri.Hide();
                        pnlRasporedUtakmica.Show();
                        pnlOdigraneUtakmice.Hide();
                        pnlRasporedTreninga.Hide();
                        break;
                    }
                case "OdigraneUtakmice":
                    {
                        pnlPocetna.Hide();
                        pnlIgraci.Hide();
                        pnlTreneri.Hide();
                        pnlRasporedUtakmica.Hide();
                        pnlOdigraneUtakmice.Show();
                        pnlRasporedTreninga.Hide();
                        break;
                    }
                case "RasporedTreninga":
                    {
                        pnlPocetna.Hide();
                        pnlIgraci.Hide();
                        pnlTreneri.Hide();
                        pnlRasporedUtakmica.Hide();
                        pnlOdigraneUtakmice.Hide();
                        pnlRasporedTreninga.Show();
                        break;
                    }
            }
        }      
        private void btnPocetna_Click(object sender, EventArgs e)
        {
            hideActiveLabels("Početna");
            igracTabs.SetPage("Početna");

        }
        private void btnIgraci_Click(object sender, EventArgs e)
        {
            hideActiveLabels("Igrači");
            igracTabs.SetPage("Igrači");
        }
        private void btnTreneri_Click(object sender, EventArgs e)
        {
            hideActiveLabels("Treneri");
            igracTabs.SetPage("Treneri");
        }
        private void btnRasporedUtakmica_Click(object sender, EventArgs e)
        {
            hideActiveLabels("RasporedUtakmica");
            igracTabs.SetPage("Raspored utakmica");
        }
        private void btnOdigraneUtakmice_Click(object sender, EventArgs e)
        {
            hideActiveLabels("OdigraneUtakmice");
            igracTabs.SetPage("Odigrane utakmice");
        }
        private void btnRasporedTreninga_Click(object sender, EventArgs e)
        {
            hideActiveLabels("RasporedTreninga");
            igracTabs.SetPage("Raspored treninga");
        }
        private void lblLogout_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.info);
            simpleSound.Play();
            Application.Restart();
        }
    }
}
