using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyEcommerce.Application.Repositories.Produto;
using MyEcommerce.Infrastructure.DataAccess;
using MyEcommerce.Infrastructure.DataAccess.Repositories;

namespace MyEcommerce.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddRepositories(services);
            AddDbContext(services, configuration);
        }
        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<MyEcommerceDbContext>(DbContexOptions =>
            {
                DbContexOptions.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });
        }
    }
}
