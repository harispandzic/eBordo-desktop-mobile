
namespace eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica
{
    partial class frmUtakmicaSastavKartica_detaljiUtakmice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtakmicaSastavKartica_detaljiUtakmice));
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.pictureIgracSlika = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblBrojDresa = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPozicija
            // 
            this.lblPozicija.BackColor = System.Drawing.Color.Transparent;
            this.lblPozicija.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.ForeColor = System.Drawing.Color.Black;
            this.lblPozicija.Location = new System.Drawing.Point(166, 8);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(34, 23);
            this.lblPozicija.TabIndex = 55;
            this.lblPozicija.Text = "CMD";
            this.lblPozicija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblImePrezime.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.ForeColor = System.Drawing.Color.Black;
            this.lblImePrezime.Location = new System.Drawing.Point(73, 7);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(87, 23);
            this.lblImePrezime.TabIndex = 52;
            this.lblImePrezime.Text = "M. Ahmetović";
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureIgracSlika
            // 
            this.pictureIgracSlika.AllowFocused = false;
            this.pictureIgracSlika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureIgracSlika.AutoSizeHeight = true;
            this.pictureIgracSlika.BorderRadius = 14;
            this.pictureIgracSlika.Image = global::eBordo.WinUI.Properties.Resources.Screenshot_12;
            this.pictureIgracSlika.IsCircle = true;
            this.pictureIgracSlika.Location = new System.Drawing.Point(44, 4);
            this.pictureIgracSlika.Name = "pictureIgracSlika";
            this.pictureIgracSlika.Size = new System.Drawing.Size(28, 28);
            this.pictureIgracSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIgracSlika.TabIndex = 51;
            this.pictureIgracSlika.TabStop = false;
            this.pictureIgracSlika.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblBrojDresa);
            this.bunifuPanel1.Location = new System.Drawing.Point(-3, -6);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(44, 45);
            this.bunifuPanel1.TabIndex = 142;
            // 
            // lblBrojDresa
            // 
            this.lblBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojDresa.Font = new System.Drawing.Font("Oswald", 10F);
            this.lblBrojDresa.ForeColor = System.Drawing.Color.White;
            this.lblBrojDresa.Location = new System.Drawing.Point(4, 11);
            this.lblBrojDresa.Name = "lblBrojDresa";
            this.lblBrojDresa.Size = new System.Drawing.Size(37, 23);
            this.lblBrojDresa.TabIndex = 142;
            this.lblBrojDresa.Text = "#12";
            this.lblBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = global::eBordo.WinUI.Properties.Resources.view22;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Location = new System.Drawing.Point(210, 8);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(20, 20);
            this.btnView.TabIndex = 143;
            this.btnView.TabStop = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmUtakmicaSastavKartica_detaljiUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.pictureIgracSlika);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblImePrezime);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Name = "frmUtakmicaSastavKartica_detaljiUtakmice";
            this.Size = new System.Drawing.Size(235, 35);
            this.Load += new System.EventHandler(this.frmUtakmicaSastavKartica_detaljiUtakmice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPictureBox pictureIgracSlika;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label lblImePrezime;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lblBrojDresa;
        private System.Windows.Forms.PictureBox btnView;
    }
}
