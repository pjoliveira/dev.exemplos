using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMenus;
using MenuServices; 

namespace WinFormsApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void FecharAplicacao()
        {
            // se precisar realizar a gravação de log 
            // será feito aqui
            //************************************************


            Application.Exit();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

            

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            // irá fechar da aplicação 
            //************************************************
            FecharAplicacao();
        }

        private void buttonMenuCadastros_Click(object sender, EventArgs e)
        {            

            MenuService.AbrirForm<MenuCadastros>(MenuService.painelMenuLateral);
        }

        private void buttonMenuParametros_Click(object sender, EventArgs e)
        {

            MenuService.AbrirForm<MenuParametros>(MenuService.painelMenuLateral);
        }
    }
}
