
namespace eBordo.WinUI.Forms.AdminPanel
{
    partial class frmPrikazTrenera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrikazTrenera));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataLoader = new Bunifu.UI.WinForms.BunifuLoader();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.txtImePrezime = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlIgraci = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlTreneriWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.noSearchResult = new System.Windows.Forms.PictureBox();
            this.loaderBrojIgraca = new Bunifu.UI.WinForms.BunifuLoader();
            this.lblDrzavljanstvoVrijednost = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnSaveIgracSastav = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.checkBoxZavrseniTreninzi = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gifLoader = new System.Windows.Forms.PictureBox();
            this.pnlIgraci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noSearchResult)).BeginInit();
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
            this.lblNaslovStranice.Size = new System.Drawing.Size(104, 24);
            this.lblNaslovStranice.TabIndex = 0;
            this.lblNaslovStranice.Text = "PRIKAZ TRENERA";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dataLoader
            // 
            this.dataLoader.AllowStylePresets = true;
            this.dataLoader.BackColor = System.Drawing.Color.Transparent;
            this.dataLoader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.dataLoader.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.dataLoader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.dataLoader.Customization = "";
            this.dataLoader.DashWidth = 0.5F;
            this.dataLoader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataLoader.Image = null;
            this.dataLoader.Location = new System.Drawing.Point(290, 232);
            this.dataLoader.Name = "dataLoader";
            this.dataLoader.NoRounding = false;
            this.dataLoader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.dataLoader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.dataLoader.ShowText = false;
            this.dataLoader.Size = new System.Drawing.Size(40, 40);
            this.dataLoader.Speed = 7;
            this.dataLoader.TabIndex = 14;
            this.dataLoader.Text = "bunifuLoader1";
            this.dataLoader.TextPadding = new System.Windows.Forms.Padding(0);
            this.dataLoader.Thickness = 6;
            this.dataLoader.Transparent = true;
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
            this.snackbar.ErrorOptions.Icon = null;
            this.snackbar.ErrorOptions.IconLeftMargin = 12;
            this.snackbar.FadeCloseIcon = true;
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
            this.snackbar.InformationOptions.Icon = null;
            this.snackbar.InformationOptions.IconLeftMargin = 12;
            this.snackbar.Margin = 30;
            this.snackbar.MaximumSize = new System.Drawing.Size(0, 0);
            this.snackbar.MaximumViews = 7;
            this.snackbar.MessageRightMargin = 15;
            this.snackbar.MinimumSize = new System.Drawing.Size(0, 0);
            this.snackbar.ShowBorders = false;
            this.snackbar.ShowCloseIcon = true;
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
            this.snackbar.SuccessOptions.Icon = null;
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
            this.snackbar.WarningOptions.Icon = null;
            this.snackbar.WarningOptions.IconLeftMargin = 12;
            this.snackbar.ZoomCloseIcon = true;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.AcceptsReturn = false;
            this.txtImePrezime.AcceptsTab = false;
            this.txtImePrezime.AnimationSpeed = 200;
            this.txtImePrezime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtImePrezime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtImePrezime.AutoSizeHeight = true;
            this.txtImePrezime.BackColor = System.Drawing.Color.Transparent;
            this.txtImePrezime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtImePrezime.BackgroundImage")));
            this.txtImePrezime.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtImePrezime.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtImePrezime.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtImePrezime.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtImePrezime.BorderRadius = 1;
            this.txtImePrezime.BorderThickness = 1;
            this.txtImePrezime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtImePrezime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImePrezime.DefaultFont = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezime.DefaultText = "";
            this.txtImePrezime.FillColor = System.Drawing.Color.White;
            this.txtImePrezime.HideSelection = true;
            this.txtImePrezime.IconLeft = null;
            this.txtImePrezime.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImePrezime.IconPadding = 10;
            this.txtImePrezime.IconRight = null;
            this.txtImePrezime.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImePrezime.Lines = new string[0];
            this.txtImePrezime.Location = new System.Drawing.Point(69, 69);
            this.txtImePrezime.MaxLength = 32767;
            this.txtImePrezime.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtImePrezime.Modified = false;
            this.txtImePrezime.Multiline = false;
            this.txtImePrezime.Name = "txtImePrezime";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtImePrezime.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtImePrezime.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtImePrezime.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtImePrezime.OnIdleState = stateProperties8;
            this.txtImePrezime.Padding = new System.Windows.Forms.Padding(3);
            this.txtImePrezime.PasswordChar = '\0';
            this.txtImePrezime.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtImePrezime.PlaceholderText = "Ime i prezime";
            this.txtImePrezime.ReadOnly = false;
            this.txtImePrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImePrezime.SelectedText = "";
            this.txtImePrezime.SelectionLength = 0;
            this.txtImePrezime.SelectionStart = 0;
            this.txtImePrezime.ShortcutsEnabled = true;
            this.txtImePrezime.Size = new System.Drawing.Size(165, 34);
            this.txtImePrezime.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtImePrezime.TabIndex = 11;
            this.txtImePrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtImePrezime.TextMarginBottom = 0;
            this.txtImePrezime.TextMarginLeft = 3;
            this.txtImePrezime.TextMarginTop = 1;
            this.txtImePrezime.TextPlaceholder = "Ime i prezime";
            this.txtImePrezime.UseSystemPasswordChar = false;
            this.txtImePrezime.WordWrap = true;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // pnlIgraci
            // 
            this.pnlIgraci.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlIgraci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIgraci.BackgroundImage")));
            this.pnlIgraci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIgraci.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIgraci.BorderRadius = 3;
            this.pnlIgraci.BorderThickness = 1;
            this.pnlIgraci.Controls.Add(this.pnlTreneriWrapper);
            this.pnlIgraci.Location = new System.Drawing.Point(20, 104);
            this.pnlIgraci.Name = "pnlIgraci";
            this.pnlIgraci.ShowBorders = true;
            this.pnlIgraci.Size = new System.Drawing.Size(600, 305);
            this.pnlIgraci.TabIndex = 17;
            // 
            // pnlTreneriWrapper
            // 
            this.pnlTreneriWrapper.AutoScroll = true;
            this.pnlTreneriWrapper.Location = new System.Drawing.Point(0, 1);
            this.pnlTreneriWrapper.Name = "pnlTreneriWrapper";
            this.pnlTreneriWrapper.Size = new System.Drawing.Size(600, 308);
            this.pnlTreneriWrapper.TabIndex = 0;
            // 
            // noSearchResult
            // 
            this.noSearchResult.BackgroundImage = global::eBordo.WinUI.Properties.Resources.Picture1;
            this.noSearchResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noSearchResult.Location = new System.Drawing.Point(23, 110);
            this.noSearchResult.Name = "noSearchResult";
            this.noSearchResult.Size = new System.Drawing.Size(578, 296);
            this.noSearchResult.TabIndex = 18;
            this.noSearchResult.TabStop = false;
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
            this.loaderBrojIgraca.Location = new System.Drawing.Point(93, 41);
            this.loaderBrojIgraca.Name = "loaderBrojIgraca";
            this.loaderBrojIgraca.NoRounding = false;
            this.loaderBrojIgraca.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loaderBrojIgraca.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loaderBrojIgraca.ShowText = false;
            this.loaderBrojIgraca.Size = new System.Drawing.Size(12, 12);
            this.loaderBrojIgraca.Speed = 7;
            this.loaderBrojIgraca.TabIndex = 286;
            this.loaderBrojIgraca.Text = "bunifuLoader1";
            this.loaderBrojIgraca.TextPadding = new System.Windows.Forms.Padding(0);
            this.loaderBrojIgraca.Thickness = 2;
            this.loaderBrojIgraca.Transparent = true;
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
            this.lblDrzavljanstvoVrijednost.Size = new System.Drawing.Size(73, 17);
            this.lblDrzavljanstvoVrijednost.TabIndex = 284;
            this.lblDrzavljanstvoVrijednost.Text = "Ukupno trenera: ";
            this.lblDrzavljanstvoVrijednost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDrzavljanstvoVrijednost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDrzavljanstvoVrijednost.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Oswald", 8F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(93, 39);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(28, 17);
            this.bunifuLabel1.TabIndex = 287;
            this.bunifuLabel1.Text = "22";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.btnSaveIgracSastav.ButtonText = "DODAJ TRENERA";
            this.btnSaveIgracSastav.ButtonTextMarginLeft = 0;
            this.btnSaveIgracSastav.ColorContrastOnClick = 45;
            this.btnSaveIgracSastav.ColorContrastOnHover = 45;
            this.btnSaveIgracSastav.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSaveIgracSastav.CustomizableEdges = borderEdges3;
            this.btnSaveIgracSastav.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveIgracSastav.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveIgracSastav.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSaveIgracSastav.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSaveIgracSastav.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveIgracSastav.Font = new System.Drawing.Font("Oswald", 9F);
            this.btnSaveIgracSastav.ForeColor = System.Drawing.Color.White;
            this.btnSaveIgracSastav.IconLeft = global::eBordo.WinUI.Properties.Resources.addPerson;
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
            this.btnSaveIgracSastav.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.addPerson;
            this.btnSaveIgracSastav.IdleIconRightImage = null;
            this.btnSaveIgracSastav.IndicateFocus = true;
            this.btnSaveIgracSastav.Location = new System.Drawing.Point(472, 69);
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
            this.btnSaveIgracSastav.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.addPerson;
            this.btnSaveIgracSastav.onHoverState.IconRightImage = null;
            this.btnSaveIgracSastav.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.OnIdleState.BorderRadius = 10;
            this.btnSaveIgracSastav.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveIgracSastav.OnIdleState.BorderThickness = 1;
            this.btnSaveIgracSastav.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSaveIgracSastav.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.addPerson;
            this.btnSaveIgracSastav.OnIdleState.IconRightImage = null;
            this.btnSaveIgracSastav.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.OnPressedState.BorderRadius = 10;
            this.btnSaveIgracSastav.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveIgracSastav.OnPressedState.BorderThickness = 1;
            this.btnSaveIgracSastav.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveIgracSastav.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveIgracSastav.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.addPerson;
            this.btnSaveIgracSastav.OnPressedState.IconRightImage = null;
            this.btnSaveIgracSastav.Size = new System.Drawing.Size(125, 33);
            this.btnSaveIgracSastav.TabIndex = 288;
            this.btnSaveIgracSastav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveIgracSastav.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveIgracSastav.TextMarginLeft = 0;
            this.btnSaveIgracSastav.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnSaveIgracSastav.UseDefaultRadiusAndThickness = true;
            this.btnSaveIgracSastav.Click += new System.EventHandler(this.btnSaveIgracSastav_Click);
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges4;
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
            this.bunifuButton1.TabIndex = 289;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Oswald", 9F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(264, 81);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(40, 17);
            this.bunifuLabel2.TabIndex = 300;
            this.bunifuLabel2.Text = "Aktivan";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.checkBoxZavrseniTreninzi.Location = new System.Drawing.Point(240, 77);
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
            this.checkBoxZavrseniTreninzi.TabIndex = 299;
            this.checkBoxZavrseniTreninzi.ThreeState = false;
            this.checkBoxZavrseniTreninzi.ToolTipText = null;
            this.checkBoxZavrseniTreninzi.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkBoxZavrseniTreninzi_CheckedChanged);
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
            this.pictureBox5.TabIndex = 323;
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
            this.gifLoader.TabIndex = 324;
            this.gifLoader.TabStop = false;
            // 
            // frmPrikazTrenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gifLoader);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.checkBoxZavrseniTreninzi);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.btnSaveIgracSastav);
            this.Controls.Add(this.loaderBrojIgraca);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.lblDrzavljanstvoVrijednost);
            this.Controls.Add(this.dataLoader);
            this.Controls.Add(this.pnlIgraci);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.lblNaslovStranice);
            this.Controls.Add(this.noSearchResult);
            this.Name = "frmPrikazTrenera";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmPrikazTrenera_Load);
            this.pnlIgraci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private Bunifu.UI.WinForms.BunifuTextBox txtImePrezime;
        private Bunifu.UI.WinForms.BunifuLoader dataLoader;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private Bunifu.UI.WinForms.BunifuPanel pnlIgraci;
        private System.Windows.Forms.FlowLayoutPanel pnlTreneriWrapper;
        private System.Windows.Forms.PictureBox noSearchResult;
        private Bunifu.UI.WinForms.BunifuLoader loaderBrojIgraca;
        private Bunifu.UI.WinForms.BunifuLabel lblDrzavljanstvoVrijednost;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveIgracSastav;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBoxZavrseniTreninzi;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox gifLoader;
    }
}
