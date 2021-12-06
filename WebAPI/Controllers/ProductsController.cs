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
        //IProductDal _productDal;

        //public ProductsController(IProductDal productDal)
        //{
        //    _productDal = productDal;
        //}

        private readonly IEntityRepository<Product> _productRepository;
        private readonly IEntityRepository<ProductBrand> _productBrandRepository;
        private readonly IEntityRepository<ProductType> _productTypeRepository;

        public ProductsController(IEntityRepository<Product> productRepository, IEntityRepository<ProductBrand> productBrandRepository, IEntityRepository<ProductType> productTypeRepository)
        {
            _productRepository = productRepository;
            _productBrandRepository = productBrandRepository;
            _productTypeRepository = productTypeRepository;
        }



        //[HttpGet("getall")]
        //public async Task<ActionResult<List<Product>>> GetProducts()
        //{
        //    var data = await _productRepository.ListAllAsync();
        //    return Ok(data);
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Product>> GetProduct(int id)
        //{
        //    return await _productRepository.GetByIdAsync(id);
        //}

        //[HttpGet("brands")]
        //public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetBrands()
        //{
        //    return Ok(await _productBrandRepository.ListAllAsync());
        //}

        //[HttpGet("types")]
        //public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetTypes()
        //{
        //    return Ok(await _productTypeRepository.ListAllAsync());
        //}

    }
}
