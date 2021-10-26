
namespace eBordo.WinUI.Forms.AdminPanel
{
    partial class frmPrikazIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrikazIgraca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvPrikazIgraca = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cmbPozicije = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dataLoader = new Bunifu.UI.WinForms.BunifuLoader();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.btnPrijava = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPretraga = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtImePrezime = new Bunifu.UI.WinForms.BunifuTextBox();
            this.brojDresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavljanstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazIgraca)).BeginInit();
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
            this.lblNaslovStranice.Size = new System.Drawing.Size(118, 21);
            this.lblNaslovStranice.TabIndex = 0;
            this.lblNaslovStranice.Text = "PRIKAZ IGRAČA";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvPrikazIgraca
            // 
            this.dgvPrikazIgraca.AllowCustomTheming = true;
            this.dgvPrikazIgraca.AllowUserToAddRows = false;
            this.dgvPrikazIgraca.AllowUserToDeleteRows = false;
            this.dgvPrikazIgraca.AllowUserToResizeColumns = false;
            this.dgvPrikazIgraca.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazIgraca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikazIgraca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikazIgraca.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPrikazIgraca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrikazIgraca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrikazIgraca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazIgraca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikazIgraca.ColumnHeadersHeight = 40;
            this.dgvPrikazIgraca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojDresa,
            this.Column1,
            this.imePrezime,
            this.drzavljanstvo,
            this.pozicija});
            this.dgvPrikazIgraca.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPrikazIgraca.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazIgraca.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrikazIgraca.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.GridColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.dgvPrikazIgraca.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPrikazIgraca.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.Name = null;
            this.dgvPrikazIgraca.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPrikazIgraca.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazIgraca.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrikazIgraca.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikazIgraca.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrikazIgraca.EnableHeadersVisualStyles = false;
            this.dgvPrikazIgraca.GridColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.dgvPrikazIgraca.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPrikazIgraca.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.Location = new System.Drawing.Point(20, 102);
            this.dgvPrikazIgraca.Name = "dgvPrikazIgraca";
            this.dgvPrikazIgraca.ReadOnly = true;
            this.dgvPrikazIgraca.RowHeadersVisible = false;
            this.dgvPrikazIgraca.RowTemplate.Height = 40;
            this.dgvPrikazIgraca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazIgraca.ShowCellErrors = false;
            this.dgvPrikazIgraca.ShowCellToolTips = false;
            this.dgvPrikazIgraca.ShowEditingIcon = false;
            this.dgvPrikazIgraca.ShowRowErrors = false;
            this.dgvPrikazIgraca.Size = new System.Drawing.Size(581, 284);
            this.dgvPrikazIgraca.TabIndex = 1;
            this.dgvPrikazIgraca.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvPrikazIgraca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikazIgraca_CellContentClick_1);
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
            this.cmbPozicije.Location = new System.Drawing.Point(215, 66);
            this.cmbPozicije.Name = "cmbPozicije";
            this.cmbPozicije.Size = new System.Drawing.Size(165, 32);
            this.cmbPozicije.TabIndex = 2;
            this.cmbPozicije.Text = "Pozicija";
            this.cmbPozicije.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbPozicije.TextLeftMargin = 5;
            this.cmbPozicije.SelectedIndexChanged += new System.EventHandler(this.cmbPozicije_SelectedIndexChanged);
            // 
            // dataLoader
            // 
            this.dataLoader.AllowStylePresets = true;
            this.dataLoader.BackColor = System.Drawing.Color.Transparent;
            this.dataLoader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.dataLoader.Color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
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
            this.snackbar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
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
            this.snackbar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
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
            this.btnPrijava.ButtonText = "DODAJ IGRAČA";
            this.btnPrijava.ButtonTextMarginLeft = 0;
            this.btnPrijava.ColorContrastOnClick = 45;
            this.btnPrijava.ColorContrastOnHover = 45;
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnPrijava.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.IconLeft = global::eBordo.WinUI.Properties.Resources.add;
            this.btnPrijava.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrijava.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrijava.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrijava.IconMarginLeft = 11;
            this.btnPrijava.IconPadding = 10;
            this.btnPrijava.IconRight = null;
            this.btnPrijava.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrijava.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrijava.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrijava.IconSize = 50;
            this.btnPrijava.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPrijava.IdleBorderRadius = 0;
            this.btnPrijava.IdleBorderThickness = 0;
            this.btnPrijava.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPrijava.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnPrijava.IdleIconRightImage = null;
            this.btnPrijava.IndicateFocus = true;
            this.btnPrijava.Location = new System.Drawing.Point(472, 16);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrijava.OnDisabledState.BorderRadius = 20;
            this.btnPrijava.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnDisabledState.BorderThickness = 1;
            this.btnPrijava.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrijava.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrijava.OnDisabledState.IconLeftImage = null;
            this.btnPrijava.OnDisabledState.IconRightImage = null;
            this.btnPrijava.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnPrijava.onHoverState.BorderRadius = 20;
            this.btnPrijava.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.onHoverState.BorderThickness = 1;
            this.btnPrijava.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPrijava.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnPrijava.onHoverState.IconRightImage = null;
            this.btnPrijava.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPrijava.OnIdleState.BorderRadius = 20;
            this.btnPrijava.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnIdleState.BorderThickness = 1;
            this.btnPrijava.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPrijava.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnPrijava.OnIdleState.IconRightImage = null;
            this.btnPrijava.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPrijava.OnPressedState.BorderRadius = 20;
            this.btnPrijava.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnPressedState.BorderThickness = 1;
            this.btnPrijava.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPrijava.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnPrijava.OnPressedState.IconRightImage = null;
            this.btnPrijava.Size = new System.Drawing.Size(129, 38);
            this.btnPrijava.TabIndex = 15;
            this.btnPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrijava.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrijava.TextMarginLeft = 0;
            this.btnPrijava.TextPadding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnPrijava.UseDefaultRadiusAndThickness = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.AllowAnimations = true;
            this.btnPretraga.AllowMouseEffects = true;
            this.btnPretraga.AllowToggling = false;
            this.btnPretraga.AnimationSpeed = 200;
            this.btnPretraga.AutoGenerateColors = false;
            this.btnPretraga.AutoRoundBorders = false;
            this.btnPretraga.AutoSizeLeftIcon = false;
            this.btnPretraga.AutoSizeRightIcon = true;
            this.btnPretraga.BackColor = System.Drawing.Color.Transparent;
            this.btnPretraga.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPretraga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPretraga.BackgroundImage")));
            this.btnPretraga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPretraga.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretraga.ButtonText = "";
            this.btnPretraga.ButtonTextMarginLeft = 0;
            this.btnPretraga.ColorContrastOnClick = 45;
            this.btnPretraga.ColorContrastOnHover = 45;
            this.btnPretraga.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPretraga.CustomizableEdges = borderEdges2;
            this.btnPretraga.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPretraga.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPretraga.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPretraga.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPretraga.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPretraga.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.ForeColor = System.Drawing.Color.White;
            this.btnPretraga.IconLeft = global::eBordo.WinUI.Properties.Resources.search;
            this.btnPretraga.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPretraga.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPretraga.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPretraga.IconMarginLeft = 11;
            this.btnPretraga.IconPadding = 10;
            this.btnPretraga.IconRight = null;
            this.btnPretraga.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPretraga.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPretraga.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPretraga.IconSize = 25;
            this.btnPretraga.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPretraga.IdleBorderRadius = 0;
            this.btnPretraga.IdleBorderThickness = 0;
            this.btnPretraga.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPretraga.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.search;
            this.btnPretraga.IdleIconRightImage = null;
            this.btnPretraga.IndicateFocus = true;
            this.btnPretraga.Location = new System.Drawing.Point(557, 67);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPretraga.OnDisabledState.BorderRadius = 10;
            this.btnPretraga.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretraga.OnDisabledState.BorderThickness = 1;
            this.btnPretraga.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPretraga.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPretraga.OnDisabledState.IconLeftImage = null;
            this.btnPretraga.OnDisabledState.IconRightImage = null;
            this.btnPretraga.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnPretraga.onHoverState.BorderRadius = 10;
            this.btnPretraga.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretraga.onHoverState.BorderThickness = 1;
            this.btnPretraga.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPretraga.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPretraga.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.search;
            this.btnPretraga.onHoverState.IconRightImage = null;
            this.btnPretraga.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPretraga.OnIdleState.BorderRadius = 10;
            this.btnPretraga.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretraga.OnIdleState.BorderThickness = 1;
            this.btnPretraga.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPretraga.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPretraga.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.search;
            this.btnPretraga.OnIdleState.IconRightImage = null;
            this.btnPretraga.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPretraga.OnPressedState.BorderRadius = 10;
            this.btnPretraga.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretraga.OnPressedState.BorderThickness = 1;
            this.btnPretraga.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPretraga.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPretraga.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.search;
            this.btnPretraga.OnPressedState.IconRightImage = null;
            this.btnPretraga.Size = new System.Drawing.Size(44, 30);
            this.btnPretraga.TabIndex = 13;
            this.btnPretraga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPretraga.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPretraga.TextMarginLeft = 0;
            this.btnPretraga.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPretraga.UseDefaultRadiusAndThickness = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnRefresh.CustomizableEdges = borderEdges3;
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
            this.btnRefresh.Location = new System.Drawing.Point(20, 67);
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
            this.btnRefresh.Size = new System.Drawing.Size(44, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.TextMarginLeft = 0;
            this.btnRefresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefresh.UseDefaultRadiusAndThickness = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.txtImePrezime.Location = new System.Drawing.Point(386, 66);
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
            this.txtImePrezime.Size = new System.Drawing.Size(165, 32);
            this.txtImePrezime.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtImePrezime.TabIndex = 11;
            this.txtImePrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtImePrezime.TextMarginBottom = 0;
            this.txtImePrezime.TextMarginLeft = 3;
            this.txtImePrezime.TextMarginTop = 1;
            this.txtImePrezime.TextPlaceholder = "Ime i prezime";
            this.txtImePrezime.UseSystemPasswordChar = false;
            this.txtImePrezime.WordWrap = true;
            // 
            // brojDresa
            // 
            this.brojDresa.FillWeight = 30F;
            this.brojDresa.HeaderText = "#";
            this.brojDresa.Name = "brojDresa";
            this.brojDresa.ReadOnly = true;
            this.brojDresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // imePrezime
            // 
            this.imePrezime.FillWeight = 150F;
            this.imePrezime.HeaderText = "Ime i prezime";
            this.imePrezime.Name = "imePrezime";
            this.imePrezime.ReadOnly = true;
            // 
            // drzavljanstvo
            // 
            this.drzavljanstvo.FillWeight = 120F;
            this.drzavljanstvo.HeaderText = "Državljanstvo";
            this.drzavljanstvo.Name = "drzavljanstvo";
            this.drzavljanstvo.ReadOnly = true;
            // 
            // pozicija
            // 
            this.pozicija.FillWeight = 110F;
            this.pozicija.HeaderText = "Pozicija";
            this.pozicija.Name = "pozicija";
            this.pozicija.ReadOnly = true;
            // 
            // frmPrikazIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.dataLoader);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.cmbPozicije);
            this.Controls.Add(this.dgvPrikazIgraca);
            this.Controls.Add(this.lblNaslovStranice);
            this.Name = "frmPrikazIgraca";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmPrikazIgraca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazIgraca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPrikazIgraca;
        private Bunifu.UI.WinForms.BunifuDropdown cmbPozicije;
        private Bunifu.UI.WinForms.BunifuTextBox txtImePrezime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPretraga;
        private Bunifu.UI.WinForms.BunifuLoader dataLoader;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrijava;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDresa;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavljanstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozicija;
    }
}
