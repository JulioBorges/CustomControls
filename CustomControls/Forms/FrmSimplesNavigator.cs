using System.ComponentModel;
using System.Windows.Forms;
using CustomControls.Classes;
using CustomControls.Enums;

namespace CustomControls.Forms
{
    public partial class FrmSimplesNavigator : FrmSimples
    {
        #region Propriedades

        [Category("Ajustes")]
        [Description("Visibilidade do botão atualizar")]
        public bool AtualizarVisible { get; set; }

        [Category("Ajustes")]
        [Description("Visibilidade do botão Cancelar")]
        public bool CancelarVisible { get; set; }

        [Category("Ajustes")]
        [Description("Visibilidade do botão Deletar")]
        public bool DeletarVisible { get; set; }

        [Category("Ajustes")]
        [Description("Visibilidade do botão Inserir")]
        public bool InserirVisible { get; set; }

        [Category("Ajustes")]
        [Description("Visibilidade do botão Salvar")]
        public bool SalvarVisible { get; set; }

        [Category("Ajustes")]
        [Description("Visibilidade dos botões de Navegação")]
        public bool NavegacaoVisible { get; set; }

        [Category("Ajustes")]
        [Description("Mensagem de confirmação a ser mostrada ao realizar uma exclusão")]
        public string MensagemConfirmacaoExclusao { get; set; }

        private bool HabilitarControlesNavegacao
        {
            set
            {
                tspNavigator.SuspendLayout();
                buttonPrimeiro.Enabled = value;
                buttonAnterior.Enabled = value;
                buttonProximo.Enabled = value;
                buttonUltimo.Enabled = value;
                tspNavigator.ResumeLayout(true);
            }
        }

        private bool HabilitarControlesEdicao
        {
            set
            {
                tspNavigator.SuspendLayout();
                buttonInserir.Enabled = !value;
                buttonCancelar.Enabled = value;
                buttonSalvar.Enabled = value;
                buttonDeletar.Enabled = !value;
                buttonAtualizar.Enabled = !value;
                tspNavigator.ResumeLayout(true);
            }
        }

        private EstadoEdicao enmEstado = EstadoEdicao.Aguardando;

        protected bool HabilitaEdicao;

        [Category("Ajustes")]
        [Description("Estado de edição")]
        public EstadoEdicao enmEstadoEdicao
        {
            get { return enmEstado; }
            set
            {
                enmEstado = value;
                ConfiguraBarraNavegacao(value);
            }
        }

        internal bool HabilitaSeparador
        {
            get
            {
                return buttonAtualizar.Visible || buttonCancelar.Visible || buttonDeletar.Visible
                       || buttonInserir.Visible || buttonSalvar.Visible;
            }
        }

        #endregion

        public FrmSimplesNavigator()
        {
            InitializeComponent();
            CancelarVisible = true;
            AtualizarVisible = true;
            DeletarVisible = true;
            InserirVisible = true;
            SalvarVisible = true;
            NavegacaoVisible = true;
            AlimentarDados();
            enmEstadoEdicao = EstadoEdicao.Aguardando;
            MensagemConfirmacaoExclusao = "Deseja realmente excluir este registro?";
        }

        #region Botoes Barra

        private void buttonInserir_Click(object sender, System.EventArgs e)
        {
            InserirRegistro();
        }

        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
            CancelarEdicao();
        }

        private void buttonSalvar_Click(object sender, System.EventArgs e)
        {
            SalvarRegistro();
        }

        private void buttonDeletar_Click(object sender, System.EventArgs e)
        {
            Excluir();
        }

        private void buttonPrimeiro_Click(object sender, System.EventArgs e)
        {
            PrimeiroRegistro();
        }

        private void buttonAnterior_Click(object sender, System.EventArgs e)
        {
            RegistroAnterior();
        }

        private void buttonProximo_Click(object sender, System.EventArgs e)
        {
            ProximoRegistro();
        }

        private void buttonUltimo_Click(object sender, System.EventArgs e)
        {
            UltimoRegistro();
        }

        private void buttonAtualizar_Click(object sender, System.EventArgs e)
        {
            AtualizarDados();
        }

        #endregion

        private void AlimentarDados()
        {
            AlimentarFonteDados();
        }

        private void CarregarBindingFormulario()
        {
            HabilitaEdicao = false;
            this.BindingControles();
            HabilitaEdicao = true;
        }

        private void ConfiguraBarraNavegacao(EstadoEdicao enmEst)
        {
            lblStatus.Text = enmEstadoEdicao.ToString();

            txtPosicao.Text = (tspNavigator.FonteDadosNavegacao.Position + 1).ToString();
            lblQtd.Text = string.Format("de {0}", tspNavigator.FonteDadosNavegacao.Count);

            switch (enmEst)
            {
                case EstadoEdicao.Aguardando:
                case EstadoEdicao.Excluindo:
                    {
                        HabilitarControlesEdicao = false;
                        HabilitarControlesNavegacao = true;
                        break;
                    }
                case EstadoEdicao.Inserindo:
                case EstadoEdicao.Editando:
                    {
                        HabilitarControlesEdicao = true;
                        HabilitarControlesNavegacao = false;
                        break;
                    }
            }
        }

        private void FrmSimplesNavigator_Load(object sender, System.EventArgs e)
        {
            CarregarBindingFormulario();
        }

        protected virtual void AlimentarFonteDados()
        {
        }

        #region Métodos de Cadastro - CRUD

        protected virtual void InserirRegistro()
        {
            enmEstadoEdicao = EstadoEdicao.Inserindo;
            tspNavigator.FonteDadosNavegacao.AddNew();
        }

        protected virtual void SalvarRegistro()
        {
            if (!Validacao())
                return;

            tspNavigator.FonteDadosNavegacao.EndEdit();

            AtualizaBancoDados();
            enmEstadoEdicao = EstadoEdicao.Aguardando;
        }

        protected virtual void AtualizaBancoDados()
        {
        }

        protected virtual bool Validacao()
        {
            return true;
        }

        /// <summary>
        ///   Verificar resultado de mensagem de reversão de formulario
        /// </summary>
        /// <returns> </returns>
        public virtual bool VerificarReverterFormulario()
        {
            return enmEstadoEdicao != EstadoEdicao.Editando || 
                Mensagem.Pergunta(this, "Deseja reverter as últimas alterações ?", DialogResult.Yes);
        }

        /// <summary>
        ///   Método que reverter as ações do formulário Formulario de cadastro Incluindo -> Aguardando, Alterando -> Exibindo Formulario de pesquisa, deletar o arquivo de configurações pessoais do grid.
        /// </summary>
        protected virtual void CancelarEdicao()
        {
            if (enmEstadoEdicao == EstadoEdicao.Inserindo ||
                enmEstadoEdicao == EstadoEdicao.Editando)
            {
                if (Mensagem.Pergunta(this, "Deseja reverter as alterações realizadas?", DialogResult.No))
                    return;

                tspNavigator.FonteDadosNavegacao.CancelEdit();

                if (tspNavigator.FonteDadosNavegacao != null && tspNavigator.FonteDadosNavegacao.Count > 0)
                {
                    enmEstadoEdicao = EstadoEdicao.Aguardando;

                    if (enmEstadoEdicao == EstadoEdicao.Editando)
                        tspNavigator.FonteDadosNavegacao.Position = 0;
                }
            }
        }

        /// <summary>
        ///   Método de exclusão
        /// </summary>
        /// <returns> </returns>
        public virtual bool Excluir()
        {
            if (enmEstadoEdicao == EstadoEdicao.Aguardando)
            {
                if (Mensagem.Pergunta(this, MensagemConfirmacaoExclusao, DialogResult.Yes))
                {
                    HabilitaEdicao = false;
                    tspNavigator.FonteDadosNavegacao.RemoveCurrent();
                    tspNavigator.FonteDadosNavegacao.Position = 0;
                    AtualizaBancoDados();
                    HabilitaEdicao = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Métodos de navegação

        protected virtual void PrimeiroRegistro()
        {
            HabilitaEdicao = false;
            tspNavigator.FonteDadosNavegacao.MoveFirst();
            HabilitaEdicao = true;
        }

        protected virtual void RegistroAnterior()
        {
            HabilitaEdicao = false;
            tspNavigator.FonteDadosNavegacao.MovePrevious();
            HabilitaEdicao = true;
        }

        protected virtual void ProximoRegistro()
        {
            HabilitaEdicao = false;
            tspNavigator.FonteDadosNavegacao.MoveNext();
            HabilitaEdicao = true;
        }

        protected virtual void UltimoRegistro()
        {
            HabilitaEdicao = false;
            tspNavigator.FonteDadosNavegacao.MoveLast();
            HabilitaEdicao = true;
        }

        protected virtual void AtualizarDados()
        {
            if (enmEstadoEdicao != EstadoEdicao.Aguardando)
                return;

            HabilitaEdicao = false;
            tspNavigator.FonteDadosNavegacao.CurrencyManager.Refresh();
            HabilitaEdicao = true;
        } 

        #endregion

        private void bdsDados_CurrentItemChanged(object sender, System.EventArgs e)
        {
            ConfiguraBarraNavegacao(enmEstadoEdicao);

            if (!HabilitaEdicao)
                return;

            enmEstadoEdicao = EstadoEdicao.Editando;
        }
    }
}