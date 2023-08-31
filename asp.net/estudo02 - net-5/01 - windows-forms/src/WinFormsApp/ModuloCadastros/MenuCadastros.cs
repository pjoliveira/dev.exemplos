using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloCadastros;
using MenuServices; 

namespace SistemaMenus
{
    public partial class MenuCadastros : Form
    {
        public MenuCadastros()
        {
            InitializeComponent();
        }

        private void MenuCadastros_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            MenuService.AbrirForm<ClasseLista>(panelForms);
        }
    }
}
