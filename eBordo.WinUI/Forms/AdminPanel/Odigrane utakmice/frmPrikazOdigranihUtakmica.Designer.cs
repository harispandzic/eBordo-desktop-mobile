
namespace eBordo.WinUI.Forms.AdminPanel.Odigrane_utakmice
{
    partial class frmPrikazOdigranihUtakmica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrikazOdigranihUtakmica));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbVrstaUtakmkce = new Bunifu.UI.WinForms.BunifuDropdown();
            this.pnlRasporedUtakmica = new System.Windows.Forms.Panel();
            this.pnlUtakmiceWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.cmbRezultat = new Bunifu.UI.WinForms.BunifuDropdown();
            this.loaderBrojIgraca = new Bunifu.UI.WinForms.BunifuLoader();
            this.txtBrojUtakmica = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDrzavljanstvoVrijednost = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveIgracSastav = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gifLoader = new System.Windows.Forms.PictureBox();
            this.pnlRasporedUtakmica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovStranice
            // 
            this.lblNaslovStranice.AllowParentOverrides = false;
            this.lblNaslovStranice.AutoEllipsis = false;
            this.lblNaslovStranice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNaslovStranice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNaslovStranice.Font = new System.Drawing.Font("Oswald", 12F);
            this.lblNaslovStranice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.lblNaslovStranice.Location = new System.Drawing.Point(20, 16);
            this.lblNaslovStranice.Name = "lblNaslovStranice";
            this.lblNaslovStranice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNaslovStranice.Size = new System.Drawing.Size(133, 24);
            this.lblNaslovStranice.TabIndex = 2;
            this.lblNaslovStranice.Text = "ODIGRANE UTAKMICE";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmbVrstaUtakmkce
            // 
            this.cmbVrstaUtakmkce.BackColor = System.Drawing.Color.Transparent;
            this.cmbVrstaUtakmkce.BackgroundColor = System.Drawing.Color.White;
            this.cmbVrstaUtakmkce.BorderColor = System.Drawing.Color.Silver;
            this.cmbVrstaUtakmkce.BorderRadius = 1;
            this.cmbVrstaUtakmkce.Color = System.Drawing.Color.Silver;
            this.cmbVrstaUtakmkce.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbVrstaUtakmkce.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbVrstaUtakmkce.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbVrstaUtakmkce.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbVrstaUtakmkce.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbVrstaUtakmkce.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbVrstaUtakmkce.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVrstaUtakmkce.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbVrstaUtakmkce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrstaUtakmkce.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbVrstaUtakmkce.FillDropDown = true;
            this.cmbVrstaUtakmkce.FillIndicator = false;
            this.cmbVrstaUtakmkce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVrstaUtakmkce.Font = new System.Drawing.Font("Oswald", 8.25F);
            this.cmbVrstaUtakmkce.ForeColor = System.Drawing.Color.Black;
            this.cmbVrstaUtakmkce.FormattingEnabled = true;
            this.cmbVrstaUtakmkce.Icon = null;
            this.cmbVrstaUtakmkce.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbVrstaUtakmkce.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbVrstaUtakmkce.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbVrstaUtakmkce.IndicatorThickness = 2;
            this.cmbVrstaUtakmkce.IsDropdownOpened = false;
            this.cmbVrstaUtakmkce.ItemBackColor = System.Drawing.Color.White;
            this.cmbVrstaUtakmkce.ItemBorderColor = System.Drawing.Color.White;
            this.cmbVrstaUtakmkce.ItemForeColor = System.Drawing.Color.Black;
            this.cmbVrstaUtakmkce.ItemHeight = 26;
            this.cmbVrstaUtakmkce.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.cmbVrstaUtakmkce.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbVrstaUtakmkce.ItemTopMargin = 3;
            this.cmbVrstaUtakmkce.Location = new System.Drawing.Point(69, 70);
            this.cmbVrstaUtakmkce.Name = "cmbVrstaUtakmkce";
            this.cmbVrstaUtakmkce.Size = new System.Drawing.Size(165, 32);
            this.cmbVrstaUtakmkce.TabIndex = 21;
            this.cmbVrstaUtakmkce.Text = "Vrsta utakmice";
            this.cmbVrstaUtakmkce.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbVrstaUtakmkce.TextLeftMargin = 5;
            this.cmbVrstaUtakmkce.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaUtakmkce_SelectedIndexChanged);
            // 
            // pnlRasporedUtakmica
            // 
            this.pnlRasporedUtakmica.Controls.Add(this.pnlUtakmiceWrapper);
            this.pnlRasporedUtakmica.Location = new System.Drawing.Point(20, 104);
            this.pnlRasporedUtakmica.Name = "pnlRasporedUtakmica";
            this.pnlRasporedUtakmica.Size = new System.Drawing.Size(600, 305);
            this.pnlRasporedUtakmica.TabIndex = 23;
            // 
            // pnlUtakmiceWrapper
            // 
            this.pnlUtakmiceWrapper.AutoScroll = true;
            this.pnlUtakmiceWrapper.Location = new System.Drawing.Point(0, 1);
            this.pnlUtakmiceWrapper.Name = "pnlUtakmiceWrapper";
            this.pnlUtakmiceWrapper.Size = new System.Drawing.Size(600, 305);
            this.pnlUtakmiceWrapper.TabIndex = 0;
            // 
            // snackbar
            // 
            this.snackbar.AllowDragging = false;
            this.snackbar.AllowMultipleViews = true;
            this.snackbar.ClickToClose = true;
            this.snackbar.DoubleClickToClose = true;
            this.snackbar.DurationAfterIdle = 3000;
            this.snackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbar.ErrorOptions.ActionBorderRadius = 1;
            this.snackbar.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbar.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.snackbar.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.snackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.snackbar.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.snackbar.ErrorOptions.IconLeftMargin = 12;
            this.snackbar.FadeCloseIcon = false;
            this.snackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.snackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbar.InformationOptions.ActionBorderRadius = 1;
            this.snackbar.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbar.InformationOptions.BackColor = System.Drawing.Color.White;
            this.snackbar.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.snackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.snackbar.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbar.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.snackbar.InformationOptions.IconLeftMargin = 12;
            this.snackbar.Margin = 10;
            this.snackbar.MaximumSize = new System.Drawing.Size(0, 0);
            this.snackbar.MaximumViews = 7;
            this.snackbar.MessageRightMargin = 15;
            this.snackbar.MinimumSize = new System.Drawing.Size(0, 0);
            this.snackbar.ShowBorders = false;
            this.snackbar.ShowCloseIcon = false;
            this.snackbar.ShowIcon = true;
            this.snackbar.ShowShadows = true;
            this.snackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbar.SuccessOptions.ActionBorderRadius = 1;
            this.snackbar.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbar.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.snackbar.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.snackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.snackbar.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbar.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.snackbar.SuccessOptions.IconLeftMargin = 12;
            this.snackbar.ViewsMargin = 7;
            this.snackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbar.WarningOptions.ActionBorderRadius = 1;
            this.snackbar.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbar.WarningOptions.BackColor = System.Drawing.Color.White;
            this.snackbar.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.snackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.snackbar.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbar.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbar.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.snackbar.WarningOptions.IconLeftMargin = 12;
            this.snackbar.ZoomCloseIcon = true;
            // 
            // loader
            // 
            this.loader.AllowStylePresets = true;
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.loader.Color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.loader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.loader.Customization = "";
            this.loader.DashWidth = 0.5F;
            this.loader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loader.Image = null;
            this.loader.Location = new System.Drawing.Point(290, 232);
            this.loader.Name = "loader";
            this.loader.NoRounding = false;
            this.loader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loader.ShowText = false;
            this.loader.Size = new System.Drawing.Size(40, 40);
            this.loader.Speed = 7;
            this.loader.TabIndex = 24;
            this.loader.Text = "bunifuLoader1";
            this.loader.TextPadding = new System.Windows.Forms.Padding(0);
            this.loader.Thickness = 6;
            this.loader.Transparent = true;
            // 
            // cmbRezultat
            // 
            this.cmbRezultat.BackColor = System.Drawing.Color.Transparent;
            this.cmbRezultat.BackgroundColor = System.Drawing.Color.White;
            this.cmbRezultat.BorderColor = System.Drawing.Color.Silver;
            this.cmbRezultat.BorderRadius = 1;
            this.cmbRezultat.Color = System.Drawing.Color.Silver;
            this.cmbRezultat.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbRezultat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbRezultat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbRezultat.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbRezultat.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbRezultat.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbRezultat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRezultat.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbRezultat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRezultat.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbRezultat.FillDropDown = true;
            this.cmbRezultat.FillIndicator = false;
            this.cmbRezultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRezultat.Font = new System.Drawing.Font("Oswald", 8.25F);
            this.cmbRezultat.ForeColor = System.Drawing.Color.Black;
            this.cmbRezultat.FormattingEnabled = true;
            this.cmbRezultat.Icon = null;
            this.cmbRezultat.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbRezultat.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbRezultat.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbRezultat.IndicatorThickness = 2;
            this.cmbRezultat.IsDropdownOpened = false;
            this.cmbRezultat.ItemBackColor = System.Drawing.Color.White;
            this.cmbRezultat.ItemBorderColor = System.Drawing.Color.White;
            this.cmbRezultat.ItemForeColor = System.Drawing.Color.Black;
            this.cmbRezultat.ItemHeight = 26;
            this.cmbRezultat.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.cmbRezultat.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbRezultat.ItemTopMargin = 3;
            this.cmbRezultat.Location = new System.Drawing.Point(237, 70);
            this.cmbRezultat.Name = "cmbRezultat";
            this.cmbRezultat.Size = new System.Drawing.Size(165, 32);
            this.cmbRezultat.TabIndex = 25;
            this.cmbRezultat.Text = "Rezultat";
            this.cmbRezultat.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbRezultat.TextLeftMargin = 5;
            this.cmbRezultat.SelectedIndexChanged += new System.EventHandler(this.cmbRezultat_SelectedIndexChanged);
            // 
            // loaderBrojIgraca
            // 
            this.loaderBrojIgraca.AllowStylePresets = true;
            this.loaderBrojIgraca.BackColor = System.Drawing.Color.Transparent;
            this.loaderBrojIgraca.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.loaderBrojIgraca.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.loaderBrojIgraca.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.loaderBrojIgraca.Customization = "";
            this.loaderBrojIgraca.DashWidth = 0.5F;
            this.loaderBrojIgraca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loaderBrojIgraca.Image = null;
            this.loaderBrojIgraca.Location = new System.Drawing.Point(101, 41);
            this.loaderBrojIgraca.Name = "loaderBrojIgraca";
            this.loaderBrojIgraca.NoRounding = false;
            this.loaderBrojIgraca.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loaderBrojIgraca.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loaderBrojIgraca.ShowText = false;
            this.loaderBrojIgraca.Size = new System.Drawing.Size(12, 12);
            this.loaderBrojIgraca.Speed = 7;
            this.loaderBrojIgraca.TabIndex = 289;
            this.loaderBrojIgraca.Text = "bunifuLoader1";
            this.loaderBrojIgraca.TextPadding = new System.Windows.Forms.Padding(0);
            this.loaderBrojIgraca.Thickness = 2;
            this.loaderBrojIgraca.Transparent = true;
            // 
            // txtBrojUtakmica
            // 
            this.txtBrojUtakmica.AllowParentOverrides = false;
            this.txtBrojUtakmica.AutoEllipsis = false;
            this.txtBrojUtakmica.AutoSize = false;
            this.txtBrojUtakmica.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBrojUtakmica.CursorType = System.Windows.Forms.Cursors.Default;
            this.txtBrojUtakmica.Font = new System.Drawing.Font("Oswald", 8F);
            this.txtBrojUtakmica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtBrojUtakmica.Location = new System.Drawing.Point(101, 39);
            this.txtBrojUtakmica.Name = "txtBrojUtakmica";
            this.txtBrojUtakmica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBrojUtakmica.Size = new System.Drawing.Size(28, 17);
            this.txtBrojUtakmica.TabIndex = 288;
            this.txtBrojUtakmica.Text = "22";
            this.txtBrojUtakmica.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtBrojUtakmica.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtBrojUtakmica.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblDrzavljanstvoVrijednost
            // 
            this.lblDrzavljanstvoVrijednost.AllowParentOverrides = false;
            this.lblDrzavljanstvoVrijednost.AutoEllipsis = false;
            this.lblDrzavljanstvoVrijednost.AutoSize = false;
            this.lblDrzavljanstvoVrijednost.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDrzavljanstvoVrijednost.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDrzavljanstvoVrijednost.Font = new System.Drawing.Font("Oswald", 8F);
            this.lblDrzavljanstvoVrijednost.ForeColor = System.Drawing.Color.Black;
            this.lblDrzavljanstvoVrijednost.Location = new System.Drawing.Point(20, 39);
            this.lblDrzavljanstvoVrijednost.Name = "lblDrzavljanstvoVrijednost";
            this.lblDrzavljanstvoVrijednost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDrzavljanstvoVrijednost.Size = new System.Drawing.Size(83, 17);
            this.lblDrzavljanstvoVrijednost.TabIndex = 287;
            this.lblDrzavljanstvoVrijednost.Text = "Ukupno utakmica: ";
            this.lblDrzavljanstvoVrijednost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDrzavljanstvoVrijednost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDrzavljanstvoVrijednost.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = false;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = global::eBordo.WinUI.Properties.Resources.refresh;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = true;
            this.bunifuButton1.Location = new System.Drawing.Point(23, 71);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 10;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.onHoverState.BorderRadius = 10;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 10;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 10;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(44, 31);
            this.bunifuButton1.TabIndex = 291;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btnSaveIgracSastav
            // 
            this.btnSaveIgracSastav.AllowAnimations = true;
            this.btnSaveIgracSastav.AllowMouseEffects = true;
            this.btnSaveIgracSastav.AllowToggling = false;
            this.btnSaveIgracSastav.AnimationSpeed = 200;
            this.btnSaveIgracSastav.AutoGenerateColors = false;
            this.btnSaveIgracSastav.AutoRoundBorders = false;
            this.btnSaveIgracSastav.AutoSizeLeftIcon = false;
            this.btnSaveIgracSastav.AutoSizeRightIcon = true;
            this.btnSaveIgracSastav.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveIgracSastav.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSaveIgracSastav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveIgracSastav.BackgroundImage")));
            this.btnSaveIgracSastav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveIgracSastav.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveIgracSastav.ButtonText = "DODAJ IZVJEŠTAJ";
            this.btnSaveIgracSastav.ButtonTextMarginLeft = 0;
            this.btnSaveIgracSastav.ColorContrastOnClick = 45;
            this.btnSaveIgracSastav.ColorContrastOnHover = 45;
            this.btnSaveIgracSastav.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSaveIgracSastav.CustomizableEdges = borderEdges2;
            this.btnSaveIgracSastav.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveIgracSastav.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveIgracSastav.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSaveIgracSastav.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSaveIgracSastav.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveIgracSastav.Font = new System.Drawing.Font("Oswald", 9F);
            this.btnSaveIgracSastav.ForeColor = System.Drawing.Color.White;
            this.btnSaveIgracSastav.IconLeft = global::eBordo.WinUI.Properties.Resources.addUtakmica;
            this.btnSaveIgracSastav.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveIgracSastav.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveIgracSastav.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSaveIgracSastav.IconMarginLeft = 11;
            this.btnSaveIgracSastav.IconPadding = 10;
            this.btnSaveIgracSastav.IconRight = null;
            this.btnSaveIgracSastav.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveIgracSastav.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveIgracSastav.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveIgracSastav.IconSize = 21;
            this.btnSaveIgracSastav.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSaveIgracSastav.IdleBorderRadius = 0;
            this.btnSaveIgracSastav.IdleBorderThickness = 0;
            this.btnSaveIgracSastav.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSaveIgracSastav.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.addUtakmica;
            this.btnSaveIgracSastav.IdleIconRightImage = null;
            this.btnSaveIgracSastav.IndicateFocus = true;
            this.btnSaveIgracSastav.Location = new System.Drawing.Point(471, 69);
            this.btnSaveIgracSastav.Name = "btnSaveIgracSastav";
            this.btnSaveIgracSastav.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveIgracSastav.OnDisabledState.BorderRadius = 10;
            this.btnSaveIgracSastav.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveIgracSastav.OnDisabledState.BorderThickness = 1;
            this.btnSaveIgracSastav.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveIgracSastav.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveIgracSastav.OnDisabledState.IconLeftImage = null;
            this.btnSaveIgracSastav.OnDisabledState.IconRightImage = null;
            this.btnSaveIgracSastav.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnSaveIgracSastav.onHoverState.BorderRadius = 10;
            this.btnSaveIgracSastav.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveIgracSastav.onHoverState.BorderThickness = 1;
            this.btnSaveIgracSastav.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveIgracSastav.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.addUtakmica;
            this.btnSaveIgracSastav.onHoverState.IconRightImage = null;
            this.btnSaveIgracSastav.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.OnIdleState.BorderRadius = 10;
            this.btnSaveIgracSastav.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveIgracSastav.OnIdleState.BorderThickness = 1;
            this.btnSaveIgracSastav.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSaveIgracSastav.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.addUtakmica;
            this.btnSaveIgracSastav.OnIdleState.IconRightImage = null;
            this.btnSaveIgracSastav.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.OnPressedState.BorderRadius = 10;
            this.btnSaveIgracSastav.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveIgracSastav.OnPressedState.BorderThickness = 1;
            this.btnSaveIgracSastav.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveIgracSastav.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.addUtakmica;
            this.btnSaveIgracSastav.OnPressedState.IconRightImage = null;
            this.btnSaveIgracSastav.Size = new System.Drawing.Size(126, 32);
            this.btnSaveIgracSastav.TabIndex = 292;
            this.btnSaveIgracSastav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveIgracSastav.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveIgracSastav.TextMarginLeft = 0;
            this.btnSaveIgracSastav.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnSaveIgracSastav.UseDefaultRadiusAndThickness = true;
            this.btnSaveIgracSastav.Click += new System.EventHandler(this.btnSaveIgracSastav_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::eBordo.WinUI.Properties.Resources.giphy;
            this.pictureBox5.Image = global::eBordo.WinUI.Properties.Resources.ezgif1;
            this.pictureBox5.Location = new System.Drawing.Point(559, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 324;
            this.pictureBox5.TabStop = false;
            // 
            // gifLoader
            // 
            this.gifLoader.BackColor = System.Drawing.Color.Transparent;
            this.gifLoader.BackgroundImage = global::eBordo.WinUI.Properties.Resources.giphy;
            this.gifLoader.Image = global::eBordo.WinUI.Properties.Resources.ezgif2;
            this.gifLoader.Location = new System.Drawing.Point(268, 224);
            this.gifLoader.Name = "gifLoader";
            this.gifLoader.Size = new System.Drawing.Size(91, 61);
            this.gifLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifLoader.TabIndex = 325;
            this.gifLoader.TabStop = false;
            // 
            // frmPrikazOdigranihUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gifLoader);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnSaveIgracSastav);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.loaderBrojIgraca);
            this.Controls.Add(this.txtBrojUtakmica);
            this.Controls.Add(this.lblDrzavljanstvoVrijednost);
            this.Controls.Add(this.cmbRezultat);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.pnlRasporedUtakmica);
            this.Controls.Add(this.cmbVrstaUtakmkce);
            this.Controls.Add(this.lblNaslovStranice);
            this.Name = "frmPrikazOdigranihUtakmica";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmPrikazOdigranihUtakmica_Load);
            this.pnlRasporedUtakmica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private Bunifu.UI.WinForms.BunifuDropdown cmbVrstaUtakmkce;
        private System.Windows.Forms.Panel pnlRasporedUtakmica;
        private System.Windows.Forms.FlowLayoutPanel pnlUtakmiceWrapper;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private Bunifu.UI.WinForms.BunifuLoader loader;
        private Bunifu.UI.WinForms.BunifuDropdown cmbRezultat;
        private Bunifu.UI.WinForms.BunifuLoader loaderBrojIgraca;
        private Bunifu.UI.WinForms.BunifuLabel txtBrojUtakmica;
        private Bunifu.UI.WinForms.BunifuLabel lblDrzavljanstvoVrijednost;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveIgracSastav;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox gifLoader;
    }
}
