
namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    partial class frmIgracNastupKartica
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIgracNastupKartica));
            this.pictureIgracSlika = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.txtImePrezimeBrojDresa = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.pictureNastupi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ratingSnaga = new Bunifu.UI.WinForms.BunifuRating();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtBrojDresa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureAsistencije = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureGolovi = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureCrveniKartoni = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureZutiKartoni = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNastupi)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsistencije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGolovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCrveniKartoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZutiKartoni)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureIgracSlika
            // 
            this.pictureIgracSlika.AllowFocused = false;
            this.pictureIgracSlika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureIgracSlika.AutoSizeHeight = true;
            this.pictureIgracSlika.BorderRadius = 15;
            this.pictureIgracSlika.Image = global::eBordo.WinUI.Properties.Resources.Screenshot_12;
            this.pictureIgracSlika.IsCircle = true;
            this.pictureIgracSlika.Location = new System.Drawing.Point(43, 4);
            this.pictureIgracSlika.Name = "pictureIgracSlika";
            this.pictureIgracSlika.Size = new System.Drawing.Size(30, 30);
            this.pictureIgracSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIgracSlika.TabIndex = 50;
            this.pictureIgracSlika.TabStop = false;
            this.pictureIgracSlika.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblPozicija
            // 
            this.lblPozicija.BackColor = System.Drawing.Color.Transparent;
            this.lblPozicija.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.ForeColor = System.Drawing.Color.Black;
            this.lblPozicija.Location = new System.Drawing.Point(184, 8);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(34, 23);
            this.lblPozicija.TabIndex = 52;
            this.lblPozicija.Text = "CMD";
            this.lblPozicija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtImePrezimeBrojDresa
            // 
            this.txtImePrezimeBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.txtImePrezimeBrojDresa.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeBrojDresa.ForeColor = System.Drawing.Color.Black;
            this.txtImePrezimeBrojDresa.Location = new System.Drawing.Point(73, 8);
            this.txtImePrezimeBrojDresa.Name = "txtImePrezimeBrojDresa";
            this.txtImePrezimeBrojDresa.Size = new System.Drawing.Size(116, 23);
            this.txtImePrezimeBrojDresa.TabIndex = 51;
            this.txtImePrezimeBrojDresa.Text = "M. Ahmetović #9";
            this.txtImePrezimeBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = global::eBordo.WinUI.Properties.Resources.view22;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Location = new System.Drawing.Point(563, 9);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(20, 20);
            this.btnView.TabIndex = 55;
            this.btnView.TabStop = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::eBordo.WinUI.Properties.Resources.delete2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(607, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::eBordo.WinUI.Properties.Resources.edit2;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(585, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(20, 20);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureNastupi
            // 
            this.pictureNastupi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureNastupi.Image = global::eBordo.WinUI.Properties.Resources.Spiele;
            this.pictureNastupi.Location = new System.Drawing.Point(236, 6);
            this.pictureNastupi.Name = "pictureNastupi";
            this.pictureNastupi.Size = new System.Drawing.Size(16, 25);
            this.pictureNastupi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureNastupi.TabIndex = 152;
            this.pictureNastupi.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 157;
            this.label1.Text = "90";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ratingSnaga
            // 
            this.ratingSnaga.BackColor = System.Drawing.Color.Transparent;
            this.ratingSnaga.DisabledEmptyFillColor = System.Drawing.Color.DarkGray;
            this.ratingSnaga.DisabledRatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingSnaga.EmptyBorderColor = System.Drawing.Color.DarkGray;
            this.ratingSnaga.EmptyFillColor = System.Drawing.Color.DarkGray;
            this.ratingSnaga.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingSnaga.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingSnaga.InnerRadius = 1F;
            this.ratingSnaga.Location = new System.Drawing.Point(460, 10);
            this.ratingSnaga.Name = "ratingSnaga";
            this.ratingSnaga.OuterRadius = 8F;
            this.ratingSnaga.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingSnaga.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingSnaga.ReadOnly = true;
            this.ratingSnaga.RightClickToClear = true;
            this.ratingSnaga.Size = new System.Drawing.Size(91, 18);
            this.ratingSnaga.Spacing = 2;
            this.ratingSnaga.TabIndex = 162;
            this.ratingSnaga.Text = "jacinaSlabijeNogeVrijednost";
            this.ratingSnaga.Value = 4;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txtBrojDresa);
            this.bunifuPanel1.Location = new System.Drawing.Point(-4, -4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(44, 45);
            this.bunifuPanel1.TabIndex = 163;
            // 
            // txtBrojDresa
            // 
            this.txtBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.txtBrojDresa.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojDresa.ForeColor = System.Drawing.Color.White;
            this.txtBrojDresa.Location = new System.Drawing.Point(6, 11);
            this.txtBrojDresa.Name = "txtBrojDresa";
            this.txtBrojDresa.Size = new System.Drawing.Size(37, 23);
            this.txtBrojDresa.TabIndex = 142;
            this.txtBrojDresa.Text = "#12";
            this.txtBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(427, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 23);
            this.label4.TabIndex = 160;
            this.label4.Text = "1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureAsistencije
            // 
            this.pictureAsistencije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureAsistencije.Image = global::eBordo.WinUI.Properties.Resources.ezgif_com_gif_maker__1_;
            this.pictureAsistencije.Location = new System.Drawing.Point(410, 6);
            this.pictureAsistencije.Name = "pictureAsistencije";
            this.pictureAsistencije.Size = new System.Drawing.Size(16, 25);
            this.pictureAsistencije.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAsistencije.TabIndex = 154;
            this.pictureAsistencije.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(385, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 23);
            this.label3.TabIndex = 159;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureGolovi
            // 
            this.pictureGolovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureGolovi.Image = global::eBordo.WinUI.Properties.Resources.ezgif_com_gif_maker;
            this.pictureGolovi.Location = new System.Drawing.Point(368, 6);
            this.pictureGolovi.Name = "pictureGolovi";
            this.pictureGolovi.Size = new System.Drawing.Size(16, 25);
            this.pictureGolovi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGolovi.TabIndex = 153;
            this.pictureGolovi.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(345, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 23);
            this.label5.TabIndex = 161;
            this.label5.Text = "1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureCrveniKartoni
            // 
            this.pictureCrveniKartoni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureCrveniKartoni.Image = global::eBordo.WinUI.Properties.Resources.ezgif_com_gif_maker__3_;
            this.pictureCrveniKartoni.Location = new System.Drawing.Point(327, 6);
            this.pictureCrveniKartoni.Name = "pictureCrveniKartoni";
            this.pictureCrveniKartoni.Size = new System.Drawing.Size(16, 25);
            this.pictureCrveniKartoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCrveniKartoni.TabIndex = 156;
            this.pictureCrveniKartoni.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(305, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 23);
            this.label2.TabIndex = 158;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureZutiKartoni
            // 
            this.pictureZutiKartoni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureZutiKartoni.Image = global::eBordo.WinUI.Properties.Resources.ezgif_com_gif_maker__2_;
            this.pictureZutiKartoni.Location = new System.Drawing.Point(288, 6);
            this.pictureZutiKartoni.Name = "pictureZutiKartoni";
            this.pictureZutiKartoni.Size = new System.Drawing.Size(16, 25);
            this.pictureZutiKartoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureZutiKartoni.TabIndex = 155;
            this.pictureZutiKartoni.TabStop = false;
            // 
            // frmIgracNastupKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.ratingSnaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCrveniKartoni);
            this.Controls.Add(this.pictureZutiKartoni);
            this.Controls.Add(this.pictureAsistencije);
            this.Controls.Add(this.pictureGolovi);
            this.Controls.Add(this.pictureNastupi);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureIgracSlika);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.txtImePrezimeBrojDresa);
            this.Name = "frmIgracNastupKartica";
            this.Size = new System.Drawing.Size(632, 37);
            this.Load += new System.EventHandler(this.frmIgracNastupKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNastupi)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsistencije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGolovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCrveniKartoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZutiKartoni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pictureIgracSlika;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label txtImePrezimeBrojDresa;
        private System.Windows.Forms.PictureBox btnView;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox pictureNastupi;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuRating ratingSnaga;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label txtBrojDresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureAsistencije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureGolovi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureCrveniKartoni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureZutiKartoni;
    }
}
