
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlikaStadiona)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSlikaStadiona
            // 
            this.pictureSlikaStadiona.Location = new System.Drawing.Point(0, 0);
            this.pictureSlikaStadiona.Name = "pictureSlikaStadiona";
            this.pictureSlikaStadiona.Size = new System.Drawing.Size(181, 117);
            this.pictureSlikaStadiona.TabIndex = 0;
            this.pictureSlikaStadiona.TabStop = false;
            // 
            // lblNazivKluba
            // 
            this.lblNazivKluba.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivKluba.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivKluba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.lblNazivKluba.Location = new System.Drawing.Point(0, 94);
            this.lblNazivKluba.Name = "lblNazivKluba";
            this.lblNazivKluba.Size = new System.Drawing.Size(181, 23);
            this.lblNazivKluba.TabIndex = 52;
            this.lblNazivKluba.Text = "Asim Ferhatović Hase, Sarajevo";
            this.lblNazivKluba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStadionKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lblNazivKluba);
            this.Controls.Add(this.pictureSlikaStadiona);
            this.Name = "frmStadionKartica";
            this.Size = new System.Drawing.Size(181, 117);
            this.Load += new System.EventHandler(this.frmStadionKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlikaStadiona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSlikaStadiona;
        private System.Windows.Forms.Label lblNazivKluba;
    }
}
