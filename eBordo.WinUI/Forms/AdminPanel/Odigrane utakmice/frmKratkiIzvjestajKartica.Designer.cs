
namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    partial class frmKratkiIzvjestajKartica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKratkiIzvjestajKartica));
            this.lblPozicija = new System.Windows.Forms.Label();
            this.txtImePrezimeBrojDresa = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtBrojDresa = new System.Windows.Forms.Label();
            this.pictureIgracSlika = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMinute = new System.Windows.Forms.Label();
            this.pictureNastupi = new System.Windows.Forms.PictureBox();
            this.ratingOcjena = new Bunifu.UI.WinForms.BunifuRating();
            this.btnView = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNastupi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPozicija
            // 
            this.lblPozicija.BackColor = System.Drawing.Color.Transparent;
            this.lblPozicija.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.ForeColor = System.Drawing.Color.Black;
            this.lblPozicija.Location = new System.Drawing.Point(137, 6);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(34, 23);
            this.lblPozicija.TabIndex = 166;
            this.lblPozicija.Text = "CMD";
            this.lblPozicija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtImePrezimeBrojDresa
            // 
            this.txtImePrezimeBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.txtImePrezimeBrojDresa.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeBrojDresa.ForeColor = System.Drawing.Color.Black;
            this.txtImePrezimeBrojDresa.Location = new System.Drawing.Point(52, 6);
            this.txtImePrezimeBrojDresa.Name = "txtImePrezimeBrojDresa";
            this.txtImePrezimeBrojDresa.Size = new System.Drawing.Size(92, 23);
            this.txtImePrezimeBrojDresa.TabIndex = 165;
            this.txtImePrezimeBrojDresa.Text = "M. Ahmetović";
            this.txtImePrezimeBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.bunifuPanel1.Location = new System.Drawing.Point(-7, -4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(33, 45);
            this.bunifuPanel1.TabIndex = 167;
            // 
            // txtBrojDresa
            // 
            this.txtBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.txtBrojDresa.Font = new System.Drawing.Font("Oswald", 9F);
            this.txtBrojDresa.ForeColor = System.Drawing.Color.White;
            this.txtBrojDresa.Location = new System.Drawing.Point(8, 9);
            this.txtBrojDresa.Name = "txtBrojDresa";
            this.txtBrojDresa.Size = new System.Drawing.Size(24, 23);
            this.txtBrojDresa.TabIndex = 142;
            this.txtBrojDresa.Text = "#12";
            this.txtBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureIgracSlika
            // 
            this.pictureIgracSlika.AllowFocused = false;
            this.pictureIgracSlika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureIgracSlika.AutoSizeHeight = true;
            this.pictureIgracSlika.BorderRadius = 12;
            this.pictureIgracSlika.Image = global::eBordo.WinUI.Properties.Resources.Screenshot_12;
            this.pictureIgracSlika.IsCircle = true;
            this.pictureIgracSlika.Location = new System.Drawing.Point(28, 4);
            this.pictureIgracSlika.Name = "pictureIgracSlika";
            this.pictureIgracSlika.Size = new System.Drawing.Size(25, 25);
            this.pictureIgracSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIgracSlika.TabIndex = 164;
            this.pictureIgracSlika.TabStop = false;
            this.pictureIgracSlika.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // flowPanel
            // 
            this.flowPanel.Location = new System.Drawing.Point(223, 6);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(131, 22);
            this.flowPanel.TabIndex = 358;
            // 
            // txtMinute
            // 
            this.txtMinute.BackColor = System.Drawing.Color.Transparent;
            this.txtMinute.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.ForeColor = System.Drawing.Color.Black;
            this.txtMinute.Location = new System.Drawing.Point(194, 6);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(29, 23);
            this.txtMinute.TabIndex = 360;
            this.txtMinute.Text = "90";
            this.txtMinute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureNastupi
            // 
            this.pictureNastupi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureNastupi.Image = global::eBordo.WinUI.Properties.Resources.Spiele;
            this.pictureNastupi.Location = new System.Drawing.Point(177, 4);
            this.pictureNastupi.Name = "pictureNastupi";
            this.pictureNastupi.Size = new System.Drawing.Size(16, 25);
            this.pictureNastupi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureNastupi.TabIndex = 359;
            this.pictureNastupi.TabStop = false;
            // 
            // ratingOcjena
            // 
            this.ratingOcjena.BackColor = System.Drawing.Color.Transparent;
            this.ratingOcjena.DisabledEmptyFillColor = System.Drawing.Color.DarkGray;
            this.ratingOcjena.DisabledRatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingOcjena.EmptyBorderColor = System.Drawing.Color.DarkGray;
            this.ratingOcjena.EmptyFillColor = System.Drawing.Color.DarkGray;
            this.ratingOcjena.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingOcjena.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingOcjena.InnerRadius = 1F;
            this.ratingOcjena.Location = new System.Drawing.Point(361, 8);
            this.ratingOcjena.Name = "ratingOcjena";
            this.ratingOcjena.OuterRadius = 8F;
            this.ratingOcjena.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingOcjena.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingOcjena.ReadOnly = true;
            this.ratingOcjena.RightClickToClear = true;
            this.ratingOcjena.Size = new System.Drawing.Size(91, 18);
            this.ratingOcjena.Spacing = 2;
            this.ratingOcjena.TabIndex = 361;
            this.ratingOcjena.Text = "jacinaSlabijeNogeVrijednost";
            this.ratingOcjena.Value = 4;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = global::eBordo.WinUI.Properties.Resources.view22;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Location = new System.Drawing.Point(459, 7);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(20, 20);
            this.btnView.TabIndex = 362;
            this.btnView.TabStop = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmKratkiIzvjestajKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.ratingOcjena);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.pictureNastupi);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.pictureIgracSlika);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.txtImePrezimeBrojDresa);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Name = "frmKratkiIzvjestajKartica";
            this.Size = new System.Drawing.Size(484, 33);
            this.Load += new System.EventHandler(this.frmKratkiIzvjestajKartica_Load);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNastupi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtBrojDresa;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox pictureIgracSlika;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label txtImePrezimeBrojDresa;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Label txtMinute;
        private System.Windows.Forms.PictureBox pictureNastupi;
        private Bunifu.UI.WinForms.BunifuRating ratingOcjena;
        private System.Windows.Forms.PictureBox btnView;
    }
}
