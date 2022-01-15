
namespace eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica
{
    partial class frmPozvaniIgracKartica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPozvaniIgracKartica));
            this.pictureIgracSlika = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblImePrezimeBrojDresa = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtBrojDresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureIgracSlika
            // 
            this.pictureIgracSlika.AllowFocused = false;
            this.pictureIgracSlika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureIgracSlika.AutoSizeHeight = true;
            this.pictureIgracSlika.BorderRadius = 14;
            this.pictureIgracSlika.Image = global::eBordo.WinUI.Properties.Resources.Screenshot_12;
            this.pictureIgracSlika.IsCircle = true;
            this.pictureIgracSlika.Location = new System.Drawing.Point(40, 4);
            this.pictureIgracSlika.Name = "pictureIgracSlika";
            this.pictureIgracSlika.Size = new System.Drawing.Size(28, 28);
            this.pictureIgracSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIgracSlika.TabIndex = 1;
            this.pictureIgracSlika.TabStop = false;
            this.pictureIgracSlika.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblImePrezimeBrojDresa
            // 
            this.lblImePrezimeBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.lblImePrezimeBrojDresa.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezimeBrojDresa.ForeColor = System.Drawing.Color.Black;
            this.lblImePrezimeBrojDresa.Location = new System.Drawing.Point(67, 7);
            this.lblImePrezimeBrojDresa.Name = "lblImePrezimeBrojDresa";
            this.lblImePrezimeBrojDresa.Size = new System.Drawing.Size(89, 23);
            this.lblImePrezimeBrojDresa.TabIndex = 42;
            this.lblImePrezimeBrojDresa.Text = "M. Ahmetović";
            this.lblImePrezimeBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::eBordo.WinUI.Properties.Resources.delete2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(241, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::eBordo.WinUI.Properties.Resources.edit2;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(219, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(20, 20);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblPozicija
            // 
            this.lblPozicija.BackColor = System.Drawing.Color.Transparent;
            this.lblPozicija.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.ForeColor = System.Drawing.Color.Black;
            this.lblPozicija.Location = new System.Drawing.Point(156, 7);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(34, 23);
            this.lblPozicija.TabIndex = 49;
            this.lblPozicija.Text = "CMD";
            this.lblPozicija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = global::eBordo.WinUI.Properties.Resources.view22;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Location = new System.Drawing.Point(197, 8);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(20, 20);
            this.btnView.TabIndex = 50;
            this.btnView.TabStop = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.bunifuPanel1.Location = new System.Drawing.Point(-8, -9);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(44, 45);
            this.bunifuPanel1.TabIndex = 141;
            // 
            // txtBrojDresa
            // 
            this.txtBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.txtBrojDresa.Font = new System.Drawing.Font("Oswald", 10F);
            this.txtBrojDresa.ForeColor = System.Drawing.Color.White;
            this.txtBrojDresa.Location = new System.Drawing.Point(8, 14);
            this.txtBrojDresa.Name = "txtBrojDresa";
            this.txtBrojDresa.Size = new System.Drawing.Size(37, 23);
            this.txtBrojDresa.TabIndex = 142;
            this.txtBrojDresa.Text = "#12";
            this.txtBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPozvaniIgracKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.pictureIgracSlika);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblImePrezimeBrojDresa);
            this.Name = "frmPozvaniIgracKartica";
            this.Size = new System.Drawing.Size(270, 35);
            this.Load += new System.EventHandler(this.frmPozvaniIgracKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPictureBox pictureIgracSlika;
        private System.Windows.Forms.Label lblImePrezimeBrojDresa;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.PictureBox btnView;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label txtBrojDresa;
    }
}
