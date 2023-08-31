using Microsoft.EntityFrameworkCore;
using ApplicationBusiness.ParametrosModels;
using ApplicationBusiness.CadastrosModels;

namespace ApplicationInfra
{
    public class Contexto :DbContext
    {
       
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated(); 
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Banco> Banco { get; set; }
    }
}
