using Microsoft.EntityFrameworkCore;
using bibliotec.Core.Entities;
namespace bibliotec.Infraestructure
{
    public class BibliotecaDbContext:DbContext
    {
        public BibliotecaDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Autor> Products { get; set; }

        public DbSet<Copia> Brands { get; set; }

        public DbSet<Libro> Categories { get; set; }

    }
}
