using FluentValidation;
using MyEcommerce.Domain.Models.Entrada;

namespace MyEcommerce.Application.Produto
{
    public class ValidaAdicionarProduto : AbstractValidator<ProdutoEntrada>
    {
        public ValidaAdicionarProduto()
        {
            RuleFor(x => x.categoria)
                .NotEmpty()
                .WithMessage("Categoria não pode ser vazia");
            RuleFor(x => x.descricao)
                .NotEmpty()
                .WithMessage("Descrição não pode ser vazia");
            RuleFor(x => x.preco)
                .GreaterThan(0)
                .WithMessage("Preço deve ser maior que zero");
        }
    }
}
