using SistemaCore;
using System.Collections.Generic;

namespace BusinessParametros
{
    public interface IMunicipioRepository<T> where T : MunicipioModel
    {

        IEnumerable<T> Lista();
        IEnumerable<T> FiltrarLista(int idFiltro, string Valor);
        T BuscarID(int id);
        int Salvar(OperacaoEnum operacao, T item);
        int Excluir(int id);

    }
}
