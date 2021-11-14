
namespace eBordo.WinUI.Forms.AdminPanel.Tabele
{
    partial class frmTabelePocetna
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabelePocetna));
            this.tabelePages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabKlubovi = new System.Windows.Forms.TabPage();
            this.tabStadioni = new System.Windows.Forms.TabPage();
            this.cmbTabele = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.tabDrzave = new System.Windows.Forms.TabPage();
            this.tabGradovi = new System.Windows.Forms.TabPage();
            this.tabTakmicenja = new System.Windows.Forms.TabPage();
            this.tabPozicije = new System.Windows.Forms.TabPage();
            this.tabFormacije = new System.Windows.Forms.TabPage();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.frmKlubovi1 = new eBordo.WinUI.Forms.AdminPanel.Tabele.Klubovi.frmKlubovi();
            this.tabelePages.SuspendLayout();
            this.tabKlubovi.SuspendLayout();
            this.tabStadioni.SuspendLayout();
            this.tabDrzave.SuspendLayout();
            this.tabGradovi.SuspendLayout();
            this.tabTakmicenja.SuspendLayout();
            this.tabPozicije.SuspendLayout();
            this.tabFormacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelePages
            // 
            this.tabelePages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabelePages.AllowTransitions = false;
            this.tabelePages.Controls.Add(this.tabKlubovi);
            this.tabelePages.Controls.Add(this.tabStadioni);
            this.tabelePages.Controls.Add(this.tabDrzave);
            this.tabelePages.Controls.Add(this.tabGradovi);
            this.tabelePages.Controls.Add(this.tabTakmicenja);
            this.tabelePages.Controls.Add(this.tabPozicije);
            this.tabelePages.Controls.Add(this.tabFormacije);
            this.tabelePages.Location = new System.Drawing.Point(20, 108);
            this.tabelePages.Multiline = true;
            this.tabelePages.Name = "tabelePages";
            this.tabelePages.Page = this.tabKlubovi;
            this.tabelePages.PageIndex = 0;
            this.tabelePages.PageName = "tabKlubovi";
            this.tabelePages.PageTitle = "Klubovi";
            this.tabelePages.SelectedIndex = 0;
            this.tabelePages.Size = new System.Drawing.Size(589, 295);
            this.tabelePages.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tabelePages.Transition = animation1;
            this.tabelePages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabKlubovi
            // 
            this.tabKlubovi.Controls.Add(this.frmKlubovi1);
            this.tabKlubovi.Location = new System.Drawing.Point(4, 4);
            this.tabKlubovi.Name = "tabKlubovi";
            this.tabKlubovi.Padding = new System.Windows.Forms.Padding(3);
            this.tabKlubovi.Size = new System.Drawing.Size(581, 269);
            this.tabKlubovi.TabIndex = 0;
            this.tabKlubovi.Text = "Klubovi";
            this.tabKlubovi.UseVisualStyleBackColor = true;
            // 
            // tabStadioni
            // 
            this.tabStadioni.Controls.Add(this.bunifuLabel2);
            this.tabStadioni.Location = new System.Drawing.Point(4, 4);
            this.tabStadioni.Name = "tabStadioni";
            this.tabStadioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabStadioni.Size = new System.Drawing.Size(581, 269);
            this.tabStadioni.TabIndex = 1;
            this.tabStadioni.Text = "Stadioni";
            this.tabStadioni.UseVisualStyleBackColor = true;
            // 
            // cmbTabele
            // 
            this.cmbTabele.BackColor = System.Drawing.Color.Transparent;
            this.cmbTabele.BackgroundColor = System.Drawing.Color.White;
            this.cmbTabele.BorderColor = System.Drawing.Color.Silver;
            this.cmbTabele.BorderRadius = 1;
            this.cmbTabele.Color = System.Drawing.Color.Silver;
            this.cmbTabele.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbTabele.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbTabele.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbTabele.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbTabele.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbTabele.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbTabele.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTabele.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbTabele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabele.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbTabele.FillDropDown = true;
            this.cmbTabele.FillIndicator = false;
            this.cmbTabele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTabele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTabele.ForeColor = System.Drawing.Color.Black;
            this.cmbTabele.FormattingEnabled = true;
            this.cmbTabele.Icon = null;
            this.cmbTabele.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbTabele.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbTabele.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbTabele.IndicatorThickness = 2;
            this.cmbTabele.IsDropdownOpened = false;
            this.cmbTabele.ItemBackColor = System.Drawing.Color.White;
            this.cmbTabele.ItemBorderColor = System.Drawing.Color.White;
            this.cmbTabele.ItemForeColor = System.Drawing.Color.Black;
            this.cmbTabele.ItemHeight = 26;
            this.cmbTabele.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.cmbTabele.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbTabele.ItemTopMargin = 3;
            this.cmbTabele.Location = new System.Drawing.Point(20, 70);
            this.cmbTabele.Name = "cmbTabele";
            this.cmbTabele.Size = new System.Drawing.Size(165, 32);
            this.cmbTabele.TabIndex = 3;
            this.cmbTabele.Text = "Tabela";
            this.cmbTabele.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbTabele.TextLeftMargin = 5;
            this.cmbTabele.SelectedIndexChanged += new System.EventHandler(this.cmbTabele_SelectedIndexChanged);
            // 
            // lblNaslovStranice
            // 
            this.lblNaslovStranice.AllowParentOverrides = false;
            this.lblNaslovStranice.AutoEllipsis = false;
            this.lblNaslovStranice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNaslovStranice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNaslovStranice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovStranice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.lblNaslovStranice.Location = new System.Drawing.Point(20, 16);
            this.lblNaslovStranice.Name = "lblNaslovStranice";
            this.lblNaslovStranice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNaslovStranice.Size = new System.Drawing.Size(317, 21);
            this.lblNaslovStranice.TabIndex = 4;
            this.lblNaslovStranice.Text = "ADMINISTRACIJA POMOĆNIM TABELAMA";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tabDrzave
            // 
            this.tabDrzave.Controls.Add(this.bunifuLabel3);
            this.tabDrzave.Location = new System.Drawing.Point(4, 4);
            this.tabDrzave.Name = "tabDrzave";
            this.tabDrzave.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrzave.Size = new System.Drawing.Size(581, 269);
            this.tabDrzave.TabIndex = 2;
            this.tabDrzave.Text = "Države";
            this.tabDrzave.UseVisualStyleBackColor = true;
            // 
            // tabGradovi
            // 
            this.tabGradovi.Controls.Add(this.bunifuLabel4);
            this.tabGradovi.Location = new System.Drawing.Point(4, 4);
            this.tabGradovi.Name = "tabGradovi";
            this.tabGradovi.Padding = new System.Windows.Forms.Padding(3);
            this.tabGradovi.Size = new System.Drawing.Size(581, 269);
            this.tabGradovi.TabIndex = 3;
            this.tabGradovi.Text = "Gradovi";
            this.tabGradovi.UseVisualStyleBackColor = true;
            // 
            // tabTakmicenja
            // 
            this.tabTakmicenja.Controls.Add(this.bunifuLabel5);
            this.tabTakmicenja.Location = new System.Drawing.Point(4, 4);
            this.tabTakmicenja.Name = "tabTakmicenja";
            this.tabTakmicenja.Padding = new System.Windows.Forms.Padding(3);
            this.tabTakmicenja.Size = new System.Drawing.Size(581, 269);
            this.tabTakmicenja.TabIndex = 4;
            this.tabTakmicenja.Text = "Takmičenja";
            this.tabTakmicenja.UseVisualStyleBackColor = true;
            // 
            // tabPozicije
            // 
            this.tabPozicije.Controls.Add(this.bunifuLabel6);
            this.tabPozicije.Location = new System.Drawing.Point(4, 4);
            this.tabPozicije.Name = "tabPozicije";
            this.tabPozicije.Padding = new System.Windows.Forms.Padding(3);
            this.tabPozicije.Size = new System.Drawing.Size(581, 269);
            this.tabPozicije.TabIndex = 5;
            this.tabPozicije.Text = "Pozicije";
            this.tabPozicije.UseVisualStyleBackColor = true;
            // 
            // tabFormacije
            // 
            this.tabFormacije.Controls.Add(this.bunifuLabel7);
            this.tabFormacije.Location = new System.Drawing.Point(4, 4);
            this.tabFormacije.Name = "tabFormacije";
            this.tabFormacije.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormacije.Size = new System.Drawing.Size(581, 269);
            this.tabFormacije.TabIndex = 6;
            this.tabFormacije.Text = "Formacije";
            this.tabFormacije.UseVisualStyleBackColor = true;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(271, 127);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(42, 15);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "stadioni";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(271, 127);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(34, 15);
            this.bunifuLabel3.TabIndex = 1;
            this.bunifuLabel3.Text = "drzave";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(271, 127);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(40, 15);
            this.bunifuLabel4.TabIndex = 1;
            this.bunifuLabel4.Text = "gradovi";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.Location = new System.Drawing.Point(271, 127);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(58, 15);
            this.bunifuLabel5.TabIndex = 1;
            this.bunifuLabel5.Text = "takmicenja";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel6.Location = new System.Drawing.Point(271, 127);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(40, 15);
            this.bunifuLabel6.TabIndex = 1;
            this.bunifuLabel6.Text = "pozicije";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel7.Location = new System.Drawing.Point(271, 127);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(50, 15);
            this.bunifuLabel7.TabIndex = 1;
            this.bunifuLabel7.Text = "formacije";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmKlubovi1
            // 
            this.frmKlubovi1.Location = new System.Drawing.Point(0, 0);
            this.frmKlubovi1.Name = "frmKlubovi1";
            this.frmKlubovi1.Size = new System.Drawing.Size(581, 269);
            this.frmKlubovi1.TabIndex = 0;
            // 
            // frmTabelePocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNaslovStranice);
            this.Controls.Add(this.cmbTabele);
            this.Controls.Add(this.tabelePages);
            this.Name = "frmTabelePocetna";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmTabelePocetna_Load);
            this.tabelePages.ResumeLayout(false);
            this.tabKlubovi.ResumeLayout(false);
            this.tabStadioni.ResumeLayout(false);
            this.tabStadioni.PerformLayout();
            this.tabDrzave.ResumeLayout(false);
            this.tabDrzave.PerformLayout();
            this.tabGradovi.ResumeLayout(false);
            this.tabGradovi.PerformLayout();
            this.tabTakmicenja.ResumeLayout(false);
            this.tabTakmicenja.PerformLayout();
            this.tabPozicije.ResumeLayout(false);
            this.tabPozicije.PerformLayout();
            this.tabFormacije.ResumeLayout(false);
            this.tabFormacije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPages tabelePages;
        private System.Windows.Forms.TabPage tabKlubovi;
        private System.Windows.Forms.TabPage tabStadioni;
        private Bunifu.UI.WinForms.BunifuDropdown cmbTabele;
        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private System.Windows.Forms.TabPage tabDrzave;
        private System.Windows.Forms.TabPage tabGradovi;
        private System.Windows.Forms.TabPage tabTakmicenja;
        private System.Windows.Forms.TabPage tabPozicije;
        private System.Windows.Forms.TabPage tabFormacije;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Klubovi.frmKlubovi frmKlubovi1;
    }
}
