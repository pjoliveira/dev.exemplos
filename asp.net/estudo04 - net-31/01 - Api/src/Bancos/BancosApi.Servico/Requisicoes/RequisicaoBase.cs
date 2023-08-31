//using Flunt.Notifications;

namespace BancosAPI.Servico.Requisicoes
{
    /// <summary>
    /// Classe base usada pelas requisições da API.
    /// </summary>
    public abstract class RequisicaoBase //: Notifiable
    {
        /// <summary>
        /// Valida a requisição.
        /// </summary>
        public abstract void Validar();
    }
}