
namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Grad
{
    partial class frmPrikazGradova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrikazGradova));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cmbDrzave = new Bunifu.UI.WinForms.BunifuDropdown();
            this.grbFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.txtNazivKluba = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtTelefonValidator = new Bunifu.UI.WinForms.BunifuLabel();
            this.loaderIgraci = new Bunifu.UI.WinForms.BunifuLoader();
            this.txtBrojIgraca = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDrzavljanstvoVrijednost = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlPrikazKlubova = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.loader = new System.Windows.Forms.PictureBox();
            this.btnSaveUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOdustani = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtDrzavaValidator = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureDrzavaValidator = new System.Windows.Forms.PictureBox();
            this.lblIme = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrzavaValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDrzave
            // 
            this.cmbDrzave.BackColor = System.Drawing.Color.Transparent;
            this.cmbDrzave.BackgroundColor = System.Drawing.Color.White;
            this.cmbDrzave.BorderColor = System.Drawing.Color.Silver;
            this.cmbDrzave.BorderRadius = 1;
            this.cmbDrzave.Color = System.Drawing.Color.Silver;
            this.cmbDrzave.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbDrzave.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbDrzave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbDrzave.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbDrzave.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbDrzave.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbDrzave.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDrzave.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbDrzave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrzave.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbDrzave.FillDropDown = true;
            this.cmbDrzave.FillIndicator = false;
            this.cmbDrzave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDrzave.Font = new System.Drawing.Font("Oswald", 8.25F);
            this.cmbDrzave.ForeColor = System.Drawing.Color.Black;
            this.cmbDrzave.FormattingEnabled = true;
            this.cmbDrzave.Icon = null;
            this.cmbDrzave.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbDrzave.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbDrzave.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbDrzave.IndicatorThickness = 2;
            this.cmbDrzave.IsDropdownOpened = false;
            this.cmbDrzave.ItemBackColor = System.Drawing.Color.White;
            this.cmbDrzave.ItemBorderColor = System.Drawing.Color.White;
            this.cmbDrzave.ItemForeColor = System.Drawing.Color.Black;
            this.cmbDrzave.ItemHeight = 26;
            this.cmbDrzave.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.cmbDrzave.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbDrzave.ItemTopMargin = 3;
            this.cmbDrzave.Location = new System.Drawing.Point(191, 62);
            this.cmbDrzave.Name = "cmbDrzave";
            this.cmbDrzave.Size = new System.Drawing.Size(180, 32);
            this.cmbDrzave.TabIndex = 134;
            this.cmbDrzave.Text = "Država";
            this.cmbDrzave.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbDrzave.TextLeftMargin = 5;
            this.cmbDrzave.SelectedIndexChanged += new System.EventHandler(this.cmbDrzave_SelectedIndexChanged);
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
            // txtNazivKluba
            // 
            this.txtNazivKluba.AcceptsReturn = false;
            this.txtNazivKluba.AcceptsTab = false;
            this.txtNazivKluba.AnimationSpeed = 200;
            this.txtNazivKluba.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNazivKluba.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNazivKluba.AutoSizeHeight = true;
            this.txtNazivKluba.BackColor = System.Drawing.Color.Transparent;
            this.txtNazivKluba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNazivKluba.BackgroundImage")));
            this.txtNazivKluba.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtNazivKluba.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNazivKluba.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtNazivKluba.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNazivKluba.BorderRadius = 1;
            this.txtNazivKluba.BorderThickness = 1;
            this.txtNazivKluba.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNazivKluba.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNazivKluba.DefaultFont = new System.Drawing.Font("Oswald", 9F);
            this.txtNazivKluba.DefaultText = "";
            this.txtNazivKluba.FillColor = System.Drawing.Color.White;
            this.txtNazivKluba.HideSelection = true;
            this.txtNazivKluba.IconLeft = null;
            this.txtNazivKluba.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNazivKluba.IconPadding = 10;
            this.txtNazivKluba.IconRight = global::eBordo.WinUI.Properties.Resources.eBordo_required3;
            this.txtNazivKluba.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNazivKluba.Lines = new string[0];
            this.txtNazivKluba.Location = new System.Drawing.Point(6, 63);
            this.txtNazivKluba.MaxLength = 32767;
            this.txtNazivKluba.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNazivKluba.Modified = false;
            this.txtNazivKluba.Multiline = false;
            this.txtNazivKluba.Name = "txtNazivKluba";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivKluba.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNazivKluba.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivKluba.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivKluba.OnIdleState = stateProperties12;
            this.txtNazivKluba.Padding = new System.Windows.Forms.Padding(3);
            this.txtNazivKluba.PasswordChar = '\0';
            this.txtNazivKluba.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNazivKluba.PlaceholderText = "Ime grada";
            this.txtNazivKluba.ReadOnly = false;
            this.txtNazivKluba.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNazivKluba.SelectedText = "";
            this.txtNazivKluba.SelectionLength = 0;
            this.txtNazivKluba.SelectionStart = 0;
            this.txtNazivKluba.ShortcutsEnabled = true;
            this.txtNazivKluba.Size = new System.Drawing.Size(180, 32);
            this.txtNazivKluba.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNazivKluba.TabIndex = 132;
            this.txtNazivKluba.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNazivKluba.TextMarginBottom = 0;
            this.txtNazivKluba.TextMarginLeft = 3;
            this.txtNazivKluba.TextMarginTop = 1;
            this.txtNazivKluba.TextPlaceholder = "Ime grada";
            this.txtNazivKluba.UseSystemPasswordChar = false;
            this.txtNazivKluba.WordWrap = true;
            this.txtNazivKluba.TextChanged += new System.EventHandler(this.txtNazivKluba_TextChanged);
            // 
            // txtTelefonValidator
            // 
            this.txtTelefonValidator.AllowParentOverrides = false;
            this.txtTelefonValidator.AutoEllipsis = false;
            this.txtTelefonValidator.CursorType = null;
            this.txtTelefonValidator.Font = new System.Drawing.Font("Oswald", 6F);
            this.txtTelefonValidator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.txtTelefonValidator.Location = new System.Drawing.Point(8, 94);
            this.txtTelefonValidator.Name = "txtTelefonValidator";
            this.txtTelefonValidator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefonValidator.Size = new System.Drawing.Size(0, 0);
            this.txtTelefonValidator.TabIndex = 377;
            this.txtTelefonValidator.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtTelefonValidator.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.loaderIgraci.Location = new System.Drawing.Point(82, 27);
            this.loaderIgraci.Name = "loaderIgraci";
            this.loaderIgraci.NoRounding = false;
            this.loaderIgraci.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loaderIgraci.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loaderIgraci.ShowText = false;
            this.loaderIgraci.Size = new System.Drawing.Size(12, 12);
            this.loaderIgraci.Speed = 7;
            this.loaderIgraci.TabIndex = 376;
            this.loaderIgraci.Text = "bunifuLoader1";
            this.loaderIgraci.TextPadding = new System.Windows.Forms.Padding(0);
            this.loaderIgraci.Thickness = 2;
            this.loaderIgraci.Transparent = true;
            this.loaderIgraci.Click += new System.EventHandler(this.loaderIgraci_Click);
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
            this.txtBrojIgraca.Location = new System.Drawing.Point(82, 25);
            this.txtBrojIgraca.Name = "txtBrojIgraca";
            this.txtBrojIgraca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBrojIgraca.Size = new System.Drawing.Size(28, 17);
            this.txtBrojIgraca.TabIndex = 375;
            this.txtBrojIgraca.Text = "22";
            this.txtBrojIgraca.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtBrojIgraca.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtBrojIgraca.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtBrojIgraca.Click += new System.EventHandler(this.txtBrojIgraca_Click);
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
            this.lblDrzavljanstvoVrijednost.Size = new System.Drawing.Size(78, 17);
            this.lblDrzavljanstvoVrijednost.TabIndex = 374;
            this.lblDrzavljanstvoVrijednost.Text = "Ukupno gradova: ";
            this.lblDrzavljanstvoVrijednost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDrzavljanstvoVrijednost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDrzavljanstvoVrijednost.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.lblNaslovStranice.Size = new System.Drawing.Size(56, 24);
            this.lblNaslovStranice.TabIndex = 373;
            this.lblNaslovStranice.Text = "GRADOVI";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuButton1.ButtonText = "DODAJ GRAD";
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
            this.bunifuButton1.Location = new System.Drawing.Point(210, 112);
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
            this.bunifuButton1.Size = new System.Drawing.Size(109, 30);
            this.bunifuButton1.TabIndex = 372;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::eBordo.WinUI.Properties.Resources.giphy;
            this.pictureBox5.Image = global::eBordo.WinUI.Properties.Resources.ezgif1;
            this.pictureBox5.Location = new System.Drawing.Point(333, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 371;
            this.pictureBox5.TabStop = false;
            // 
            // pnlPrikazKlubova
            // 
            this.pnlPrikazKlubova.AutoScroll = true;
            this.pnlPrikazKlubova.Location = new System.Drawing.Point(377, 27);
            this.pnlPrikazKlubova.Name = "pnlPrikazKlubova";
            this.pnlPrikazKlubova.Size = new System.Drawing.Size(236, 290);
            this.pnlPrikazKlubova.TabIndex = 131;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gainsboro;
            this.label14.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(379, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 23);
            this.label14.TabIndex = 380;
            this.label14.Text = "GRADOVI";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.BackgroundImage = global::eBordo.WinUI.Properties.Resources.giphy;
            this.loader.Image = global::eBordo.WinUI.Properties.Resources.ezgif2;
            this.loader.Location = new System.Drawing.Point(441, 127);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(91, 61);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loader.TabIndex = 381;
            this.loader.TabStop = false;
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
            this.btnSaveUpdate.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
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
            this.btnSaveUpdate.Location = new System.Drawing.Point(210, 112);
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
            this.btnSaveUpdate.Size = new System.Drawing.Size(109, 30);
            this.btnSaveUpdate.TabIndex = 411;
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
            this.btnOdustani.Location = new System.Drawing.Point(325, 112);
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
            this.btnOdustani.TabIndex = 412;
            this.btnOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOdustani.TextMarginLeft = 0;
            this.btnOdustani.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnOdustani.UseDefaultRadiusAndThickness = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtDrzavaValidator
            // 
            this.txtDrzavaValidator.AllowParentOverrides = false;
            this.txtDrzavaValidator.AutoEllipsis = false;
            this.txtDrzavaValidator.CursorType = null;
            this.txtDrzavaValidator.Font = new System.Drawing.Font("Oswald", 6F);
            this.txtDrzavaValidator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.txtDrzavaValidator.Location = new System.Drawing.Point(192, 94);
            this.txtDrzavaValidator.Name = "txtDrzavaValidator";
            this.txtDrzavaValidator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDrzavaValidator.Size = new System.Drawing.Size(0, 0);
            this.txtDrzavaValidator.TabIndex = 413;
            this.txtDrzavaValidator.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtDrzavaValidator.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureDrzavaValidator
            // 
            this.pictureDrzavaValidator.BackgroundImage = global::eBordo.WinUI.Properties.Resources.eBordo_required3;
            this.pictureDrzavaValidator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureDrzavaValidator.Location = new System.Drawing.Point(351, 74);
            this.pictureDrzavaValidator.Name = "pictureDrzavaValidator";
            this.pictureDrzavaValidator.Size = new System.Drawing.Size(10, 10);
            this.pictureDrzavaValidator.TabIndex = 414;
            this.pictureDrzavaValidator.TabStop = false;
            // 
            // lblIme
            // 
            this.lblIme.AllowParentOverrides = false;
            this.lblIme.AutoEllipsis = false;
            this.lblIme.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIme.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblIme.Font = new System.Drawing.Font("Oswald", 8F);
            this.lblIme.Location = new System.Drawing.Point(6, 48);
            this.lblIme.Name = "lblIme";
            this.lblIme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIme.Size = new System.Drawing.Size(50, 16);
            this.lblIme.TabIndex = 415;
            this.lblIme.Text = "Naziv grada";
            this.lblIme.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblIme.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmPrikazGradova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.pictureDrzavaValidator);
            this.Controls.Add(this.txtDrzavaValidator);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pnlPrikazKlubova);
            this.Controls.Add(this.txtTelefonValidator);
            this.Controls.Add(this.loaderIgraci);
            this.Controls.Add(this.txtBrojIgraca);
            this.Controls.Add(this.lblDrzavljanstvoVrijednost);
            this.Controls.Add(this.lblNaslovStranice);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.cmbDrzave);
            this.Controls.Add(this.txtNazivKluba);
            this.Name = "frmPrikazGradova";
            this.Size = new System.Drawing.Size(587, 317);
            this.Load += new System.EventHandler(this.frmPrikazGradova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrzavaValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown cmbDrzave;
        private System.Windows.Forms.OpenFileDialog grbFileDialog;
        private Bunifu.UI.WinForms.BunifuTextBox txtNazivKluba;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private Bunifu.UI.WinForms.BunifuLabel txtTelefonValidator;
        private Bunifu.UI.WinForms.BunifuLoader loaderIgraci;
        private Bunifu.UI.WinForms.BunifuLabel txtBrojIgraca;
        private Bunifu.UI.WinForms.BunifuLabel lblDrzavljanstvoVrijednost;
        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.FlowLayoutPanel pnlPrikazKlubova;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox loader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveUpdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOdustani;
        private Bunifu.UI.WinForms.BunifuLabel txtDrzavaValidator;
        private System.Windows.Forms.PictureBox pictureDrzavaValidator;
        private Bunifu.UI.WinForms.BunifuLabel lblIme;
    }
}
