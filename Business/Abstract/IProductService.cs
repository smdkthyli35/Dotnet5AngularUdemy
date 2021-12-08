using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<ProductDetailDto> GetProductDetails(Expression<Func<Product, bool>> filter = null);
        List<ProductDetailDto> GetProductsByBrandId(int brandId);
        List<ProductDetailDto> GetProductsByTypeId(int typeId);
        List<ProductDetailDto> GetProductDetailsByBrandName(string brandName);
        List<ProductDetailDto> GetProductDetailsByTypeName(string typeName);
        List<ProductDetailDto> GetProductDetailsByBrandNameAndTypeName(string brandName, string typeName);

    }
}
