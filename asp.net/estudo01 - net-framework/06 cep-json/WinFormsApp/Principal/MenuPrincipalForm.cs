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

        private void buttonMenu_Click(object sender, EventArgs e)
        {
          
        }

        private void menuStripPrincipal_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void BancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void BancosButton_Click(object sender, EventArgs e)
        {
            // chama o form para inclusão
            // ************************************************
            new BancoLista().ShowDialog();
          
        }

        private void PaisButton_Click(object sender, EventArgs e)
        {
            // chama o form para inclusão
            // ************************************************
            //new PaisLista().ShowDialog();
        }

        private void BuscaCepButton_Click(object sender, EventArgs e)
        {
            // chama o form CEP
            // ************************************************
            _ = new BuscaCEPForm().ShowDialog();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
