using BancosAPI.Dominio.Interfaces;
using BancosAPI.Infra.Data.Contexto;
using BancosAPI.Infra.Data.Repositorios;
using BancosAPI.Servico.Interfaces;
using BancosAPI.Servico.Mapeamentos;
using BancosAPI.Servico.Servicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace BancosAPI.Infra.IC.InversaoDeControle
{
    public static class InjecaoDependencia
    {
        /// <summary>
        /// Metodo de Extensão que será utilizado no ConfigureServices do Startup.cs
        /// services.Connection(Configuration);
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddConnection(this IServiceCollection services,
            IConfiguration configuration)
        {
            // string do dbcontexto para conexão com o SQLite
            // a string esta no appsettings.json
            //***********************************************************************************
            services.AddDbContext<SistemaDbContexto>(options =>
                      options.UseSqlite(
                            configuration.GetConnectionString("DefaultConnection"),
                            b => b.MigrationsAssembly(typeof(SistemaDbContexto).Assembly.FullName)));

            // necessita instalar o pacote 
            // Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore, apenas para .net 5
            //***********************************************************************************
            //services.AddDatabaseDeveloperPageExceptionFilter();
            

            return services;
        }
        /// <summary>
        /// Metodo de Extensão que será utilizado no ConfigureServices do Startup.cs
        /// Adciona as classe da camada InfraData
        /// services.AddInfrastructure(Configuration);
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddRespositorios(this IServiceCollection services)
        {

            // Interface e os Repositories
            // Sistema.Domain.Interfaces e Sistema.InfraData.Repositories
            //***********************************************************************************
            services.AddScoped<IBancoRepositorio, BancoRepositorio>();

            return services;
        }
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
            services.AddScoped<IBancoServico, BancoServico>();


            return services;
        }

        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // instalar o no projeto o AutoMapper.Extensions.Microsoft.DependencyInjection
            //***********************************************************************************
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile),
                 typeof(ViewModelToDomainMappingProfile));

        }

    }
}