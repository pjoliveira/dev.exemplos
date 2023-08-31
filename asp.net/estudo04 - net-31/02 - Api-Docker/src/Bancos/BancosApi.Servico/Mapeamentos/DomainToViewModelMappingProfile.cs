using AutoMapper;
using BancosAPI.Servico.Respostas;
using BancosAPI.Dominio.Entidades;

namespace BancosAPI.Servico.Mapeamentos
{
    /// <summary>
    /// Classe do AUTOMAPPER para mapeamento de classe.
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        /// <summary>
        /// Mapear Model do Domain para ViewModel 
        /// considerando que o atributos da Model e ViewModel estão com mesmo nome
        /// </summary>
        public DomainToViewModelMappingProfile()
        {
            // Mapear Banco para BancoViewModel
            //************************************************
            CreateMap<BancoEntidade, BancoResposta>();
            
        }
    }
}
