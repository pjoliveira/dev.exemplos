using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancosAPI.Servico.Respostas
{
    //Respostas é o mesmo que viewModel
    //**********************************************

    /// <summary>
    /// Classe ViewModel
    /// </summary>
    public class BancoResposta
    {

        public string ID { get; set; }

        public string Nome { get; set; }

        public string Fantasia { get; set; }

        public string EmpresaID { get; set; }
    }
}
