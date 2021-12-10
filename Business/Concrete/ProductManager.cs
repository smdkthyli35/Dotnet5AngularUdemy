using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(), Messages.ProductListed);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id));
        }

        public IDataResult<List<ProductDetailDto>> GetProductsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.ProductBrandId == brandId));
        }

        public IDataResult<List<ProductDetailDto>> GetProductsByTypeId(int typeId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.ProductTypeId == typeId));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails(Expression<Func<Product, bool>> filter = null)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(filter), Messages.ProductListed);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailsByBrandName(string brandName)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.ProductBrand.Name == brandName));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailsByTypeName(string typeName)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.ProductType.Name == typeName));
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailsByBrandNameAndTypeName(string brandName, string typeName)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.ProductBrand.Name == brandName && p.ProductType.Name == typeName));
        }
    }
}
