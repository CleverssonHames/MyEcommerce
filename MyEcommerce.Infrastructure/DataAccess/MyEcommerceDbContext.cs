using Microsoft.EntityFrameworkCore;
using MyEcommerce.Domain.Models;

namespace MyEcommerce.Infrastructure.DataAccess
{
    public class MyEcommerceDbContext : DbContext
    {
        public MyEcommerceDbContext(DbContextOptions<MyEcommerceDbContext> options) : base(options) { }    

        public DbSet<ProdutoModel> produto { get; set; }
        public DbSet<UsuarioModel> usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyEcommerceDbContext).Assembly);
        }

    }
}
