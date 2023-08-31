using Microsoft.EntityFrameworkCore;
using BancosAPI.Dominio.Entidades;
using BancosAPI.Infra.Data.EntidadeConfig;

namespace BancosAPI.Infra.Data.Contexto
{
    public class SistemaDbContexto : DbContext
    {

        public SistemaDbContexto(DbContextOptions<SistemaDbContexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //Definir os mapeamentos das entidades do banco de dados.
        //****************************************************************************
        public DbSet<BancoEntidade> Bancos { get; set; }



        //Definições dos campos das tabelas 
        //para que não seja utilizada DataAnnotations nos models no domain
        //****************************************************************************
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Definições das sequence de cada tabela - apenas no PostgreSQL
            //****************************************************************************
            //modelBuilder.HasSequence<int>("usuario_seq").StartsAt(1000).IncrementsBy(1);
            //modelBuilder.HasSequence<int>("convenio_seq").StartsAt(1000).IncrementsBy(1);
            //modelBuilder.HasSequence<int>("cliente_seq").StartsAt(1000).IncrementsBy(1);
            //modelBuilder.HasSequence<int>("beneficio_seq").StartsAt(1000).IncrementsBy(1);

            //Definições das configurações de cada tabela.
            //****************************************************************************
            modelBuilder.ApplyConfiguration(new BancoEntidadeConfig());

        }

    }
}

