using System.Linq;
using System.Windows.Forms;

namespace MenuServices
{
    public static class MenuService
    {
        /// <summary>
        /// Guarda o painel do menu lateral.
        /// Deve ser indicado qual é esse painel no Load do Form Princpal
        /// </summary>
        public static Panel painelMenuLateral;

        /// <summary>
        /// Abre um form no painel indicado no parametro
        /// </summary>
        /// <returns>null</returns>
        public static void AbrirForm<Forms>(Panel PainelForm) where Forms : Form, new()
        {
            Form formulario;
            formulario = PainelForm.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PainelForm.Controls.Add(formulario);
                PainelForm.Tag = formulario;
                //formulario.Show();
                //formulario.BringToFront();
            }

            formulario.Show();
            formulario.BringToFront();

        }
    }
}
