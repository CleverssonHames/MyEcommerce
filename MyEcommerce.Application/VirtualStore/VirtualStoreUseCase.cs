using MyEcommerce.Application.Repositories.Produto;
using MyEcommerce.Domain.Models.ViewModels;

namespace MyEcommerce.Application.VirtualStore
{
    public class VirtualStoreUseCase : IVirtualStoreUseCase
    {
        private readonly IProdutoRepository _produtoRepository;
        public VirtualStoreUseCase(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<ListaDeProdutosViewModel> GetProdutosVirtualStore()
        {
            var  model = await _produtoRepository.ListaDeProdutos();
            return model;
        }
    }
}
