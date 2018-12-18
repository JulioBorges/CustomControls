using System.Collections.Generic;
using System.ComponentModel;

namespace CustomControls.Data
{
    public partial class DataComboBoxUF : DataComboBox
    {
        public DataComboBoxUF()
        {
            InitializeComponent();
        }

        public DataComboBoxUF(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            CarregaComboboxUF();
        }

        public void CarregaComboboxUF()
        {
            var lista = new List<Estado>
                            {
                                new Estado
                                    {
                                        UF = "AC"
                                    },
                                new Estado
                                    {
                                        UF = "AL"
                                    },
                                new Estado
                                    {
                                        UF = "AP"
                                    },
                                new Estado
                                    {
                                        UF = "AM"
                                    },
                                new Estado
                                    {
                                        UF = "BA"
                                    },
                                new Estado
                                    {
                                        UF = "CE"
                                    },
                                new Estado
                                    {
                                        UF = "DF"
                                    },
                                new Estado
                                    {
                                        UF = "ES"
                                    },
                                new Estado
                                    {
                                        UF = "GO"
                                    },
                                new Estado
                                    {
                                        UF = "MA"
                                    },
                                new Estado
                                    {
                                        UF = "MT"
                                    },
                                new Estado
                                    {
                                        UF = "MS"
                                    },
                                new Estado
                                    {
                                        UF = "MG"
                                    },
                                new Estado
                                    {
                                        UF = "PA"
                                    },
                                new Estado
                                    {
                                        UF = "PB"
                                    },
                                new Estado
                                    {
                                        UF = "PE"
                                    },
                                new Estado
                                    {
                                        UF = "PI"
                                    },
                                new Estado
                                    {
                                        UF = "PR"
                                    },
                                new Estado
                                    {
                                        UF = "RJ"
                                    },
                                new Estado
                                    {
                                        UF = "RN"
                                    },
                                new Estado
                                    {
                                        UF = "RS"
                                    },
                                new Estado
                                    {
                                        UF = "RO"
                                    },
                                new Estado
                                    {
                                        UF = "RR"
                                    },
                                new Estado
                                    {
                                        UF = "SC"
                                    },
                                new Estado
                                    {
                                        UF = "SP"
                                    },
                                new Estado
                                    {
                                        UF = "SE"
                                    },
                                new Estado
                                    {
                                        UF = "TO"
                                    },
                            };

            DataSource = lista;
            DisplayMember = "UF";
            ValueMember = "UF";
        }
    }

    struct Estado
    {
        public string UF { get; set; }
    }
}
