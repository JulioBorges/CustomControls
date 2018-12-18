using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CustomControls.Classes;
using CustomControls.Enums;

namespace CustomControls.Forms
{
    public partial class UserControlSimplesNavigator : UserControl
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
        [Description("Visibilidade do botão Editar")]
        public bool EditarVisible { get; set; }

        [Category("Ajustes")]
        [Description("Visibilidade do botão Inserir")]
        public bool InserirVisible { get; set; }

        [Category("Ajustes")]
        [Description("Visibilidade do botão Salvar")]
        public bool SalvarVisible { get; set; }

        [Category("Ajustes")]
        [Description("Visibilidade dos botões de Navegação")]
        public bool NavegacaoVisible { get; set; }

        [Category("Acesso a Dados")]
        [Description("DataSet de controle dos dados")]
        public DataSet DsDados { get; set; }

        [Category("Acesso a Dados")]
        [Description("Nome da tabela")]
        public string NomeTabela { get; set; }

        [Category("Acesso a Dados")]
        [Description("Filtro a ser realizado na tabela")]
        public string Filtro { get; set; }

        [Category("Acesso a Dados")]
        [Description("enmEstadoEdicao inicial")]
        public EstadoEdicao DataMode { get; set; }

        [Category("Acesso a Dados")]
        [Description("Campo Primary Key")]
        public string CampoId { get; set; }

        [Category("Acesso a Dados")]
        [Description("Se o campo ID é dateTima")]
        public bool CampoIdDateTime { get; set; }

        [Category("Acesso a Dados")]
        [Description("DataGrid que mostrará os dados")]
        public DataGridView GridView { get; set; }

        internal bool HabilitaSeparador()
        {
            return buttonAtualizar.Visible || buttonCancelar.Visible || buttonDeletar.Visible ||
                   buttonEditar.Visible || buttonInserir.Visible || buttonSalvar.Visible;
        }

        #endregion

        protected UserControlSimplesNavigator()
        {
            InitializeComponent();
            NomeTabela = "";
            Filtro = "";
            CampoIdDateTime = false;
            CampoId = "";
            CancelarVisible = true;
            AtualizarVisible = true;
            DeletarVisible = true;
            EditarVisible = true;
            InserirVisible = true;
            SalvarVisible = true;
            NavegacaoVisible = true;

            DataMode = EstadoEdicao.Aguardando;
        }

        protected virtual ToolStripButton[] GetBotoesBrowse()
        {
            return new[] {buttonEditar, buttonDeletar, buttonInserir, buttonAtualizar};
        }

        protected virtual ToolStripButton[] GetBotoesEdit()
        {
            return new[] {buttonSalvar, buttonCancelar};
        }

        protected virtual object[] GetControlesEdit()
        {
            throw new NotImplementedException("Método GetcontrolesEdit não implementado");
        }

        protected virtual void AlimentarDados()
        {
            DataMode = EstadoEdicao.Aguardando;
        }

        protected virtual void ButtonAtualizarClick(object sender, EventArgs e)
        {
        }

        protected virtual void ButtonInserirClick(object sender, EventArgs e)
        {
            DataMode = EstadoEdicao.Aguardando;
        }

        protected virtual void ButtonEditarClick(object sender, EventArgs e)
        {
            DataMode = EstadoEdicao.Editando;
        }

        protected virtual void ButtonSalvarClick(object sender, EventArgs e)
        {
        }

        protected virtual bool Consistencia()
        {
            return true;
        }

        protected virtual void ButtonCancelarClick(object sender, EventArgs e)
        {
            DataMode = EstadoEdicao.Aguardando;
        }

        protected virtual void ButtonDeletarClick(object sender, EventArgs e)
        {
        }

        protected virtual void UserControlSimplesNavigatorLoad(object sender, EventArgs e)
        {
            try
            {
                ControleBotoes();

                if (!Funcoes.InDesign())
                {
                }
            }
            catch (Exception ex)
            {
                Mensagem.Excecao(this, ex);
            }
        }

        private void ControleBotoes()
        {
            SuspendLayout();
            buttonCancelar.Visible = CancelarVisible;
            buttonAtualizar.Visible = AtualizarVisible;
            buttonDeletar.Visible = DeletarVisible;
            buttonEditar.Visible = EditarVisible;
            buttonInserir.Visible = InserirVisible;
            buttonSalvar.Visible = SalvarVisible;

            buttonAnterior.Visible = NavegacaoVisible;
            buttonPrimeiro.Visible = NavegacaoVisible;
            buttonProximo.Visible = NavegacaoVisible;
            buttonUltimo.Visible = NavegacaoVisible;
            SeparatorNav1.Visible = NavegacaoVisible;
            SeparatorNav2.Visible = NavegacaoVisible;
            ResumeLayout(true);
        }

        private void UserControlSimplesNavigatorPaint(object sender, PaintEventArgs e)
        {
            if (Funcoes.InDesign())
                ControleBotoes();
        }
    }
}
