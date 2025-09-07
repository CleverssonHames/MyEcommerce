using MyEcommerce.Domain.Models.Entrada;
using MyEcommerce.Domain.Models.ViewModels;

namespace MyEcommerce.Application.Repositories.Produto
{
    public interface IProdutoRepository
    {
        public Task<ProdutoViewModel> AdicionarProduto(ProdutoEntrada produto);
        public Task<ListaDeProdutosViewModel> ListaDeProdutos();
        public ProdutoViewModel GetCategorias();
    }
}
