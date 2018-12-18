namespace CustomControls.Forms
{
    partial class FrmSimples
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
            this.pnlComponentes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlComponentes
            // 
            this.pnlComponentes.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComponentes.Location = new System.Drawing.Point(0, 0);
            this.pnlComponentes.Name = "pnlComponentes";
            this.pnlComponentes.Size = new System.Drawing.Size(639, 295);
            this.pnlComponentes.TabIndex = 0;
            // 
            // FrmSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 295);
            this.Controls.Add(this.pnlComponentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nome do Formulário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSimples_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlComponentes;

    }
}