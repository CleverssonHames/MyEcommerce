using Microsoft.EntityFrameworkCore;
using MyEcommerce.Application.Repositories.Produto;
using MyEcommerce.Domain.Enum;
using MyEcommerce.Domain.Models;
using MyEcommerce.Domain.Models.Entrada;
using MyEcommerce.Domain.Models.ViewModels;

namespace MyEcommerce.Infrastructure.DataAccess.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyEcommerceDbContext _dbContext;

        public ProdutoRepository(MyEcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ProdutoViewModel> AdicionarProduto(ProdutoEntrada produto)
        {
            var model = new ProdutoViewModel();
            var pdto = new ProdutoModel()
            {
                descricao = produto.descricao,
                categoria = produto.categoria,
                preco = produto.preco
            };

            if (produto.imagem != null)
            {
                using var memoryStream = new MemoryStream();
                await produto.imagem.CopyToAsync(memoryStream);
                pdto.imagem = memoryStream.ToArray();
            }

            var result = await _dbContext.produto.AddAsync(pdto);
            await _dbContext.SaveChangesAsync();

            model.categorias = GetCategoriasEnum();

            if (result == null)
            {
                model.status = false;
                model.status_mensagem = "Erro ao cadastrar produto";                
            }
            else
            {
                model.status = true;
                model.status_mensagem = "Produto cadastrado com sucesso";
            }
            return model;
        }

        public async Task<ListaDeProdutosViewModel> ListaDeProdutos()
        {
            var model = new ListaDeProdutosViewModel();
            model.categorias = GetCategoriasEnum();
            model.produtos = await _dbContext.produto.ToListAsync();

            return model;
        }

        public ProdutoViewModel GetCategorias()
        {
            var model = new ProdutoViewModel();
            model.categorias = GetCategoriasEnum();
            return model;
        }

        private List<Categoria> GetCategoriasEnum()
        {
            var categorias = new List<Categoria>();

            foreach (var cat in Enum.GetValues(typeof(Categorias)))
            {
                var categoria = new Categoria
                {
                    Id = (int)cat,
                    Descricao = Convert.ToString(((Categorias)cat))!
                };
                categorias.Add(categoria);
            }

            return categorias;
        }
    }
}
