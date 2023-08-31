using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp
{
    /// <summary>
    ///      Lista de Bancos
    /// </summary>
    public partial class BancoLista : Form
    {
        private AguardeForm fAguarde = new AguardeForm();
        public BancoLista()
        {
            InitializeComponent();
            Application.DoEvents();

            fAguarde.cMensagem = "Selecionando dados no servidor...";

            Filtros();
        }

        void Filtros()
        {
            //List<Combo> list = new List<Combo>();
            //list.Add(new Combo { ID = 0, Nome = "ID" });
            //list.Add(new Combo { ID = 1, Nome = "Código Febraban" });
            //list.Add(new Combo { ID = 2, Nome = "Nome" });

            //campoComboBox.DisplayMember = "Nome";
            //campoComboBox.ValueMember = "ID";
            //campoComboBox.DataSource = list;
        }
        private void AtualizaGrid()
        {
            fAguarde.Show();
            Application.DoEvents();
            /*
             * criar a instancia de BancoDAO e utilizar o metodo Listar
            */
            var bancos = new BancoDAO().Listar();

            /*
            * para utilizar  o Count() deve utilizar o  using System.Linq
            */
            //textBoxQuantRegistros.Text = "Registros: " + bancos.Count().ToString();

            /*
            * adicionar o retorno de Listar() ao DataSource do dataGridView1 
            */
            dataGridView1.DataSource = bancos;

            Application.DoEvents();
            fAguarde.Hide();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            // fecha a tela
            //************************************************
            Close(); 
        }

        private void BancoGridForm_Load(object sender, EventArgs e)
        {
            // atualizar os dados do grid
            //************************************************
            //AtualizaGrid();
        }

        private void BancoGridForm_Shown(object sender, EventArgs e)
        {
            // atualizar os dados do grid
            //************************************************
            AtualizaGrid();
        }


        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            // atualizar os dados do grid
            //************************************************
            AtualizaGrid();
        }

        private void VoltarToolStripButton_Click(object sender, EventArgs e)
        {
            // fecha a tela
            //************************************************
            Close();
        }

        private void NovoToolStripButton_Click(object sender, EventArgs e)
        {
            // chama o form para inclusão
            //************************************************
            BancoForm fManu = new BancoForm(OperacaoEnum.Inclusao, "0");
            fManu.ShowDialog();
            if (fManu.DialogResult == DialogResult.OK)
            {
                // atualizar os dados do grid
                //************************************************
                AtualizaGrid();
            }
            fManu.Dispose();
        }

        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            string id;
            try
            {
                //id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar o registro");
                return;
            }

            // chama o form para alteração
            //************************************************
            BancoForm fManu = new BancoForm(OperacaoEnum.Alteracao, id);
            fManu.ShowDialog();
            if (fManu.DialogResult == DialogResult.OK)
            {
                // atualizar os dados do grid
                //************************************************
                AtualizaGrid();
            }
            fManu.Dispose();
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            string id;
            try
            {
                //id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar o registro");
                return;
            }

            // chama o form para exclusão
            //************************************************
            BancoForm fManu = new BancoForm(OperacaoEnum.Exclusao, id);
            fManu.ShowDialog();
            if (fManu.DialogResult == DialogResult.OK)
            {
                // atualizar os dados do grid
                //************************************************
                AtualizaGrid();
            }
            fManu.Dispose();
        }

    }
}
