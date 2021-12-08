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
        IProductBrandService _productBrandService;
        IProductTypeService _productTypeService;

        public ProductsController(IProductService productService, IProductBrandService productBrandService, IProductTypeService productTypeService)
        {
            _productService = productService;
            _productBrandService = productBrandService;
            _productTypeService = productTypeService;
        }

        [HttpGet("getall")]
        public ActionResult<List<Product>> GetProducts()
        {
            var result = _productService.GetAll();
            return Ok(result);
        }

        [HttpGet("getproductdetails")]
        public ActionResult<List<Product>> GetProductDetails()
        {
            var result = _productService.GetProductDetails();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public ActionResult<Product> GetProduct(int id)
        {
            return _productService.GetById(id);
        }

        [HttpGet("getproductdetailsbyid")]
        public ActionResult<List<Product>> GetProductDetailsById(int id)
        {
            var result = _productService.GetProductDetails(p => p.ProductId == id);
            return Ok(result);
        }

        [HttpGet("getproductsbybrandid")]
        public ActionResult<List<ProductDetailDto>> GetProductsByBrandId(int id)
        {
            var result = _productService.GetProductsByBrandId(id);
            return Ok(result);
        }

        [HttpGet("getproductsbytypeid")]
        public ActionResult<List<Product>> GetProductsByTypeId(int id)
        {
            var result = _productService.GetProductsByTypeId(id);
            return Ok(result);
        }


        [HttpGet("getproductdetailsbybrandname")]
        public ActionResult<List<Product>> GetProductDetailsByBrandName(string name)
        {
            var result = _productService.GetProductDetailsByBrandName(name);
            return Ok(result);
        }

        [HttpGet("getproductdetailsbytypename")]
        public ActionResult<List<Product>> GetProductDetailsByTypeName(string name)
        {
            var result = _productService.GetProductDetailsByTypeName(name);
            return Ok(result);
        }

        [HttpGet("getproductdetailsbybrandnameandtypename")]
        public ActionResult<List<Product>> GetProductDetailsByBrandNameAndTypeName(string brandName, string typeName)
        {
            var result = _productService.GetProductDetailsByBrandNameAndTypeName(brandName, typeName);
            return Ok(result);
        }

        [HttpGet("brands")]
        public ActionResult<List<ProductBrand>> GetBrands()
        {
            return Ok(_productBrandService.GetAll());
        }

        [HttpGet("types")]
        public ActionResult<List<ProductBrand>> GetTypes()
        {
            return Ok(_productTypeService.GetAll());
        }
    }
}
