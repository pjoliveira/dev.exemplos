using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // fechar a aplicação
            // ************************************************
            Application.Exit();
        }

        private void BancosButton_Click(object sender, EventArgs e)
        {
            // chama o form para inclusão
            // ************************************************
            new BancoLista().ShowDialog();
          
        }
    }
}
