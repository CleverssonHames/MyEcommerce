using MyEcommerce.Domain.Models;

namespace MyEcommerce.Domain.Repositories.Auth
{
    public interface IAuthRepository
    {
        public Task SetUsuario(UsuarioModel model);
    }
}
