using BusinessCadastros;
using SistemaBaseForms;
using SistemaCore;
using SistemaServices;
using System;
using System.Windows.Forms;


namespace ModuloCadastros
{
    public partial class ClasseLista : BaseFormLista
    {
        // manipulação do banco de dados
        //************************************************
        private readonly ClasseService servico = new ClasseService();

        // form de aguarde
        //************************************************
        private AguardeForm fAguarde;

        public ClasseLista()
        {
            InitializeComponent();
            Application.DoEvents();

            fAguarde.cMensagem = "Selecionando dados no servidor...";

            Filtros();
        }

        private void FecharTela()
        {
            Close();
        }

        private void AbreManutencaoForm(OperacaoEnum operacaoEnum, int id)
        {

            ClasseForm fManu = new ClasseForm(operacaoEnum, id);
            fManu.ShowDialog();
            if (fManu.DialogResult == DialogResult.OK)
            {
                AtualizarGrid();
            }
            fManu.Dispose();

        }

        private void Filtros()
        {
            comboBoxOpcaoFiltro.DisplayMember = "Nome";
            comboBoxOpcaoFiltro.ValueMember = "ID";

            comboBoxOpcaoFiltro.DataSource = servico.ComboBoxFields();

        }

        private int GetDataGridColunaValue()
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao selecionar o registro " + ex.Message, "Erro");
                new MensagemForm(TipoMensagemEnum.Erro, "Erro:\n" + ex.Message).ShowDialog();


            }

            return id;


        }
        private void AtualizarGrid()
        {
            fAguarde = new AguardeForm();
            fAguarde.cMensagem = "Selecionando dados no servidor...";
            fAguarde.Show();
            Application.DoEvents();

            int idFiltro = comboBoxOpcaoFiltro.SelectedValue.ToString().ToInt32();

            dataGridView.DataSource = servico.FiltrarLista(idFiltro, textBoxFiltro.Text.Trim());

            Application.DoEvents();
            fAguarde.Close();

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void ClasseLista_Load(object sender, EventArgs e)
        {
            ClasseRepository rep = new ClasseRepository(ConexaoService.GetConnectionString());
            dataGridView.DataSource = rep.Lista(); 

        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            // chama o form para inclusão
            //************************************************
            AbreManutencaoForm(OperacaoEnum.Inclusao, 0);

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id = GetDataGridColunaValue();

            // chama o form para alteração
            //************************************************
            AbreManutencaoForm(OperacaoEnum.Alteracao, id);
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = GetDataGridColunaValue();

            // chama o form para exclusão
            //************************************************
            AbreManutencaoForm(OperacaoEnum.Exclusao, id);
        }
    }
}
