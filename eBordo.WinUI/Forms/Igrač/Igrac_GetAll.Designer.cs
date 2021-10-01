
namespace eBordo.WinUI.UserControls
{
    partial class PrikazIgraca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrikazIgraca = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Dred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzavljanstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtImePrezime = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPretraga = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbPozicije = new System.Windows.Forms.ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDodaj = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazIgraca)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrikazIgraca
            // 
            this.dgvPrikazIgraca.AllowUserToAddRows = false;
            this.dgvPrikazIgraca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikazIgraca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikazIgraca.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPrikazIgraca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrikazIgraca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrikazIgraca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazIgraca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikazIgraca.ColumnHeadersHeight = 21;
            this.dgvPrikazIgraca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dred,
            this.ImePrezime,
            this.Drzavljanstvo,
            this.Pozicija});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikazIgraca.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrikazIgraca.EnableHeadersVisualStyles = false;
            this.dgvPrikazIgraca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvPrikazIgraca.Location = new System.Drawing.Point(23, 125);
            this.dgvPrikazIgraca.Name = "dgvPrikazIgraca";
            this.dgvPrikazIgraca.ReadOnly = true;
            this.dgvPrikazIgraca.RowHeadersVisible = false;
            this.dgvPrikazIgraca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazIgraca.Size = new System.Drawing.Size(620, 326);
            this.dgvPrikazIgraca.TabIndex = 0;
            this.dgvPrikazIgraca.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvPrikazIgraca.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPrikazIgraca.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPrikazIgraca.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPrikazIgraca.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPrikazIgraca.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvPrikazIgraca.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvPrikazIgraca.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvPrikazIgraca.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrikazIgraca.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPrikazIgraca.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazIgraca.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPrikazIgraca.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvPrikazIgraca.ThemeStyle.ReadOnly = true;
            this.dgvPrikazIgraca.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrikazIgraca.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrikazIgraca.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPrikazIgraca.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazIgraca.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPrikazIgraca.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvPrikazIgraca.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrikazIgraca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikazIgraca_CellContentClick_1);
            // 
            // Dred
            // 
            this.Dred.FillWeight = 19.67971F;
            this.Dred.HeaderText = "#";
            this.Dred.Name = "Dred";
            this.Dred.ReadOnly = true;
            this.Dred.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ImePrezime
            // 
            this.ImePrezime.FillWeight = 122.6702F;
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Drzavljanstvo
            // 
            this.Drzavljanstvo.FillWeight = 122.6702F;
            this.Drzavljanstvo.HeaderText = "Državljanstvo";
            this.Drzavljanstvo.Name = "Drzavljanstvo";
            this.Drzavljanstvo.ReadOnly = true;
            // 
            // Pozicija
            // 
            this.Pozicija.FillWeight = 122.6702F;
            this.Pozicija.HeaderText = "Pozicija";
            this.Pozicija.Name = "Pozicija";
            this.Pozicija.ReadOnly = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(6, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(239, 34);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Upravljanje igračima";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(285, 67);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(85, 18);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Ime i prezime: ";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImePrezime.DefaultText = "";
            this.txtImePrezime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImePrezime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImePrezime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImePrezime.DisabledState.Parent = this.txtImePrezime;
            this.txtImePrezime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImePrezime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImePrezime.FocusedState.Parent = this.txtImePrezime;
            this.txtImePrezime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImePrezime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImePrezime.HoverState.Parent = this.txtImePrezime;
            this.txtImePrezime.Location = new System.Drawing.Point(376, 62);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.PasswordChar = '\0';
            this.txtImePrezime.PlaceholderText = "";
            this.txtImePrezime.SelectedText = "";
            this.txtImePrezime.ShadowDecoration.Parent = this.txtImePrezime;
            this.txtImePrezime.Size = new System.Drawing.Size(125, 23);
            this.txtImePrezime.TabIndex = 5;
            // 
            // btnPretraga
            // 
            this.btnPretraga.CheckedState.Parent = this.btnPretraga;
            this.btnPretraga.CustomImages.Parent = this.btnPretraga;
            this.btnPretraga.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPretraga.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPretraga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPretraga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPretraga.DisabledState.Parent = this.btnPretraga;
            this.btnPretraga.FillColor = System.Drawing.Color.Maroon;
            this.btnPretraga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPretraga.ForeColor = System.Drawing.Color.White;
            this.btnPretraga.HoverState.Parent = this.btnPretraga;
            this.btnPretraga.Location = new System.Drawing.Point(507, 62);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.ShadowDecoration.Parent = this.btnPretraga;
            this.btnPretraga.Size = new System.Drawing.Size(107, 23);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.DisabledState.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.Maroon;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(6, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(65, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Osvježi";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.cmbPozicije);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.txtImePrezime);
            this.guna2Panel1.Controls.Add(this.btnPretraga);
            this.guna2Panel1.Controls.Add(this.btnRefresh);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(23, 26);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(620, 417);
            this.guna2Panel1.TabIndex = 9;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(99, 67);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(53, 18);
            this.guna2HtmlLabel5.TabIndex = 11;
            this.guna2HtmlLabel5.Text = "Pozicija: ";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(276, 207);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(85, 18);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "Ime i prezime: ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(268, 199);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(85, 18);
            this.guna2HtmlLabel3.TabIndex = 9;
            this.guna2HtmlLabel3.Text = "Ime i prezime: ";
            // 
            // cmbPozicije
            // 
            this.cmbPozicije.FormattingEnabled = true;
            this.cmbPozicije.Location = new System.Drawing.Point(158, 64);
            this.cmbPozicije.Name = "cmbPozicije";
            this.cmbPozicije.Size = new System.Drawing.Size(121, 21);
            this.cmbPozicije.TabIndex = 8;
            this.cmbPozicije.SelectedIndexChanged += new System.EventHandler(this.cmbPozicije_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Maroon;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.btnDodaj);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(620, 47);
            this.guna2Panel2.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BorderRadius = 15;
            this.btnDodaj.CheckedState.Parent = this.btnDodaj;
            this.btnDodaj.CustomImages.Parent = this.btnDodaj;
            this.btnDodaj.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDodaj.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDodaj.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDodaj.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDodaj.DisabledState.Parent = this.btnDodaj;
            this.btnDodaj.FillColor = System.Drawing.Color.Green;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.HoverState.Parent = this.btnDodaj;
            this.btnDodaj.Location = new System.Drawing.Point(515, 9);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.ShadowDecoration.Parent = this.btnDodaj;
            this.btnDodaj.Size = new System.Drawing.Size(99, 30);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj igrača";
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // PrikazIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPrikazIgraca);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "PrikazIgraca";
            this.Size = new System.Drawing.Size(669, 471);
            this.Load += new System.EventHandler(this.PrikazIgraca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazIgraca)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPrikazIgraca;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtImePrezime;
        private Guna.UI2.WinForms.Guna2Button btnPretraga;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDodaj;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.ComboBox cmbPozicije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dred;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzavljanstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozicija;
    }
}
