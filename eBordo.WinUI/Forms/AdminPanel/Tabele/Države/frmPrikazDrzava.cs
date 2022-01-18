using eBordo.Model.Requests.Drzava;
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

namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Države
{
    public partial class frmPrikazDrzava : UserControl
    {
        private byte[] zastava { get; set; }
        private readonly ApiService.ApiService _drzava = new ApiService.ApiService("Drzava");

        private List<Model.Models.Drzava> _drzave;

        Model.Models.Drzava drzava;

        ByteToImage byteToImage = new ByteToImage();

        bool isNazivDrzaveValidated = false, isSlikaAvatarValidated = false;

        public frmPrikazDrzava()
        {
            InitializeComponent();
        }
        public async Task LoadDrzave(TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            if (notifikacija != TipNotifikacije.BEZ)
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, notifikacija);
            }

            try
            {
                pnlPrikazDrzava.Controls.Clear();

                _drzave = await _drzava.GetAll<List<Model.Models.Drzava>>(null);
                loader.Hide();
                loaderIgraci.Hide();

                frmDrzavaKartica[] listItems = new frmDrzavaKartica[_drzave.Count];
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new frmDrzavaKartica(this);
                    listItems[i].drzavaid = _drzave[i].drzavaId;
                    listItems[i].nazivDrzave = _drzave[i].nazivDrzave;
                    listItems[i].zastavaDrzave = byteToImage.ConvertByteToImage(_drzave[i].zastava);

                    pnlPrikazDrzava.Controls.Add(listItems[i]);
                }
                UpdateBrojDrazva();
                btnSaveUpdate.Hide();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        private void pictureGrb_Click(object sender, EventArgs e)
        {
            
        }
        private bool ValidirajFormu()
        {
            bool isUspjesno = true;
            if (!isNazivDrzaveValidated || !isSlikaAvatarValidated)
            {
                isUspjesno = false;
            }
            else
            {
                isUspjesno = true;
            }

            return isUspjesno;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private async void frmPrikazDrzava_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
        }

        private void btnUcitajPanelPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnUcitajPanelPhoto_Click_1(object sender, EventArgs e)
        {
            try
            {
                var result = grbFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var fileName = grbFileDialog.FileName;

                    var file = System.IO.File.ReadAllBytes(fileName);

                    zastava = file;

                    Image image = Image.FromFile(fileName);
                    pictureZastava.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureZastava.BackgroundImage = image;

                    isSlikaAvatarValidated = Validacija.ValidirajSliku(image, pictureSlikaUtakmicaValidator, Field.SLIKA_AVATAR);
                }
            }
            catch
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.GRESKA_UPLOAD);
            }
        }
        private void UpdateBrojDrazva()
        {
            txtBrojIgraca.Text = _drzave.Count().ToString();
        }

        private void txtNazivDrzave_TextChanged(object sender, EventArgs e)
        {
            isNazivDrzaveValidated = Validacija.ValidirajInputString(txtNazivDrzave, txtTelefonValidator, Field.IME);
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            DrzavaInsertRequest insertRequest = new DrzavaInsertRequest
            {
                nazivDrzave = txtNazivDrzave.Text,
                zastava = this.zastava,
            };
            try
            {
                await _drzava.Insert<Model.Models.Drzava>(insertRequest);
                await LoadDrzave(notifikacija: TipNotifikacije.DODAVANJE);
                pictureZastava.BackgroundImage = Properties.Resources.uploadFile;
                pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
                txtNazivDrzave.Text = "";
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }
        public void filterStadioni(int drzavaId)
        {
            bunifuButton1.Hide();
            btnSaveUpdate.Show();
            drzava = _drzave.Where(s => s.drzavaId == drzavaId).SingleOrDefault();
            txtNazivDrzave.Text = drzava.nazivDrzave;
            pictureZastava.BackgroundImage = byteToImage.ConvertByteToImage(drzava.zastava);
            pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;

            isSlikaAvatarValidated = true;
            btnUcitajPanelPhoto.Enabled = false;
            pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(204, 204, 204);
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, TipNotifikacije.FORMA_VALIDACIJA);
                return;
            }
            DrzavaUpdateRequest update = new DrzavaUpdateRequest
            {
                nazivDrzave = txtNazivDrzave.Text
            };
            try
            {
                await _drzava.Update<Model.Models.Drzava>(drzava.drzavaId, update);
                await LoadDrzave(notifikacija: TipNotifikacije.UREĐIVANJE);
                OcistiPolja();
            }
            catch (Flurl.Http.FlurlHttpException ex)
            {
                var message = await ex.GetResponseStringAsync();
                TipNotifikacije tipNotifikacije = Exceptions.getException((message));
                PosaljiNotifikaciju.notificationSwitch(snackbar, this.ParentForm, tipNotifikacije);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDrzave();
        }

        public void OcistiPolja()
        {
            btnSaveUpdate.Hide();
            bunifuButton1.Show();
            txtNazivDrzave.Text = "";
            txtTelefonValidator.Text = "";
            pictureZastava.BackgroundImage = Properties.Resources.uploadFile;
            pictureZastava.BackgroundImageLayout = ImageLayout.Zoom;
            pictureSlikaUtakmicaValidator.BackColor = Color.FromArgb(64, 5, 7);
            btnUcitajPanelPhoto.Enabled = true;
        }
    }
}
