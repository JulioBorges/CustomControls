namespace CustomControls.Forms
{
    public partial class FrmVisualizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.imageBoxData = new CustomControls.Data.ImageBox();
            this.SuspendLayout();
            // 
            // imageBoxData
            // 
            this.imageBoxData.AutoScroll = true;
            this.imageBoxData.AutoSize = false;
            this.imageBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxData.Location = new System.Drawing.Point(9, 9);
            this.imageBoxData.Name = "imageBoxData";
            this.imageBoxData.Size = new System.Drawing.Size(599, 464);
            this.imageBoxData.TabIndex = 1;
            // 
            // FrmVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 482);
            this.Controls.Add(this.imageBoxData);
            this.Name = "FrmVisualizer";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Imagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CustomControls.Data.ImageBox imageBoxData;

    }
}
