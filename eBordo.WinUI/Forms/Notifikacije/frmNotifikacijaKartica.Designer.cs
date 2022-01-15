
namespace eBordo.WinUI.Forms.Notifikacije
{
    partial class frmNotifikacijaKartica
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
            this.txtDatumNotifikacije = new System.Windows.Forms.Label();
            this.txtTekstNotifikacije = new System.Windows.Forms.Label();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureTipNotifikacije = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTipNotifikacije)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDatumNotifikacije
            // 
            this.txtDatumNotifikacije.BackColor = System.Drawing.Color.Transparent;
            this.txtDatumNotifikacije.Font = new System.Drawing.Font("Oswald", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumNotifikacije.ForeColor = System.Drawing.Color.Black;
            this.txtDatumNotifikacije.Location = new System.Drawing.Point(48, 40);
            this.txtDatumNotifikacije.Name = "txtDatumNotifikacije";
            this.txtDatumNotifikacije.Size = new System.Drawing.Size(116, 17);
            this.txtDatumNotifikacije.TabIndex = 61;
            this.txtDatumNotifikacije.Text = "M. Ahmetović #9";
            this.txtDatumNotifikacije.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTekstNotifikacije
            // 
            this.txtTekstNotifikacije.AutoSize = true;
            this.txtTekstNotifikacije.BackColor = System.Drawing.Color.Transparent;
            this.txtTekstNotifikacije.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTekstNotifikacije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.txtTekstNotifikacije.Location = new System.Drawing.Point(37, 5);
            this.txtTekstNotifikacije.MaximumSize = new System.Drawing.Size(208, 34);
            this.txtTekstNotifikacije.Name = "txtTekstNotifikacije";
            this.txtTekstNotifikacije.Size = new System.Drawing.Size(164, 32);
            this.txtTekstNotifikacije.TabIndex = 59;
            this.txtTekstNotifikacije.Text = "M. Ahmetović #9M. Ahmetović #9M. Ahmetović #9M. Ahmetović #9";
            this.txtTekstNotifikacije.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTekstNotifikacije.Click += new System.EventHandler(this.txtTekstNotifikacije_Click);
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox7.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBox7.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox7.IconSize = 10;
            this.iconPictureBox7.Location = new System.Drawing.Point(40, 44);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(10, 10);
            this.iconPictureBox7.TabIndex = 63;
            this.iconPictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::eBordo.WinUI.Properties.Resources.eBordo_DONEDONEDONE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(246, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureTipNotifikacije
            // 
            this.pictureTipNotifikacije.BackColor = System.Drawing.Color.Transparent;
            this.pictureTipNotifikacije.BackgroundImage = global::eBordo.WinUI.Properties.Resources.eBordo_success_notification;
            this.pictureTipNotifikacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureTipNotifikacije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureTipNotifikacije.Location = new System.Drawing.Point(3, 5);
            this.pictureTipNotifikacije.Name = "pictureTipNotifikacije";
            this.pictureTipNotifikacije.Size = new System.Drawing.Size(30, 30);
            this.pictureTipNotifikacije.TabIndex = 60;
            this.pictureTipNotifikacije.TabStop = false;
            // 
            // frmNotifikacijaKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.iconPictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDatumNotifikacije);
            this.Controls.Add(this.pictureTipNotifikacije);
            this.Controls.Add(this.txtTekstNotifikacije);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Name = "frmNotifikacijaKartica";
            this.Size = new System.Drawing.Size(269, 57);
            this.Load += new System.EventHandler(this.frmNotifikacijaKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTipNotifikacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtDatumNotifikacije;
        private System.Windows.Forms.PictureBox pictureTipNotifikacije;
        private System.Windows.Forms.Label txtTekstNotifikacije;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
    }
}
