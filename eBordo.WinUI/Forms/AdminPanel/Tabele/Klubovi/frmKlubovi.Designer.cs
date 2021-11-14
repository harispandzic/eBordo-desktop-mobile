
namespace eBordo.WinUI.Forms.AdminPanel.Tabele.Klubovi
{
    partial class frmKlubovi
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
            this.flowPanelKlubovi = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowPanelKlubovi
            // 
            this.flowPanelKlubovi.Location = new System.Drawing.Point(338, 0);
            this.flowPanelKlubovi.Name = "flowPanelKlubovi";
            this.flowPanelKlubovi.Size = new System.Drawing.Size(243, 269);
            this.flowPanelKlubovi.TabIndex = 0;
            // 
            // frmKlubovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanelKlubovi);
            this.Name = "frmKlubovi";
            this.Size = new System.Drawing.Size(581, 269);
            this.Load += new System.EventHandler(this.frmKlubovi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelKlubovi;
    }
}
