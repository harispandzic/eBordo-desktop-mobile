
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
            this.frmPrikazKlubova1 = new eBordo.WinUI.Forms.AdminPanel.Tabele.Klubovi.frmPrikazKlubova();
            this.tabStadioni = new System.Windows.Forms.TabPage();
            this.frmPrikazStadiona1 = new eBordo.WinUI.Forms.AdminPanel.Tabele.Stadion.frmPrikazStadiona();
            this.tabDrzave = new System.Windows.Forms.TabPage();
            this.frmPrikazDrzava1 = new eBordo.WinUI.Forms.AdminPanel.Tabele.Države.frmPrikazDrzava();
            this.tabGradovi = new System.Windows.Forms.TabPage();
            this.frmPrikazGradova1 = new eBordo.WinUI.Forms.AdminPanel.Tabele.Grad.frmPrikazGradova();
            this.tabTakmicenja = new System.Windows.Forms.TabPage();
            this.frmTakmicenjaPrikaz1 = new eBordo.WinUI.Forms.AdminPanel.Tabele.Takmičenja.frmTakmicenjaPrikaz();
            this.cmbTabele = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.tabelePages.SuspendLayout();
            this.tabKlubovi.SuspendLayout();
            this.tabStadioni.SuspendLayout();
            this.tabDrzave.SuspendLayout();
            this.tabGradovi.SuspendLayout();
            this.tabTakmicenja.SuspendLayout();
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
            this.tabelePages.Location = new System.Drawing.Point(20, 57);
            this.tabelePages.Multiline = true;
            this.tabelePages.Name = "tabelePages";
            this.tabelePages.Page = this.tabKlubovi;
            this.tabelePages.PageIndex = 0;
            this.tabelePages.PageName = "tabKlubovi";
            this.tabelePages.PageTitle = "Klubovi";
            this.tabelePages.SelectedIndex = 0;
            this.tabelePages.Size = new System.Drawing.Size(595, 343);
            this.tabelePages.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
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
            this.tabKlubovi.Controls.Add(this.frmPrikazKlubova1);
            this.tabKlubovi.Location = new System.Drawing.Point(4, 4);
            this.tabKlubovi.Name = "tabKlubovi";
            this.tabKlubovi.Padding = new System.Windows.Forms.Padding(3);
            this.tabKlubovi.Size = new System.Drawing.Size(587, 317);
            this.tabKlubovi.TabIndex = 0;
            this.tabKlubovi.Text = "Klubovi";
            this.tabKlubovi.UseVisualStyleBackColor = true;
            // 
            // frmPrikazKlubova1
            // 
            this.frmPrikazKlubova1.Location = new System.Drawing.Point(0, 0);
            this.frmPrikazKlubova1.Name = "frmPrikazKlubova1";
            this.frmPrikazKlubova1.Size = new System.Drawing.Size(587, 317);
            this.frmPrikazKlubova1.TabIndex = 0;
            // 
            // tabStadioni
            // 
            this.tabStadioni.Controls.Add(this.frmPrikazStadiona1);
            this.tabStadioni.Location = new System.Drawing.Point(4, 4);
            this.tabStadioni.Name = "tabStadioni";
            this.tabStadioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabStadioni.Size = new System.Drawing.Size(587, 317);
            this.tabStadioni.TabIndex = 1;
            this.tabStadioni.Text = "Stadioni";
            this.tabStadioni.UseVisualStyleBackColor = true;
            // 
            // frmPrikazStadiona1
            // 
            this.frmPrikazStadiona1.Location = new System.Drawing.Point(0, 0);
            this.frmPrikazStadiona1.Name = "frmPrikazStadiona1";
            this.frmPrikazStadiona1.Size = new System.Drawing.Size(587, 317);
            this.frmPrikazStadiona1.TabIndex = 0;
            // 
            // tabDrzave
            // 
            this.tabDrzave.Controls.Add(this.frmPrikazDrzava1);
            this.tabDrzave.Location = new System.Drawing.Point(4, 4);
            this.tabDrzave.Name = "tabDrzave";
            this.tabDrzave.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrzave.Size = new System.Drawing.Size(587, 317);
            this.tabDrzave.TabIndex = 2;
            this.tabDrzave.Text = "Države";
            this.tabDrzave.UseVisualStyleBackColor = true;
            // 
            // frmPrikazDrzava1
            // 
            this.frmPrikazDrzava1.Location = new System.Drawing.Point(0, 0);
            this.frmPrikazDrzava1.Name = "frmPrikazDrzava1";
            this.frmPrikazDrzava1.Size = new System.Drawing.Size(587, 317);
            this.frmPrikazDrzava1.TabIndex = 0;
            // 
            // tabGradovi
            // 
            this.tabGradovi.Controls.Add(this.frmPrikazGradova1);
            this.tabGradovi.Location = new System.Drawing.Point(4, 4);
            this.tabGradovi.Name = "tabGradovi";
            this.tabGradovi.Padding = new System.Windows.Forms.Padding(3);
            this.tabGradovi.Size = new System.Drawing.Size(587, 317);
            this.tabGradovi.TabIndex = 3;
            this.tabGradovi.Text = "Gradovi";
            this.tabGradovi.UseVisualStyleBackColor = true;
            // 
            // frmPrikazGradova1
            // 
            this.frmPrikazGradova1.Location = new System.Drawing.Point(0, 0);
            this.frmPrikazGradova1.Name = "frmPrikazGradova1";
            this.frmPrikazGradova1.Size = new System.Drawing.Size(587, 317);
            this.frmPrikazGradova1.TabIndex = 0;
            // 
            // tabTakmicenja
            // 
            this.tabTakmicenja.Controls.Add(this.frmTakmicenjaPrikaz1);
            this.tabTakmicenja.Location = new System.Drawing.Point(4, 4);
            this.tabTakmicenja.Name = "tabTakmicenja";
            this.tabTakmicenja.Padding = new System.Windows.Forms.Padding(3);
            this.tabTakmicenja.Size = new System.Drawing.Size(587, 317);
            this.tabTakmicenja.TabIndex = 4;
            this.tabTakmicenja.Text = "Takmičenja";
            this.tabTakmicenja.UseVisualStyleBackColor = true;
            // 
            // frmTakmicenjaPrikaz1
            // 
            this.frmTakmicenjaPrikaz1.Location = new System.Drawing.Point(0, 0);
            this.frmTakmicenjaPrikaz1.Name = "frmTakmicenjaPrikaz1";
            this.frmTakmicenjaPrikaz1.Size = new System.Drawing.Size(587, 317);
            this.frmTakmicenjaPrikaz1.TabIndex = 0;
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
            this.cmbTabele.Location = new System.Drawing.Point(415, 9);
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
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(20, 47);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(560, 14);
            this.bunifuSeparator1.TabIndex = 5;
            // 
            // frmTabelePocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblNaslovStranice);
            this.Controls.Add(this.cmbTabele);
            this.Controls.Add(this.tabelePages);
            this.Name = "frmTabelePocetna";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmTabelePocetna_Load);
            this.tabelePages.ResumeLayout(false);
            this.tabKlubovi.ResumeLayout(false);
            this.tabStadioni.ResumeLayout(false);
            this.tabDrzave.ResumeLayout(false);
            this.tabGradovi.ResumeLayout(false);
            this.tabTakmicenja.ResumeLayout(false);
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
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Klubovi.frmPrikazKlubova frmPrikazKlubova1;
        private Države.frmPrikazDrzava frmPrikazDrzava1;
        private Takmičenja.frmTakmicenjaPrikaz frmTakmicenjaPrikaz1;
        private Stadion.frmPrikazStadiona frmPrikazStadiona1;
        private Grad.frmPrikazGradova frmPrikazGradova1;
    }
}
