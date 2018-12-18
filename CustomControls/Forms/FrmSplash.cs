using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace CustomControls.Forms
{
    public partial class FrmSplash : Form
    {
        private readonly List<string> plstInformacoes;
        private int cont;

        public FrmSplash(string strDescricaoAplicacao)
        {
            InitializeComponent();
            plstInformacoes = new List<string>
                                  {
                                      "Verificando configurações.",
                                      "Verificando configurações. .",
                                      "Verificando configurações. . .",
                                      "Localizando banco de dados.",
                                      "Localizando banco de dados. .",
                                      "Localizando banco de dados. . .",
                                      "Abrindo banco de dados.",
                                      "Abrindo banco de dados. .",
                                      "Abrindo banco de dados. . .",
                                      "Conexão realizada com sucesso!",
                                      "Carregando objetos da aplicação.",
                                      "Carregando objetos da aplicação. .",
                                      "Carregando objetos da aplicação. . .",
                                      "Carregando interface.",
                                      "Carregando interface. .",
                                      "Carregando interface. . .",
                                      "Carregamento concluído!",
                                      "Abrindo aplicação.",
                                      "Abrindo aplicação. .",
                                      "Abrindo aplicação. . .",
                                      "Abrindo aplicação.",
                                      "Abrindo aplicação. .",
                                      "Abrindo aplicação. . .",
                                      "Abrindo aplicação.",
                                      "Abrindo aplicação. .",
                                      "Abrindo aplicação. . ."
                                  };
            lblDescricaoAplicacao.Text = strDescricaoAplicacao;
        }

        public FrmSplash(string strDescricaoAplicacao, List<string> lstInformacoes)
        {
            InitializeComponent();

            plstInformacoes = lstInformacoes;
            lblDescricaoAplicacao.Text = strDescricaoAplicacao;
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            var rnd = new Random(1);
            int value = rnd.Next(60);

            if (cont < plstInformacoes.Count)
            {
                labelCarregando.Text = plstInformacoes[cont];
                cont++;
            }

            if (progressBarSplash.Value + value >= 100)
            {
                timerSplash.Enabled = false;
                Close();
            }
            else
            {
                progressBarSplash.Value += value;
                Refresh();
            }
        }


        private void FrmSplash_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            for (double i = 0; i <= 1; i += 0.1)
            {
                Opacity = i;
                Refresh();
                Thread.Sleep(15);
            }
            Carregamento();
        }

        private void Carregamento()
        {
            foreach (var info in plstInformacoes)
                ExibirTextoCarregamento(info);

            Close();
        }

        public void ExibirTextoCarregamento(string strTextoCarregamento)
        {
            var rnd = new Random(1);
            int value = rnd.Next(200, 400);
            progressBarSplash.PerformStep();
            progressBarSplash.Update();
            labelCarregando.Text = strTextoCarregamento;
            Refresh();
            Thread.Sleep(value);
        }
    }
}
