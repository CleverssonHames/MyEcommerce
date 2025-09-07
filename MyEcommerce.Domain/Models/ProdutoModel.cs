using Microsoft.AspNetCore.Http;

namespace MyEcommerce.Domain.Models
{
    public class ProdutoModel
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public int categoria { get; set; }
        public string descricao { get; set; } = string.Empty;
        public double preco { get; set; }
        public byte[]? imagem { get; set; } = null!;
    }
}
