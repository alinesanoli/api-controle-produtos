namespace ApiWeb.Entity
{
    public class CategoriaEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public List<ProdutoEntity> Produtos { get; set; } = new List<ProdutoEntity>(); //propriedade de navegação para a relação entre categoria e produtos, indicando que uma categoria pode ter vários produtos associados a ela
    }
}
