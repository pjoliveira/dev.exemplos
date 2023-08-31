using Newtonsoft.Json;

namespace BancosAPI.Servico.Requisicoes
{
    /// <summary>
    /// Indica que o recurso da requisição pode ser editado.
    /// </summary>
    public abstract class EditavelRequisicao : RequisicaoBase
    {
        /// <summary>
        /// Identificação do recurso para efetuar a edição/atualização.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Indica se a requisição é um novo recurso a ser criado.
        /// </summary>
        [JsonIgnore]
        public bool NovoRecurso => Id == 0;
    }
}
