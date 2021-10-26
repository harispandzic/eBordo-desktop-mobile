
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
            this.dgvPrikazTrenera = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.imePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavljanstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLoader = new Bunifu.UI.WinForms.BunifuLoader();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.btnDodajTrenera = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPretraga = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtImePrezime = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazTrenera)).BeginInit();
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
            this.lblNaslovStranice.Size = new System.Drawing.Size(131, 21);
            this.lblNaslovStranice.TabIndex = 0;
            this.lblNaslovStranice.Text = "PRIKAZ TRENERA";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvPrikazTrenera
            // 
            this.dgvPrikazTrenera.AllowCustomTheming = true;
            this.dgvPrikazTrenera.AllowUserToAddRows = false;
            this.dgvPrikazTrenera.AllowUserToDeleteRows = false;
            this.dgvPrikazTrenera.AllowUserToResizeColumns = false;
            this.dgvPrikazTrenera.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazTrenera.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikazTrenera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikazTrenera.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPrikazTrenera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrikazTrenera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrikazTrenera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazTrenera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikazTrenera.ColumnHeadersHeight = 40;
            this.dgvPrikazTrenera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imePrezime,
            this.drzavljanstvo,
            this.licenca});
            this.dgvPrikazTrenera.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPrikazTrenera.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazTrenera.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrikazTrenera.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.GridColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.dgvPrikazTrenera.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPrikazTrenera.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.Name = null;
            this.dgvPrikazTrenera.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPrikazTrenera.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazTrenera.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrikazTrenera.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikazTrenera.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrikazTrenera.EnableHeadersVisualStyles = false;
            this.dgvPrikazTrenera.GridColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.dgvPrikazTrenera.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPrikazTrenera.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPrikazTrenera.Location = new System.Drawing.Point(20, 102);
            this.dgvPrikazTrenera.Name = "dgvPrikazTrenera";
            this.dgvPrikazTrenera.ReadOnly = true;
            this.dgvPrikazTrenera.RowHeadersVisible = false;
            this.dgvPrikazTrenera.RowTemplate.Height = 40;
            this.dgvPrikazTrenera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazTrenera.ShowCellErrors = false;
            this.dgvPrikazTrenera.ShowCellToolTips = false;
            this.dgvPrikazTrenera.ShowEditingIcon = false;
            this.dgvPrikazTrenera.ShowRowErrors = false;
            this.dgvPrikazTrenera.Size = new System.Drawing.Size(581, 284);
            this.dgvPrikazTrenera.TabIndex = 1;
            this.dgvPrikazTrenera.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvPrikazTrenera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikazTrenera_CellContentClick);
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
            // licenca
            // 
            this.licenca.FillWeight = 110F;
            this.licenca.HeaderText = "Licenca";
            this.licenca.Name = "licenca";
            this.licenca.ReadOnly = true;
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
            // btnDodajTrenera
            // 
            this.btnDodajTrenera.AllowAnimations = true;
            this.btnDodajTrenera.AllowMouseEffects = true;
            this.btnDodajTrenera.AllowToggling = false;
            this.btnDodajTrenera.AnimationSpeed = 200;
            this.btnDodajTrenera.AutoGenerateColors = false;
            this.btnDodajTrenera.AutoRoundBorders = false;
            this.btnDodajTrenera.AutoSizeLeftIcon = true;
            this.btnDodajTrenera.AutoSizeRightIcon = true;
            this.btnDodajTrenera.BackColor = System.Drawing.Color.Transparent;
            this.btnDodajTrenera.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDodajTrenera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajTrenera.BackgroundImage")));
            this.btnDodajTrenera.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajTrenera.ButtonText = "DODAJ TRENERA";
            this.btnDodajTrenera.ButtonTextMarginLeft = 0;
            this.btnDodajTrenera.ColorContrastOnClick = 45;
            this.btnDodajTrenera.ColorContrastOnHover = 45;
            this.btnDodajTrenera.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDodajTrenera.CustomizableEdges = borderEdges1;
            this.btnDodajTrenera.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDodajTrenera.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDodajTrenera.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDodajTrenera.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDodajTrenera.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDodajTrenera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTrenera.ForeColor = System.Drawing.Color.White;
            this.btnDodajTrenera.IconLeft = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajTrenera.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajTrenera.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajTrenera.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDodajTrenera.IconMarginLeft = 11;
            this.btnDodajTrenera.IconPadding = 10;
            this.btnDodajTrenera.IconRight = null;
            this.btnDodajTrenera.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajTrenera.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDodajTrenera.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDodajTrenera.IconSize = 50;
            this.btnDodajTrenera.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDodajTrenera.IdleBorderRadius = 0;
            this.btnDodajTrenera.IdleBorderThickness = 0;
            this.btnDodajTrenera.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDodajTrenera.IdleIconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajTrenera.IdleIconRightImage = null;
            this.btnDodajTrenera.IndicateFocus = true;
            this.btnDodajTrenera.Location = new System.Drawing.Point(461, 16);
            this.btnDodajTrenera.Name = "btnDodajTrenera";
            this.btnDodajTrenera.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDodajTrenera.OnDisabledState.BorderRadius = 20;
            this.btnDodajTrenera.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajTrenera.OnDisabledState.BorderThickness = 1;
            this.btnDodajTrenera.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDodajTrenera.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDodajTrenera.OnDisabledState.IconLeftImage = null;
            this.btnDodajTrenera.OnDisabledState.IconRightImage = null;
            this.btnDodajTrenera.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnDodajTrenera.onHoverState.BorderRadius = 20;
            this.btnDodajTrenera.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajTrenera.onHoverState.BorderThickness = 1;
            this.btnDodajTrenera.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajTrenera.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDodajTrenera.onHoverState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajTrenera.onHoverState.IconRightImage = null;
            this.btnDodajTrenera.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajTrenera.OnIdleState.BorderRadius = 20;
            this.btnDodajTrenera.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajTrenera.OnIdleState.BorderThickness = 1;
            this.btnDodajTrenera.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajTrenera.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDodajTrenera.OnIdleState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajTrenera.OnIdleState.IconRightImage = null;
            this.btnDodajTrenera.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajTrenera.OnPressedState.BorderRadius = 20;
            this.btnDodajTrenera.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDodajTrenera.OnPressedState.BorderThickness = 1;
            this.btnDodajTrenera.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDodajTrenera.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDodajTrenera.OnPressedState.IconLeftImage = global::eBordo.WinUI.Properties.Resources.add;
            this.btnDodajTrenera.OnPressedState.IconRightImage = null;
            this.btnDodajTrenera.Size = new System.Drawing.Size(140, 38);
            this.btnDodajTrenera.TabIndex = 15;
            this.btnDodajTrenera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajTrenera.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDodajTrenera.TextMarginLeft = 0;
            this.btnDodajTrenera.TextPadding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnDodajTrenera.UseDefaultRadiusAndThickness = true;
            this.btnDodajTrenera.Click += new System.EventHandler(this.btnDodajTrenera_Click);
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
            // frmPrikazTrenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajTrenera);
            this.Controls.Add(this.dataLoader);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.dgvPrikazTrenera);
            this.Controls.Add(this.lblNaslovStranice);
            this.Name = "frmPrikazTrenera";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmPrikazTrenera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazTrenera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPrikazTrenera;
        private Bunifu.UI.WinForms.BunifuTextBox txtImePrezime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPretraga;
        private Bunifu.UI.WinForms.BunifuLoader dataLoader;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDodajTrenera;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavljanstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenca;
    }
}
