using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp
{
    /// <summary>
    ///      Tela da Lista de Bancos
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

        /// <summary>
        ///      Prepara os filtros da tela com base no FiltroBancoEnum
        /// </summary>
        void Filtros()
        {
            List<ComboLista> Filtrolist = new List<ComboLista>();

            // Enum com o filtro da lista
            //************************************************
            foreach (int iCont in Enum.GetValues(typeof(FiltroBancoEnum)))
            {
                Filtrolist.Add(new ComboLista { Nome = Enum.GetName(typeof(FiltroBancoEnum), iCont), ID = iCont });
            };

            campoComboBox.DisplayMember = "Nome";
            campoComboBox.ValueMember = "ID";
            campoComboBox.DataSource = Filtrolist;
        }

        /// <summary>
        ///      Atualiza os dados no Grid
        /// </summary>
        private void AtualizaGrid()
        {
            fAguarde.Show();
            Application.DoEvents();

            /*
            * obter o idFiltro 
            * 
            */
            int idFiltro = Convert.ToInt32(campoComboBox.SelectedValue.ToString());

            /*
            * criar a instancia de BancoDAO e utilizar o metodo Listar
            * 
            */
            var bancos = new BancoDAO().Listar(idFiltro, BuscarTextBox.Text.Trim());

            /*
            * para utilizar  o Count() deve utilizar o  using System.Linq
            * 
            */
            //textBoxQuantRegistros.Text = "Registros: " + bancos.Count().ToString();

            /*
            * adicionar o retorno de Listar() ao DataSource do dataGridView1 
            * 
            */
            dataGridView1.DataSource = bancos;

            Application.DoEvents();
            fAguarde.Hide();
        }

         private void voltarButton_Click(object sender, EventArgs e)
        {
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
            // fechar a tela
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
                AtualizaGrid();
            }
            fManu.Dispose();
        }

        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            string Codigo;
            try
            {
                //id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar o registro");
                return;
            }

            // chama o form para alteração
            //************************************************
            BancoForm fManu = new BancoForm(OperacaoEnum.Alteracao, Codigo);
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
            string Codigo;
            try
            {
                //id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar o registro");
                return;
            }

            // chama o form para exclusão
            //************************************************
            BancoForm fManu = new BancoForm(OperacaoEnum.Exclusao, Codigo);
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
