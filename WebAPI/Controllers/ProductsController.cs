using Business.Abstract;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        public IActionResult GetProducts()
        {
            var result = _productService.GetAll();
            return Ok(result);
        }

        [HttpGet("getproductdetails")]
        public IActionResult GetProductDetails()
        {
            var result = _productService.GetProductDetails();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetProduct(int id)
        {
            var result = _productService.GetById(id);
            return Ok(result);
        }

        [HttpGet("getproductdetailsbyid")]
        public IActionResult GetProductDetailsById(int id)
        {
            var result = _productService.GetProductDetails(p => p.ProductId == id);
            return Ok(result);
        }

        [HttpGet("getproductsbybrandid")]
        public IActionResult GetProductsByBrandId(int id)
        {
            var result = _productService.GetProductsByBrandId(id);
            return Ok(result);
        }

        [HttpGet("getproductsbytypeid")]
        public IActionResult GetProductsByTypeId(int id)
        {
            var result = _productService.GetProductsByTypeId(id);
            return Ok(result);
        }


        [HttpGet("getproductdetailsbybrandname")]
        public IActionResult GetProductDetailsByBrandName(string name)
        {
            var result = _productService.GetProductDetailsByBrandName(name);
            return Ok(result);
        }

        [HttpGet("getproductdetailsbytypename")]
        public IActionResult GetProductDetailsByTypeName(string name)
        {
            var result = _productService.GetProductDetailsByTypeName(name);
            return Ok(result);
        }

        [HttpGet("getproductdetailsbybrandnameandtypename")]
        public IActionResult GetProductDetailsByBrandNameAndTypeName(string brandName, string typeName)
        {
            var result = _productService.GetProductDetailsByBrandNameAndTypeName(brandName, typeName);
            return Ok(result);
        }
    }
}
