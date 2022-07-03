using BlazingShop.Server.Services.ProductService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazingShop.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productService.GetAllProducts());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _productService.GetProduct(id);
        }

        [HttpGet("Edition/{editionId}")]
        public async Task<ActionResult<List<Product>>> GetProductsByEdition(int editionId)
        {
            var result = await _productService.GetProductsByEdition(editionId);
            return Ok(result);
        }

        [HttpGet("Search/{searchedText}")]
        public async Task<ActionResult<List<Product>>> SearchProducts(string searchedText)
        {
            return Ok(await _productService.SearchProducts(searchedText));
        }
    }
}
