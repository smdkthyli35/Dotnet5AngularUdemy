using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(ProductBrand productBrand)
        {
            _productBrandDal.Add(productBrand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(ProductBrand productBrand)
        {
            _productBrandDal.Delete(productBrand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<ProductBrand>> GetAll()
        {
            return new SuccessDataResult<List<ProductBrand>>(_productBrandDal.GetList(),Messages.BrandListed);
        }

        public IDataResult<ProductBrand> GetById(int id)
        {
            return new SuccessDataResult<ProductBrand>(_productBrandDal.Get(p => p.ProductBrandId == id));
        }

        public IResult Update(ProductBrand productBrand)
        {
            _productBrandDal.Update(productBrand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
