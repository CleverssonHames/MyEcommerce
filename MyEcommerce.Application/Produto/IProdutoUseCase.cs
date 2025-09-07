using MyEcommerce.Domain.Models.Entrada;
using MyEcommerce.Domain.Models.ViewModels;

namespace MyEcommerce.Application.Produto
{
    public interface IProdutoUseCase
    {
        Task<ListaDeProdutosViewModel> Produtos();
        Task<ProdutoViewModel> AdicionarProduto(ProdutoEntrada produto);
        ProdutoViewModel GetCategorias();
    }
}
