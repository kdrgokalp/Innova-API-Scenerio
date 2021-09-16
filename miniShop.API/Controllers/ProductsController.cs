using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using miniShop.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await productService.GetProductListResponses());

        }
    }
}
