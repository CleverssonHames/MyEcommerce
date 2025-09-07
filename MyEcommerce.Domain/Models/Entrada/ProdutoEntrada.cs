using Microsoft.AspNetCore.Http;

namespace MyEcommerce.Domain.Models.Entrada
{
    public class ProdutoEntrada
    {
        public int categoria { get; set; }
        public string descricao { get; set; } = string.Empty;
        public double preco { get; set; }
        public IFormFile imagem { get; set; } = null!;
    }
}
