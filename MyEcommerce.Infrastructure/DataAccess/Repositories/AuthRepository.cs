using MyEcommerce.Domain.Models;
using MyEcommerce.Domain.Repositories.Auth;

namespace MyEcommerce.Infrastructure.DataAccess.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly MyEcommerceDbContext _context;

        public AuthRepository(MyEcommerceDbContext context)
        {
            _context = context;
        }

        public async Task SetUsuario(UsuarioModel model)
        {
            var result = await _context.usuario.AddAsync(model);
            await _context.SaveChangesAsync();

        }
    }
}
