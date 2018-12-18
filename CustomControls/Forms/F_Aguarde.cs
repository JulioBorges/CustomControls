#region

using System;
using System.Windows.Forms;

#endregion

namespace CustomControls.Forms
{
    public partial class F_Aguarde : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams lcreateParams = base.CreateParams;

                if (Environment.OSVersion.Version.Major >= 6)
                    lcreateParams.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED

                return lcreateParams;
            }
        }

        public F_Aguarde()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
    }
}