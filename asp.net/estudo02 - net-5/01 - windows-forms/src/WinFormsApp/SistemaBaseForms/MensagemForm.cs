using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaBaseForms
{
    /// <summary>
    ///      Classe para mostrar uma pergunta ou uma informação para o usuario.
    /// </summary>
    public partial class MensagemForm : Form
    {
        private TipoMensagemEnum tipoMensagem;
        private string cMensagem1 = "";
        private string cMensagem2 = "";
        public MensagemForm(TipoMensagemEnum tipoMensagem, string texto1, string texto2 = null)
        {
            InitializeComponent();
            Application.DoEvents();
            this.tipoMensagem = tipoMensagem;
            cMensagem1 = texto1;
            cMensagem2 = texto2;
        }

        private void MensagemForm_Load(object sender, EventArgs e)
        {
            imagemAlertaPictureBox.Visible = false;
            imagemPerguntapictureBox.Visible = false;
            imagemErroPictureBox.Visible = false;

            if (cMensagem2 == null)
            {
                panelMensagem2OBS.Visible = false;
                //obsTituloLabel.Visible = false;
                //ObsTextoLabel.Visible = false;
            }

            switch (tipoMensagem)
            {
                case TipoMensagemEnum.Pergunta:
                imagemPerguntapictureBox.Visible = true;
                imagemPerguntapictureBox.Size = new Size(140, 145);

                CancelarButton.Visible = true;
                ConfirmarButton.Text = "Confirmar";

                perguntaTituloLabel.Text = "P E R G U N T A";
                PerguntaTextoLabel.Text = cMensagem1;

                obsTituloLabel.Text = "O B S.";
                ObsTextoLabel.Text = cMensagem2;

                break;
                case TipoMensagemEnum.Erro:
                imagemErroPictureBox.Visible = true;
                imagemErroPictureBox.Size = new Size(140, 145);

                CancelarButton.Visible = false;
                ConfirmarButton.Text = "OK";

                perguntaTituloLabel.Text = "V E R I F I Q U E";
                PerguntaTextoLabel.Text = cMensagem1;

                obsTituloLabel.Text = "S O L U Ç Ã O";
                ObsTextoLabel.Text = cMensagem2;

                break;
                case TipoMensagemEnum.Aviso:
                default:
                imagemAlertaPictureBox.Visible = true;
                imagemAlertaPictureBox.Size = new Size(140, 145);

                CancelarButton.Visible = false;
                ConfirmarButton.Text = "OK";

                perguntaTituloLabel.Text = "V E R I F I Q U E";
                PerguntaTextoLabel.Text = cMensagem1;

                obsTituloLabel.Text = "S O L U Ç Ã O";
                ObsTextoLabel.Text = cMensagem2;
                break;
                case TipoMensagemEnum.Informacao:
                MessageBox.Show("FAZER");
                //imagemAlertaPictureBox.Visible = true;
                //imagemAlertaPictureBox.Size = new Size(140, 145);

                //CancelarButton.Visible = false;
                //ConfirmarButton.Text = "OK";

                //perguntaTituloLabel.Text = "INFORMAÇÃO";
                //PerguntaTextoLabel.Text = cMensagem1;

                //obsTituloLabel.Text = "S O L U Ç Ã O";
                //ObsTextoLabel.Text = cMensagem2;
                break;
            }
        }

        private void FecharWindowButton_Click(object sender, EventArgs e)
        {
            CancelarButton.PerformClick(); 
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; 
            Close(); 
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close(); 
        }
    }
}
