namespace ApiWeb.Entity
{
    public class ProdutoEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; 
        public string Descricao { get; set; } = string.Empty;
        public int QuantidadeEstoque { get; set; }
        public string CodigoBarras { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public int CategoriaId { get; set; } 
        public CategoriaEntity? Categorias { get; set; }
        public List<ProdutoFornecedorEntity> Fornecedores { get; set; } = new List<ProdutoFornecedorEntity>(); 
    }
}