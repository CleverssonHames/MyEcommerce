namespace MyEcommerce.Domain.Models.ViewModels
{
    public class ListaDeProdutosViewModel
    {
        public List<Categoria> categorias { get; set; } = new List<Categoria>();    
        public List<ProdutoModel> produtos { get; set; } = new List<ProdutoModel>();
    }
}
