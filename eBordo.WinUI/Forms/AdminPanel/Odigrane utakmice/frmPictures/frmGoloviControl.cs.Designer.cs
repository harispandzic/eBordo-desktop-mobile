
namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice.frmPictures
{
    partial class frmGoloviControl
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
            this.pictureGolovi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGolovi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureGolovi
            // 
            this.pictureGolovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureGolovi.Image = global::eBordo.WinUI.Properties.Resources.ezgif_com_gif_maker;
            this.pictureGolovi.Location = new System.Drawing.Point(-1, -2);
            this.pictureGolovi.Name = "pictureGolovi";
            this.pictureGolovi.Size = new System.Drawing.Size(16, 25);
            this.pictureGolovi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGolovi.TabIndex = 154;
            this.pictureGolovi.TabStop = false;
            // 
            // frmGoloviControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureGolovi);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Name = "frmGoloviControl";
            this.Size = new System.Drawing.Size(15, 22);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGolovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureGolovi;
    }
}
