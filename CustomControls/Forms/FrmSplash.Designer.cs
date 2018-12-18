namespace CustomControls.Forms
{
    partial class FrmSplash
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
            this.lblDescricaoAplicacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCarregando = new System.Windows.Forms.Label();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.progressBarSplash = new System.Windows.Forms.ProgressBar();
            this.pictureBoxGlobo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlobo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricaoAplicacao
            // 
            this.lblDescricaoAplicacao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoAplicacao.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoAplicacao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricaoAplicacao.Location = new System.Drawing.Point(168, 37);
            this.lblDescricaoAplicacao.Name = "lblDescricaoAplicacao";
            this.lblDescricaoAplicacao.Size = new System.Drawing.Size(205, 125);
            this.lblDescricaoAplicacao.TabIndex = 5;
            this.lblDescricaoAplicacao.Text = "DescricaoAplicacao";
            this.lblDescricaoAplicacao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDescricaoAplicacao.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desenvolvido por Julio Cezar Borges.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // labelCarregando
            // 
            this.labelCarregando.AutoSize = true;
            this.labelCarregando.BackColor = System.Drawing.Color.Transparent;
            this.labelCarregando.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarregando.ForeColor = System.Drawing.Color.Black;
            this.labelCarregando.Location = new System.Drawing.Point(15, 161);
            this.labelCarregando.Name = "labelCarregando";
            this.labelCarregando.Size = new System.Drawing.Size(68, 14);
            this.labelCarregando.TabIndex = 4;
            this.labelCarregando.Text = "Carregando";
            // 
            // timerSplash
            // 
            this.timerSplash.Interval = 200;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // progressBarSplash
            // 
            // 
            // 
            // 
            this.progressBarSplash.Location = new System.Drawing.Point(17, 178);
            this.progressBarSplash.Name = "progressBarSplash";
            this.progressBarSplash.Size = new System.Drawing.Size(345, 18);
            this.progressBarSplash.Step = 10;
            this.progressBarSplash.TabIndex = 7;
            // 
            // pictureBoxGlobo
            // 
            this.pictureBoxGlobo.Image = global::CustomControls.Properties.Resources.animation;
            this.pictureBoxGlobo.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxGlobo.Name = "pictureBoxGlobo";
            this.pictureBoxGlobo.Size = new System.Drawing.Size(155, 147);
            this.pictureBoxGlobo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGlobo.TabIndex = 8;
            this.pictureBoxGlobo.TabStop = false;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 213);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarSplash);
            this.Controls.Add(this.lblDescricaoAplicacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCarregando);
            this.Controls.Add(this.pictureBoxGlobo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlobo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricaoAplicacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCarregando;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.ProgressBar progressBarSplash;
        private System.Windows.Forms.PictureBox pictureBoxGlobo;
    }
}