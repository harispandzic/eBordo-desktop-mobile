
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
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.pictureIgracSlika = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblBrojDresa = new System.Windows.Forms.Label();
            this.lblKapiten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPozicija
            // 
            this.lblPozicija.BackColor = System.Drawing.Color.Transparent;
            this.lblPozicija.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.lblPozicija.Location = new System.Drawing.Point(159, 6);
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
            this.lblImePrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.lblImePrezime.Location = new System.Drawing.Point(33, 6);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(86, 23);
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
            this.pictureIgracSlika.Location = new System.Drawing.Point(6, 3);
            this.pictureIgracSlika.Name = "pictureIgracSlika";
            this.pictureIgracSlika.Size = new System.Drawing.Size(28, 28);
            this.pictureIgracSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIgracSlika.TabIndex = 51;
            this.pictureIgracSlika.TabStop = false;
            this.pictureIgracSlika.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblBrojDresa
            // 
            this.lblBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojDresa.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojDresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.lblBrojDresa.Location = new System.Drawing.Point(201, 6);
            this.lblBrojDresa.Name = "lblBrojDresa";
            this.lblBrojDresa.Size = new System.Drawing.Size(34, 23);
            this.lblBrojDresa.TabIndex = 56;
            this.lblBrojDresa.Text = "#10";
            this.lblBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKapiten
            // 
            this.lblKapiten.BackColor = System.Drawing.Color.Yellow;
            this.lblKapiten.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapiten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.lblKapiten.Location = new System.Drawing.Point(121, 6);
            this.lblKapiten.Name = "lblKapiten";
            this.lblKapiten.Size = new System.Drawing.Size(27, 23);
            this.lblKapiten.TabIndex = 57;
            this.lblKapiten.Text = "(C)";
            this.lblKapiten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmUtakmicaSastavKartica_detaljiUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lblKapiten);
            this.Controls.Add(this.lblBrojDresa);
            this.Controls.Add(this.pictureIgracSlika);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblImePrezime);
            this.Name = "frmUtakmicaSastavKartica_detaljiUtakmice";
            this.Size = new System.Drawing.Size(235, 35);
            this.Load += new System.EventHandler(this.frmUtakmicaSastavKartica_detaljiUtakmice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPictureBox pictureIgracSlika;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblBrojDresa;
        private System.Windows.Forms.Label lblKapiten;
    }
}
