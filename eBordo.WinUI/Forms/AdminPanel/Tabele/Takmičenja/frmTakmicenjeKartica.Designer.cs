
namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Takmičenja
{
    partial class frmTakmicenjeKartica
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
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.lblNazivTakmicenja = new System.Windows.Forms.Label();
            this.picureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::eBordo.WinUI.Properties.Resources.edit2;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(95, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(15, 15);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNazivTakmicenja
            // 
            this.lblNazivTakmicenja.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivTakmicenja.Font = new System.Drawing.Font("Oswald", 7F);
            this.lblNazivTakmicenja.ForeColor = System.Drawing.Color.Black;
            this.lblNazivTakmicenja.Location = new System.Drawing.Point(0, 76);
            this.lblNazivTakmicenja.Name = "lblNazivTakmicenja";
            this.lblNazivTakmicenja.Size = new System.Drawing.Size(97, 20);
            this.lblNazivTakmicenja.TabIndex = 55;
            this.lblNazivTakmicenja.Text = "M:tel Premier Liga";
            this.lblNazivTakmicenja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picureLogo
            // 
            this.picureLogo.Location = new System.Drawing.Point(0, 7);
            this.picureLogo.Name = "picureLogo";
            this.picureLogo.Size = new System.Drawing.Size(115, 60);
            this.picureLogo.TabIndex = 54;
            this.picureLogo.TabStop = false;
            // 
            // frmTakmicenjeKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNazivTakmicenja);
            this.Controls.Add(this.picureLogo);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.Name = "frmTakmicenjeKartica";
            this.Size = new System.Drawing.Size(115, 98);
            this.Load += new System.EventHandler(this.frmTakmicenjeKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.Label lblNazivTakmicenja;
        private System.Windows.Forms.PictureBox picureLogo;
    }
}
