#region

using CustomControls.Classes;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


#endregion

namespace CustomControls.Forms
{
    public partial class FrmParent : Form
    {
        private string _diretorioAplicacao;

        #region Código gerado automaticamente

        public FrmParent()
        {
            InitializeComponent();
        }

        private void FrmParentLoad(object sender, EventArgs e)
        {
            SetaImagemBackground();
            _diretorioAplicacao = Path.GetDirectoryName(Application.ExecutablePath);
        }

        private void FrmParentFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Mensagem.Pergunta(this,
                                  "Se fechar a aplicação, você poderá perder o trabalho não salvo!.\nDeseja realmente fechar a aplicação?.",
                                  DialogResult.No))
                e.Cancel = true;
        }

        private void SetaImagemBackground()
        {
            /*
             * Configura a imagem da tela de acordo com a imagem do banco de dados.
            
            object imagem = Conexao.ExecuteScalar("SELECT P_LOGO_EMPRESA FROM PARAMETROS");

            if (imagem != DBNull.Value)
            {
                this.BackgroundImage = Funcoes.ObjectToImage(imagem);
                ConfiguraImageStyleBackground();
            }
            */
        }

        private void TimerStatusTick(object sender, EventArgs e)
        {
            //try
            //{
            //    GC.Collect();
            //}
            //catch
            //{
            //}

            //labelStatus.Text = DateTime.Now.ToLongDateString() + Resources.FrmParent_TimerStatusTick____ + DateTime.Now.ToLongTimeString();
        }

        private void MenuItemSairClick(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemBarraStatusClick(object sender, EventArgs e)
        {
            barraStatus.Visible = menuItemBarraStatus.Checked;
        }

        private void MenuItemBarraBotoesClick(object sender, EventArgs e)
        {
            barraBotoes.Visible = menuItemBarraBotoes.Checked;
        }

        private void MenuManutencaoBancoDadosClickMenuManutencaoBancoDadosClick(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                Mensagem.Aviso(this, "Para realizar manutenção no banco todas as janelas devem estar fechadas !");
                return;
            }

            timerStatus.Enabled = false;
            //new F_UTILITARIOBANCO().ShowDialog();
            timerStatus.Enabled = true;
        }

        private void MenuSobreClick(object sender, EventArgs e)
        {
            var frmSobre = new FrmSobre {MdiParent = this};
            frmSobre.Show();
        }

        private void MenuCascataClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuLadoLadoVerticalClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuLadoLadoHorizontalClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuFecharTodasClick(object sender, EventArgs e)
        {
            foreach (var childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MenuManualClick(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(_diretorioAplicacao + @"\Help\Manual de referência.pdf"))
                {
                    Mensagem.Erro(this, "Manual de referência inexistente no diretório da aplicação");
                    return;
                }

                Process.Start(_diretorioAplicacao + @"\Help\Manual de referência.pdf");
            }
            catch
            {
            }
        }

        private void MenuEmailDesenvolvedorClick(object sender, EventArgs e)
        {
            var frmEmail = new FrmEmailDesenvolvedor("CATI") {MdiParent = this};
            frmEmail.ShowDialog();
        }

        #endregion
    }
}