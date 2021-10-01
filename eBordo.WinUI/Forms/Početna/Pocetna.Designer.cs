
namespace eBordo.WinUI.Forms.Početna
{
    partial class frmPocetna
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
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrikaziIgrace = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.prikazIgraca1 = new eBordo.WinUI.UserControls.PrikazIgraca();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnPrikaziIgrace);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.ShadowDecoration.Parent = this.pnlSidebar;
            this.pnlSidebar.Size = new System.Drawing.Size(200, 521);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnPrikaziIgrace
            // 
            this.btnPrikaziIgrace.CheckedState.Parent = this.btnPrikaziIgrace;
            this.btnPrikaziIgrace.CustomImages.Parent = this.btnPrikaziIgrace;
            this.btnPrikaziIgrace.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrikaziIgrace.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrikaziIgrace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrikaziIgrace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrikaziIgrace.DisabledState.Parent = this.btnPrikaziIgrace;
            this.btnPrikaziIgrace.FillColor = System.Drawing.Color.LightGray;
            this.btnPrikaziIgrace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrikaziIgrace.ForeColor = System.Drawing.Color.White;
            this.btnPrikaziIgrace.HoverState.Parent = this.btnPrikaziIgrace;
            this.btnPrikaziIgrace.Location = new System.Drawing.Point(0, 77);
            this.btnPrikaziIgrace.Name = "btnPrikaziIgrace";
            this.btnPrikaziIgrace.ShadowDecoration.Parent = this.btnPrikaziIgrace;
            this.btnPrikaziIgrace.Size = new System.Drawing.Size(200, 45);
            this.btnPrikaziIgrace.TabIndex = 0;
            this.btnPrikaziIgrace.Text = "btnPrikaziIgrace";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.guna2Panel1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ShadowDecoration.Parent = this.pnlContent;
            this.pnlContent.Size = new System.Drawing.Size(670, 521);
            this.pnlContent.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prikazIgraca1);
            this.panel1.Location = new System.Drawing.Point(1, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 471);
            this.panel1.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(670, 50);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            // 
            // prikazIgraca1
            // 
            this.prikazIgraca1.BackColor = System.Drawing.Color.White;
            this.prikazIgraca1.Location = new System.Drawing.Point(-1, 0);
            this.prikazIgraca1.Name = "prikazIgraca1";
            this.prikazIgraca1.Size = new System.Drawing.Size(669, 471);
            this.prikazIgraca1.TabIndex = 0;
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(870, 521);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBordo | Početna";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Button btnPrikaziIgrace;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UserControls.PrikazIgraca prikazIgraca1;
        private System.Windows.Forms.Label label1;
    }
}