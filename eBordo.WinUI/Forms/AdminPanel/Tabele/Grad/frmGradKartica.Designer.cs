
namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Grad
{
    partial class frmGradKartica
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
            this.lblNazivDrzave = new System.Windows.Forms.Label();
            this.picureZastava = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picureZastava)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::eBordo.WinUI.Properties.Resources.edit2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(181, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNazivDrzave
            // 
            this.lblNazivDrzave.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivDrzave.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivDrzave.ForeColor = System.Drawing.Color.Black;
            this.lblNazivDrzave.Location = new System.Drawing.Point(31, 6);
            this.lblNazivDrzave.Name = "lblNazivDrzave";
            this.lblNazivDrzave.Size = new System.Drawing.Size(116, 23);
            this.lblNazivDrzave.TabIndex = 58;
            this.lblNazivDrzave.Text = "Bosna i Hercegovina";
            this.lblNazivDrzave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picureZastava
            // 
            this.picureZastava.Location = new System.Drawing.Point(5, 5);
            this.picureZastava.Name = "picureZastava";
            this.picureZastava.Size = new System.Drawing.Size(25, 25);
            this.picureZastava.TabIndex = 57;
            this.picureZastava.TabStop = false;
            // 
            // frmGradKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNazivDrzave);
            this.Controls.Add(this.picureZastava);
            this.Name = "frmGradKartica";
            this.Size = new System.Drawing.Size(207, 35);
            this.Load += new System.EventHandler(this.frmGradKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picureZastava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.Label lblNazivDrzave;
        private System.Windows.Forms.PictureBox picureZastava;
    }
}
