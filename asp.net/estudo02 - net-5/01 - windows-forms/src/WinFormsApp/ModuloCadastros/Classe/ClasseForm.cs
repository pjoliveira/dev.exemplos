using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBaseForms;
using SistemaCore;
using SistemaServices;

namespace ModuloCadastros
{
    public partial class ClasseForm : BaseFormCadastro
    {
        // manipulação do banco de dados
        //************************************************
        private readonly ClasseService servico = new ClasseService();
        private readonly OperacaoEnum operacaoEnum;

        public ClasseForm()
        {
            InitializeComponent();
            Application.DoEvents();

            labelTitulo.Text = "Classe - Novo ";
            TextBoxID.Text = "Automático";
            TextBoxID.ReadOnly = true;
            TextBoxDescricao.Focus();

            this.operacaoEnum = OperacaoEnum.Inclusao;

            servico.NewModel();

        }

        public ClasseForm(OperacaoEnum operacaoEnum, int idBanco)
        {
            InitializeComponent();
            Application.DoEvents();

            this.operacaoEnum = operacaoEnum;

            switch (operacaoEnum)
            {
                case OperacaoEnum.Inclusao:
                    labelTitulo.Text = "Classe - Novo ";
                    TextBoxID.Text = "Automático";
                    break;

                case OperacaoEnum.Alteracao:
                    labelTitulo.Text = "Classe - Alteração ";
                    break;

                case OperacaoEnum.Exclusao:
                    labelTitulo.Text = "Classe - Exclusão ";
                    TextBoxID.ReadOnly = true;
                    TextBoxDescricao.ReadOnly = true;
                    TextBoxEmpresaID.ReadOnly = true;
                    break;

                default:
                    MessageBox.Show("Operação não definida!");
                    return;
            }

            servico.DataRepositorio = servico.BuscarID(idBanco);
            if (servico.DataRepositorio == null)
            {
                //tituloLabel.Text = "Banco - Novo ";
                //IDtextBox.Text = "Automático";
                TextBoxID.ReadOnly = true;
                TextBoxDescricao.Focus();

                TextBoxEmpresaID.ReadOnly = true;
                //TextBoxEmpresaID.Text = SistemaService.EmpresaLogada.ID;

                //banco = new Banco();
                servico.NewModel();
            }
            else
            {
                TextBoxID.ReadOnly = true;
                TextBoxDescricao.Focus();

                TextBoxID.Text = servico.DataRepositorio.ID.ToString();
                TextBoxDescricao.Text = servico.DataRepositorio.Nome;
                TextBoxEmpresaID.Text = servico.DataRepositorio.EmpresaId;
            }

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            //
            Close();
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            // coloca os dados no objeto banco
            //************************************************
            servico.DataRepositorio.Nome = TextBoxDescricao.Text.Trim();
            servico.DataRepositorio.EmpresaId = TextBoxEmpresaID.Text.Trim();

            // Valida dados 
            //************************************************
            string cErro = servico.ValidateModel();
            if (!cErro.Trim().IsNullOrEmpty())
            {
                new MensagemForm(TipoMensagemEnum.Erro, cErro).ShowDialog();
                return;
            }

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


            if (result == DialogResult.OK)
            {
                // Se clicou no confirmar da Pergunta 
                //************************************************
                DialogResult = DialogResult.OK;
                int resultado;

                if (operacaoEnum == OperacaoEnum.Exclusao)
                {
                    // efetua a exclusão do registro 
                    //************************************************
                    resultado = servico.Excluir(servico.DataRepositorio.ID);
                }
                else
                {
                    // coloca os dados no objeto banco
                    //************************************************
                    servico.DataRepositorio.Nome = TextBoxDescricao.Text.Trim();
                    servico.DataRepositorio.EmpresaId = TextBoxEmpresaID.Text.Trim();

                    // salva os dados do objeto no banco de dados
                    //************************************************
                    resultado = servico.Salvar(operacaoEnum);
                }


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

                    // mostra uma mensagem 
                    //************************************************
                    new MensagemForm(TipoMensagemEnum.Erro, msg).ShowDialog();
                }
                else
                {
                    Close();
                }
            }

        }
    }
}
