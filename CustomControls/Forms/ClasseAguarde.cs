#region

using System;
using System.Threading;
using System.Windows.Forms;

#endregion

namespace CustomControls.Forms
{
    public static class ClasseAguarde
    {
        private static F_BackgroundAguarde _background;
        private static F_Aguarde _telaAguarde; //Form Loading.
        private static Action _metodoFimDoCarregamento = null;

        public static void IniciarCarregamento(Action metodoNoFinal = null)
        {
            _metodoFimDoCarregamento = metodoNoFinal;
            var _threadAguarde = new Thread(CarregandoPorThread) { IsBackground = true };
            _threadAguarde.SetApartmentState(ApartmentState.STA);
            _threadAguarde.Start();
        }

        private static void CarregandoPorThread()
        {
            try
            {
                _background = new F_BackgroundAguarde();
                _background.Show();
                _background.Enabled = false;
                _background.TopMost = true;

                _telaAguarde = new F_Aguarde
                {
                    TopMost = true
                };
                _telaAguarde.BringToFront();
                _telaAguarde.ShowDialog();
            }
            catch
            {
                // ignored
            }
        }

        public static void FimCarregamento()
        {
            FecharFormulario();
            //_threadAguarde.Abort();
            Application.DoEvents();

            _metodoFimDoCarregamento?.Invoke();
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
                        //_threadAguarde.Interrupt();
                    }
                }
            }
            catch
            {
                //_threadAguarde.Abort();
            }
        }
    }
}