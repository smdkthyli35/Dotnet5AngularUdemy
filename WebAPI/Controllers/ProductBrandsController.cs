using Business.Abstract;
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
    public class ProductBrandsController : ControllerBase
    {
        IProductBrandService _productBrandService;

        public ProductBrandsController(IProductBrandService productBrandService)
        {
            _productBrandService = productBrandService;
        }

        [HttpGet("brands")]
        public IActionResult GetAllBrands()
        {
            var result = _productBrandService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetBrand(int id)
        {
            var result = _productBrandService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ProductBrand productBrand)
        {
            var result = _productBrandService.Add(productBrand);
            if (result.Success)
            {
                return Ok(productBrand);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ProductBrand productBrand)
        {
            var result = _productBrandService.Delete(productBrand);
            if (result.Success)
            {
                return Ok(productBrand);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(ProductBrand productBrand)
        {
            var result = _productBrandService.Update(productBrand);
            if (result.Success)
            {
                return Ok(productBrand);
            }
            return BadRequest(result);
        }
    }
}
