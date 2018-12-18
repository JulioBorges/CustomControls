namespace CustomControls.Forms
{
    public partial class FrmSimplesNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSimplesNavigator));
            this.tspNavigator = new CustomControls.Data.DataNavigator(this.components);
            this.bdsDados = new System.Windows.Forms.BindingSource(this.components);
            this.buttonInserir = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.buttonSalvar = new System.Windows.Forms.ToolStripButton();
            this.buttonDeletar = new System.Windows.Forms.ToolStripButton();
            this.SeparatorNav2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.sepNavegacao1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.buttonAnterior = new System.Windows.Forms.ToolStripButton();
            this.sepNavegacao2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPosicao = new System.Windows.Forms.ToolStripTextBox();
            this.lblQtd = new System.Windows.Forms.ToolStripLabel();
            this.sepNavegacao3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonProximo = new System.Windows.Forms.ToolStripButton();
            this.buttonUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAtualizar = new System.Windows.Forms.ToolStripButton();
            this.tspNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlComponentes
            // 
            this.pnlComponentes.Location = new System.Drawing.Point(0, 38);
            this.pnlComponentes.Size = new System.Drawing.Size(802, 382);
            // 
            // tspNavigator
            // 
            this.tspNavigator.BackColor = System.Drawing.Color.GhostWhite;
            this.tspNavigator.FonteDadosNavegacao = this.bdsDados;
            this.tspNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonInserir,
            this.buttonCancelar,
            this.buttonSalvar,
            this.buttonDeletar,
            this.SeparatorNav2,
            this.lblStatus,
            this.sepNavegacao1,
            this.buttonPrimeiro,
            this.buttonAnterior,
            this.sepNavegacao2,
            this.txtPosicao,
            this.lblQtd,
            this.sepNavegacao3,
            this.buttonProximo,
            this.buttonUltimo,
            this.toolStripSeparator2,
            this.buttonAtualizar});
            this.tspNavigator.Location = new System.Drawing.Point(0, 0);
            this.tspNavigator.Name = "tspNavigator";
            this.tspNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspNavigator.Size = new System.Drawing.Size(802, 38);
            this.tspNavigator.TabIndex = 7;
            this.tspNavigator.Text = "Navegação";
            // 
            // bdsDados
            // 
            this.bdsDados.CurrentItemChanged += new System.EventHandler(this.bdsDados_CurrentItemChanged);
            // 
            // buttonInserir
            // 
            this.buttonInserir.AutoSize = false;
            this.buttonInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonInserir.Image = ((System.Drawing.Image)(resources.GetObject("buttonInserir.Image")));
            this.buttonInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.RightToLeftAutoMirrorImage = true;
            this.buttonInserir.Size = new System.Drawing.Size(35, 35);
            this.buttonInserir.Text = "Adcionar Registro";
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = false;
            this.buttonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Image = global::CustomControls.Properties.Resources.cancelar;
            this.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(35, 35);
            this.buttonCancelar.Text = "Calcelar edição";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.AutoSize = false;
            this.buttonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Image = global::CustomControls.Properties.Resources.Gnome;
            this.buttonSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(35, 35);
            this.buttonSalvar.Text = "Salvar Dados";
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.AutoSize = false;
            this.buttonDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDeletar.Image = global::CustomControls.Properties.Resources.deletar;
            this.buttonDeletar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(35, 35);
            this.buttonDeletar.Text = "Deletar registro";
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // SeparatorNav2
            // 
            this.SeparatorNav2.Name = "SeparatorNav2";
            this.SeparatorNav2.Size = new System.Drawing.Size(6, 38);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 35);
            this.lblStatus.Text = "Aguardando";
            // 
            // sepNavegacao1
            // 
            this.sepNavegacao1.Name = "sepNavegacao1";
            this.sepNavegacao1.Size = new System.Drawing.Size(6, 38);
            // 
            // buttonPrimeiro
            // 
            this.buttonPrimeiro.AutoSize = false;
            this.buttonPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPrimeiro.Image = global::CustomControls.Properties.Resources.Primeiro;
            this.buttonPrimeiro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonPrimeiro.Name = "buttonPrimeiro";
            this.buttonPrimeiro.RightToLeftAutoMirrorImage = true;
            this.buttonPrimeiro.Size = new System.Drawing.Size(35, 35);
            this.buttonPrimeiro.Text = "Primeiro Registro";
            this.buttonPrimeiro.Click += new System.EventHandler(this.buttonPrimeiro_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.AutoSize = false;
            this.buttonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAnterior.Image = global::CustomControls.Properties.Resources.anterior;
            this.buttonAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.RightToLeftAutoMirrorImage = true;
            this.buttonAnterior.Size = new System.Drawing.Size(35, 35);
            this.buttonAnterior.Text = "Registro Anterior";
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // sepNavegacao2
            // 
            this.sepNavegacao2.Name = "sepNavegacao2";
            this.sepNavegacao2.Size = new System.Drawing.Size(6, 38);
            // 
            // txtPosicao
            // 
            this.txtPosicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(75, 38);
            // 
            // lblQtd
            // 
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(29, 35);
            this.lblQtd.Text = "de 0";
            // 
            // sepNavegacao3
            // 
            this.sepNavegacao3.Name = "sepNavegacao3";
            this.sepNavegacao3.Size = new System.Drawing.Size(6, 38);
            // 
            // buttonProximo
            // 
            this.buttonProximo.AutoSize = false;
            this.buttonProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonProximo.Image = global::CustomControls.Properties.Resources.proximo;
            this.buttonProximo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.RightToLeftAutoMirrorImage = true;
            this.buttonProximo.Size = new System.Drawing.Size(35, 35);
            this.buttonProximo.Text = "Próximo Registro";
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.AutoSize = false;
            this.buttonUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUltimo.Image = global::CustomControls.Properties.Resources.ultimo;
            this.buttonUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.RightToLeftAutoMirrorImage = true;
            this.buttonUltimo.Size = new System.Drawing.Size(35, 35);
            this.buttonUltimo.Text = "Ultimo Registro";
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.AutoSize = false;
            this.buttonAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAtualizar.Image = global::CustomControls.Properties.Resources.atualizar;
            this.buttonAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(35, 35);
            this.buttonAtualizar.Text = "Atualizar Dados";
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // FrmSimplesNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 420);
            this.Controls.Add(this.tspNavigator);
            this.Name = "FrmSimplesNavigator";
            this.Text = "FrmSimplesNavigator";
            this.Load += new System.EventHandler(this.FrmSimplesNavigator_Load);
            this.Controls.SetChildIndex(this.tspNavigator, 0);
            this.Controls.SetChildIndex(this.pnlComponentes, 0);
            this.tspNavigator.ResumeLayout(false);
            this.tspNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton buttonPrimeiro;
        private System.Windows.Forms.ToolStripButton buttonAnterior;
        private System.Windows.Forms.ToolStripSeparator sepNavegacao2;
        private System.Windows.Forms.ToolStripButton buttonProximo;
        private System.Windows.Forms.ToolStripButton buttonUltimo;
        private System.Windows.Forms.ToolStripSeparator SeparatorNav2;
        private System.Windows.Forms.ToolStripButton buttonAtualizar;
        private System.Windows.Forms.ToolStripButton buttonInserir;
        private System.Windows.Forms.ToolStripButton buttonSalvar;
        private System.Windows.Forms.ToolStripButton buttonCancelar;
        private System.Windows.Forms.ToolStripButton buttonDeletar;
        private System.Windows.Forms.ToolStripLabel lblStatus;
        private System.Windows.Forms.ToolStripSeparator sepNavegacao1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtPosicao;
        private System.Windows.Forms.ToolStripLabel lblQtd;
        private System.Windows.Forms.ToolStripSeparator sepNavegacao3;
        private Data.DataNavigator tspNavigator;
        protected System.Windows.Forms.BindingSource bdsDados;
    }
}