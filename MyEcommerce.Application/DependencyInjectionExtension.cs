using Microsoft.Extensions.DependencyInjection;
using MyEcommerce.Application.Produto;
using MyEcommerce.Application.VirtualStore;
using MyEcommerce.Domain.Repositories.Auth;

namespace MyEcommerce.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddUseCases(services);
        }

        public static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IProdutoUseCase, ProdutoUseCase>();
            services.AddScoped<IVirtualStoreUseCase, VirtualStoreUseCase>();
            services.AddScoped<IAuthRepository, AuthRepository>();
        }
    }
}
