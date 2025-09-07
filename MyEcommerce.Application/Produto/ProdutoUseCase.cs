using MyEcommerce.Application.Repositories.Produto;
using MyEcommerce.Domain.Models;
using MyEcommerce.Domain.Models.Entrada;
using MyEcommerce.Domain.Models.ViewModels;

namespace MyEcommerce.Application.Produto
{
    public class ProdutoUseCase : IProdutoUseCase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoUseCase(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<ProdutoViewModel> AdicionarProduto(ProdutoEntrada produto)
        {

            var validar = new ValidaAdicionarProduto();
            var resultado = validar.Validate(produto);

            if (resultado.IsValid == false)
            {
                var modelError = new ProdutoViewModel();
                modelError.categorias = GetCategorias().categorias;
                modelError.status = false;
                
                foreach (var erro in resultado.Errors)
                {
                    var failAndError = new ErrosValidacao
                    {
                        campo = erro.PropertyName,
                        mensagem = erro.ErrorMessage
                    };
                    modelError.erros.Add(failAndError);
                }
                return modelError;
            }

            var model = await _produtoRepository.AdicionarProduto(produto);

            return model;
        }

        public ProdutoViewModel GetCategorias() => _produtoRepository.GetCategorias();


        public async Task<ListaDeProdutosViewModel> Produtos() => await _produtoRepository.ListaDeProdutos();
    }
}
