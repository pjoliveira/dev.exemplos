using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    /// <summary>
    ///      Classe realizar o CRUD de Bancos
    /// </summary>
    public partial class BancoForm : Form
    {

        private readonly OperacaoEnum operacaoEnum;

        public BancoForm()
        {
            InitializeComponent();
            Application.DoEvents();

            tituloLabel.Text = "Banco - Novo ";
            IDtextBox.Text = "Automático";
            IDtextBox.ReadOnly = true;
            nomeTextBox.Focus();

            //this.operacaoEnum = OperacaoEnum.Inclusao;
        }

        public BancoForm(OperacaoEnum operacaoEnum, string Codigo)
        {
            InitializeComponent();
            Application.DoEvents();

            this.operacaoEnum = operacaoEnum;

            switch (operacaoEnum)
            {
                case OperacaoEnum.Inclusao:
                    tituloLabel.Text = "Banco - Novo ";
                    IDtextBox.Text = "Automático";
                break;

                case OperacaoEnum.Alteracao:
                    tituloLabel.Text = "Banco - Alteração ";
                break;

                case OperacaoEnum.Exclusao:
                    tituloLabel.Text = "Banco - Exclusão ";
                    IDtextBox.ReadOnly = true;
                    codfebrabanTextBox.ReadOnly = true;
                    nomeTextBox.ReadOnly = true;
                    nomeRTextBox.ReadOnly = true;
                    idEmpresaTextBox.ReadOnly = true;
                break;

                default:
                    MessageBox.Show("Operação não definida!");
                return;
            }

            
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Cancel;
            
            if (operacaoEnum == OperacaoEnum.Inclusao || operacaoEnum == OperacaoEnum.Alteracao)
            {
                // pergunta se que mesmo gravar o registro
                //************************************************
                result = new MensagemForm(
                    TipoMensagemEnum.Pergunta,
                    "confirmar a gravação dos dados na tabela?",
                    "Confirmar: salvará os dados. Cancelar: valtará a tela."
                ).ShowDialog();
            }
            
            if (operacaoEnum == OperacaoEnum.Exclusao)
            {
                // Pergutna se quer mesmo excluir o registro 
                //************************************************
                result = new MensagemForm(
                  TipoMensagemEnum.Pergunta,
                  "confirmar a exclusão dos dados na tabela?",
                  "Confirmar: excluirá os dados. Cancelar: valtará a tela."
              ).ShowDialog();
            }

            
        }

        private void BancoManuForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BancoManuForm_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
                // como não sair um som quando troca de campo com o ENTER?
            }
        }

    }
}