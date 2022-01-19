
namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Države
{
    partial class frmPrikazDrzava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrikazDrzava));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.grbFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.pictureZastava = new System.Windows.Forms.PictureBox();
            this.txtNazivDrzave = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureSlikaUtakmicaValidator = new System.Windows.Forms.PictureBox();
            this.btnUcitajPanelPhoto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.loader = new System.Windows.Forms.PictureBox();
            this.loaderIgraci = new Bunifu.UI.WinForms.BunifuLoader();
            this.txtBrojIgraca = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDrzavljanstvoVrijednost = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlPrikazDrzava = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtTelefonValidator = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOdustani = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblIme = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.noSearchResults = new System.Windows.Forms.PictureBox();
            this.noSearchResultsText = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZastava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlikaUtakmicaValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFileDialog
            // 
            this.grbFileDialog.FileName = "grbFileDialog";
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
            // pictureZastava
            // 
            this.pictureZastava.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureZastava.BackgroundImage = global::eBordo.WinUI.Properties.Resources.uploadFile;
            this.pictureZastava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureZastava.Location = new System.Drawing.Point(6, 47);
            this.pictureZastava.Name = "pictureZastava";
            this.pictureZastava.Size = new System.Drawing.Size(135, 102);
            this.pictureZastava.TabIndex = 135;
            this.pictureZastava.TabStop = false;
            this.pictureZastava.Click += new System.EventHandler(this.pictureGrb_Click);
            // 
            // txtNazivDrzave
            // 
            this.txtNazivDrzave.AcceptsReturn = false;
            this.txtNazivDrzave.AcceptsTab = false;
            this.txtNazivDrzave.AnimationSpeed = 200;
            this.txtNazivDrzave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNazivDrzave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNazivDrzave.AutoSizeHeight = true;
            this.txtNazivDrzave.BackColor = System.Drawing.Color.Transparent;
            this.txtNazivDrzave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNazivDrzave.BackgroundImage")));
            this.txtNazivDrzave.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtNazivDrzave.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNazivDrzave.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtNazivDrzave.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNazivDrzave.BorderRadius = 1;
            this.txtNazivDrzave.BorderThickness = 1;
            this.txtNazivDrzave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNazivDrzave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNazivDrzave.DefaultFont = new System.Drawing.Font("Oswald", 9F);
            this.txtNazivDrzave.DefaultText = "";
            this.txtNazivDrzave.FillColor = System.Drawing.Color.White;
            this.txtNazivDrzave.HideSelection = true;
            this.txtNazivDrzave.IconLeft = null;
            this.txtNazivDrzave.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNazivDrzave.IconPadding = 10;
            this.txtNazivDrzave.IconRight = global::eBordo.WinUI.Properties.Resources.eBordo_required3;
            this.txtNazivDrzave.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNazivDrzave.Lines = new string[0];
            this.txtNazivDrzave.Location = new System.Drawing.Point(147, 61);
            this.txtNazivDrzave.MaxLength = 32767;
            this.txtNazivDrzave.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNazivDrzave.Modified = false;
            this.txtNazivDrzave.Multiline = false;
            this.txtNazivDrzave.Name = "txtNazivDrzave";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivDrzave.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNazivDrzave.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivDrzave.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivDrzave.OnIdleState = stateProperties8;
            this.txtNazivDrzave.Padding = new System.Windows.Forms.Padding(3);
            this.txtNazivDrzave.PasswordChar = '\0';
            this.txtNazivDrzave.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNazivDrzave.PlaceholderText = "Naziv države";
            this.txtNazivDrzave.ReadOnly = false;
            this.txtNazivDrzave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNazivDrzave.SelectedText = "";
            this.txtNazivDrzave.SelectionLength = 0;
            this.txtNazivDrzave.SelectionStart = 0;
            this.txtNazivDrzave.ShortcutsEnabled = true;
            this.txtNazivDrzave.Size = new System.Drawing.Size(195, 32);
            this.txtNazivDrzave.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNazivDrzave.TabIndex = 132;
            this.txtNazivDrzave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNazivDrzave.TextMarginBottom = 0;
            this.txtNazivDrzave.TextMarginLeft = 3;
            this.txtNazivDrzave.TextMarginTop = 1;
            this.txtNazivDrzave.TextPlaceholder = "Naziv države";
            this.txtNazivDrzave.UseSystemPasswordChar = false;
            this.txtNazivDrzave.WordWrap = true;
            this.txtNazivDrzave.TextChanged += new System.EventHandler(this.txtNazivDrzave_TextChanged);
            // 
            // pictureSlikaUtakmicaValidator
            // 
            this.pictureSlikaUtakmicaValidator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.pictureSlikaUtakmicaValidator.BackgroundImage = global::eBordo.WinUI.Properties.Resources.eBordo_required3;
            this.pictureSlikaUtakmicaValidator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureSlikaUtakmicaValidator.Location = new System.Drawing.Point(37, 160);
            this.pictureSlikaUtakmicaValidator.Name = "pictureSlikaUtakmicaValidator";
            this.pictureSlikaUtakmicaValidator.Size = new System.Drawing.Size(10, 10);
            this.pictureSlikaUtakmicaValidator.TabIndex = 352;
            this.pictureSlikaUtakmicaValidator.TabStop = false;
            // 
            // btnUcitajPanelPhoto
            // 
            this.btnUcitajPanelPhoto.AllowAnimations = true;
            this.btnUcitajPanelPhoto.AllowMouseEffects = true;
            this.btnUcitajPanelPhoto.AllowToggling = false;
            this.btnUcitajPanelPhoto.AnimationSpeed = 200;
            this.btnUcitajPanelPhoto.AutoGenerateColors = false;
            this.btnUcitajPanelPhoto.AutoRoundBorders = false;
            this.btnUcitajPanelPhoto.AutoSizeLeftIcon = true;
            this.btnUcitajPanelPhoto.AutoSizeRightIcon = true;
            this.btnUcitajPanelPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnUcitajPanelPhoto.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnUcitajPanelPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUcitajPanelPhoto.BackgroundImage")));
            this.btnUcitajPanelPhoto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUcitajPanelPhoto.ButtonText = "     Učitaj zastavu";
            this.btnUcitajPanelPhoto.ButtonTextMarginLeft = 0;
            this.btnUcitajPanelPhoto.ColorContrastOnClick = 45;
            this.btnUcitajPanelPhoto.ColorContrastOnHover = 45;
            this.btnUcitajPanelPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnUcitajPanelPhoto.CustomizableEdges = borderEdges6;
            this.btnUcitajPanelPhoto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUcitajPanelPhoto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUcitajPanelPhoto.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnUcitajPanelPhoto.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnUcitajPanelPhoto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUcitajPanelPhoto.Font = new System.Drawing.Font("Oswald", 7F);
            this.btnUcitajPanelPhoto.ForeColor = System.Drawing.Color.White;
            this.btnUcitajPanelPhoto.IconLeft = null;
            this.btnUcitajPanelPhoto.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcitajPanelPhoto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUcitajPanelPhoto.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUcitajPanelPhoto.IconMarginLeft = 11;
            this.btnUcitajPanelPhoto.IconPadding = 10;
            this.btnUcitajPanelPhoto.IconRight = null;
            this.btnUcitajPanelPhoto.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUcitajPanelPhoto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUcitajPanelPhoto.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUcitajPanelPhoto.IconSize = 25;
            this.btnUcitajPanelPhoto.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnUcitajPanelPhoto.IdleBorderRadius = 0;
            this.btnUcitajPanelPhoto.IdleBorderThickness = 0;
            this.btnUcitajPanelPhoto.IdleFillColor = System.Drawing.Color.Empty;
            this.btnUcitajPanelPhoto.IdleIconLeftImage = null;
            this.btnUcitajPanelPhoto.IdleIconRightImage = null;
            this.btnUcitajPanelPhoto.IndicateFocus = true;
            this.btnUcitajPanelPhoto.Location = new System.Drawing.Point(6, 154);
            this.btnUcitajPanelPhoto.Name = "btnUcitajPanelPhoto";
            this.btnUcitajPanelPhoto.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUcitajPanelPhoto.OnDisabledState.BorderRadius = 10;
            this.btnUcitajPanelPhoto.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUcitajPanelPhoto.OnDisabledState.BorderThickness = 1;
            this.btnUcitajPanelPhoto.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUcitajPanelPhoto.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUcitajPanelPhoto.OnDisabledState.IconLeftImage = null;
            this.btnUcitajPanelPhoto.OnDisabledState.IconRightImage = null;
            this.btnUcitajPanelPhoto.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnUcitajPanelPhoto.onHoverState.BorderRadius = 10;
            this.btnUcitajPanelPhoto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUcitajPanelPhoto.onHoverState.BorderThickness = 1;
            this.btnUcitajPanelPhoto.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnUcitajPanelPhoto.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUcitajPanelPhoto.onHoverState.IconLeftImage = null;
            this.btnUcitajPanelPhoto.onHoverState.IconRightImage = null;
            this.btnUcitajPanelPhoto.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnUcitajPanelPhoto.OnIdleState.BorderRadius = 10;
            this.btnUcitajPanelPhoto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUcitajPanelPhoto.OnIdleState.BorderThickness = 1;
            this.btnUcitajPanelPhoto.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnUcitajPanelPhoto.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUcitajPanelPhoto.OnIdleState.IconLeftImage = null;
            this.btnUcitajPanelPhoto.OnIdleState.IconRightImage = null;
            this.btnUcitajPanelPhoto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnUcitajPanelPhoto.OnPressedState.BorderRadius = 10;
            this.btnUcitajPanelPhoto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUcitajPanelPhoto.OnPressedState.BorderThickness = 1;
            this.btnUcitajPanelPhoto.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnUcitajPanelPhoto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUcitajPanelPhoto.OnPressedState.IconLeftImage = null;
            this.btnUcitajPanelPhoto.OnPressedState.IconRightImage = null;
            this.btnUcitajPanelPhoto.Size = new System.Drawing.Size(135, 22);
            this.btnUcitajPanelPhoto.TabIndex = 351;
            this.btnUcitajPanelPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUcitajPanelPhoto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUcitajPanelPhoto.TextMarginLeft = 0;
            this.btnUcitajPanelPhoto.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUcitajPanelPhoto.UseDefaultRadiusAndThickness = true;
            this.btnUcitajPanelPhoto.Click += new System.EventHandler(this.btnUcitajPanelPhoto_Click_1);
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.BackgroundImage = global::eBordo.WinUI.Properties.Resources.giphy;
            this.loader.Image = global::eBordo.WinUI.Properties.Resources.ezgif2;
            this.loader.Location = new System.Drawing.Point(433, 142);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(91, 61);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loader.TabIndex = 353;
            this.loader.TabStop = false;
            // 
            // loaderIgraci
            // 
            this.loaderIgraci.AllowStylePresets = true;
            this.loaderIgraci.BackColor = System.Drawing.Color.Transparent;
            this.loaderIgraci.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.loaderIgraci.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.loaderIgraci.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.loaderIgraci.Customization = "";
            this.loaderIgraci.DashWidth = 0.5F;
            this.loaderIgraci.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loaderIgraci.Image = null;
            this.loaderIgraci.Location = new System.Drawing.Point(75, 27);
            this.loaderIgraci.Name = "loaderIgraci";
            this.loaderIgraci.NoRounding = false;
            this.loaderIgraci.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loaderIgraci.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loaderIgraci.ShowText = false;
            this.loaderIgraci.Size = new System.Drawing.Size(12, 12);
            this.loaderIgraci.Speed = 7;
            this.loaderIgraci.TabIndex = 355;
            this.loaderIgraci.Text = "bunifuLoader1";
            this.loaderIgraci.TextPadding = new System.Windows.Forms.Padding(0);
            this.loaderIgraci.Thickness = 2;
            this.loaderIgraci.Transparent = true;
            // 
            // txtBrojIgraca
            // 
            this.txtBrojIgraca.AllowParentOverrides = false;
            this.txtBrojIgraca.AutoEllipsis = false;
            this.txtBrojIgraca.AutoSize = false;
            this.txtBrojIgraca.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBrojIgraca.CursorType = System.Windows.Forms.Cursors.Default;
            this.txtBrojIgraca.Font = new System.Drawing.Font("Oswald", 8F);
            this.txtBrojIgraca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtBrojIgraca.Location = new System.Drawing.Point(75, 25);
            this.txtBrojIgraca.Name = "txtBrojIgraca";
            this.txtBrojIgraca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBrojIgraca.Size = new System.Drawing.Size(28, 17);
            this.txtBrojIgraca.TabIndex = 354;
            this.txtBrojIgraca.Text = "22";
            this.txtBrojIgraca.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtBrojIgraca.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtBrojIgraca.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.lblDrzavljanstvoVrijednost.Location = new System.Drawing.Point(6, 25);
            this.lblDrzavljanstvoVrijednost.Name = "lblDrzavljanstvoVrijednost";
            this.lblDrzavljanstvoVrijednost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDrzavljanstvoVrijednost.Size = new System.Drawing.Size(73, 17);
            this.lblDrzavljanstvoVrijednost.TabIndex = 353;
            this.lblDrzavljanstvoVrijednost.Text = "Ukupno država: ";
            this.lblDrzavljanstvoVrijednost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDrzavljanstvoVrijednost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDrzavljanstvoVrijednost.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // pnlPrikazDrzava
            // 
            this.pnlPrikazDrzava.AutoScroll = true;
            this.pnlPrikazDrzava.Location = new System.Drawing.Point(348, 61);
            this.pnlPrikazDrzava.Name = "pnlPrikazDrzava";
            this.pnlPrikazDrzava.Size = new System.Drawing.Size(278, 256);
            this.pnlPrikazDrzava.TabIndex = 131;
            // 
            // lblNaslovStranice
            // 
            this.lblNaslovStranice.AllowParentOverrides = false;
            this.lblNaslovStranice.AutoEllipsis = false;
            this.lblNaslovStranice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNaslovStranice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNaslovStranice.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovStranice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.lblNaslovStranice.Location = new System.Drawing.Point(6, 4);
            this.lblNaslovStranice.Name = "lblNaslovStranice";
            this.lblNaslovStranice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNaslovStranice.Size = new System.Drawing.Size(48, 24);
            this.lblNaslovStranice.TabIndex = 357;
            this.lblNaslovStranice.Text = "DRŽAVE";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtTelefonValidator
            // 
            this.txtTelefonValidator.AllowParentOverrides = false;
            this.txtTelefonValidator.AutoEllipsis = false;
            this.txtTelefonValidator.CursorType = null;
            this.txtTelefonValidator.Font = new System.Drawing.Font("Oswald", 6F);
            this.txtTelefonValidator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.txtTelefonValidator.Location = new System.Drawing.Point(149, 93);
            this.txtTelefonValidator.Name = "txtTelefonValidator";
            this.txtTelefonValidator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefonValidator.Size = new System.Drawing.Size(0, 0);
            this.txtTelefonValidator.TabIndex = 359;
            this.txtTelefonValidator.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtTelefonValidator.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuButton1.ButtonText = "DODAJ DRŽAVU";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges7;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Oswald", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = global::eBordo.WinUI.Properties.Resources.save;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 20;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.save;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = true;
            this.bunifuButton1.Location = new System.Drawing.Point(172, 111);
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
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.save;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 10;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.save;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 10;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.save;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(119, 30);
            this.bunifuButton1.TabIndex = 360;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
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
            this.btnSaveUpdate.ButtonText = "SPASI IZMJENE";
            this.btnSaveUpdate.ButtonTextMarginLeft = 0;
            this.btnSaveUpdate.ColorContrastOnClick = 45;
            this.btnSaveUpdate.ColorContrastOnHover = 45;
            this.btnSaveUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnSaveUpdate.CustomizableEdges = borderEdges8;
            this.btnSaveUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveUpdate.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSaveUpdate.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSaveUpdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Oswald", 9F);
            this.btnSaveUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUpdate.IconLeft = global::eBordo.WinUI.Properties.Resources.save_black;
            this.btnSaveUpdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveUpdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
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
            this.btnSaveUpdate.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.save_black;
            this.btnSaveUpdate.IdleIconRightImage = null;
            this.btnSaveUpdate.IndicateFocus = true;
            this.btnSaveUpdate.Location = new System.Drawing.Point(172, 111);
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
            this.btnSaveUpdate.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.save_black;
            this.btnSaveUpdate.onHoverState.IconRightImage = null;
            this.btnSaveUpdate.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.OnIdleState.BorderRadius = 10;
            this.btnSaveUpdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUpdate.OnIdleState.BorderThickness = 1;
            this.btnSaveUpdate.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUpdate.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.save_black;
            this.btnSaveUpdate.OnIdleState.IconRightImage = null;
            this.btnSaveUpdate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.OnPressedState.BorderRadius = 10;
            this.btnSaveUpdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUpdate.OnPressedState.BorderThickness = 1;
            this.btnSaveUpdate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSaveUpdate.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUpdate.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.save_black;
            this.btnSaveUpdate.OnPressedState.IconRightImage = null;
            this.btnSaveUpdate.Size = new System.Drawing.Size(119, 30);
            this.btnSaveUpdate.TabIndex = 412;
            this.btnSaveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUpdate.TextMarginLeft = 0;
            this.btnSaveUpdate.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnSaveUpdate.UseDefaultRadiusAndThickness = true;
            this.btnSaveUpdate.Visible = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.AllowAnimations = true;
            this.btnOdustani.AllowMouseEffects = true;
            this.btnOdustani.AllowToggling = false;
            this.btnOdustani.AnimationSpeed = 200;
            this.btnOdustani.AutoGenerateColors = false;
            this.btnOdustani.AutoRoundBorders = false;
            this.btnOdustani.AutoSizeLeftIcon = false;
            this.btnOdustani.AutoSizeRightIcon = true;
            this.btnOdustani.BackColor = System.Drawing.Color.Transparent;
            this.btnOdustani.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnOdustani.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdustani.BackgroundImage")));
            this.btnOdustani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOdustani.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOdustani.ButtonText = "";
            this.btnOdustani.ButtonTextMarginLeft = 0;
            this.btnOdustani.ColorContrastOnClick = 45;
            this.btnOdustani.ColorContrastOnHover = 45;
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnOdustani.CustomizableEdges = borderEdges9;
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOdustani.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOdustani.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnOdustani.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnOdustani.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOdustani.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.IconLeft = global::eBordo.WinUI.Properties.Resources.eBordo_close;
            this.btnOdustani.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOdustani.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOdustani.IconMarginLeft = 11;
            this.btnOdustani.IconPadding = 10;
            this.btnOdustani.IconRight = null;
            this.btnOdustani.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOdustani.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnOdustani.IconSize = 25;
            this.btnOdustani.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnOdustani.IdleBorderRadius = 0;
            this.btnOdustani.IdleBorderThickness = 0;
            this.btnOdustani.IdleFillColor = System.Drawing.Color.Empty;
            this.btnOdustani.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.eBordo_close;
            this.btnOdustani.IdleIconRightImage = null;
            this.btnOdustani.IndicateFocus = true;
            this.btnOdustani.Location = new System.Drawing.Point(297, 111);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOdustani.OnDisabledState.BorderRadius = 10;
            this.btnOdustani.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOdustani.OnDisabledState.BorderThickness = 1;
            this.btnOdustani.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOdustani.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOdustani.OnDisabledState.IconLeftImage = null;
            this.btnOdustani.OnDisabledState.IconRightImage = null;
            this.btnOdustani.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnOdustani.onHoverState.BorderRadius = 10;
            this.btnOdustani.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOdustani.onHoverState.BorderThickness = 1;
            this.btnOdustani.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustani.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.eBordo_close;
            this.btnOdustani.onHoverState.IconRightImage = null;
            this.btnOdustani.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustani.OnIdleState.BorderRadius = 10;
            this.btnOdustani.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOdustani.OnIdleState.BorderThickness = 1;
            this.btnOdustani.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustani.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.eBordo_close;
            this.btnOdustani.OnIdleState.IconRightImage = null;
            this.btnOdustani.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustani.OnPressedState.BorderRadius = 10;
            this.btnOdustani.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOdustani.OnPressedState.BorderThickness = 1;
            this.btnOdustani.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustani.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.eBordo_close;
            this.btnOdustani.OnPressedState.IconRightImage = null;
            this.btnOdustani.Size = new System.Drawing.Size(45, 30);
            this.btnOdustani.TabIndex = 413;
            this.btnOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOdustani.TextMarginLeft = 0;
            this.btnOdustani.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnOdustani.UseDefaultRadiusAndThickness = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblIme
            // 
            this.lblIme.AllowParentOverrides = false;
            this.lblIme.AutoEllipsis = false;
            this.lblIme.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIme.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblIme.Font = new System.Drawing.Font("Oswald", 8F);
            this.lblIme.Location = new System.Drawing.Point(149, 46);
            this.lblIme.Name = "lblIme";
            this.lblIme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIme.Size = new System.Drawing.Size(54, 16);
            this.lblIme.TabIndex = 414;
            this.lblIme.Text = "Naziv države";
            this.lblIme.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblIme.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowMouseEffects = true;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.AnimationSpeed = 200;
            this.btnRefresh.AutoGenerateColors = false;
            this.btnRefresh.AutoRoundBorders = false;
            this.btnRefresh.AutoSizeLeftIcon = false;
            this.btnRefresh.AutoSizeRightIcon = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.ButtonText = "";
            this.btnRefresh.ButtonTextMarginLeft = 0;
            this.btnRefresh.ColorContrastOnClick = 45;
            this.btnRefresh.ColorContrastOnHover = 45;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnRefresh.CustomizableEdges = borderEdges10;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefresh.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnRefresh.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnRefresh.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRefresh.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconLeft = global::eBordo.WinUI.Properties.Resources.refresh;
            this.btnRefresh.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRefresh.IconMarginLeft = 11;
            this.btnRefresh.IconPadding = 10;
            this.btnRefresh.IconRight = null;
            this.btnRefresh.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRefresh.IconSize = 25;
            this.btnRefresh.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnRefresh.IdleBorderRadius = 0;
            this.btnRefresh.IdleBorderThickness = 0;
            this.btnRefresh.IdleFillColor = System.Drawing.Color.Empty;
            this.btnRefresh.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.btnRefresh.IdleIconRightImage = null;
            this.btnRefresh.IndicateFocus = true;
            this.btnRefresh.Location = new System.Drawing.Point(540, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefresh.OnDisabledState.BorderRadius = 10;
            this.btnRefresh.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnDisabledState.BorderThickness = 1;
            this.btnRefresh.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefresh.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefresh.OnDisabledState.IconLeftImage = null;
            this.btnRefresh.OnDisabledState.IconRightImage = null;
            this.btnRefresh.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnRefresh.onHoverState.BorderRadius = 10;
            this.btnRefresh.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.onHoverState.BorderThickness = 1;
            this.btnRefresh.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnRefresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.btnRefresh.onHoverState.IconRightImage = null;
            this.btnRefresh.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnRefresh.OnIdleState.BorderRadius = 10;
            this.btnRefresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnIdleState.BorderThickness = 1;
            this.btnRefresh.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnRefresh.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.btnRefresh.OnIdleState.IconRightImage = null;
            this.btnRefresh.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnRefresh.OnPressedState.BorderRadius = 10;
            this.btnRefresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnPressedState.BorderThickness = 1;
            this.btnRefresh.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.btnRefresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.btnRefresh.OnPressedState.IconRightImage = null;
            this.btnRefresh.Size = new System.Drawing.Size(44, 31);
            this.btnRefresh.TabIndex = 423;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.TextMarginLeft = 0;
            this.btnRefresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefresh.UseDefaultRadiusAndThickness = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // noSearchResults
            // 
            this.noSearchResults.BackColor = System.Drawing.Color.Transparent;
            this.noSearchResults.BackgroundImage = global::eBordo.WinUI.Properties.Resources.nema_rezultata_pretrage;
            this.noSearchResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noSearchResults.Location = new System.Drawing.Point(404, 109);
            this.noSearchResults.Name = "noSearchResults";
            this.noSearchResults.Size = new System.Drawing.Size(151, 139);
            this.noSearchResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noSearchResults.TabIndex = 424;
            this.noSearchResults.TabStop = false;
            this.noSearchResults.Visible = false;
            // 
            // noSearchResultsText
            // 
            this.noSearchResultsText.AllowParentOverrides = false;
            this.noSearchResultsText.AutoEllipsis = false;
            this.noSearchResultsText.Cursor = System.Windows.Forms.Cursors.Default;
            this.noSearchResultsText.CursorType = System.Windows.Forms.Cursors.Default;
            this.noSearchResultsText.Font = new System.Drawing.Font("Oswald", 10F);
            this.noSearchResultsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noSearchResultsText.Location = new System.Drawing.Point(433, 241);
            this.noSearchResultsText.Name = "noSearchResultsText";
            this.noSearchResultsText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.noSearchResultsText.Size = new System.Drawing.Size(88, 20);
            this.noSearchResultsText.TabIndex = 425;
            this.noSearchResultsText.Text = "NEMA REZULTATA";
            this.noSearchResultsText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.noSearchResultsText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.noSearchResultsText.Visible = false;
            // 
            // frmPrikazDrzava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.noSearchResultsText);
            this.Controls.Add(this.noSearchResults);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.txtTelefonValidator);
            this.Controls.Add(this.lblNaslovStranice);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.loaderIgraci);
            this.Controls.Add(this.txtBrojIgraca);
            this.Controls.Add(this.lblDrzavljanstvoVrijednost);
            this.Controls.Add(this.pictureSlikaUtakmicaValidator);
            this.Controls.Add(this.btnUcitajPanelPhoto);
            this.Controls.Add(this.pnlPrikazDrzava);
            this.Controls.Add(this.pictureZastava);
            this.Controls.Add(this.txtNazivDrzave);
            this.Name = "frmPrikazDrzava";
            this.Size = new System.Drawing.Size(587, 317);
            this.Load += new System.EventHandler(this.frmPrikazDrzava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureZastava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlikaUtakmicaValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog grbFileDialog;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private System.Windows.Forms.PictureBox pictureZastava;
        private Bunifu.UI.WinForms.BunifuTextBox txtNazivDrzave;
        private System.Windows.Forms.PictureBox pictureSlikaUtakmicaValidator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUcitajPanelPhoto;
        private System.Windows.Forms.PictureBox loader;
        private Bunifu.UI.WinForms.BunifuLoader loaderIgraci;
        private Bunifu.UI.WinForms.BunifuLabel txtBrojIgraca;
        private Bunifu.UI.WinForms.BunifuLabel lblDrzavljanstvoVrijednost;
        private System.Windows.Forms.FlowLayoutPanel pnlPrikazDrzava;
        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private Bunifu.UI.WinForms.BunifuLabel txtTelefonValidator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveUpdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOdustani;
        private Bunifu.UI.WinForms.BunifuLabel lblIme;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefresh;
        private System.Windows.Forms.PictureBox noSearchResults;
        private Bunifu.UI.WinForms.BunifuLabel noSearchResultsText;
    }
}
