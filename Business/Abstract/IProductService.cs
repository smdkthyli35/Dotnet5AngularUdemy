using Core.Utilities.Results;
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
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
        IDataResult<List<ProductDetailDto>> GetProductDetails(Expression<Func<Product, bool>> filter = null);
        IDataResult<List<ProductDetailDto>> GetProductsByBrandId(int brandId);
        IDataResult<List<ProductDetailDto>> GetProductsByTypeId(int typeId);
        IDataResult<List<ProductDetailDto>> GetProductDetailsByBrandName(string brandName);
        IDataResult<List<ProductDetailDto>> GetProductDetailsByTypeName(string typeName);
        IDataResult<List<ProductDetailDto>> GetProductDetailsByBrandNameAndTypeName(string brandName, string typeName);
    }
}
