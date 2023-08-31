using System;
using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp.CorreiosWSService; 


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

        private void button1_Click(object sender, EventArgs e)
        {
            AguardeForm fAguarde = new AguardeForm
            {
                cMensagem = "Localizando WS CORREIOS..."
            };
            fAguarde.Show();
            Application.DoEvents();

            CepModel cep = APPCorreiosBuscar();
            
            textBoxJson.Text = JsonSerializer.Serialize(cep);

            textBoxLogradouro.Text = cep.logradouro;
            textBoxBairro.Text = cep.bairro;
            textBoxComplemento.Text = cep.complemento;
            textBoxLocalidade.Text = cep.localidade;
            textBoxUF.Text = cep.uf;

            Application.DoEvents();
            fAguarde.Hide();
        }

        private CepModel APPCorreiosBuscar()
        {
            //
            using var ws = new CorreiosWSService.AtendeClienteClient();
            var endereco = ws.consultaCEP(BuscarTextBox.Text.Trim());
            Application.DoEvents();

            CepModel cep = new CepModel();
            cep.bairro = endereco.bairro;
            cep.cep = endereco.cep;
            cep.complemento = endereco.complemento2;
            cep.logradouro = endereco.end;
            cep.uf = endereco.uf;
            cep.localidade = endereco.cidade;             

            return cep;
        }
    }
}
