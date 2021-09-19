
namespace eBordo.WinUI.Početna
{
    partial class frmPočetna
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
            this.btnPrikazIgrača = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrikazIgrača
            // 
            this.btnPrikazIgrača.Location = new System.Drawing.Point(12, 12);
            this.btnPrikazIgrača.Name = "btnPrikazIgrača";
            this.btnPrikazIgrača.Size = new System.Drawing.Size(113, 23);
            this.btnPrikazIgrača.TabIndex = 0;
            this.btnPrikazIgrača.Text = "Prikaz igrača";
            this.btnPrikazIgrača.UseVisualStyleBackColor = true;
            this.btnPrikazIgrača.Click += new System.EventHandler(this.btnPrikazIgrača_Click);
            // 
            // frmPočetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazIgrača);
            this.Name = "frmPočetna";
            this.Text = "Početna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazIgrača;
    }
}