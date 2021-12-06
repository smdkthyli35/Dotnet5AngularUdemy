using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductTypeManager : IProductTypeService
    {
        IProductTypeDal _productTypeDal;

        public ProductTypeManager(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }

        public void Add(ProductType productType)
        {
            _productTypeDal.Add(productType);
        }

        public void Delete(ProductType productType)
        {
            _productTypeDal.Delete(productType);
        }

        public List<ProductType> GetAll()
        {
            return _productTypeDal.GetList();
        }

        public ProductType GetById(int id)
        {
            return _productTypeDal.Get(p => p.ProductTypeId == id);
        }

        public void Update(ProductType productType)
        {
            _productTypeDal.Update(productType);
        }
    }
}
