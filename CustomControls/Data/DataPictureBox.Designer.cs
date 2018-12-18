namespace CustomControls.Data
{
    partial class DataPictureBox
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
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBoxData = new System.Windows.Forms.PictureBox();
            this.contextMenuStripImagem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSelecionarImagem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExcluirImagem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.panelButton.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData)).BeginInit();
            this.contextMenuStripImagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnSelecionar);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 368);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(321, 35);
            this.panelButton.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Location = new System.Drawing.Point(0, 0);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(321, 35);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar imagem";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.ButtonSelecionarClick);
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureBoxData);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(321, 368);
            this.panelImage.TabIndex = 2;
            // 
            // pictureBoxData
            // 
            this.pictureBoxData.ContextMenuStrip = this.contextMenuStripImagem;
            this.pictureBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxData.InitialImage = null;
            this.pictureBoxData.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxData.Name = "pictureBoxData";
            this.pictureBoxData.Size = new System.Drawing.Size(321, 368);
            this.pictureBoxData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxData.TabIndex = 0;
            this.pictureBoxData.TabStop = false;
            // 
            // contextMenuStripImagem
            // 
            this.contextMenuStripImagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSelecionarImagem,
            this.toolStripMenuItemExcluirImagem});
            this.contextMenuStripImagem.Name = "contextMenuStripImagem";
            this.contextMenuStripImagem.Size = new System.Drawing.Size(185, 48);
            // 
            // toolStripMenuItemSelecionarImagem
            // 
            this.toolStripMenuItemSelecionarImagem.Name = "toolStripMenuItemSelecionarImagem";
            this.toolStripMenuItemSelecionarImagem.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemSelecionarImagem.Text = "Selecionar imagem...";
            this.toolStripMenuItemSelecionarImagem.Click += new System.EventHandler(this.ButtonSelecionarClick);
            // 
            // toolStripMenuItemExcluirImagem
            // 
            this.toolStripMenuItemExcluirImagem.Name = "toolStripMenuItemExcluirImagem";
            this.toolStripMenuItemExcluirImagem.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemExcluirImagem.Text = "Excluir imagem..";
            this.toolStripMenuItemExcluirImagem.Click += new System.EventHandler(this.ToolStripMenuItemExcluirImagemClick);
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.Filter = "Arquivos de imagem(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp" +
    ";*.wmf;*.png|Todos os arquivos(*.*)|*.*";
            this.openFileDialogImagem.InitialDirectory = "Desktop";
            // 
            // DataPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelButton);
            this.Name = "DataPictureBox";
            this.Size = new System.Drawing.Size(321, 403);
            this.panelButton.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData)).EndInit();
            this.contextMenuStripImagem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
        public System.Windows.Forms.PictureBox pictureBoxData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImagem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelecionarImagem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExcluirImagem;


    }
}
