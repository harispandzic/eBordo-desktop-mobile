
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
            this.pictureZastava = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlikaStadiona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZastava)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSlikaStadiona
            // 
            this.pictureSlikaStadiona.Location = new System.Drawing.Point(0, 0);
            this.pictureSlikaStadiona.Name = "pictureSlikaStadiona";
            this.pictureSlikaStadiona.Size = new System.Drawing.Size(115, 76);
            this.pictureSlikaStadiona.TabIndex = 0;
            this.pictureSlikaStadiona.TabStop = false;
            this.pictureSlikaStadiona.Click += new System.EventHandler(this.pictureSlikaStadiona_Click);
            // 
            // lblNazivKluba
            // 
            this.lblNazivKluba.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivKluba.Font = new System.Drawing.Font("Oswald", 7F);
            this.lblNazivKluba.ForeColor = System.Drawing.Color.Black;
            this.lblNazivKluba.Location = new System.Drawing.Point(0, 76);
            this.lblNazivKluba.MaximumSize = new System.Drawing.Size(97, 20);
            this.lblNazivKluba.MinimumSize = new System.Drawing.Size(97, 20);
            this.lblNazivKluba.Name = "lblNazivKluba";
            this.lblNazivKluba.Size = new System.Drawing.Size(97, 20);
            this.lblNazivKluba.TabIndex = 52;
            this.lblNazivKluba.Text = "Koševo";
            this.lblNazivKluba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnDelete.TabIndex = 54;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureZastava
            // 
            this.pictureZastava.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureZastava.BackgroundImage = global::eBordo.WinUI.Properties.Resources._300px_Flag_of_Bosnia_and_Herzegovina_svg;
            this.pictureZastava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureZastava.Location = new System.Drawing.Point(4, 4);
            this.pictureZastava.Name = "pictureZastava";
            this.pictureZastava.Size = new System.Drawing.Size(17, 14);
            this.pictureZastava.TabIndex = 118;
            this.pictureZastava.TabStop = false;
            // 
            // frmStadionKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pictureZastava);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNazivKluba);
            this.Controls.Add(this.pictureSlikaStadiona);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.Name = "frmStadionKartica";
            this.Size = new System.Drawing.Size(115, 98);
            this.Load += new System.EventHandler(this.frmStadionKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlikaStadiona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZastava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSlikaStadiona;
        private System.Windows.Forms.Label lblNazivKluba;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox pictureZastava;
    }
}
