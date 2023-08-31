using Flunt.Notifications;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace BancosAPI.Servico.Resultado
{
    /// <summary>
    /// Padronização das respostas.
    /// </summary>
    public class Resultado
    {
        public Resultado()
        {
            Erros = Enumerable.Empty<Notification>();
        }

        public Resultado(string mensagem, bool bemSucedido)
        {
            Mensagem = mensagem;
            BemSucedido = bemSucedido;
        }

        /// <summary>
        /// Mensagem (Opcional).
        /// </summary>
        [JsonProperty(Order = 0)]
        public string Mensagem { get; protected set; }

        /// <summary>
        /// Quando verdadeiro, indica que a requisição foi bem-sucedida.
        /// </summary>
        [JsonProperty(Order = 1)]
        public bool BemSucedido { get; protected set; }

        /// <summary>
        /// Indica que o recurso (exemplo: registro na base de dados) não foi encontrado.
        /// </summary>
        [JsonIgnore]
        public bool RecursoNaoEncontrado { get; protected set; }

        /// <summary>
        /// Lista com os erros da requisição (Opcional).
        /// </summary>
        [JsonProperty(Order = 2)]
        public IEnumerable<Notification> Erros { get; protected set; }

        public Resultado Falha(string mensagem)
        {
            BemSucedido = false;
            Mensagem = mensagem;
            return this;
        }

        public Resultado Falha(string mensagem, bool recursoNaoEncontrado)
        {
            BemSucedido = false;
            Mensagem = mensagem;
            RecursoNaoEncontrado = recursoNaoEncontrado;
            return this;
        }

        public Resultado Falha(string mensagem, bool recursoNaoEncontrado, IEnumerable<Notification> notificacoes)
        {
            BemSucedido = false;
            Mensagem = mensagem;
            RecursoNaoEncontrado = recursoNaoEncontrado;
            Erros = notificacoes;
            return this;
        }

        public Resultado Falha(string mensagem, IEnumerable<Notification> notificacoes)
        {
            BemSucedido = false;
            Mensagem = mensagem;
            Erros = notificacoes;
            return this;
        }

        public Resultado Falha(IEnumerable<Notification> notificacoes)
        {
            BemSucedido = false;
            Mensagem = "Requisição inválida.";
            Erros = notificacoes;
            return this;
        }

        public Resultado Sucesso()
        {
            BemSucedido = true;
            return this;
        }

        public Resultado Sucesso(string mensagem)
        {
            BemSucedido = true;
            Mensagem = mensagem;
            return this;
        }
    }

    public class Resultado<T> : Resultado
    {
        [JsonProperty(Order = 3, Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public T Dados { get; private set; }

        public new Resultado<T> Falha(string mensagem)
        {
            BemSucedido = false;
            Mensagem = mensagem;
            return this;
        }

        public new Resultado<T> Falha(string mensagem, bool recursoNaoEncontrado)
        {
            BemSucedido = false;
            Mensagem = mensagem;
            RecursoNaoEncontrado = recursoNaoEncontrado;
            return this;
        }

        public new Resultado<T> Falha(string mensagem, bool recursoNaoEncontrado, IEnumerable<Notification> notificacoes)
        {
            BemSucedido = false;
            Mensagem = mensagem;
            RecursoNaoEncontrado = recursoNaoEncontrado;
            Erros = notificacoes;
            return this;
        }

        public new Resultado<T> Falha(string mensagem, IEnumerable<Notification> notificacoes)
        {
            BemSucedido = false;
            Mensagem = mensagem;
            Erros = notificacoes;
            return this;
        }

        public new Resultado<T> Falha(IEnumerable<Notification> notificacoes)
        {
            BemSucedido = false;
            Mensagem = "Requisição inválida.";
            Erros = notificacoes;
            return this;
        }

        public Resultado<T> Sucesso(T dados)
        {
            BemSucedido = true;
            Dados = dados;
            return this;
        }

        public Resultado<T> Sucesso(string mensagem, T dados)
        {
            BemSucedido = true;
            Mensagem = mensagem;
            Dados = dados;
            return this;
        }
    }
}