
namespace eBordo.WinUI.Forms.AdminPanel.Igrač
{
    partial class frmIgracKartica
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
            this.igracOcjena = new Bunifu.UI.WinForms.BunifuRating();
            this.korisnickaFotografija = new System.Windows.Forms.PictureBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblBrojDresa = new System.Windows.Forms.Label();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.pictureZastava = new System.Windows.Forms.PictureBox();
            this.pictureAktivan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.korisnickaFotografija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZastava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAktivan)).BeginInit();
            this.SuspendLayout();
            // 
            // igracOcjena
            // 
            this.igracOcjena.BackColor = System.Drawing.Color.Transparent;
            this.igracOcjena.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.igracOcjena.DisabledRatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.igracOcjena.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.igracOcjena.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.igracOcjena.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.igracOcjena.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.igracOcjena.InnerRadius = 1F;
            this.igracOcjena.Location = new System.Drawing.Point(48, 238);
            this.igracOcjena.Name = "igracOcjena";
            this.igracOcjena.OuterRadius = 7F;
            this.igracOcjena.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.igracOcjena.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.igracOcjena.ReadOnly = true;
            this.igracOcjena.RightClickToClear = true;
            this.igracOcjena.Size = new System.Drawing.Size(91, 16);
            this.igracOcjena.TabIndex = 38;
            this.igracOcjena.Text = "jacinaSlabijeNogeVrijednost";
            this.igracOcjena.Value = 2;
            // 
            // korisnickaFotografija
            // 
            this.korisnickaFotografija.BackColor = System.Drawing.Color.Transparent;
            this.korisnickaFotografija.BackgroundImage = global::eBordo.WinUI.Properties.Resources.Picture12;
            this.korisnickaFotografija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.korisnickaFotografija.Location = new System.Drawing.Point(0, 0);
            this.korisnickaFotografija.Name = "korisnickaFotografija";
            this.korisnickaFotografija.Size = new System.Drawing.Size(188, 203);
            this.korisnickaFotografija.TabIndex = 39;
            this.korisnickaFotografija.TabStop = false;
            this.korisnickaFotografija.Click += new System.EventHandler(this.korisnickaFotografija_Click);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblImePrezime.Font = new System.Drawing.Font("Oswald", 11F);
            this.lblImePrezime.ForeColor = System.Drawing.Color.Transparent;
            this.lblImePrezime.Location = new System.Drawing.Point(0, 196);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(188, 23);
            this.lblImePrezime.TabIndex = 41;
            this.lblImePrezime.Text = "MERSUDIN AHMETOVIĆ";
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojDresa
            // 
            this.lblBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojDresa.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojDresa.ForeColor = System.Drawing.Color.Transparent;
            this.lblBrojDresa.Location = new System.Drawing.Point(0, 0);
            this.lblBrojDresa.Name = "lblBrojDresa";
            this.lblBrojDresa.Size = new System.Drawing.Size(44, 36);
            this.lblBrojDresa.TabIndex = 42;
            this.lblBrojDresa.Text = "#20";
            this.lblBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPozicija
            // 
            this.lblPozicija.BackColor = System.Drawing.Color.Transparent;
            this.lblPozicija.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.ForeColor = System.Drawing.Color.Transparent;
            this.lblPozicija.Location = new System.Drawing.Point(0, 217);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(188, 23);
            this.lblPozicija.TabIndex = 43;
            this.lblPozicija.Text = "NAPADAČ";
            this.lblPozicija.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = global::eBordo.WinUI.Properties.Resources.view22;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Location = new System.Drawing.Point(60, 259);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(20, 20);
            this.btnView.TabIndex = 47;
            this.btnView.TabStop = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::eBordo.WinUI.Properties.Resources.edit2;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(83, 259);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(20, 20);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::eBordo.WinUI.Properties.Resources.delete2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(106, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // pictureZastava
            // 
            this.pictureZastava.BackColor = System.Drawing.Color.Transparent;
            this.pictureZastava.BackgroundImage = global::eBordo.WinUI.Properties.Resources._300px_Flag_of_Bosnia_and_Herzegovina_svg;
            this.pictureZastava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureZastava.Location = new System.Drawing.Point(150, 3);
            this.pictureZastava.Name = "pictureZastava";
            this.pictureZastava.Size = new System.Drawing.Size(30, 28);
            this.pictureZastava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureZastava.TabIndex = 54;
            this.pictureZastava.TabStop = false;
            // 
            // pictureAktivan
            // 
            this.pictureAktivan.BackColor = System.Drawing.Color.Transparent;
            this.pictureAktivan.BackgroundImage = global::eBordo.WinUI.Properties.Resources.eBordo_success_notification;
            this.pictureAktivan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureAktivan.Location = new System.Drawing.Point(4, 30);
            this.pictureAktivan.Name = "pictureAktivan";
            this.pictureAktivan.Size = new System.Drawing.Size(15, 15);
            this.pictureAktivan.TabIndex = 116;
            this.pictureAktivan.TabStop = false;
            // 
            // frmIgracKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::eBordo.WinUI.Properties.Resources.Screenshot_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureAktivan);
            this.Controls.Add(this.pictureZastava);
            this.Controls.Add(this.igracOcjena);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblBrojDresa);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.korisnickaFotografija);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "frmIgracKartica";
            this.Size = new System.Drawing.Size(188, 286);
            this.Load += new System.EventHandler(this.frmIgracKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisnickaFotografija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZastava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAktivan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuRating igracOcjena;
        private System.Windows.Forms.PictureBox korisnickaFotografija;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblBrojDresa;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.PictureBox btnView;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox pictureZastava;
        private System.Windows.Forms.PictureBox pictureAktivan;
    }
}
