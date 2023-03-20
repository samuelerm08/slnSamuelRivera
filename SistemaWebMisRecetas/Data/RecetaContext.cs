using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Models;

namespace SistemaWebMisRecetas.Data
{
    public class RecetaContext : DbContext
    {
        public RecetaContext(DbContextOptions<RecetaContext> options) : base(options) { }

        public DbSet<Receta> Recetas { get; set; }
    }
}
