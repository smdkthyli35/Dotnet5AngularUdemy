using Business.Abstract;
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

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public List<ProductDetailDto> GetProductsByBrandId(int brandId)
        {
            return _productDal.GetProductDetails(p => p.ProductBrandId == brandId);
        }

        public List<ProductDetailDto> GetProductsByTypeId(int typeId)
        {
            return _productDal.GetProductDetails(p => p.ProductTypeId == typeId);
        }

        public List<ProductDetailDto> GetProductDetails(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.GetProductDetails(filter);
        }

        public List<ProductDetailDto> GetProductDetailsByBrandName(string brandName)
        {
            return _productDal.GetProductDetails(p => p.ProductBrand.Name == brandName);
        }

        public List<ProductDetailDto> GetProductDetailsByTypeName(string typeName)
        {
            return _productDal.GetProductDetails(p => p.ProductType.Name == typeName);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public List<ProductDetailDto> GetProductDetailsByBrandNameAndTypeName(string brandName, string typeName)
        {
            return _productDal.GetProductDetails(p => p.ProductBrand.Name == brandName && p.ProductType.Name == typeName);
        }
    }
}
