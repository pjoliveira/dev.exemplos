using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
            Application.DoEvents(); 

        }

        private void toolStripButtonConectarDesconectar_Click(object sender, EventArgs e)
        {
            // para conectar ao banco de dados.

           /*
            * criar a instancia de BancoDAO e utilizar o metodo Listar
            */
            var bancos = new BancoDAO().Listar();

            /*
            * para utilizar  o Count() deve utilizar o  using System.Linq
            */
            textBoxQuantRegistros.Text = "Registros: " + bancos.Count().ToString();

            /*
            * adicionar o retorno de Listar() ao DataSource do dataGridView1 
            */
            dataGridViewBancos.DataSource = bancos;


            Application.DoEvents();

        }

        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
