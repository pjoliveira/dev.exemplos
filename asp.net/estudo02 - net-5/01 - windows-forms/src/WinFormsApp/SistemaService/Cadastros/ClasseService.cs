using BusinessCadastros;
using SistemaCore;
using System;
using System.Collections.Generic;

namespace SistemaServices
{
    /// <summary>
    /// classe static 
    /// para integração das camadas de APLICAÇÃO com as camadas de BUSINESS
    /// </summary>
    public class ClasseService
    {
        // guarda a string de conexão com o banco de dados
        //************************************************
        /// <summary>
        /// guarda a string de conexão utilizado no reposirio.
        /// </summary> 
        private readonly string connectionString = ConexaoService.GetConnectionString();

        // Repositorio
        //************************************************
        /// <summary>
        /// Repositorio de manipulação dos dados.
        /// </summary> 
        private readonly IClasseRepository<ClasseModel> Repositorio;

        // model
        //************************************************
        /// <summary>
        /// Model Responsável por manter os dados
        /// </summary> 
        public ClasseModel DataRepositorio { get; set; }

        /// <summary>
        /// Contrutor da classe 
        /// </summary>
        public ClasseService()
        {
            Repositorio = new ClasseRepository(connectionString);
        }

        /// <summary>
        /// Lista todos os dados da tabela
        /// </summary>
        /// <param></param>
        /// <returns>IEnumerable</returns>
        public IEnumerable<ClasseModel> Lista()
        {
            return Repositorio.Lista();
        }

        /// <summary>
        /// Fitra a lista com base no campo selecionado 
        /// Filtra a lista com base no valor passado 
        /// </summary>
        /// <param name="idFiltro">id do filtro, vem do enum dessa lista</param>
        /// <param name="Valor">Valor a ser filtrado</param>
        /// <returns>IEnumerable</returns>
        public IEnumerable<ClasseModel> FiltrarLista(int idFiltro, string Valor)
        {
            return Repositorio.FiltrarLista(idFiltro, Valor);
        }

        /// <summary>
        /// Busca na tabela apenas o ID indicado.
        /// </summary>
        /// <param name="id">id do registro na respectiva tabela</param>
        /// <returns>BancoModel</returns>
        public ClasseModel BuscarID(int id)
        {
            return Repositorio.BuscarID(id);
        }

        /// <summary>
        /// Salva o registro na tabelas.
        /// Obedece o parametro Operação passado.
        /// </summary>
        /// <param name="operacao">identificação da operação</param>
        /// <returns>Na Inclusão - retorna o ID gerado</returns>
        /// <returns>Na Alteração - retorna o numero de registros alterados</returns>
        public int Salvar(OperacaoEnum operacao)
        {
            return Repositorio.Salvar(operacao, DataRepositorio);
        }

        /// <summary>
        /// Salva o registro na tabelas.
        /// Obedece o parametro Operação passado.
        /// </summary>
        /// <param name="operacao">identificação da operação</param>
        /// <param name="item">Model a ser salvo</param>
        /// <returns>Na Inclusão - retorna o ID gerado</returns>
        /// <returns>Na Alteração - retorna o numero de registros alterados</returns>
        public int Salvar(OperacaoEnum operacao, ClasseModel item)
        {
            return Repositorio.Salvar(operacao, item);
        }

        /// <summary>
        /// Exclui o registro pelo ID indicado.
        /// </summary>
        /// <param name="id">ID do registro na respectiva tabela</param>
        /// <returns>Quantidade registros excluidos</returns>
        public int Excluir(int id)
        {
            return Repositorio.Excluir(id);
        }

        /// <summary>
        /// Cria o novo Model para ModelRepository
        /// </summary>
        /// <returns>null</returns>
        public void NewModel()
        {
            DataRepositorio = new ClasseModel();
        }


        /// <summary>
        /// indica os campos que estarão no combobox do filtro
        /// </summary>
        /// <returns>Ret</returns>
        public IEnumerable<ComboLista> ComboBoxFields()
        {
            //List<Combo> Filtrolist = new List<Combo>();
            //Filtrolist.Add(new Combo { ID = 0, Nome = "ID" });
            //Filtrolist.Add(new Combo { ID = 1, Nome = "Código Febraban" });
            //Filtrolist.Add(new Combo { ID = 2, Nome = "Nome" });

            List<ComboLista> Filtrolist = new List<ComboLista>();

            // Enum - filtro da lista
            //************************************************
            foreach (int iCont in Enum.GetValues(typeof(ClasseEnums)))
            {
                Filtrolist.Add(new ComboLista { Nome = Enum.GetName(typeof(ClasseEnums), iCont), ID = iCont });
            };


            return Filtrolist;
        }

        /// <summary>
        /// Valida o model com base nos DataAnotations na classe.
        /// </summary>
        /// <returns>cErro - string com os erros encontrados</returns>
        public string ValidateModel()
        {
            string cErro = string.Empty;

            ValidateService valida = new ValidateService(DataRepositorio);

            cErro = valida.ValidaModel();

            return cErro;
        }

    }
}
