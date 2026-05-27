using ApiWeb.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ApiWeb.Data
{
    public class AppDbContext: DbContext
    {
        //aqui é o meio de canto entre o banco de dados e a aplicação, onde as entidades são mapeadas para as tabelas do banco de dados
        //enviamos e coletamos os dados do banco de dados para a aplicação, e vice-versa, usando o Entity Framework Core
        public AppDbContext(DbContextOptions<AppDbContext> options)//ctor + tab atalho para criar o construtor; options são as credenciais de conexão com o banco
             : base(options) //chama o construtor da classe base DbContext, passando as opções de configuração para a classe base
        {
            
        }

        public DbSet<ProdutoEntity> Produtos {get; set; } //no DbSet<> (tabela do banco) deve ser colocado o nome da classe do modelo, e o nome da propriedade deve ser o nome da tabela no banco de dados, e o tipo genérico do DbSet deve ser a classe do modelo que representa a tabela no banco de dados
        public DbSet<CategoriaEntity> Categorias { get; set; }
        public DbSet<FornecedorEntity> Fornecedor { get; set; }
        public DbSet<ProdutoFornecedorEntity> ProdutoFornecedor { get; set; }


    }
}
