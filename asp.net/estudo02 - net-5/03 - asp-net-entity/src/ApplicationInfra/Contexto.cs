using ApplicationBusiness.CadastrosModels;
using ApplicationBusiness.ParametrosModels;
using Microsoft.EntityFrameworkCore;

namespace ApplicationInfra
{
    public class Contexto :DbContext
    {
       
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated(); 
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Banco> Banco { get; set; }
        
    }
}
