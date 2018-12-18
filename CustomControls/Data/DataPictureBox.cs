using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CustomControls.Forms;
using CustomControls.Contract;

namespace CustomControls.Data
{
    public partial class DataPictureBox : UserControl, IData
    {
        public Action EventoClickBotaoZoom;

        public DataPictureBox()
        {
            InitializeComponent();
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

        [Category("Dados")]
        [Description("Caminho da imagem carregada")]
        public string CaminhoImagem { get; set; }

        [Category("Dados")]
        [Description("Imagem do componente")]
        public Image Imagem
        {
            get
            {
                return pictureBoxData.Image;
            }
            set
            {
                pictureBoxData.Image = value;
            }
        }

        #endregion

        private void ButtonSelecionarClick(object sender, EventArgs e)
        {
            if (openFileDialogImagem.ShowDialog() != DialogResult.OK)
                return;

            pictureBoxData.Image = Image.FromFile(openFileDialogImagem.FileName);
            CaminhoImagem = openFileDialogImagem.FileName;
        }

        private void ToolStripMenuItemExcluirImagemClick(object sender, EventArgs e)
        {
            pictureBoxData.Image = null;
            CaminhoImagem = null;
            pictureBoxData.ImageLocation = null;
        }

        public void ZoomImage()
        {
            if (pictureBoxData.Image == null)
                return;

            FrmVisualizer visualizer;
            using (visualizer = new FrmVisualizer())
            {
                visualizer.imageBoxData.Image = pictureBoxData.Image;
                visualizer.imageBoxData.ZoomToFit();
                visualizer.ShowDialog();
                visualizer.Dispose();
            }
            GC.Collect();
        }
    }
}