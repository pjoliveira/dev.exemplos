using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    /// <summary>
    ///      Classe realizar o CRUD de Bancos
    /// </summary>
    public partial class BancoForm : Form
    {
        BancoDAO bancoDAO = new BancoDAO();
        Banco banco = null ;
        private readonly OperacaoEnum operacaoEnum;

        /// <summary>
        ///      Contrutor da classe 
        /// </summary>
        public BancoForm()
        {
            InitializeComponent();
            Application.DoEvents();

            tituloLabel.Text = "Banco - Novo ";
            //IDtextBox.Text = "Automático";
            //IDtextBox.ReadOnly = true;
            nomeTextBox.Focus();

            this.operacaoEnum = OperacaoEnum.Inclusao;
        }

        /// <summary>
        ///      Ccontrutor da classe
        /// </summary>
        public BancoForm(OperacaoEnum operacaoEnum, string Codigo)
        {
            InitializeComponent();
            Application.DoEvents();

            this.operacaoEnum = operacaoEnum;

            switch (operacaoEnum)
            {
                case OperacaoEnum.Inclusao:
                    tituloLabel.Text = "Banco - Novo ";
                    
                break;

                case OperacaoEnum.Alteracao:
                    tituloLabel.Text = "Banco - Alteração ";

                    codfebrabanTextBox.ReadOnly = false; 
                break;

                case OperacaoEnum.Exclusao:
                    tituloLabel.Text = "Banco - Exclusão ";
                    
                    codfebrabanTextBox.ReadOnly = true;
                    nomeTextBox.ReadOnly = true;
                    nomeRTextBox.ReadOnly = true;
                    idEmpresaTextBox.ReadOnly = true;
                break;

                default:
                    MessageBox.Show("Operação não definida!");
                return;
            }

            // localizar o registro pelo Codigo passado 
            // no Contrutor
            //************************************************
            banco = bancoDAO.BuscarID(Codigo);
            if (banco == null)
            {
                // não localizou o Codigo
                //************************************************
                //tituloLabel.Text = "Banco - Novo ";                
                codfebrabanTextBox.Focus();
                
                idEmpresaTextBox.ReadOnly = true;
                //idEmpresaTextBox.Text = Compartilhada.EmpresaLogada.ID;
                
                banco = new Banco();
            }
            else
            {
                // Localizou o Codigo
                //************************************************
                codfebrabanTextBox.ReadOnly = true;
                codfebrabanTextBox.Focus();

                codfebrabanTextBox.Text = banco.Codigo;
                nomeTextBox.Text = banco.Nome;
                nomeRTextBox.Text = banco.Fantasia;
                idEmpresaTextBox.Text = banco.IdEmpresa;

            }
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            // fecha a tela
            //************************************************
            Close();
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            // inicializa o result com CANCEL
            //************************************************
            DialogResult result = DialogResult.Cancel;

            // Verificar se é INCLUSÃO ou ALTERAÇÃO
            //************************************************
            if (operacaoEnum == OperacaoEnum.Inclusao || operacaoEnum == OperacaoEnum.Alteracao)
            {
                // CONFIRMA se quer mesmo gravar o registro
                // e recebe o RESULT do MensagemForm 
                //************************************************
                result = new MensagemForm(
                    TipoMensagemEnum.Pergunta,
                    "confirmar a gravação dos dados na tabela?",
                    "Confirmar: salvará os dados. Cancelar: valtará a tela."
                ).ShowDialog();
            }

            // Verificar se é EXCLUSÃO
            //************************************************
            if (operacaoEnum == OperacaoEnum.Exclusao)
            {
                // CONFIRMA se quer mesmo excluir o registro 
                // e recebe o RESULT do MensagemForm
                //************************************************
                result = new MensagemForm(
                  TipoMensagemEnum.Pergunta,
                  "confirmar a exclusão dos dados na tabela?",
                  "Confirmar: excluirá os dados. Cancelar: valtará a tela."
              ).ShowDialog();
            }
            // clicou no confirmar do MensagemForm
            //************************************************
            if (result == DialogResult.OK)
            {
                // passar ok para o DialogResult desta tela
                //************************************************
                DialogResult = DialogResult.OK;
                int resultado;

                // Verifica a operação corrente
                //************************************************
                if (operacaoEnum == OperacaoEnum.Exclusao)
                {
                    // efetua a exclusão do registro 
                    // resultado será igual ao numero de registros 
                    // afetados pela operação
                    //************************************************
                    resultado = bancoDAO.Excluir(banco.Codigo);
                }
                else
                {
                    // coloca os dados na clase banco
                    //************************************************
                    banco.Codigo = codfebrabanTextBox.Text.Trim();
                    banco.Nome = nomeTextBox.Text.Trim();
                    banco.Fantasia = nomeRTextBox.Text.Trim();
                    banco.IdEmpresa = idEmpresaTextBox.Text.Trim();
                    
                    // salva os dados da classe na tabela
                    // resultado será igual ao numero de registros 
                    // afetados pela operação
                    //************************************************
                    resultado = bancoDAO.Salvar(operacaoEnum, banco);
                }

                // Quando resultado == 0
                // ocorreu erro.
                //************************************************
                if (resultado == 0)
                {
                    string msg;
                    // quando encontrar algum erro 
                    //************************************************
                    if (operacaoEnum == OperacaoEnum.Inclusao)
                        msg = "Erro na Inclusão desse registro.";
                    else if (operacaoEnum == OperacaoEnum.Alteracao)
                        msg = "Erro na alteração dos dados.";
                    else
                        msg = "Erro na Exclusão desse registro.";

                    // mostra uma mensagem de erro.
                    //************************************************
                    new MensagemForm(TipoMensagemEnum.Erro, msg).ShowDialog();
                }
                else
                {
                    // Fecha a tela
                    //************************************************
                    Close();
                }

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