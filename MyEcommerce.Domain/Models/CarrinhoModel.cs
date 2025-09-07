namespace MyEcommerce.Domain.Models
{
    public class CarrinhoModel
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public List<ProdutoCarrinhoModel> Itens { get; set; } = new List<ProdutoCarrinhoModel>();
        public decimal Total { get; set; }
        public void AdicionarItem(ProdutoCarrinhoModel item)
        {
            Itens.Add(item);
            Total += item.Preco * item.Quantidade;
        }
        public void RemoverItem(int itemId)
        {
            var item = Itens.FirstOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                Itens.Remove(item);
                Total -= item.Preco * item.Quantidade;
            }
        }
    }

    public class ProdutoCarrinhoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}