
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblNaslovStranice = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbPozicije = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dataLoader = new Bunifu.UI.WinForms.BunifuLoader();
            this.snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.pnlIgraciWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.lblDrzavljanstvoVrijednost = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtBrojIgraca = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnSaveIgracSastav = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlIgraci = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtImePrezime = new Bunifu.UI.WinForms.BunifuTextBox();
            this.noSearchResult = new System.Windows.Forms.PictureBox();
            this.loaderIgraci = new Bunifu.UI.WinForms.BunifuLoader();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.checkBoxZavrseniTreninzi = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gifLoader = new System.Windows.Forms.PictureBox();
            this.btnSaveUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.lblNaslovStranice.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovStranice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.lblNaslovStranice.Location = new System.Drawing.Point(20, 16);
            this.lblNaslovStranice.Name = "lblNaslovStranice";
            this.lblNaslovStranice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNaslovStranice.Size = new System.Drawing.Size(95, 24);
            this.lblNaslovStranice.TabIndex = 0;
            this.lblNaslovStranice.Text = "PRIKAZ IGRAČA";
            this.lblNaslovStranice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNaslovStranice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.cmbPozicije.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbPozicije.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.cmbPozicije.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbPozicije.ItemTopMargin = 3;
            this.cmbPozicije.Location = new System.Drawing.Point(208, 70);
            this.cmbPozicije.Name = "cmbPozicije";
            this.cmbPozicije.Size = new System.Drawing.Size(122, 32);
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
            this.dataLoader.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.dataLoader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.dataLoader.Customization = "";
            this.dataLoader.DashWidth = 0.5F;
            this.dataLoader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataLoader.Image = null;
            this.dataLoader.Location = new System.Drawing.Point(290, 233);
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
            // pnlIgraciWrapper
            // 
            this.pnlIgraciWrapper.AutoScroll = true;
            this.pnlIgraciWrapper.Location = new System.Drawing.Point(20, 105);
            this.pnlIgraciWrapper.Name = "pnlIgraciWrapper";
            this.pnlIgraciWrapper.Size = new System.Drawing.Size(600, 305);
            this.pnlIgraciWrapper.TabIndex = 0;
            this.pnlIgraciWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIgraciWrapper_Paint);
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon4")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon5")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 20;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon6")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon7")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
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
            this.lblDrzavljanstvoVrijednost.TabIndex = 281;
            this.lblDrzavljanstvoVrijednost.Text = "Ukupno igrača: ";
            this.lblDrzavljanstvoVrijednost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDrzavljanstvoVrijednost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDrzavljanstvoVrijednost.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.txtBrojIgraca.Location = new System.Drawing.Point(87, 39);
            this.txtBrojIgraca.Name = "txtBrojIgraca";
            this.txtBrojIgraca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBrojIgraca.Size = new System.Drawing.Size(28, 17);
            this.txtBrojIgraca.TabIndex = 282;
            this.txtBrojIgraca.Text = "22";
            this.txtBrojIgraca.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtBrojIgraca.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtBrojIgraca.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.btnSaveIgracSastav.ButtonText = "DODAJ IGRAČA";
            this.btnSaveIgracSastav.ButtonTextMarginLeft = 0;
            this.btnSaveIgracSastav.ColorContrastOnClick = 45;
            this.btnSaveIgracSastav.ColorContrastOnHover = 45;
            this.btnSaveIgracSastav.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSaveIgracSastav.CustomizableEdges = borderEdges1;
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
            this.btnSaveIgracSastav.Location = new System.Drawing.Point(477, 69);
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
            this.btnSaveIgracSastav.Size = new System.Drawing.Size(120, 33);
            this.btnSaveIgracSastav.TabIndex = 279;
            this.btnSaveIgracSastav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveIgracSastav.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveIgracSastav.TextMarginLeft = 0;
            this.btnSaveIgracSastav.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnSaveIgracSastav.UseDefaultRadiusAndThickness = true;
            this.btnSaveIgracSastav.Click += new System.EventHandler(this.btnSaveIgracSastav_Click);
            // 
            // pnlIgraci
            // 
            this.pnlIgraci.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlIgraci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIgraci.BackgroundImage")));
            this.pnlIgraci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIgraci.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIgraci.BorderRadius = 3;
            this.pnlIgraci.BorderThickness = 1;
            this.pnlIgraci.Location = new System.Drawing.Point(20, 104);
            this.pnlIgraci.Name = "pnlIgraci";
            this.pnlIgraci.ShowBorders = true;
            this.pnlIgraci.Size = new System.Drawing.Size(600, 305);
            this.pnlIgraci.TabIndex = 16;
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
            this.txtImePrezime.Size = new System.Drawing.Size(137, 34);
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
            // noSearchResult
            // 
            this.noSearchResult.BackgroundImage = global::eBordo.WinUI.Properties.Resources.Picture1;
            this.noSearchResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noSearchResult.Location = new System.Drawing.Point(23, 110);
            this.noSearchResult.Name = "noSearchResult";
            this.noSearchResult.Size = new System.Drawing.Size(578, 296);
            this.noSearchResult.TabIndex = 17;
            this.noSearchResult.TabStop = false;
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
            this.loaderIgraci.Location = new System.Drawing.Point(87, 41);
            this.loaderIgraci.Name = "loaderIgraci";
            this.loaderIgraci.NoRounding = false;
            this.loaderIgraci.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loaderIgraci.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loaderIgraci.ShowText = false;
            this.loaderIgraci.Size = new System.Drawing.Size(12, 12);
            this.loaderIgraci.Speed = 7;
            this.loaderIgraci.TabIndex = 287;
            this.loaderIgraci.Text = "bunifuLoader1";
            this.loaderIgraci.TextPadding = new System.Windows.Forms.Padding(0);
            this.loaderIgraci.Thickness = 2;
            this.loaderIgraci.Transparent = true;
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
            this.bunifuLabel1.Location = new System.Drawing.Point(357, 81);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(40, 17);
            this.bunifuLabel1.TabIndex = 298;
            this.bunifuLabel1.Text = "Aktivan";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.checkBoxZavrseniTreninzi.Location = new System.Drawing.Point(333, 77);
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
            this.checkBoxZavrseniTreninzi.TabIndex = 297;
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
            this.pictureBox5.TabIndex = 322;
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
            this.gifLoader.TabIndex = 323;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSaveUpdate.CustomizableEdges = borderEdges3;
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
            this.btnSaveUpdate.Location = new System.Drawing.Point(434, 69);
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
            this.btnSaveUpdate.TabIndex = 326;
            this.btnSaveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUpdate.TextMarginLeft = 0;
            this.btnSaveUpdate.TextPadding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnSaveUpdate.UseDefaultRadiusAndThickness = true;
            // 
            // frmPrikazIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.gifLoader);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.checkBoxZavrseniTreninzi);
            this.Controls.Add(this.loaderIgraci);
            this.Controls.Add(this.txtBrojIgraca);
            this.Controls.Add(this.lblDrzavljanstvoVrijednost);
            this.Controls.Add(this.btnSaveIgracSastav);
            this.Controls.Add(this.dataLoader);
            this.Controls.Add(this.pnlIgraciWrapper);
            this.Controls.Add(this.pnlIgraci);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.cmbPozicije);
            this.Controls.Add(this.lblNaslovStranice);
            this.Controls.Add(this.noSearchResult);
            this.Name = "frmPrikazIgraca";
            this.Size = new System.Drawing.Size(622, 403);
            this.Load += new System.EventHandler(this.frmPrikazIgraca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblNaslovStranice;
        private Bunifu.UI.WinForms.BunifuDropdown cmbPozicije;
        private Bunifu.UI.WinForms.BunifuTextBox txtImePrezime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuLoader dataLoader;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbar;
        private Bunifu.UI.WinForms.BunifuPanel pnlIgraci;
        private System.Windows.Forms.FlowLayoutPanel pnlIgraciWrapper;
        private System.Windows.Forms.PictureBox noSearchResult;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveIgracSastav;
        private Bunifu.UI.WinForms.BunifuLabel lblDrzavljanstvoVrijednost;
        private Bunifu.UI.WinForms.BunifuLabel txtBrojIgraca;
        private Bunifu.UI.WinForms.BunifuLoader loaderIgraci;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBoxZavrseniTreninzi;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox gifLoader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveUpdate;
    }
}
