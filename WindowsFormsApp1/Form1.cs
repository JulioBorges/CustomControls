using CustomControls.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClasseAguarde.IniciarCarregamento();
            Thread.Sleep(10000);
            ClasseAguarde.FimCarregamento();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }
    }
}
