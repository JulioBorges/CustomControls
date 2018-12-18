using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CustomControls.Contract;

namespace CustomControls.Data
{
    public partial class DataTextBox : TextBox, IData
    {
        public DataTextBox()
        {
            InitializeComponent();
            TipoValidacao = TipoTexto.Geral;
            CharacterCasing = CharacterCasing.Upper;
        }

        [Category("Dados")]
        [Description("Tipo de validação de texto")]
        public TipoTexto TipoValidacao { get; set; }


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

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if ((TipoValidacao == TipoTexto.Inteiro) || (TipoValidacao == TipoTexto.Numerico))
            {
                if ((TipoValidacao == TipoTexto.Numerico) && (e.KeyChar == ','))
                {
                    if (ContainsLetra(Text, ',') == 1)
                        e.Handled = true;
                }
                else
                {
                    // Se não é um numero...
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char) 8)
                        e.Handled = true;
                }
            }
        }

        private int ContainsLetra(string str, char wChar)
        {
            char[] charArray = str.ToCharArray();
            IEnumerable<char> query = charArray.Where(letra => letra == wChar);
            return query.Count();
        }
    }

    public enum TipoTexto
    {
        Inteiro,
        Numerico,
        Geral
    }
}