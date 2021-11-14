
namespace eBordo.WinUI.Forms.AdminPanel.RasporedUtakmica
{
    partial class frmPrikazRasporedaUtakmicacs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrikazRasporedaUtakmicacs));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlRasporedUtakmica = new System.Windows.Forms.Panel();
            this.pnlUtakmiceWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.btnDodajUtakmicu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtImePrezime = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cmbPozicije = new Bunifu.UI.WinForms.BunifuDropdown();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.SuspendLayout();
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
            this.lblNaslovStranice.Size = new System.Drawing.Size(170, 21);
            this.lblNaslovStranice.TabIndex = 1;
            this.lblNaslovStranice.Text = "RASPORED UTAKMICA";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlRasporedUtakmica
            // 
            this.pnlRasporedUtakmica.Location = new System.Drawing.Point(20, 104);
            this.pnlRasporedUtakmica.Name = "pnlRasporedUtakmica";
            this.pnlRasporedUtakmica.Size = new System.Drawing.Size(600, 305);
            this.pnlRasporedUtakmica.TabIndex = 2;
            // 
            // pnlUtakmiceWrapper
            // 
            this.pnlUtakmiceWrapper.AutoScroll = true;
            this.pnlUtakmiceWrapper.Location = new System.Drawing.Point(20, 104);
            this.pnlUtakmiceWrapper.Name = "pnlUtakmiceWrapper";
            this.pnlUtakmiceWrapper.Size = new System.Drawing.Size(600, 305);
            this.pnlUtakmiceWrapper.TabIndex = 0;
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
            this.loader.TabIndex = 9;
            this.loader.Text = "bunifuLoader1";
            this.loader.TextPadding = new System.Windows.Forms.Padding(0);
            this.loader.Thickness = 6;
            this.loader.Transparent = true;
            // 
            // btnDodajUtakmicu
            // 
            this.btnDodajUtakmicu.AllowAnimations = true;
            this.btnDodajUtakmicu.AllowMouseEffects = true;
            this.btnDodajUtakmicu.AllowToggling = false;
            this.btnDodajUtakmicu.AnimationSpeed = 200;
            this.btnDodajUtakmicu.AutoGenerateColors = false;
            this.btnDodajUtakmicu.AutoRoundBorders = false;
            this.btnDodajUtakmicu.AutoSizeLeftIcon = true;
            this.btnDodajUtakmicu.AutoSizeRightIcon = true;
            this.btnDodajUtakmicu.BackColor = System.Drawing.Color.Transparent;
            this.btnDodajUtakmicu.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDodajUtakmicu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajUtakmicu.BackgroundImage")));
            this.btnDodajUtakmicu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajUtakmicu.ButtonText = "DODAJ UTAKMICU";
            this.btnDodajUtakmicu.ButtonTextMarginLeft = 0;
            this.btnDodajUtakmicu.ColorContrastOnClick = 45;
            this.btnDodajUtakmicu.ColorContrastOnHover = 45;
            this.btnDodajUtakmicu.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDodajUtakmicu.CustomizableEdges = borderEdges1;
            this.btnDodajUtakmicu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDodajUtakmicu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDodajUtakmicu.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDodajUtakmicu.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDodajUtakmicu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDodajUtakmicu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUtakmicu.ForeColor = System.Drawing.Color.White;
            this.btnDodajUtakmicu.IconLeft = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajUtakmicu.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajUtakmicu.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajUtakmicu.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDodajUtakmicu.IconMarginLeft = 11;
            this.btnDodajUtakmicu.IconPadding = 10;
            this.btnDodajUtakmicu.IconRight = null;
            this.btnDodajUtakmicu.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajUtakmicu.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajUtakmicu.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDodajUtakmicu.IconSize = 50;
            this.btnDodajUtakmicu.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDodajUtakmicu.IdleBorderRadius = 0;
            this.btnDodajUtakmicu.IdleBorderThickness = 0;
            this.btnDodajUtakmicu.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDodajUtakmicu.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajUtakmicu.IdleIconRightImage = null;
            this.btnDodajUtakmicu.IndicateFocus = true;
            this.btnDodajUtakmicu.Location = new System.Drawing.Point(454, 70);
            this.btnDodajUtakmicu.Name = "btnDodajUtakmicu";
            this.btnDodajUtakmicu.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDodajUtakmicu.OnDisabledState.BorderRadius = 10;
            this.btnDodajUtakmicu.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajUtakmicu.OnDisabledState.BorderThickness = 1;
            this.btnDodajUtakmicu.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDodajUtakmicu.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDodajUtakmicu.OnDisabledState.IconLeftImage = null;
            this.btnDodajUtakmicu.OnDisabledState.IconRightImage = null;
            this.btnDodajUtakmicu.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnDodajUtakmicu.onHoverState.BorderRadius = 10;
            this.btnDodajUtakmicu.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajUtakmicu.onHoverState.BorderThickness = 1;
            this.btnDodajUtakmicu.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajUtakmicu.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDodajUtakmicu.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajUtakmicu.onHoverState.IconRightImage = null;
            this.btnDodajUtakmicu.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajUtakmicu.OnIdleState.BorderRadius = 10;
            this.btnDodajUtakmicu.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajUtakmicu.OnIdleState.BorderThickness = 1;
            this.btnDodajUtakmicu.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajUtakmicu.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDodajUtakmicu.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajUtakmicu.OnIdleState.IconRightImage = null;
            this.btnDodajUtakmicu.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajUtakmicu.OnPressedState.BorderRadius = 10;
            this.btnDodajUtakmicu.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajUtakmicu.OnPressedState.BorderThickness = 1;
            this.btnDodajUtakmicu.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajUtakmicu.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDodajUtakmicu.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajUtakmicu.OnPressedState.IconRightImage = null;
            this.btnDodajUtakmicu.Size = new System.Drawing.Size(144, 32);
            this.btnDodajUtakmicu.TabIndex = 16;
            this.btnDodajUtakmicu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajUtakmicu.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDodajUtakmicu.TextMarginLeft = 0;
            this.btnDodajUtakmicu.TextPadding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnDodajUtakmicu.UseDefaultRadiusAndThickness = true;
            this.btnDodajUtakmicu.Click += new System.EventHandler(this.btnDodajUtakmicu_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRefresh.CustomizableEdges = borderEdges2;
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
            this.btnRefresh.Location = new System.Drawing.Point(23, 71);
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
            this.btnRefresh.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnRefresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.btnRefresh.onHoverState.IconRightImage = null;
            this.btnRefresh.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnRefresh.OnIdleState.BorderRadius = 10;
            this.btnRefresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnIdleState.BorderThickness = 1;
            this.btnRefresh.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnRefresh.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.btnRefresh.OnIdleState.IconRightImage = null;
            this.btnRefresh.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnRefresh.OnPressedState.BorderRadius = 10;
            this.btnRefresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnPressedState.BorderThickness = 1;
            this.btnRefresh.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnRefresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.refresh;
            this.btnRefresh.OnPressedState.IconRightImage = null;
            this.btnRefresh.Size = new System.Drawing.Size(44, 31);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.TextMarginLeft = 0;
            this.btnRefresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefresh.UseDefaultRadiusAndThickness = true;
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
            this.txtImePrezime.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
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
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtImePrezime.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtImePrezime.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtImePrezime.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtImePrezime.OnIdleState = stateProperties4;
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
            this.txtImePrezime.TabIndex = 18;
            this.txtImePrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtImePrezime.TextMarginBottom = 0;
            this.txtImePrezime.TextMarginLeft = 3;
            this.txtImePrezime.TextMarginTop = 1;
            this.txtImePrezime.TextPlaceholder = "Ime i prezime";
            this.txtImePrezime.UseSystemPasswordChar = false;
            this.txtImePrezime.WordWrap = true;
            // 
            // cmbPozicije
            // 
            this.cmbPozicije.BackColor = System.Drawing.Color.Transparent;
            this.cmbPozicije.BackgroundColor = System.Drawing.Color.White;
            this.cmbPozicije.BorderColor = System.Drawing.Color.Silver;
            this.cmbPozicije.BorderRadius = 1;
            this.cmbPozicije.Color = System.Drawing.Color.Silver;
            this.cmbPozicije.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbPozicije.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbPozicije.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbPozicije.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbPozicije.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbPozicije.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbPozicije.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPozicije.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbPozicije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozicije.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbPozicije.FillDropDown = true;
            this.cmbPozicije.FillIndicator = false;
            this.cmbPozicije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPozicije.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPozicije.ForeColor = System.Drawing.Color.Black;
            this.cmbPozicije.FormattingEnabled = true;
            this.cmbPozicije.Icon = null;
            this.cmbPozicije.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbPozicije.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbPozicije.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbPozicije.IndicatorThickness = 2;
            this.cmbPozicije.IsDropdownOpened = false;
            this.cmbPozicije.ItemBackColor = System.Drawing.Color.White;
            this.cmbPozicije.ItemBorderColor = System.Drawing.Color.White;
            this.cmbPozicije.ItemForeColor = System.Drawing.Color.Black;
            this.cmbPozicije.ItemHeight = 26;
            this.cmbPozicije.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.cmbPozicije.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbPozicije.ItemTopMargin = 3;
            this.cmbPozicije.Location = new System.Drawing.Point(236, 70);
            this.cmbPozicije.Name = "cmbPozicije";
            this.cmbPozicije.Size = new System.Drawing.Size(165, 32);
            this.cmbPozicije.TabIndex = 17;
            this.cmbPozicije.Text = "Pozicija";
            this.cmbPozicije.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbPozicije.TextLeftMargin = 5;
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
            // frmPrikazRasporedaUtakmicacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loader);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.cmbPozicije);
            this.Controls.Add(this.pnlUtakmiceWrapper);
            this.Controls.Add(this.btnDodajUtakmicu);
            this.Controls.Add(this.pnlRasporedUtakmica);
            this.Controls.Add(this.lblNaslovStranice);
            this.Name = "frmPrikazRasporedaUtakmicacs";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmPrikazRasporedaUtakmicacs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private System.Windows.Forms.Panel pnlRasporedUtakmica;
        private System.Windows.Forms.FlowLayoutPanel pnlUtakmiceWrapper;
        private Bunifu.UI.WinForms.BunifuLoader loader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDodajUtakmicu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuTextBox txtImePrezime;
        private Bunifu.UI.WinForms.BunifuDropdown cmbPozicije;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
    }
}
