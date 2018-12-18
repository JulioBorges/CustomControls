namespace CustomControls.Forms
{
    partial class FrmParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParent));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualizacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBarraStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBarraBotoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEstiloImagem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImageLadoALado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImageCentralizado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImageAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBancoDeDados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManutencaoBancoDados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmailDesenvolvedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJanelas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLadoLadoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLadoLadoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFecharTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.barraBotoes = new System.Windows.Forms.ToolStrip();
            this.buttonManualReferencia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.barraStatus.SuspendLayout();
            this.barraMenu.SuspendLayout();
            this.barraBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.barraStatus.Location = new System.Drawing.Point(0, 451);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(744, 22);
            this.barraStatus.TabIndex = 4;
            this.barraStatus.Text = "BarraStatus";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 17);
            this.labelStatus.Text = "Status";
            // 
            // barraMenu
            // 
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuControle,
            this.menuRelatorios,
            this.menuVisualizacao,
            this.menuBancoDeDados,
            this.menuAjuda,
            this.menuJanelas});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.MdiWindowListItem = this.menuJanelas;
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(744, 24);
            this.barraMenu.TabIndex = 5;
            this.barraMenu.Text = "MenuStrip";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.menuItemSair});
            this.menuCadastros.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(80, 20);
            this.menuCadastros.Text = "&1 Cadastros";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(90, 6);
            // 
            // menuItemSair
            // 
            this.menuItemSair.Name = "menuItemSair";
            this.menuItemSair.Size = new System.Drawing.Size(93, 22);
            this.menuItemSair.Text = "S&air";
            this.menuItemSair.Click += new System.EventHandler(this.MenuItemSairClick);
            // 
            // menuControle
            // 
            this.menuControle.Name = "menuControle";
            this.menuControle.Size = new System.Drawing.Size(74, 20);
            this.menuControle.Text = "&2 Controle";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(80, 20);
            this.menuRelatorios.Text = "&3 Relatórios";
            // 
            // menuVisualizacao
            // 
            this.menuVisualizacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBarraStatus,
            this.menuItemBarraBotoes,
            this.menuItemEstiloImagem});
            this.menuVisualizacao.Name = "menuVisualizacao";
            this.menuVisualizacao.Size = new System.Drawing.Size(59, 20);
            this.menuVisualizacao.Text = "&4 Visual";
            // 
            // menuItemBarraStatus
            // 
            this.menuItemBarraStatus.Checked = true;
            this.menuItemBarraStatus.CheckOnClick = true;
            this.menuItemBarraStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemBarraStatus.Name = "menuItemBarraStatus";
            this.menuItemBarraStatus.Size = new System.Drawing.Size(225, 22);
            this.menuItemBarraStatus.Text = "&1 Barra de Status";
            this.menuItemBarraStatus.Click += new System.EventHandler(this.MenuItemBarraStatusClick);
            // 
            // menuItemBarraBotoes
            // 
            this.menuItemBarraBotoes.Checked = true;
            this.menuItemBarraBotoes.CheckOnClick = true;
            this.menuItemBarraBotoes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemBarraBotoes.Name = "menuItemBarraBotoes";
            this.menuItemBarraBotoes.Size = new System.Drawing.Size(225, 22);
            this.menuItemBarraBotoes.Text = "&2 Barra de Botões";
            this.menuItemBarraBotoes.Click += new System.EventHandler(this.MenuItemBarraBotoesClick);
            // 
            // menuItemEstiloImagem
            // 
            this.menuItemEstiloImagem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemImageLadoALado,
            this.menuItemImageCentralizado,
            this.menuItemImageAjustar});
            this.menuItemEstiloImagem.Name = "menuItemEstiloImagem";
            this.menuItemEstiloImagem.Size = new System.Drawing.Size(225, 22);
            this.menuItemEstiloImagem.Text = "&3 Estilo da imagem de fundo";
            // 
            // menuItemImageLadoALado
            // 
            this.menuItemImageLadoALado.CheckOnClick = true;
            this.menuItemImageLadoALado.Name = "menuItemImageLadoALado";
            this.menuItemImageLadoALado.Size = new System.Drawing.Size(149, 22);
            this.menuItemImageLadoALado.Text = "&1 Lado a Lado";
            // 
            // menuItemImageCentralizado
            // 
            this.menuItemImageCentralizado.CheckOnClick = true;
            this.menuItemImageCentralizado.Name = "menuItemImageCentralizado";
            this.menuItemImageCentralizado.Size = new System.Drawing.Size(149, 22);
            this.menuItemImageCentralizado.Text = "&2 Centralizado";
            // 
            // menuItemImageAjustar
            // 
            this.menuItemImageAjustar.CheckOnClick = true;
            this.menuItemImageAjustar.Name = "menuItemImageAjustar";
            this.menuItemImageAjustar.Size = new System.Drawing.Size(149, 22);
            this.menuItemImageAjustar.Text = "&3 Ajustar";
            // 
            // menuBancoDeDados
            // 
            this.menuBancoDeDados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManutencaoBancoDados});
            this.menuBancoDeDados.Name = "menuBancoDeDados";
            this.menuBancoDeDados.Size = new System.Drawing.Size(112, 20);
            this.menuBancoDeDados.Text = "&5 Banco de dados";
            // 
            // menuManutencaoBancoDados
            // 
            this.menuManutencaoBancoDados.Name = "menuManutencaoBancoDados";
            this.menuManutencaoBancoDados.Size = new System.Drawing.Size(253, 22);
            this.menuManutencaoBancoDados.Text = "&1 Manutenção de banco de dados";
            this.menuManutencaoBancoDados.Click += new System.EventHandler(this.MenuManutencaoBancoDadosClickMenuManutencaoBancoDadosClick);
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManual,
            this.menuEmailDesenvolvedor,
            this.toolStripSeparator8,
            this.menuSobre});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(68, 20);
            this.menuAjuda.Text = "&6 Ajuda...";
            // 
            // menuManual
            // 
            this.menuManual.Image = ((System.Drawing.Image)(resources.GetObject("menuManual.Image")));
            this.menuManual.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuManual.Name = "menuManual";
            this.menuManual.Size = new System.Drawing.Size(268, 22);
            this.menuManual.Text = "&1 Manual do usuário";
            this.menuManual.Click += new System.EventHandler(this.MenuManualClick);
            // 
            // menuEmailDesenvolvedor
            // 
            this.menuEmailDesenvolvedor.Image = ((System.Drawing.Image)(resources.GetObject("menuEmailDesenvolvedor.Image")));
            this.menuEmailDesenvolvedor.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuEmailDesenvolvedor.Name = "menuEmailDesenvolvedor";
            this.menuEmailDesenvolvedor.Size = new System.Drawing.Size(268, 22);
            this.menuEmailDesenvolvedor.Text = "&2 Enviar e-mail para o desenvolvedor";
            this.menuEmailDesenvolvedor.Click += new System.EventHandler(this.MenuEmailDesenvolvedorClick);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(265, 6);
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(268, 22);
            this.menuSobre.Text = "&3 Sobre. . .";
            this.menuSobre.Click += new System.EventHandler(this.MenuSobreClick);
            // 
            // menuJanelas
            // 
            this.menuJanelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCascata,
            this.menuLadoLadoVertical,
            this.menuLadoLadoHorizontal,
            this.menuFecharTodas});
            this.menuJanelas.Name = "menuJanelas";
            this.menuJanelas.Size = new System.Drawing.Size(65, 20);
            this.menuJanelas.Text = "&7 Janelas";
            // 
            // menuCascata
            // 
            this.menuCascata.Name = "menuCascata";
            this.menuCascata.Size = new System.Drawing.Size(203, 22);
            this.menuCascata.Text = "&1 Cascata";
            this.menuCascata.Click += new System.EventHandler(this.MenuCascataClick);
            // 
            // menuLadoLadoVertical
            // 
            this.menuLadoLadoVertical.Name = "menuLadoLadoVertical";
            this.menuLadoLadoVertical.Size = new System.Drawing.Size(203, 22);
            this.menuLadoLadoVertical.Text = "&2 Lado a lado Vertical";
            this.menuLadoLadoVertical.Click += new System.EventHandler(this.MenuLadoLadoVerticalClick);
            // 
            // menuLadoLadoHorizontal
            // 
            this.menuLadoLadoHorizontal.Name = "menuLadoLadoHorizontal";
            this.menuLadoLadoHorizontal.Size = new System.Drawing.Size(203, 22);
            this.menuLadoLadoHorizontal.Text = "&3 Lado a lado Horizontal";
            this.menuLadoLadoHorizontal.Click += new System.EventHandler(this.MenuLadoLadoHorizontalClick);
            // 
            // menuFecharTodas
            // 
            this.menuFecharTodas.Name = "menuFecharTodas";
            this.menuFecharTodas.Size = new System.Drawing.Size(203, 22);
            this.menuFecharTodas.Text = "&4 Fechar todas as janelas";
            this.menuFecharTodas.Click += new System.EventHandler(this.MenuFecharTodasClick);
            // 
            // barraBotoes
            // 
            this.barraBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonManualReferencia,
            this.toolStripSeparator1});
            this.barraBotoes.Location = new System.Drawing.Point(0, 24);
            this.barraBotoes.Name = "barraBotoes";
            this.barraBotoes.Size = new System.Drawing.Size(744, 25);
            this.barraBotoes.TabIndex = 6;
            this.barraBotoes.Text = "Barra de botões";
            // 
            // buttonManualReferencia
            // 
            this.buttonManualReferencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonManualReferencia.Image = ((System.Drawing.Image)(resources.GetObject("buttonManualReferencia.Image")));
            this.buttonManualReferencia.ImageTransparentColor = System.Drawing.Color.Black;
            this.buttonManualReferencia.Name = "buttonManualReferencia";
            this.buttonManualReferencia.Size = new System.Drawing.Size(23, 22);
            this.buttonManualReferencia.Text = "Help";
            this.buttonManualReferencia.Click += new System.EventHandler(this.MenuManualClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Tick += new System.EventHandler(this.TimerStatusTick);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 473);
            this.Controls.Add(this.barraBotoes);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.barraStatus);
            this.IsMdiContainer = true;
            this.Name = "FrmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nome da aplicação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmParentLoad);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmParentFormClosing);
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.barraBotoes.ResumeLayout(false);
            this.barraBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuItemSair;
        private System.Windows.Forms.ToolStripMenuItem menuControle;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuVisualizacao;
        private System.Windows.Forms.ToolStripMenuItem menuItemBarraStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItemEstiloImagem;
        private System.Windows.Forms.ToolStripMenuItem menuItemImageLadoALado;
        private System.Windows.Forms.ToolStripMenuItem menuItemImageCentralizado;
        private System.Windows.Forms.ToolStripMenuItem menuItemImageAjustar;
        private System.Windows.Forms.ToolStripMenuItem menuBancoDeDados;
        private System.Windows.Forms.ToolStripMenuItem menuManutencaoBancoDados;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuManual;
        private System.Windows.Forms.ToolStripMenuItem menuEmailDesenvolvedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.ToolStripMenuItem menuJanelas;
        private System.Windows.Forms.ToolStripMenuItem menuCascata;
        private System.Windows.Forms.ToolStripMenuItem menuLadoLadoVertical;
        private System.Windows.Forms.ToolStripMenuItem menuLadoLadoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuFecharTodas;
        private System.Windows.Forms.ToolStrip barraBotoes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonManualReferencia;
        public System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItemBarraBotoes;
    }
}



