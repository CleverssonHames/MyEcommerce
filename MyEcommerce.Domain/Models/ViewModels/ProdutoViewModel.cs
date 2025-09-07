using Microsoft.AspNetCore.Http;

namespace MyEcommerce.Domain.Models.ViewModels
{
    public class ProdutoViewModel : RetornoValidacao
    {
        public string descricao { get; set; } = string.Empty;
        public int categoria { get; set; } 
        public double preco { get; set; }
        public IFormFile imagem { get; set; } = null!;
        public List<Categoria> categorias { get; set; } = new List<Categoria>();
    }
}
