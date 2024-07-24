using Microsoft.EntityFrameworkCore;
using siteRoupa.Models;

namespace siteRoupa.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Boutique> Boutiques { get; set; }

    }
}
