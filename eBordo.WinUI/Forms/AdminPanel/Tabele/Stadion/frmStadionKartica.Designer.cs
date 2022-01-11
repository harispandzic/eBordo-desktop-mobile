
namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Stadion
{
    partial class frmStadionKartica
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
            this.pictureSlikaStadiona = new System.Windows.Forms.PictureBox();
            this.lblNazivKluba = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlikaStadiona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSlikaStadiona
            // 
            this.pictureSlikaStadiona.Location = new System.Drawing.Point(0, 0);
            this.pictureSlikaStadiona.Name = "pictureSlikaStadiona";
            this.pictureSlikaStadiona.Size = new System.Drawing.Size(207, 127);
            this.pictureSlikaStadiona.TabIndex = 0;
            this.pictureSlikaStadiona.TabStop = false;
            this.pictureSlikaStadiona.Click += new System.EventHandler(this.pictureSlikaStadiona_Click);
            // 
            // lblNazivKluba
            // 
            this.lblNazivKluba.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivKluba.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivKluba.ForeColor = System.Drawing.Color.Black;
            this.lblNazivKluba.Location = new System.Drawing.Point(0, 94);
            this.lblNazivKluba.Name = "lblNazivKluba";
            this.lblNazivKluba.Size = new System.Drawing.Size(207, 33);
            this.lblNazivKluba.TabIndex = 52;
            this.lblNazivKluba.Text = "Asim Ferhatović Hase, Sarajevo";
            this.lblNazivKluba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::eBordo.WinUI.Properties.Resources.edit2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(183, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmStadionKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNazivKluba);
            this.Controls.Add(this.pictureSlikaStadiona);
            this.Name = "frmStadionKartica";
            this.Size = new System.Drawing.Size(207, 127);
            this.Load += new System.EventHandler(this.frmStadionKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlikaStadiona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSlikaStadiona;
        private System.Windows.Forms.Label lblNazivKluba;
        private System.Windows.Forms.PictureBox btnDelete;
    }
}
