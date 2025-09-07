using Microsoft.AspNetCore.Mvc;
using MyEcommerce.Application.Produto;
using MyEcommerce.Domain.Models.Entrada;

namespace MyEcommerce.Web.Controllers
{
    public class ProdutoController : MyEcommerceBaseController
    {
        private readonly IProdutoUseCase _produtoUseCase;

        public ProdutoController(IProdutoUseCase produtoUseCase)
        {
            _produtoUseCase = produtoUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> Produtos()
        {
            var model = await _produtoUseCase.Produtos();
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarProduto(ProdutoEntrada produto)
        {
            var model = await _produtoUseCase.AdicionarProduto(produto);
            return Created();
        }
    }
}
