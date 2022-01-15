
namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Klubovi
{
    partial class frmKlubKartica
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
            this.picureGrb = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.lblNazivKluba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picureGrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // picureGrb
            // 
            this.picureGrb.Location = new System.Drawing.Point(5, 5);
            this.picureGrb.Name = "picureGrb";
            this.picureGrb.Size = new System.Drawing.Size(25, 25);
            this.picureGrb.TabIndex = 0;
            this.picureGrb.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::eBordo.WinUI.Properties.Resources.edit2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(181, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNazivKluba
            // 
            this.lblNazivKluba.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivKluba.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivKluba.ForeColor = System.Drawing.Color.Black;
            this.lblNazivKluba.Location = new System.Drawing.Point(31, 7);
            this.lblNazivKluba.Name = "lblNazivKluba";
            this.lblNazivKluba.Size = new System.Drawing.Size(116, 23);
            this.lblNazivKluba.TabIndex = 51;
            this.lblNazivKluba.Text = "FK Sarajevo";
            this.lblNazivKluba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmKlubKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNazivKluba);
            this.Controls.Add(this.picureGrb);
            this.Name = "frmKlubKartica";
            this.Size = new System.Drawing.Size(207, 35);
            this.Load += new System.EventHandler(this.frmKlubKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picureGrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picureGrb;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.Label lblNazivKluba;
    }
}
