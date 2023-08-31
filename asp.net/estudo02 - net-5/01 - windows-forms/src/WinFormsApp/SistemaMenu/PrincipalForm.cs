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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();


        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
           
            MenuService.painelMenuLateral = this.panelForm;

            //MenuService.painelMenuLateral.Hide();
            MenuService.AbrirForm<Menu>(panelForm);

        }
    }
}
