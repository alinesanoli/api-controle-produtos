namespace ApiWeb.Entity
{
    // Relação N:N entre produtos e fornecedores.
    // Um produto pode possuir múltiplos fornecedores.
    public class ProdutoFornecedorEntity
    {
        public int ProdutoId { get; set; }
        public ProdutoEntity Produto { get; set; } = null!; 
        public int FornecerdorId { get; set; }
        public FornecedorEntity Fornecedor { get; set; } = null!; 
        public decimal PrecoForcenedor { get; set; }
        public int PrazoEntregaDias { get; set; }

    }
}
