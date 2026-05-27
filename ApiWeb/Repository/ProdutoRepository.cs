using ApiWeb.Data;
using ApiWeb.Entity;
using Microsoft.EntityFrameworkCore;  


namespace SistemaControleApi.Repository
{
    // Repository responsável apenas pelo acesso a dados.
    public class ProdutoRepository
    {
        private readonly AppDbContext _context; 
        public ProdutoRepository(AppDbContext context)
        {
            _context = context; //injeção de dependência do contexto do banco de dados
        }

         public async Task<List<ProdutoEntity>> BuscarProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<ProdutoEntity?> BuscarProdutoPorId(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task<ProdutoEntity> CriarProduto(ProdutoEntity produto) 
        {
            await _context.Produtos.AddAsync(produto);

            await _context.SaveChangesAsync();

            return produto;        
        }

        public async Task AtualizarProduto(ProdutoEntity produto)
        {
            _context.Produtos.Update(produto);

            await _context.SaveChangesAsync();
        }

        public async Task RemoverProduto(ProdutoEntity produto)
        {
            _context.Produtos.Remove(produto);

            await _context.SaveChangesAsync();
        } 

    }
}
