using Dapper;
using System.Collections.Generic;

namespace WinFormsApp
{
    /// <summary>
    ///  Essa classe trata os dados diretamente com a banco de dados
    ///  Para funcionar deve instalar o ORM dapper    
    ///      tem quem instalar o package no projeto da dar um using no pacote.
    ///      Install-Package dapper  
    ///      using Dapper;
    /// </summary>
    public class BancoDAO : ConexaoSqlite
    {
        /// <summary>
        /// listar os dados da tabela
        /// </summary>
        public IEnumerable<Banco> Listar()
        {
            using var db = ConexaoDB;

            return db.Query<Banco>(@"SELECT * FROM fnbanco "); 
        }

        /*
        public List<Banco> Listar(int idFiltro, string valor)
        {
            List<Banco> list = new List<Banco>();
            using (var db = ConexaoDB)
            {
                switch ((FiltroBancoEnum)idFiltro)
                {
                    case FiltroBancoEnum.ID:
                        list = db.Query<Banco>(@"SELECT * FROM fnbanco where id = @pid",
                                                new { pId = valor.ToInt32() }).ToList();
                        break;

                    case FiltroBancoEnum.CodigoFebraban:
                        list = db.Query<Banco>(@"SELECT * FROM fnbanco where codfebraban = @pcodfebraban",
                                                                  new { pcodfebraban = valor }).ToList();
                        break;

                    case FiltroBancoEnum.Nome:
                        list = db.Query<Banco>(@"SELECT * FROM fnbanco where nome ilike '%" + valor + "%' ORDER BY nome").ToList();
                        break;
                }
            }
            return list;
        }

        public Banco Buscar(int id)
        {
            using (var db = ConexaoDB)
            {
                return db.Query<Banco>(@"SELECT * FROM fnbanco WHERE Id = @pId",
                                         new { pId = id }).SingleOrDefault();

            }
        }

        public int Salvar(Banco banco)
        {
            try
            {
                using (var db = ConexaoDB)
                {
                    if (banco.ID == 0)
                    {
                        //zero é inclusão
                        return db.Query<int>(@"INSERT INTO fnbanco(codfebraban, nome, nomer, empresa_id) 
                                            VALUES (@codfebraban, @Nome, @nomer, @empresa_id);" + ReturnId, banco).SingleOrDefault();

                    }
                    else
                    {
                        db.Execute(@"UPDATE fnbanco SET Nome = @Nome, Nomer = @Nomer, 
                                                            codfebraban = @CodFebraban, 
                                                            empresa_id = @empresa_id 
                                                            WHERE ID = @ID ", banco);
                        return banco.ID;
                    }
                }
            }
            catch { return 0; }
        }


        public bool Excluir(int id)
        {
            using (var db = ConexaoDB)
            {
                return db.Execute(@"DELETE FROM fnbanco WHERE ID = @pId",
                    new { pId = id }) == 1;

            }
        }
        */
    }
       
}