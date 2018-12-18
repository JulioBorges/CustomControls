using System.Windows.Forms;
using CustomControls.Classes;

namespace CustomControls.Forms
{
    public partial class FrmSimples : Form
    {
        protected bool pblnValidaFechamento;

        public FrmSimples()
        {
            InitializeComponent();
        }

        private void FrmSimples_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!pblnValidaFechamento) return;

            if (!Mensagem.Pergunta(this, "Existem operações em execução, deseja realmente fechar a tela?", DialogResult.Yes))
                e.Cancel = true;
        }
    }
}