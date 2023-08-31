using AutoMapper;
using BancosAPI.Servico.Respostas;
using BancosAPI.Dominio.Entidades;

namespace BancosAPI.Servico.Mapeamentos
{
    /// <summary>
    /// Classe do AUTOMAPPER para mapeamento de classe.
    /// </summary>
    public class ViewModelToDomainMappingProfile : Profile
    {
        /// <summary>
        /// Mapear ViewModel para o Model do Domain
        /// considerando que o atributos da Model e ViewModel estão com mesmo nome
        /// </summary>
        public ViewModelToDomainMappingProfile()
        {
            // Ex.: Mapear BancoResposta (BancoViewModel) para BancoEntidade
            //**************************************************************
            CreateMap<BancoResposta, BancoEntidade>();

        }


    }
}
