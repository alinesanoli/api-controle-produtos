namespace ApiWeb.Entity
{
    public class FornecedorEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public List<ProdutoFornecedorEntity> Produtos { get; set; } = new List<ProdutoFornecedorEntity>();
    }
}
