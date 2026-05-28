using ApiWeb.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ApiWeb.Data
{
    public class AppDbContext: DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options)
             : base(options) //chama o construtor da classe base DbContext, passando as opções de configuração para a classe base
        {
            
        }

        public DbSet<ProdutoEntity> Produtos {get; set; } 
        public DbSet<CategoriaEntity> Categorias { get; set; }
        public DbSet<FornecedorEntity> Fornecedores { get; set; }
        public DbSet<ProdutoFornecedorEntity> ProdutoFornecedores { get; set; }


    }
}
