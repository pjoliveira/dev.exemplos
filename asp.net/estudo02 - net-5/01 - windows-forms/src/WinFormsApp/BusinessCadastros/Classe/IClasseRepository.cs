using System.Collections.Generic;
using SistemaCore;


namespace BusinessCadastros
{
    public interface IClasseRepository<T> where T : ClasseModel
    {

        IEnumerable<T> Lista();
        IEnumerable<T> FiltrarLista(int idFiltro, string Valor);
        T BuscarID(int id);
        int Salvar(OperacaoEnum operacao, T item);
        int Excluir(int id);

    }
}