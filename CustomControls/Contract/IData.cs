using System.Windows.Forms;

namespace CustomControls.Contract
{
    public interface IData
    {
        string Campo { get; set; }

        string Propriedade { get; set; }

        BindingSource FonteDados { get; set; }
    }
}
