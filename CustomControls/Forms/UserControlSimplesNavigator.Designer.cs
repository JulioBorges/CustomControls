namespace CustomControls.Forms
{
    public partial class UserControlSimplesNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSimplesNavigator));
            this.bdsDados = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDados = new System.Windows.Forms.BindingNavigator(this.components);
            this.buttonInserir = new System.Windows.Forms.ToolStripButton();
            this.buttonPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.buttonAnterior = new System.Windows.Forms.ToolStripButton();
            this.SeparatorNav1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonProximo = new System.Windows.Forms.ToolStripButton();
            this.buttonUltimo = new System.Windows.Forms.ToolStripButton();
            this.SeparatorNav2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAtualizar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonSalvar = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.buttonDeletar = new System.Windows.Forms.ToolStripButton();
            this.SeparatorFim = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).BeginInit();
            this.bindingNavigatorDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorDados
            // 
            this.bindingNavigatorDados.AddNewItem = this.buttonInserir;
            this.bindingNavigatorDados.BindingSource = this.bdsDados;
            this.bindingNavigatorDados.CountItem = null;
            this.bindingNavigatorDados.CountItemFormat = "de {0}";
            this.bindingNavigatorDados.DeleteItem = null;
            this.bindingNavigatorDados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonPrimeiro,
            this.buttonAnterior,
            this.SeparatorNav1,
            this.buttonProximo,
            this.buttonUltimo,
            this.SeparatorNav2,
            this.buttonAtualizar,
            this.buttonInserir,
            this.buttonEditar,
            this.buttonSalvar,
            this.buttonCancelar,
            this.buttonDeletar,
            this.SeparatorFim});
            this.bindingNavigatorDados.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorDados.MoveFirstItem = this.buttonPrimeiro;
            this.bindingNavigatorDados.MoveLastItem = this.buttonUltimo;
            this.bindingNavigatorDados.MoveNextItem = this.buttonProximo;
            this.bindingNavigatorDados.MovePreviousItem = this.buttonAnterior;
            this.bindingNavigatorDados.Name = "bindingNavigatorDados";
            this.bindingNavigatorDados.PositionItem = null;
            this.bindingNavigatorDados.Size = new System.Drawing.Size(555, 43);
            this.bindingNavigatorDados.TabIndex = 7;
            // 
            // buttonInserir
            // 
            this.buttonInserir.AutoSize = false;
            this.buttonInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonInserir.Image = ((System.Drawing.Image)(resources.GetObject("buttonInserir.Image")));
            this.buttonInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.RightToLeftAutoMirrorImage = true;
            this.buttonInserir.Size = new System.Drawing.Size(40, 40);
            this.buttonInserir.Text = "Novo";
            this.buttonInserir.Click += new System.EventHandler(this.ButtonInserirClick);
            // 
            // buttonPrimeiro
            // 
            this.buttonPrimeiro.AutoSize = false;
            this.buttonPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrimeiro.Image")));
            this.buttonPrimeiro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonPrimeiro.Name = "buttonPrimeiro";
            this.buttonPrimeiro.RightToLeftAutoMirrorImage = true;
            this.buttonPrimeiro.Size = new System.Drawing.Size(40, 40);
            this.buttonPrimeiro.Text = "Primeiro";
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.AutoSize = false;
            this.buttonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAnterior.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnterior.Image")));
            this.buttonAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.RightToLeftAutoMirrorImage = true;
            this.buttonAnterior.Size = new System.Drawing.Size(40, 40);
            this.buttonAnterior.Text = "Anterior";
            // 
            // SeparatorNav1
            // 
            this.SeparatorNav1.Name = "SeparatorNav1";
            this.SeparatorNav1.Size = new System.Drawing.Size(6, 43);
            // 
            // buttonProximo
            // 
            this.buttonProximo.AutoSize = false;
            this.buttonProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonProximo.Image = ((System.Drawing.Image)(resources.GetObject("buttonProximo.Image")));
            this.buttonProximo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.RightToLeftAutoMirrorImage = true;
            this.buttonProximo.Size = new System.Drawing.Size(40, 40);
            this.buttonProximo.Text = "Próximo";
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.AutoSize = false;
            this.buttonUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUltimo.Image = ((System.Drawing.Image)(resources.GetObject("buttonUltimo.Image")));
            this.buttonUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.RightToLeftAutoMirrorImage = true;
            this.buttonUltimo.Size = new System.Drawing.Size(40, 40);
            this.buttonUltimo.Text = "Ultimo";
            // 
            // SeparatorNav2
            // 
            this.SeparatorNav2.Name = "SeparatorNav2";
            this.SeparatorNav2.Size = new System.Drawing.Size(6, 43);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.AutoSize = false;
            this.buttonAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtualizar.Image")));
            this.buttonAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(40, 40);
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.Click += new System.EventHandler(this.ButtonAtualizarClick);
            // 
            // buttonEditar
            // 
            this.buttonEditar.AutoSize = false;
            this.buttonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(40, 40);
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.Click += new System.EventHandler(this.ButtonEditarClick);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(40, 40);
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.Click += new System.EventHandler(this.ButtonSalvarClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(40, 40);
            this.buttonCancelar.Text = "Calcelar edição";
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDeletar.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletar.Image")));
            this.buttonDeletar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(40, 40);
            this.buttonDeletar.Text = "Deletar registro";
            this.buttonDeletar.Click += new System.EventHandler(this.ButtonDeletarClick);
            // 
            // SeparatorFim
            // 
            this.SeparatorFim.Name = "SeparatorFim";
            this.SeparatorFim.Size = new System.Drawing.Size(6, 43);
            // 
            // UserControlSimplesNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigatorDados);
            this.Name = "UserControlSimplesNavigator";
            this.Size = new System.Drawing.Size(555, 406);
            this.Load += new System.EventHandler(this.UserControlSimplesNavigatorLoad);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlSimplesNavigatorPaint);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).EndInit();
            this.bindingNavigatorDados.ResumeLayout(false);
            this.bindingNavigatorDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsDados;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDados;
        private System.Windows.Forms.ToolStripButton buttonInserir;
        private System.Windows.Forms.ToolStripButton buttonPrimeiro;
        private System.Windows.Forms.ToolStripButton buttonAnterior;
        private System.Windows.Forms.ToolStripSeparator SeparatorNav1;
        private System.Windows.Forms.ToolStripButton buttonProximo;
        private System.Windows.Forms.ToolStripButton buttonUltimo;
        private System.Windows.Forms.ToolStripSeparator SeparatorNav2;
        private System.Windows.Forms.ToolStripButton buttonAtualizar;
        private System.Windows.Forms.ToolStripButton buttonEditar;
        private System.Windows.Forms.ToolStripButton buttonSalvar;
        private System.Windows.Forms.ToolStripButton buttonCancelar;
        private System.Windows.Forms.ToolStripButton buttonDeletar;
        private System.Windows.Forms.ToolStripSeparator SeparatorFim;
    }
}
