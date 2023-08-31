using System;
using System.Windows.Forms;

namespace WinFormsApp
{

    /// <summary>
    ///      Utilizada para mostrar um tela de aguarde
    ///    
    /// </summary>
    public partial class AguardeForm : Form
    {
        public String cMensagem = "";
        public AguardeForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        public AguardeForm(string pmensagem)
        {
            InitializeComponent();
            Application.DoEvents();

            cMensagem = pmensagem; 

        }

        private void FechaWindowButton_Click(object sender, EventArgs e)
        {
            // 
        }

        private void AguardeForm_Load(object sender, EventArgs e)
        {
            //            
        }

        private void AguardeForm_Shown(object sender, EventArgs e)
        {
            mensagemLabel.Text = cMensagem;
            //LoadingPictureBox.
            Application.DoEvents();
        }
    }
}
