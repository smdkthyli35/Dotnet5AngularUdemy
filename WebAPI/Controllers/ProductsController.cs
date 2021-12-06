using Business.Abstract;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public ActionResult<List<Product>> GetProducts()
        {
            var data = _productService.GetProductDetails();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            return _productService.GetById(id);
        }

        [HttpGet("brands")]
        public ActionResult<List<ProductBrand>> GetBrands()
        {
            return Ok(_productService.GetAll());
        }

        [HttpGet("types")]
        public ActionResult<List<ProductBrand>> GetTypes()
        {
            return Ok(_productService.GetAll());
        }

    }
}
