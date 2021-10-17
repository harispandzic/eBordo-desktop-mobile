
namespace eBordo.WinUI.Forms.Login
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtKorisnickoIme = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlLoginPozadina = new System.Windows.Forms.Panel();
            this.pnlGrb = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtLozinka = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnPrijava = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bnfSnackBar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.AcceptsReturn = false;
            this.txtKorisnickoIme.AcceptsTab = false;
            this.txtKorisnickoIme.AnimationSpeed = 200;
            this.txtKorisnickoIme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtKorisnickoIme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtKorisnickoIme.AutoSizeHeight = true;
            this.txtKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.txtKorisnickoIme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtKorisnickoIme.BackgroundImage")));
            this.txtKorisnickoIme.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtKorisnickoIme.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtKorisnickoIme.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtKorisnickoIme.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtKorisnickoIme.BorderRadius = 1;
            this.txtKorisnickoIme.BorderThickness = 1;
            this.txtKorisnickoIme.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKorisnickoIme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKorisnickoIme.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtKorisnickoIme.DefaultText = "";
            this.txtKorisnickoIme.FillColor = System.Drawing.Color.White;
            this.txtKorisnickoIme.HideSelection = true;
            this.txtKorisnickoIme.IconLeft = null;
            this.txtKorisnickoIme.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKorisnickoIme.IconPadding = 10;
            this.txtKorisnickoIme.IconRight = null;
            this.txtKorisnickoIme.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKorisnickoIme.Lines = new string[0];
            this.txtKorisnickoIme.Location = new System.Drawing.Point(27, 189);
            this.txtKorisnickoIme.MaxLength = 32767;
            this.txtKorisnickoIme.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtKorisnickoIme.Modified = false;
            this.txtKorisnickoIme.Multiline = false;
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKorisnickoIme.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtKorisnickoIme.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKorisnickoIme.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKorisnickoIme.OnIdleState = stateProperties4;
            this.txtKorisnickoIme.Padding = new System.Windows.Forms.Padding(3);
            this.txtKorisnickoIme.PasswordChar = '\0';
            this.txtKorisnickoIme.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKorisnickoIme.PlaceholderText = "Korisničko ime";
            this.txtKorisnickoIme.ReadOnly = false;
            this.txtKorisnickoIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKorisnickoIme.SelectedText = "";
            this.txtKorisnickoIme.SelectionLength = 0;
            this.txtKorisnickoIme.SelectionStart = 0;
            this.txtKorisnickoIme.ShortcutsEnabled = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(260, 39);
            this.txtKorisnickoIme.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtKorisnickoIme.TabIndex = 2;
            this.txtKorisnickoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKorisnickoIme.TextMarginBottom = 0;
            this.txtKorisnickoIme.TextMarginLeft = 3;
            this.txtKorisnickoIme.TextMarginTop = 1;
            this.txtKorisnickoIme.TextPlaceholder = "Korisničko ime";
            this.txtKorisnickoIme.UseSystemPasswordChar = false;
            this.txtKorisnickoIme.WordWrap = true;
            // 
            // pnlLoginPozadina
            // 
            this.pnlLoginPozadina.BackgroundImage = global::eBordo.WinUI.Properties.Resources.LoginBackground;
            this.pnlLoginPozadina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginPozadina.Location = new System.Drawing.Point(318, 0);
            this.pnlLoginPozadina.Name = "pnlLoginPozadina";
            this.pnlLoginPozadina.Size = new System.Drawing.Size(319, 382);
            this.pnlLoginPozadina.TabIndex = 1;
            // 
            // pnlGrb
            // 
            this.pnlGrb.BackgroundImage = global::eBordo.WinUI.Properties.Resources.dd1860c8_3fc1_4729_9da0_86d0a8038668;
            this.pnlGrb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGrb.Location = new System.Drawing.Point(119, 23);
            this.pnlGrb.Name = "pnlGrb";
            this.pnlGrb.Size = new System.Drawing.Size(76, 100);
            this.pnlGrb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prijavi se";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(68, 157);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(185, 16);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Unesite podatke za prijavu";
            // 
            // txtLozinka
            // 
            this.txtLozinka.AcceptsReturn = false;
            this.txtLozinka.AcceptsTab = false;
            this.txtLozinka.AnimationSpeed = 200;
            this.txtLozinka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLozinka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLozinka.AutoSizeHeight = true;
            this.txtLozinka.BackColor = System.Drawing.Color.Transparent;
            this.txtLozinka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLozinka.BackgroundImage")));
            this.txtLozinka.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.txtLozinka.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLozinka.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtLozinka.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtLozinka.BorderRadius = 1;
            this.txtLozinka.BorderThickness = 1;
            this.txtLozinka.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLozinka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLozinka.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtLozinka.DefaultText = "";
            this.txtLozinka.FillColor = System.Drawing.Color.White;
            this.txtLozinka.HideSelection = true;
            this.txtLozinka.IconLeft = null;
            this.txtLozinka.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLozinka.IconPadding = 10;
            this.txtLozinka.IconRight = null;
            this.txtLozinka.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLozinka.Lines = new string[0];
            this.txtLozinka.Location = new System.Drawing.Point(27, 242);
            this.txtLozinka.MaxLength = 32767;
            this.txtLozinka.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLozinka.Modified = false;
            this.txtLozinka.Multiline = false;
            this.txtLozinka.Name = "txtLozinka";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLozinka.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLozinka.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLozinka.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLozinka.OnIdleState = stateProperties8;
            this.txtLozinka.Padding = new System.Windows.Forms.Padding(3);
            this.txtLozinka.PasswordChar = '\0';
            this.txtLozinka.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLozinka.PlaceholderText = "Lozinka";
            this.txtLozinka.ReadOnly = false;
            this.txtLozinka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLozinka.SelectedText = "";
            this.txtLozinka.SelectionLength = 0;
            this.txtLozinka.SelectionStart = 0;
            this.txtLozinka.ShortcutsEnabled = true;
            this.txtLozinka.Size = new System.Drawing.Size(260, 39);
            this.txtLozinka.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtLozinka.TabIndex = 6;
            this.txtLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLozinka.TextMarginBottom = 0;
            this.txtLozinka.TextMarginLeft = 3;
            this.txtLozinka.TextMarginTop = 1;
            this.txtLozinka.TextPlaceholder = "Lozinka";
            this.txtLozinka.UseSystemPasswordChar = false;
            this.txtLozinka.WordWrap = true;
            // 
            // btnPrijava
            // 
            this.btnPrijava.AllowAnimations = true;
            this.btnPrijava.AllowMouseEffects = true;
            this.btnPrijava.AllowToggling = false;
            this.btnPrijava.AnimationSpeed = 200;
            this.btnPrijava.AutoGenerateColors = false;
            this.btnPrijava.AutoRoundBorders = false;
            this.btnPrijava.AutoSizeLeftIcon = true;
            this.btnPrijava.AutoSizeRightIcon = true;
            this.btnPrijava.BackColor = System.Drawing.Color.Transparent;
            this.btnPrijava.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPrijava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrijava.BackgroundImage")));
            this.btnPrijava.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.ButtonText = "PRIJAVI SE";
            this.btnPrijava.ButtonTextMarginLeft = 0;
            this.btnPrijava.ColorContrastOnClick = 45;
            this.btnPrijava.ColorContrastOnHover = 45;
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPrijava.CustomizableEdges = borderEdges1;
            this.btnPrijava.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrijava.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrijava.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPrijava.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPrijava.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrijava.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.IconLeft = null;
            this.btnPrijava.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrijava.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrijava.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrijava.IconMarginLeft = 11;
            this.btnPrijava.IconPadding = 10;
            this.btnPrijava.IconRight = null;
            this.btnPrijava.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrijava.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrijava.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrijava.IconSize = 25;
            this.btnPrijava.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPrijava.IdleBorderRadius = 0;
            this.btnPrijava.IdleBorderThickness = 0;
            this.btnPrijava.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPrijava.IdleIconLeftImage = null;
            this.btnPrijava.IdleIconRightImage = null;
            this.btnPrijava.IndicateFocus = true;
            this.btnPrijava.Location = new System.Drawing.Point(83, 311);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrijava.OnDisabledState.BorderRadius = 35;
            this.btnPrijava.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnDisabledState.BorderThickness = 1;
            this.btnPrijava.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrijava.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrijava.OnDisabledState.IconLeftImage = null;
            this.btnPrijava.OnDisabledState.IconRightImage = null;
            this.btnPrijava.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnPrijava.onHoverState.BorderRadius = 35;
            this.btnPrijava.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.onHoverState.BorderThickness = 1;
            this.btnPrijava.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPrijava.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.onHoverState.IconLeftImage = null;
            this.btnPrijava.onHoverState.IconRightImage = null;
            this.btnPrijava.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPrijava.OnIdleState.BorderRadius = 35;
            this.btnPrijava.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnIdleState.BorderThickness = 1;
            this.btnPrijava.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPrijava.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.OnIdleState.IconLeftImage = null;
            this.btnPrijava.OnIdleState.IconRightImage = null;
            this.btnPrijava.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPrijava.OnPressedState.BorderRadius = 35;
            this.btnPrijava.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnPressedState.BorderThickness = 1;
            this.btnPrijava.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPrijava.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.OnPressedState.IconLeftImage = null;
            this.btnPrijava.OnPressedState.IconRightImage = null;
            this.btnPrijava.Size = new System.Drawing.Size(150, 39);
            this.btnPrijava.TabIndex = 7;
            this.btnPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrijava.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrijava.TextMarginLeft = 0;
            this.btnPrijava.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrijava.UseDefaultRadiusAndThickness = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // bnfSnackBar
            // 
            this.bnfSnackBar.AllowDragging = false;
            this.bnfSnackBar.AllowMultipleViews = true;
            this.bnfSnackBar.ClickToClose = true;
            this.bnfSnackBar.DoubleClickToClose = true;
            this.bnfSnackBar.DurationAfterIdle = 3000;
            this.bnfSnackBar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.ErrorOptions.ActionBorderRadius = 1;
            this.bnfSnackBar.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bnfSnackBar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bnfSnackBar.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bnfSnackBar.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bnfSnackBar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bnfSnackBar.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bnfSnackBar.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bnfSnackBar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bnfSnackBar.ErrorOptions.IconLeftMargin = 12;
            this.bnfSnackBar.FadeCloseIcon = false;
            this.bnfSnackBar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bnfSnackBar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.InformationOptions.ActionBorderRadius = 1;
            this.bnfSnackBar.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bnfSnackBar.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bnfSnackBar.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bnfSnackBar.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bnfSnackBar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bnfSnackBar.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bnfSnackBar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bnfSnackBar.InformationOptions.IconLeftMargin = 12;
            this.bnfSnackBar.Margin = 20;
            this.bnfSnackBar.MaximumSize = new System.Drawing.Size(0, 0);
            this.bnfSnackBar.MaximumViews = 7;
            this.bnfSnackBar.MessageRightMargin = 15;
            this.bnfSnackBar.MinimumSize = new System.Drawing.Size(0, 0);
            this.bnfSnackBar.ShowBorders = false;
            this.bnfSnackBar.ShowCloseIcon = false;
            this.bnfSnackBar.ShowIcon = true;
            this.bnfSnackBar.ShowShadows = true;
            this.bnfSnackBar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.SuccessOptions.ActionBorderRadius = 1;
            this.bnfSnackBar.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bnfSnackBar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bnfSnackBar.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bnfSnackBar.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bnfSnackBar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bnfSnackBar.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bnfSnackBar.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bnfSnackBar.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bnfSnackBar.SuccessOptions.IconLeftMargin = 12;
            this.bnfSnackBar.ViewsMargin = 7;
            this.bnfSnackBar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnfSnackBar.WarningOptions.ActionBorderRadius = 1;
            this.bnfSnackBar.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bnfSnackBar.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bnfSnackBar.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bnfSnackBar.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bnfSnackBar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bnfSnackBar.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bnfSnackBar.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bnfSnackBar.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bnfSnackBar.WarningOptions.IconLeftMargin = 12;
            this.bnfSnackBar.ZoomCloseIcon = true;
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
            this.loader.Location = new System.Drawing.Point(143, 313);
            this.loader.Name = "loader";
            this.loader.NoRounding = false;
            this.loader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loader.ShowText = false;
            this.loader.Size = new System.Drawing.Size(35, 35);
            this.loader.Speed = 7;
            this.loader.TabIndex = 8;
            this.loader.Text = "bunifuLoader1";
            this.loader.TextPadding = new System.Windows.Forms.Padding(0);
            this.loader.Thickness = 6;
            this.loader.Transparent = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 382);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGrb);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.pnlLoginPozadina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBordo | Prijavi se";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLoginPozadina;
        private Bunifu.UI.WinForms.BunifuTextBox txtKorisnickoIme;
        private System.Windows.Forms.Panel pnlGrb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpis;
        private Bunifu.UI.WinForms.BunifuTextBox txtLozinka;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrijava;
        private Bunifu.UI.WinForms.BunifuSnackbar bnfSnackBar;
        private Bunifu.UI.WinForms.BunifuLoader loader;
    }
}