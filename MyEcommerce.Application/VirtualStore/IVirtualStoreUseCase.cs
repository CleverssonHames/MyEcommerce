using MyEcommerce.Domain.Models.ViewModels;

namespace MyEcommerce.Application.VirtualStore
{
    public interface IVirtualStoreUseCase
    {
        Task<ListaDeProdutosViewModel> GetProdutosVirtualStore();
    }
}
