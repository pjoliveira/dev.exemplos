using System;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp
{
    /// <summary>
    ///    form de consulta ao CEP digitado. 
    /// </summary>
    public partial class BuscaCEPForm : Form
    {
        public BuscaCEPForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        /// <summary>
        ///    executa consulta ao CEP digitado. 
        /// </summary>
        private void BuscaCEPButton_Click(object sender, EventArgs e)
        {

            AguardeForm fAguarde = new AguardeForm
            {
                cMensagem = "Localizando VIACEP..."
            };
            fAguarde.Show();
            Application.DoEvents();

            
            textBoxJson.Text = APPViacepBuscar(); // retorna um json
          
            CepModel cep = JsonSerializer.Deserialize<CepModel>(json: textBoxJson.Text);
            
            textBoxLogradouro.Text = cep.logradouro;
            textBoxBairro.Text = cep.bairro;
            textBoxComplemento.Text = cep.complemento;
            textBoxLocalidade.Text = cep.localidade;
            textBoxUF.Text = cep.uf;

            Application.DoEvents();
            fAguarde.Hide();

        }

        private string APPViacepBuscar()
        {
            //
            RestClient client = new RestClient
            {
                EndPoint = "http://viacep.com.br/ws/"
            };

            client.Request(BuscarTextBox.Text.Trim());
            Application.DoEvents();

            string RetResponse = client.Response();

            return RetResponse; 
        }

   
    }
}
