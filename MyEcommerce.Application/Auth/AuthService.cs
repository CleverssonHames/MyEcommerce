using MyEcommerce.Communication.Exceptions;
using MyEcommerce.Communication.Requests.Auth;
using MyEcommerce.Communication.Responses.Auth;
using MyEcommerce.Domain.Models;
using MyEcommerce.Domain.Repositories.Auth;
using MyEcommerce.Web.Requests.Auth;
using System.Data;

namespace MyEcommerce.Application.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(AuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        Task<UsuarioModel> IAuthService.Login(LoginJson request)
        {
            var clevao = "Teste";
            throw new NotImplementedException();
        }

        async Task<ResponseRegisterJson> IAuthService.SetUsuario(RegisterJson request)
        {
            var validar = new RegisterValidation();
            var resultado = validar.Validate(request);

            if (resultado.IsValid == false)
            {
                throw new ErrorOnValidationException(resultado.Errors.Select(e => e.ErrorMessage).ToList());
            }



            return new ResponseRegisterJson();
        }
    }
}
