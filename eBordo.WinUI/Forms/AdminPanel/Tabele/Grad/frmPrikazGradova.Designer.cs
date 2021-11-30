
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.cmbDrzave = new Bunifu.UI.WinForms.BunifuDropdown();
            this.pnlPrikazKlubova = new System.Windows.Forms.FlowLayoutPanel();
            this.grbFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.pnlLoader = new System.Windows.Forms.Panel();
            this.loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtNazivKluba = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlLoader.SuspendLayout();
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
            this.cmbDrzave.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.cmbDrzave.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.cmbDrzave.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbDrzave.ItemTopMargin = 3;
            this.cmbDrzave.Location = new System.Drawing.Point(178, 5);
            this.cmbDrzave.Name = "cmbDrzave";
            this.cmbDrzave.Size = new System.Drawing.Size(169, 32);
            this.cmbDrzave.TabIndex = 134;
            this.cmbDrzave.Text = "Država";
            this.cmbDrzave.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbDrzave.TextLeftMargin = 5;
            // 
            // pnlPrikazKlubova
            // 
            this.pnlPrikazKlubova.AutoScroll = true;
            this.pnlPrikazKlubova.Location = new System.Drawing.Point(351, 0);
            this.pnlPrikazKlubova.Name = "pnlPrikazKlubova";
            this.pnlPrikazKlubova.Size = new System.Drawing.Size(236, 317);
            this.pnlPrikazKlubova.TabIndex = 131;
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
            // pnlLoader
            // 
            this.pnlLoader.Controls.Add(this.loader);
            this.pnlLoader.Location = new System.Drawing.Point(351, 0);
            this.pnlLoader.Name = "pnlLoader";
            this.pnlLoader.Size = new System.Drawing.Size(236, 317);
            this.pnlLoader.TabIndex = 137;
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
            this.loader.Location = new System.Drawing.Point(99, 122);
            this.loader.Name = "loader";
            this.loader.NoRounding = false;
            this.loader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loader.ShowText = false;
            this.loader.Size = new System.Drawing.Size(40, 40);
            this.loader.Speed = 7;
            this.loader.TabIndex = 130;
            this.loader.Text = "loader";
            this.loader.TextPadding = new System.Windows.Forms.Padding(0);
            this.loader.Thickness = 6;
            this.loader.Transparent = true;
            // 
            // btnSave
            // 
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowMouseEffects = true;
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoRoundBorders = false;
            this.btnSave.AutoSizeLeftIcon = true;
            this.btnSave.AutoSizeRightIcon = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Spasi";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSave.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeft = null;
            this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRight = null;
            this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.IconSize = 25;
            this.btnSave.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSave.IdleBorderRadius = 0;
            this.btnSave.IdleBorderThickness = 0;
            this.btnSave.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(237, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 0;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnSave.onHoverState.BorderRadius = 0;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnSave.OnIdleState.BorderRadius = 0;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.Green;
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btnSave.OnPressedState.BorderRadius = 0;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 136;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txtNazivKluba.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtNazivKluba.DefaultText = "";
            this.txtNazivKluba.FillColor = System.Drawing.Color.White;
            this.txtNazivKluba.HideSelection = true;
            this.txtNazivKluba.IconLeft = null;
            this.txtNazivKluba.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNazivKluba.IconPadding = 10;
            this.txtNazivKluba.IconRight = null;
            this.txtNazivKluba.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNazivKluba.Lines = new string[0];
            this.txtNazivKluba.Location = new System.Drawing.Point(3, 5);
            this.txtNazivKluba.MaxLength = 32767;
            this.txtNazivKluba.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNazivKluba.Modified = false;
            this.txtNazivKluba.Multiline = false;
            this.txtNazivKluba.Name = "txtNazivKluba";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivKluba.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNazivKluba.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivKluba.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNazivKluba.OnIdleState = stateProperties4;
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
            this.txtNazivKluba.Size = new System.Drawing.Size(169, 32);
            this.txtNazivKluba.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNazivKluba.TabIndex = 132;
            this.txtNazivKluba.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNazivKluba.TextMarginBottom = 0;
            this.txtNazivKluba.TextMarginLeft = 3;
            this.txtNazivKluba.TextMarginTop = 1;
            this.txtNazivKluba.TextPlaceholder = "Ime grada";
            this.txtNazivKluba.UseSystemPasswordChar = false;
            this.txtNazivKluba.WordWrap = true;
            // 
            // frmPrikazGradova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbDrzave);
            this.Controls.Add(this.pnlPrikazKlubova);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNazivKluba);
            this.Controls.Add(this.pnlLoader);
            this.Name = "frmPrikazGradova";
            this.Size = new System.Drawing.Size(587, 317);
            this.Load += new System.EventHandler(this.frmPrikazGradova_Load);
            this.pnlLoader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown cmbDrzave;
        private System.Windows.Forms.FlowLayoutPanel pnlPrikazKlubova;
        private System.Windows.Forms.OpenFileDialog grbFileDialog;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.UI.WinForms.BunifuTextBox txtNazivKluba;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private System.Windows.Forms.Panel pnlLoader;
        private Bunifu.UI.WinForms.BunifuLoader loader;
    }
}
