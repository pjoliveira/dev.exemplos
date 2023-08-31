using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonConectarDesconectar_Click(object sender, EventArgs e)
        {
            /*
            * para conectar ao banco de dados.
            * 
            */

            var db = new ConexaoSqlite().ConexaoDB;

            db.Open();

            textBox1.Text = db.ConnectionString; 

            db.Close();


        }
    }
}
