
namespace eBordo.WinUI.Forms.AdminPanel.Upravljanje_treningom
{
    partial class frmPrikazTreninga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrikazTreninga));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges24 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbLokacija = new Bunifu.UI.WinForms.BunifuDropdown();
            this.loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.pnlUtakmiceWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRasporedUtakmica = new System.Windows.Forms.Panel();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.loaderBrojIgraca = new Bunifu.UI.WinForms.BunifuLoader();
            this.txtBrojTreninga = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDrzavljanstvoVrijednost = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveIgracSastav = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.checkBoxZavrseniTreninzi = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gifLoader = new System.Windows.Forms.PictureBox();
            this.btnSaveUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.noSearchResults = new System.Windows.Forms.PictureBox();
            this.noSearchResultsText = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtNemaRezultataOpis = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlRasporedUtakmica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSearchResults)).BeginInit();
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
            this.lblNaslovStranice.Text = "RASPORED TRENINGA";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.BackColor = System.Drawing.Color.Transparent;
            this.cmbLokacija.BackgroundColor = System.Drawing.Color.White;
            this.cmbLokacija.BorderColor = System.Drawing.Color.Silver;
            this.cmbLokacija.BorderRadius = 1;
            this.cmbLokacija.Color = System.Drawing.Color.Silver;
            this.cmbLokacija.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbLokacija.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbLokacija.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbLokacija.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbLokacija.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbLokacija.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbLokacija.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLokacija.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbLokacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLokacija.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbLokacija.FillDropDown = true;
            this.cmbLokacija.FillIndicator = false;
            this.cmbLokacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLokacija.Font = new System.Drawing.Font("Oswald", 8.25F);
            this.cmbLokacija.ForeColor = System.Drawing.Color.Black;
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Icon = null;
            this.cmbLokacija.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbLokacija.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbLokacija.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbLokacija.IndicatorThickness = 2;
            this.cmbLokacija.IsDropdownOpened = false;
            this.cmbLokacija.ItemBackColor = System.Drawing.Color.White;
            this.cmbLokacija.ItemBorderColor = System.Drawing.Color.White;
            this.cmbLokacija.ItemForeColor = System.Drawing.Color.Black;
            this.cmbLokacija.ItemHeight = 26;
            this.cmbLokacija.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.cmbLokacija.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbLokacija.ItemTopMargin = 3;
            this.cmbLokacija.Location = new System.Drawing.Point(69, 70);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(165, 32);
            this.cmbLokacija.TabIndex = 21;
            this.cmbLokacija.Text = "Lokacija treninga";
            this.cmbLokacija.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbLokacija.TextLeftMargin = 5;
            this.cmbLokacija.SelectedIndexChanged += new System.EventHandler(this.cmbLokacija_SelectedIndexChanged);
            // 
            // loader
            // 
            this.loader.AllowStylePresets = true;
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.loader.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
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
            // pnlUtakmiceWrapper
            // 
            this.pnlUtakmiceWrapper.AutoScroll = true;
            this.pnlUtakmiceWrapper.Location = new System.Drawing.Point(0, 1);
            this.pnlUtakmiceWrapper.Name = "pnlUtakmiceWrapper";
            this.pnlUtakmiceWrapper.Size = new System.Drawing.Size(600, 305);
            this.pnlUtakmiceWrapper.TabIndex = 0;
            // 
            // pnlRasporedUtakmica
            // 
            this.pnlRasporedUtakmica.Controls.Add(this.pnlUtakmiceWrapper);
            this.pnlRasporedUtakmica.Location = new System.Drawing.Point(20, 104);
            this.pnlRasporedUtakmica.Name = "pnlRasporedUtakmica";
            this.pnlRasporedUtakmica.Size = new System.Drawing.Size(600, 305);
            this.pnlRasporedUtakmica.TabIndex = 23;
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
            this.snackbar.Margin = 20;
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
            this.loaderBrojIgraca.Location = new System.Drawing.Point(96, 41);
            this.loaderBrojIgraca.Name = "loaderBrojIgraca";
            this.loaderBrojIgraca.NoRounding = false;
            this.loaderBrojIgraca.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loaderBrojIgraca.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loaderBrojIgraca.ShowText = false;
            this.loaderBrojIgraca.Size = new System.Drawing.Size(12, 12);
            this.loaderBrojIgraca.Speed = 7;
            this.loaderBrojIgraca.TabIndex = 292;
            this.loaderBrojIgraca.Text = "loaderTreninzi";
            this.loaderBrojIgraca.TextPadding = new System.Windows.Forms.Padding(0);
            this.loaderBrojIgraca.Thickness = 2;
            this.loaderBrojIgraca.Transparent = true;
            // 
            // txtBrojTreninga
            // 
            this.txtBrojTreninga.AllowParentOverrides = false;
            this.txtBrojTreninga.AutoEllipsis = false;
            this.txtBrojTreninga.AutoSize = false;
            this.txtBrojTreninga.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBrojTreninga.CursorType = System.Windows.Forms.Cursors.Default;
            this.txtBrojTreninga.Font = new System.Drawing.Font("Oswald", 8F);
            this.txtBrojTreninga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.txtBrojTreninga.Location = new System.Drawing.Point(96, 39);
            this.txtBrojTreninga.Name = "txtBrojTreninga";
            this.txtBrojTreninga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBrojTreninga.Size = new System.Drawing.Size(28, 17);
            this.txtBrojTreninga.TabIndex = 291;
            this.txtBrojTreninga.Text = "22";
            this.txtBrojTreninga.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtBrojTreninga.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtBrojTreninga.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.lblDrzavljanstvoVrijednost.TabIndex = 290;
            this.lblDrzavljanstvoVrijednost.Text = "Ukupno treninga:";
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
            borderEdges21.BottomLeft = true;
            borderEdges21.BottomRight = true;
            borderEdges21.TopLeft = true;
            borderEdges21.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges21;
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
            this.bunifuButton1.TabIndex = 293;
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
            this.btnSaveIgracSastav.ButtonText = "DODAJ TRENING";
            this.btnSaveIgracSastav.ButtonTextMarginLeft = 0;
            this.btnSaveIgracSastav.ColorContrastOnClick = 45;
            this.btnSaveIgracSastav.ColorContrastOnHover = 45;
            this.btnSaveIgracSastav.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges22.BottomLeft = true;
            borderEdges22.BottomRight = true;
            borderEdges22.TopLeft = true;
            borderEdges22.TopRight = true;
            this.btnSaveIgracSastav.CustomizableEdges = borderEdges22;
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
            this.btnSaveIgracSastav.Location = new System.Drawing.Point(473, 69);
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
            this.btnSaveIgracSastav.Size = new System.Drawing.Size(124, 33);
            this.btnSaveIgracSastav.TabIndex = 294;
            this.btnSaveIgracSastav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveIgracSastav.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveIgracSastav.TextMarginLeft = 0;
            this.btnSaveIgracSastav.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnSaveIgracSastav.UseDefaultRadiusAndThickness = true;
            this.btnSaveIgracSastav.Click += new System.EventHandler(this.btnSaveIgracSastav_Click);
            // 
            // checkBoxZavrseniTreninzi
            // 
            this.checkBoxZavrseniTreninzi.AllowBindingControlAnimation = true;
            this.checkBoxZavrseniTreninzi.AllowBindingControlColorChanges = false;
            this.checkBoxZavrseniTreninzi.AllowBindingControlLocation = true;
            this.checkBoxZavrseniTreninzi.AllowCheckBoxAnimation = false;
            this.checkBoxZavrseniTreninzi.AllowCheckmarkAnimation = true;
            this.checkBoxZavrseniTreninzi.AllowOnHoverStates = true;
            this.checkBoxZavrseniTreninzi.AutoCheck = true;
            this.checkBoxZavrseniTreninzi.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxZavrseniTreninzi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxZavrseniTreninzi.BackgroundImage")));
            this.checkBoxZavrseniTreninzi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxZavrseniTreninzi.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBoxZavrseniTreninzi.BorderRadius = 12;
            this.checkBoxZavrseniTreninzi.Checked = true;
            this.checkBoxZavrseniTreninzi.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkBoxZavrseniTreninzi.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxZavrseniTreninzi.CustomCheckmarkImage = null;
            this.checkBoxZavrseniTreninzi.Location = new System.Drawing.Point(241, 77);
            this.checkBoxZavrseniTreninzi.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBoxZavrseniTreninzi.Name = "checkBoxZavrseniTreninzi";
            this.checkBoxZavrseniTreninzi.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.checkBoxZavrseniTreninzi.OnCheck.BorderRadius = 12;
            this.checkBoxZavrseniTreninzi.OnCheck.BorderThickness = 2;
            this.checkBoxZavrseniTreninzi.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.checkBoxZavrseniTreninzi.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxZavrseniTreninzi.OnCheck.CheckmarkThickness = 2;
            this.checkBoxZavrseniTreninzi.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBoxZavrseniTreninzi.OnDisable.BorderRadius = 12;
            this.checkBoxZavrseniTreninzi.OnDisable.BorderThickness = 2;
            this.checkBoxZavrseniTreninzi.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxZavrseniTreninzi.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBoxZavrseniTreninzi.OnDisable.CheckmarkThickness = 2;
            this.checkBoxZavrseniTreninzi.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.checkBoxZavrseniTreninzi.OnHoverChecked.BorderRadius = 12;
            this.checkBoxZavrseniTreninzi.OnHoverChecked.BorderThickness = 2;
            this.checkBoxZavrseniTreninzi.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.checkBoxZavrseniTreninzi.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxZavrseniTreninzi.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBoxZavrseniTreninzi.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.checkBoxZavrseniTreninzi.OnHoverUnchecked.BorderRadius = 12;
            this.checkBoxZavrseniTreninzi.OnHoverUnchecked.BorderThickness = 1;
            this.checkBoxZavrseniTreninzi.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxZavrseniTreninzi.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBoxZavrseniTreninzi.OnUncheck.BorderRadius = 12;
            this.checkBoxZavrseniTreninzi.OnUncheck.BorderThickness = 1;
            this.checkBoxZavrseniTreninzi.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxZavrseniTreninzi.Size = new System.Drawing.Size(21, 21);
            this.checkBoxZavrseniTreninzi.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBoxZavrseniTreninzi.TabIndex = 295;
            this.checkBoxZavrseniTreninzi.ThreeState = false;
            this.checkBoxZavrseniTreninzi.ToolTipText = null;
            this.checkBoxZavrseniTreninzi.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkBoxZavrseniTreninzi_CheckedChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Oswald", 9F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(265, 81);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(83, 17);
            this.bunifuLabel1.TabIndex = 296;
            this.bunifuLabel1.Text = "Završeni treninzi";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.pictureBox5.TabIndex = 325;
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
            this.gifLoader.TabIndex = 326;
            this.gifLoader.TabStop = false;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.AllowAnimations = true;
            this.btnSaveUpdate.AllowMouseEffects = true;
            this.btnSaveUpdate.AllowToggling = false;
            this.btnSaveUpdate.AnimationSpeed = 200;
            this.btnSaveUpdate.AutoGenerateColors = false;
            this.btnSaveUpdate.AutoRoundBorders = false;
            this.btnSaveUpdate.AutoSizeLeftIcon = false;
            this.btnSaveUpdate.AutoSizeRightIcon = true;
            this.btnSaveUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUpdate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSaveUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveUpdate.BackgroundImage")));
            this.btnSaveUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveUpdate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUpdate.ButtonText = "";
            this.btnSaveUpdate.ButtonTextMarginLeft = 0;
            this.btnSaveUpdate.ColorContrastOnClick = 45;
            this.btnSaveUpdate.ColorContrastOnHover = 45;
            this.btnSaveUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges23.BottomLeft = true;
            borderEdges23.BottomRight = true;
            borderEdges23.TopLeft = true;
            borderEdges23.TopRight = true;
            this.btnSaveUpdate.CustomizableEdges = borderEdges23;
            this.btnSaveUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveUpdate.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSaveUpdate.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSaveUpdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Oswald", 9F);
            this.btnSaveUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUpdate.IconLeft = global::eBordo.WinUI.Properties.Resources.pdf;
            this.btnSaveUpdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveUpdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 5, 3, 3);
            this.btnSaveUpdate.IconMarginLeft = 11;
            this.btnSaveUpdate.IconPadding = 10;
            this.btnSaveUpdate.IconRight = null;
            this.btnSaveUpdate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUpdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveUpdate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveUpdate.IconSize = 20;
            this.btnSaveUpdate.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSaveUpdate.IdleBorderRadius = 0;
            this.btnSaveUpdate.IdleBorderThickness = 0;
            this.btnSaveUpdate.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSaveUpdate.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.pdf;
            this.btnSaveUpdate.IdleIconRightImage = null;
            this.btnSaveUpdate.IndicateFocus = true;
            this.btnSaveUpdate.Location = new System.Drawing.Point(430, 69);
            this.btnSaveUpdate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveUpdate.OnDisabledState.BorderRadius = 10;
            this.btnSaveUpdate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUpdate.OnDisabledState.BorderThickness = 1;
            this.btnSaveUpdate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveUpdate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveUpdate.OnDisabledState.IconLeftImage = null;
            this.btnSaveUpdate.OnDisabledState.IconRightImage = null;
            this.btnSaveUpdate.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnSaveUpdate.onHoverState.BorderRadius = 10;
            this.btnSaveUpdate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUpdate.onHoverState.BorderThickness = 1;
            this.btnSaveUpdate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUpdate.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.pdf;
            this.btnSaveUpdate.onHoverState.IconRightImage = null;
            this.btnSaveUpdate.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.OnIdleState.BorderRadius = 10;
            this.btnSaveUpdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUpdate.OnIdleState.BorderThickness = 1;
            this.btnSaveUpdate.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUpdate.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.pdf;
            this.btnSaveUpdate.OnIdleState.IconRightImage = null;
            this.btnSaveUpdate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.OnPressedState.BorderRadius = 10;
            this.btnSaveUpdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUpdate.OnPressedState.BorderThickness = 1;
            this.btnSaveUpdate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUpdate.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.pdf;
            this.btnSaveUpdate.OnPressedState.IconRightImage = null;
            this.btnSaveUpdate.Size = new System.Drawing.Size(40, 33);
            this.btnSaveUpdate.TabIndex = 327;
            this.btnSaveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUpdate.TextMarginLeft = 0;
            this.btnSaveUpdate.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnSaveUpdate.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = false;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "PREUZMI PDF";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges24.BottomLeft = true;
            borderEdges24.BottomRight = true;
            borderEdges24.TopLeft = true;
            borderEdges24.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges24;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Oswald", 9F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton2.IconLeft = global::eBordo.WinUI.Properties.Resources.pdf;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 5, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRight = null;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 20;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton2.IdleBorderRadius = 0;
            this.bunifuButton2.IdleBorderThickness = 0;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton2.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.pdf;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = true;
            this.bunifuButton2.Location = new System.Drawing.Point(485, 68);
            this.bunifuButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 10;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.bunifuButton2.onHoverState.BorderRadius = 10;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton2.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.pdf;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.bunifuButton2.OnIdleState.BorderRadius = 10;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton2.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.pdf;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 10;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton2.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.pdf;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(112, 34);
            this.bunifuButton2.TabIndex = 329;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // noSearchResults
            // 
            this.noSearchResults.BackColor = System.Drawing.Color.Transparent;
            this.noSearchResults.BackgroundImage = global::eBordo.WinUI.Properties.Resources.nema_rezultata_pretrage;
            this.noSearchResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noSearchResults.Location = new System.Drawing.Point(183, 116);
            this.noSearchResults.Name = "noSearchResults";
            this.noSearchResults.Size = new System.Drawing.Size(280, 242);
            this.noSearchResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noSearchResults.TabIndex = 332;
            this.noSearchResults.TabStop = false;
            this.noSearchResults.Visible = false;
            // 
            // noSearchResultsText
            // 
            this.noSearchResultsText.AllowParentOverrides = false;
            this.noSearchResultsText.AutoEllipsis = false;
            this.noSearchResultsText.Cursor = System.Windows.Forms.Cursors.Default;
            this.noSearchResultsText.CursorType = System.Windows.Forms.Cursors.Default;
            this.noSearchResultsText.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSearchResultsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noSearchResultsText.Location = new System.Drawing.Point(266, 345);
            this.noSearchResultsText.Name = "noSearchResultsText";
            this.noSearchResultsText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.noSearchResultsText.Size = new System.Drawing.Size(108, 24);
            this.noSearchResultsText.TabIndex = 333;
            this.noSearchResultsText.Text = "NEMA REZULTATA";
            this.noSearchResultsText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.noSearchResultsText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.noSearchResultsText.Visible = false;
            // 
            // txtNemaRezultataOpis
            // 
            this.txtNemaRezultataOpis.AllowParentOverrides = false;
            this.txtNemaRezultataOpis.AutoEllipsis = false;
            this.txtNemaRezultataOpis.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNemaRezultataOpis.CursorType = System.Windows.Forms.Cursors.Default;
            this.txtNemaRezultataOpis.Font = new System.Drawing.Font("Oswald", 9F);
            this.txtNemaRezultataOpis.ForeColor = System.Drawing.Color.Black;
            this.txtNemaRezultataOpis.Location = new System.Drawing.Point(141, 369);
            this.txtNemaRezultataOpis.Name = "txtNemaRezultataOpis";
            this.txtNemaRezultataOpis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNemaRezultataOpis.Size = new System.Drawing.Size(360, 17);
            this.txtNemaRezultataOpis.TabIndex = 334;
            this.txtNemaRezultataOpis.Text = "BAZA PODATAKA JE PRETRAŽENA I NISU PRONAĐENI ODGOVARAJUĆI REZULTATI! ";
            this.txtNemaRezultataOpis.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtNemaRezultataOpis.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtNemaRezultataOpis.Visible = false;
            // 
            // frmPrikazTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNemaRezultataOpis);
            this.Controls.Add(this.noSearchResultsText);
            this.Controls.Add(this.noSearchResults);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.gifLoader);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.checkBoxZavrseniTreninzi);
            this.Controls.Add(this.btnSaveIgracSastav);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.loaderBrojIgraca);
            this.Controls.Add(this.txtBrojTreninga);
            this.Controls.Add(this.lblDrzavljanstvoVrijednost);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.pnlRasporedUtakmica);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.lblNaslovStranice);
            this.Name = "frmPrikazTreninga";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmPrikazTreninga_Load);
            this.pnlRasporedUtakmica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private Bunifu.UI.WinForms.BunifuDropdown cmbLokacija;
        private Bunifu.UI.WinForms.BunifuLoader loader;
        private System.Windows.Forms.FlowLayoutPanel pnlUtakmiceWrapper;
        private System.Windows.Forms.Panel pnlRasporedUtakmica;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private Bunifu.UI.WinForms.BunifuLoader loaderBrojIgraca;
        private Bunifu.UI.WinForms.BunifuLabel txtBrojTreninga;
        private Bunifu.UI.WinForms.BunifuLabel lblDrzavljanstvoVrijednost;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveIgracSastav;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBoxZavrseniTreninzi;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox gifLoader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveUpdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private System.Windows.Forms.PictureBox noSearchResults;
        private Bunifu.UI.WinForms.BunifuLabel noSearchResultsText;
        private Bunifu.UI.WinForms.BunifuLabel txtNemaRezultataOpis;
    }
}
