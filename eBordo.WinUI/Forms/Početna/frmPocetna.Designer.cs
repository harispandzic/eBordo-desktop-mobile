
namespace eBordo.WinUI.Forms.Početna
{
    partial class frmPocetna
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPocetna));
            this.loggedUserAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.prikazIgraca1 = new eBordo.WinUI.UserControls.PrikazIgraca();
            ((System.ComponentModel.ISupportInitialize)(this.loggedUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // loggedUserAvatar
            // 
            this.loggedUserAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loggedUserAvatar.Cursor = System.Windows.Forms.Cursors.No;
            this.loggedUserAvatar.Image = ((System.Drawing.Image)(resources.GetObject("loggedUserAvatar.Image")));
            this.loggedUserAvatar.ImageRotate = 0F;
            this.loggedUserAvatar.Location = new System.Drawing.Point(12, 12);
            this.loggedUserAvatar.Name = "loggedUserAvatar";
            this.loggedUserAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.loggedUserAvatar.ShadowDecoration.Parent = this.loggedUserAvatar;
            this.loggedUserAvatar.Size = new System.Drawing.Size(30, 30);
            this.loggedUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loggedUserAvatar.TabIndex = 0;
            this.loggedUserAvatar.TabStop = false;
            this.loggedUserAvatar.Click += new System.EventHandler(this.loggedUserAvatar_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(58, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(3, 2);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = null;
            // 
            // prikazIgraca1
            // 
            this.prikazIgraca1.Location = new System.Drawing.Point(75, 38);
            this.prikazIgraca1.Name = "prikazIgraca1";
            this.prikazIgraca1.Size = new System.Drawing.Size(669, 471);
            this.prikazIgraca1.TabIndex = 2;
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prikazIgraca1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.loggedUserAvatar);
            this.Name = "frmPocetna";
            this.Text = "frmPocetna";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loggedUserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox loggedUserAvatar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private UserControls.PrikazIgraca prikazIgraca1;
    }
}