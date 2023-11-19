// Agrega la directiva 'using' necesaria
using Microsoft.EntityFrameworkCore;
using static Apiproject.Client.Pages.NuevaPersonas;

namespace Apiproject.Server.Data
{
    public class BasedeDatosContext : DbContext
    {
        public BasedeDatosContext(DbContextOptions<BasedeDatosContext> options) : base(options)
        {

        }

        
        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Persona>().HasKey(p => p.Id);
        }
    }
}
