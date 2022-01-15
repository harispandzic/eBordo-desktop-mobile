
namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    partial class frmIzmjeneKartica_detalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzmjeneKartica_detalji));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtMinuta = new System.Windows.Forms.Label();
            this.pictureIgracIn = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureIgracOut = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIgracOutPrezime = new System.Windows.Forms.Label();
            this.txtIgracInPrezime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::eBordo.WinUI.Properties.Resources.eBordo_igracIn;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(152, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 12);
            this.pictureBox2.TabIndex = 172;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txtMinuta);
            this.bunifuPanel1.Location = new System.Drawing.Point(-6, -6);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(44, 45);
            this.bunifuPanel1.TabIndex = 171;
            // 
            // txtMinuta
            // 
            this.txtMinuta.BackColor = System.Drawing.Color.Transparent;
            this.txtMinuta.Font = new System.Drawing.Font("Oswald", 10F);
            this.txtMinuta.ForeColor = System.Drawing.Color.White;
            this.txtMinuta.Location = new System.Drawing.Point(5, 11);
            this.txtMinuta.Name = "txtMinuta";
            this.txtMinuta.Size = new System.Drawing.Size(31, 23);
            this.txtMinuta.TabIndex = 142;
            this.txtMinuta.Text = "90\'";
            this.txtMinuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureIgracIn
            // 
            this.pictureIgracIn.AllowFocused = false;
            this.pictureIgracIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureIgracIn.AutoSizeHeight = true;
            this.pictureIgracIn.BorderRadius = 12;
            this.pictureIgracIn.Image = global::eBordo.WinUI.Properties.Resources.Screenshot_12;
            this.pictureIgracIn.IsCircle = true;
            this.pictureIgracIn.Location = new System.Drawing.Point(56, 4);
            this.pictureIgracIn.Name = "pictureIgracIn";
            this.pictureIgracIn.Size = new System.Drawing.Size(25, 25);
            this.pictureIgracIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIgracIn.TabIndex = 169;
            this.pictureIgracIn.TabStop = false;
            this.pictureIgracIn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pictureIgracOut
            // 
            this.pictureIgracOut.AllowFocused = false;
            this.pictureIgracOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureIgracOut.AutoSizeHeight = true;
            this.pictureIgracOut.BorderRadius = 12;
            this.pictureIgracOut.Image = global::eBordo.WinUI.Properties.Resources.Screenshot_12;
            this.pictureIgracOut.IsCircle = true;
            this.pictureIgracOut.Location = new System.Drawing.Point(42, 4);
            this.pictureIgracOut.Name = "pictureIgracOut";
            this.pictureIgracOut.Size = new System.Drawing.Size(25, 25);
            this.pictureIgracOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIgracOut.TabIndex = 170;
            this.pictureIgracOut.TabStop = false;
            this.pictureIgracOut.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::eBordo.WinUI.Properties.Resources.eBordo_igracOut;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(139, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // txtIgracOutPrezime
            // 
            this.txtIgracOutPrezime.BackColor = System.Drawing.Color.Transparent;
            this.txtIgracOutPrezime.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgracOutPrezime.ForeColor = System.Drawing.Color.Black;
            this.txtIgracOutPrezime.Location = new System.Drawing.Point(62, 6);
            this.txtIgracOutPrezime.Name = "txtIgracOutPrezime";
            this.txtIgracOutPrezime.Size = new System.Drawing.Size(80, 23);
            this.txtIgracOutPrezime.TabIndex = 167;
            this.txtIgracOutPrezime.Text = "M. Ahmetović";
            this.txtIgracOutPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIgracInPrezime
            // 
            this.txtIgracInPrezime.BackColor = System.Drawing.Color.Transparent;
            this.txtIgracInPrezime.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgracInPrezime.ForeColor = System.Drawing.Color.Black;
            this.txtIgracInPrezime.Location = new System.Drawing.Point(162, 6);
            this.txtIgracInPrezime.Name = "txtIgracInPrezime";
            this.txtIgracInPrezime.Size = new System.Drawing.Size(84, 23);
            this.txtIgracInPrezime.TabIndex = 166;
            this.txtIgracInPrezime.Text = "M. Ahmetović";
            this.txtIgracInPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 23);
            this.label1.TabIndex = 173;
            this.label1.Text = "T";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmIzmjeneKartica_detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.pictureIgracIn);
            this.Controls.Add(this.pictureIgracOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIgracOutPrezime);
            this.Controls.Add(this.txtIgracInPrezime);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Name = "frmIzmjeneKartica_detalji";
            this.Size = new System.Drawing.Size(279, 33);
            this.Load += new System.EventHandler(this.frmIzmjeneKartica_detalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIgracOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label txtMinuta;
        private Bunifu.UI.WinForms.BunifuPictureBox pictureIgracIn;
        private Bunifu.UI.WinForms.BunifuPictureBox pictureIgracOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtIgracOutPrezime;
        private System.Windows.Forms.Label txtIgracInPrezime;
        private System.Windows.Forms.Label label1;
    }
}
