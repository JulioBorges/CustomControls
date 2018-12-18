#region

using System;
using System.Threading;
using System.Windows.Forms;

#endregion

namespace CustomControls.Forms
{
    public static class ClasseAguarde
    {
        private static F_Aguarde _telaAguarde; //Form Loading.
        private static Thread _threadAguarde; //Thread para controle de loading.
        public delegate void SetFecharTelaAguarde();

        public static void IniciarCarregamento()
        {
            _threadAguarde = new Thread(CarregandoPorThread) { IsBackground = true };
            _threadAguarde.SetApartmentState(ApartmentState.STA);
            _threadAguarde.Start();
        }

        private static void CarregandoPorThread()
        {
            try
            {
                _telaAguarde = new F_Aguarde();
                _telaAguarde.TopMost = true;
                _telaAguarde.ShowDialog();
            }
            catch
            {
                // ignored
            }
        }

        public static void FimCarregamento()
        {
            if (_threadAguarde != null)
            {
                FecharFormulario();
                _threadAguarde.Abort();
                Application.DoEvents();
            }
        }

        private static void FecharFormulario()
        {
            try
            {
                if (_telaAguarde != null)
                {
                    if (_telaAguarde.InvokeRequired)
                    {
                        _telaAguarde.Invoke((MethodInvoker)delegate { FecharFormulario(); });
                    }
                    else
                    {
                        _telaAguarde.Close();
                        _telaAguarde.Dispose();
                        _threadAguarde.Interrupt();
                    }
                }
            }
            catch
            {
                _threadAguarde.Abort();
            }
        }
    }
}