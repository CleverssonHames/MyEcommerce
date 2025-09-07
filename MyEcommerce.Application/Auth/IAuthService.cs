using MyEcommerce.Communication.Requests.Auth;
using MyEcommerce.Communication.Responses.Auth;
using MyEcommerce.Domain.Models;
using MyEcommerce.Web.Requests.Auth;

namespace MyEcommerce.Application.Auth
{
    public interface IAuthService
    {
        Task<ResponseRegisterJson> SetUsuario(RegisterJson request);
        Task<UsuarioModel> Login(LoginJson request);
    }
}
