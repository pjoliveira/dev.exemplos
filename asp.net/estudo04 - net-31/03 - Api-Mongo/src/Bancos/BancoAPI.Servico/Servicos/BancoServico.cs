using BancoAPI.Dominio.Entidades;
using BancoAPI.Dominio.RepositorioInterfaces;
using BancoAPI.Servico.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancoAPI.Servico.Servicos
{
    /// <summary>
    /// BancosAPI.Servico
    /// </summary>
    public class BancoServico : IBancoServico
    {
        // propriedade do repositorio.
        //***********************************************************************************************
        private IBancoRepositorio _bancoRepository;

        // propriedade para o mapeamento
        //***********************************************************************************************
        //private readonly IMapper _mapper;

        /// <summary>
        /// contrutor da classe BancoService
        /// </summary>
        public BancoServico(IBancoRepositorio bancoRepository)
        {
            // injeção de dependencia do repositorio
            //***********************************************************************************************
            _bancoRepository = bancoRepository;

        }

        /// <summary>
        /// retorna a lista de bancos
        /// </summary>
        public async Task<IEnumerable<BancoEntidade>> GetLista()
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetLista();

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            //return _mapper.Map<IEnumerable<BancoResposta>>(result);
            return result; 
        }


        
        public async Task<BancoEntidade> GetId(string id)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetId(id);

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            //return _mapper.Map<BancoResposta>(result);
            return result; 

        }

        public async Task<BancoEntidade> GetCodigo(string codigo)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetCodigo(codigo);

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            //return _mapper.Map<BancoResposta>(result);
            return result;

        }

        public async Task<BancoEntidade> GetNome(string nome)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetNome(nome);

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            //return _mapper.Map<BancoResposta>(result);
            return result;

        }

        public async Task Add(BancoEntidade item)
        {
            
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            await _bancoRepository.Add(item);
        }

        

        public async Task<long> Update(BancoEntidade item)
        {
        
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return await _bancoRepository.Update(item);
        }

        public async Task<bool> ExisteCodigo(string codigo)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return await _bancoRepository.ExisteCodigo(codigo);

        }

        public async Task<long> Delete(string id)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return await _bancoRepository.Delete(id);
        }

    }
}
