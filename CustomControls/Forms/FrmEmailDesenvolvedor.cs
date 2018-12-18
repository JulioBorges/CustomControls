#region

using CustomControls.Classes;
using System;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace CustomControls.Forms
{
    public partial class FrmEmailDesenvolvedor : Form
    {
        private readonly string pstrNomeAplicacao;

        #region Código gerado automaticamente

        public FrmEmailDesenvolvedor(string strNomeAplicacao)
        {
            InitializeComponent();
            pstrNomeAplicacao = strNomeAplicacao;
        }

        private void FrmEmailDesenvolvedorLoad(object sender, EventArgs e)
        {
            comboBoxAssunto.SelectedIndex = 0;
        }

        private bool Consistencia()
        {
            if (!InternetIsOn())
            {
                Mensagem.Atencao(this,
                                 "É necessário ter uma conexão ativa com a internet para que o email seja enviado.");
                return false;
            }

            if ((textBoxEmail.Text == String.Empty) && (textBoxTelefone.Text == String.Empty) &&
                (textBoxNome.Text == String.Empty))
            {
                Mensagem.Atencao(this,
                                 "É necessário digitar algum dado para contato, por favor preencha o nome, email ou telefone para poder enviar a mensagem");
                return false;
            }

            if (textBoxMensagem.Text == String.Empty)
            {
                Mensagem.Atencao(this, "É necessário escrever uma mensagem para poder enviar o e-mail.");
                return false;
            }

            return true;
        }

        private void EnviandoEmail()
        {
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("borges.juliocezar@gmail.com", "mel130485"),
                    EnableSsl = true
                };

                Exception except = null;
                ClasseAguarde.IniciarCarregamento();
                try
                {
                    client.Send("borges.juliocezar@gmail.com", "borges.juliocezar@gmail.com",
                    comboBoxAssunto.SelectedText, MontaMensagem());
                }
                catch (Exception ex)
                {
                    except = ex;
                }
                finally
                {
                    ClasseAguarde.FimCarregamento();
                }

                if (except != null)
                    Mensagem.Excecao(this, "Ocorreu um erro no envio da mensagem", except);
                else
                    Mensagem.Aviso(this, "Mensagem Enviada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string MontaMensagem()
        {
            return "Aplicação: " + pstrNomeAplicacao + "\nAssunto: " +
                   comboBoxAssunto.SelectedItem +
                   "\nDados do remetente:\nNome: " + textBoxNome.Text + "\nE-mail: " + textBoxEmail.Text +
                   "\nTelefone: " + textBoxTelefone.Text + "\nMensagem: " + textBoxMensagem.Text;
        }

        private void ButtonEnviarMensagemClick(object sender, EventArgs e)
        {
            if (Consistencia())
                EnviandoEmail();
        }

        // Este método pode ser implementado dentro da aplicação para melhor acesso
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int description, int reservedValue);

        public static bool InternetIsOn()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        #endregion
    }
}