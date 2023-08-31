using BancoAPI.InfraData.Contexto;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BancoAPI.InfraIC.InversaoDeControle
{
    public static class InjecaoDependenciaContexto
    {
        /// <summary>
        /// Metodo de Extensão que será utilizado no ConfigureServices do Startup.cs
        /// services.Connection(Configuration);
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddSistemaContexto(this IServiceCollection services)
        {
            // string do dbcontexto para conexão com o SQLite
            // a string esta no appsettings.json
            //***********************************************************************************
            services.AddScoped<ISistemaContexto, SistemaContexto>();

            // necessita instalar o pacote 
            // Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore, apenas para .net 5
            //***********************************************************************************
            //services.AddDatabaseDeveloperPageExceptionFilter();


            return services;
        }
    }
}
