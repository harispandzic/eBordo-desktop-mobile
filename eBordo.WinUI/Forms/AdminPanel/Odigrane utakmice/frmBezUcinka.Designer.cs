
namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    partial class frmBezUcinka
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
            this.txtMinute = new System.Windows.Forms.Label();
            this.pictureNastupi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNastupi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMinute
            // 
            this.txtMinute.BackColor = System.Drawing.Color.Transparent;
            this.txtMinute.Font = new System.Drawing.Font("Oswald", 7F);
            this.txtMinute.ForeColor = System.Drawing.Color.Black;
            this.txtMinute.Location = new System.Drawing.Point(17, -1);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(69, 23);
            this.txtMinute.TabIndex = 362;
            this.txtMinute.Text = "Bez učinka!";
            this.txtMinute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureNastupi
            // 
            this.pictureNastupi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureNastupi.Image = global::eBordo.WinUI.Properties.Resources.eBordo_error_izvjestaj;
            this.pictureNastupi.Location = new System.Drawing.Point(0, -5);
            this.pictureNastupi.Name = "pictureNastupi";
            this.pictureNastupi.Size = new System.Drawing.Size(22, 33);
            this.pictureNastupi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureNastupi.TabIndex = 361;
            this.pictureNastupi.TabStop = false;
            // 
            // frmBezUcinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.pictureNastupi);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "frmBezUcinka";
            this.Size = new System.Drawing.Size(131, 22);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNastupi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtMinute;
        private System.Windows.Forms.PictureBox pictureNastupi;
    }
}
