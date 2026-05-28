using ApiWeb.Entity;
using SistemaControleApi.Repository;


namespace SistemaControleApi.Service
{
    // Toda regra de negócio deve permanecer na camada Service.
    public class ProdutoService
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoService(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<List<ProdutoEntity>> BuscarProdutos()
        {
            return await _produtoRepository.BuscarProdutos();
        }

        public async Task<ProdutoEntity?> BuscarProdutoPorId(int id)
        {
            return await _produtoRepository.BuscarProdutoPorId(id);
        }

        public async Task<ProdutoEntity> CriarProduto(ProdutoEntity produto)
        {
            var produtoExistente = await _produtoRepository.BuscarProdutos();

            var codigoDuplicado = produtoExistente.FirstOrDefault(p => p.CodigoBarras == produto.CodigoBarras); // Verifica se o código de barras já existe para outro produto

            if (codigoDuplicado != null)
            {
                throw new Exception("Código de barras já existe para outro produto.");
            }

            return await _produtoRepository.CriarProduto(produto);
        }

        public async Task<bool> EditarProduto(int id, ProdutoEntity produtoEditado)
        {
            var produto = await _produtoRepository.BuscarProdutoPorId(id);

            if(produto == null)
            {
                return false;
            }

            produto.Nome = produtoEditado.Nome;
            produto.Descricao = produtoEditado.Descricao;
            produto.Marca = produtoEditado.Marca;
            produto.QuantidadeEstoque = produtoEditado.QuantidadeEstoque;
            produto.CodigoBarras = produtoEditado.CodigoBarras;

            await _produtoRepository.AtualizarProduto(produto);

            return true;

        }

        public async Task<bool> RemoverProduto(int id)
        {
            var produto = await _produtoRepository.BuscarProdutoPorId(id);

            if (produto == null)
            {
                return false;
            }

            await _produtoRepository.RemoverProduto(produto);

            return true;
        }

    }
}
