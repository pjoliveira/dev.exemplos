using SistemaCore;
using System.Collections.Generic;

namespace BusinessParametros
{
    public interface IUsuarioRepository<T> where T : UsuarioModel
    {
        IEnumerable<T> Lista();
        IEnumerable<T> FiltrarLista(int idFiltro, string Valor);
        T BuscarLogin(string email, string senha);
        T BuscarID(int id);
        int Salvar(OperacaoEnum operacao, T item);
        int Excluir(int id);

    }
}
