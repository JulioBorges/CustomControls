using System.ComponentModel;
using System.Windows.Forms;

namespace CustomControls.Data
{
    public partial class DataNavigator : ToolStrip
    {
        [Category("Ajustes")]
        [Description("Fonte de dados referente a navegação")]
        public BindingSource FonteDadosNavegacao { get; set; }

        public DataNavigator()
        {
            InitializeComponent();
        }

        public DataNavigator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
