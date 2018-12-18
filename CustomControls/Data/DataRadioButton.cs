using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CustomControls.Contract;

namespace CustomControls.Data
{
    public partial class DataRadioButton : RadioButton, IData
    {
        public Image ImagemChecked { get; set; }
        public Image ImagemUnChecked { get; set; }

        public DataRadioButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (Checked)
            {
                if (ImagemChecked != null)
                {
                    BackgroundImage = ImagemChecked;
                }
            }
            else
            {
                if (ImagemUnChecked != null)
                {
                    BackgroundImage = ImagemUnChecked;
                }
            }

            base.OnPaint(pe);
        }

        #region Implementation of IData

        [Category("Dados")]
        [Description("Campo da base de dados a ser ligado ao componente")]
        public string Campo { get; set; }

        [Category("Dados")]
        [Description("Propriedade do componente a ser ligada")]
        public string Propriedade { get; set; }

        [Category("Dados")]
        [Description("Binding que é a fonte dos dados")]
        public BindingSource FonteDados { get; set; }

        #endregion
    }
}
