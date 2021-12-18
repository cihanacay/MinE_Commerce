using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinE_Commerce.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public Product Insert([FromBody] Product product)
        {
            _productService.TAdd(product);
            return product;
        }
        [HttpGet]
        public List<Product> GetProduct()
        {
            var model = _productService.GetListAll(x => x.Deleted == false);
            return model;
        }
        [HttpPost("{id}")]
        public Product Delete(int id)
        {
            var model = _productService.TGetById(id);
            model.Deleted = true;
            _productService.TUpdate(model);
            return model;
        }
        [HttpPost]
        public Product Update(Product product)
        {
            var productId = product.Id;
            _productService.TUpdate(product);
            var model = _productService.TGetById(productId);
            return model;
        }
    }
}
