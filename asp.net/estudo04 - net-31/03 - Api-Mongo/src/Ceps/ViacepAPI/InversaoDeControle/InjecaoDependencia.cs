using Microsoft.Extensions.DependencyInjection;
using ViacepAPI.Servico;
using ViacepAPI.ServicoInterfaces;

namespace ViacepAPI.InversaoDeControle
{
    public static class InjecaoDependencia
    {


        /// <summary>
        /// Metodo de Extensão que será utilizado no ConfigureServices do Startup.cs
        /// Adciona as classe da camada Application
        /// services.AddApplication(Configuration);
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddServicos(this IServiceCollection services)
        {

            // Interface e os Services
            // Sistema.Application.Interfaces e Sistema.Application.Services
            //***********************************************************************************
            services.AddScoped<IViacepServico, ViacepServico>();


            return services;
        }



    }
}