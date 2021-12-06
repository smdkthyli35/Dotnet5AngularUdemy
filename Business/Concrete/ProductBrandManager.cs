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
    public class ProductBrandManager : IProductBrandService
    {
        IProductBrandDal _productBrandDal;

        public ProductBrandManager(IProductBrandDal productBrandDal)
        {
            _productBrandDal = productBrandDal;
        }

        public void Add(ProductBrand productBrand)
        {
            _productBrandDal.Add(productBrand);
        }

        public void Delete(ProductBrand productBrand)
        {
            _productBrandDal.Delete(productBrand);
        }

        public List<ProductBrand> GetAll()
        {
            return _productBrandDal.GetList();
        }

        public ProductBrand GetById(int id)
        {
            return _productBrandDal.Get(p => p.ProductBrandId == id);
        }

        public void Update(ProductBrand productBrand)
        {
            _productBrandDal.Update(productBrand);
        }
    }
}
