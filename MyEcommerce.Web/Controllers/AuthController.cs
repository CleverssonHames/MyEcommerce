using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyEcommerce.Application.Auth;
using MyEcommerce.Communication.Requests.Auth;
using MyEcommerce.Domain.Models;

namespace MyEcommerce.Web.Controllers
{
    public class AuthController : MyEcommerceBaseController
    {
        private readonly IAuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(UsuarioModel), StatusCodes.Status201Created)]
        public IActionResult Register(RegisterJson request)
        {
            var result = _authService.SetUsuario(request);

            return Created(string.Empty, result);
        }
    }
}
