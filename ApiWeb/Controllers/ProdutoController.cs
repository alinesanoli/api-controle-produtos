
using Microsoft.AspNetCore.Mvc;
using ApiWeb.Entity;
using SistemaControleApi.Service;



namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService; 
        public ProdutoController(ProdutoService context)
        {
            _produtoService = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdutoEntity>>> BuscarProdutos() 
        {
            var produtos = await _produtoService.BuscarProdutos();

            return Ok(produtos); //Retorna um status HTTP 200 (OK) com a lista de produtos
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<ProdutoEntity>>> BuscarProdutoPorId(int id) 
        {
            var produto = await _produtoService.BuscarProdutoPorId(id);
            
            if(produto == null)
            {
                return NotFound("Registro não localizado!");
            }

            return Ok(produto);
        }

        [HttpPost]
        public ActionResult<List<ProdutoEntity>> CriarProduto(ProdutoEntity produto)
        {
            var produtoCriado = _produtoService.CriarProduto(produto);            

            return CreatedAtAction(nameof(BuscarProdutoPorId), new { id = produto.Id }, produto);
        }

        

    }
}
