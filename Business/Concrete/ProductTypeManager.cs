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
    public class ProductTypeManager : IProductTypeService
    {
        IProductTypeDal _productTypeDal;

        public ProductTypeManager(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }

        public IResult Add(ProductType productType)
        {
            _productTypeDal.Add(productType);
            return new SuccessResult(Messages.TypeAdded);
        }

        public IResult Delete(ProductType productType)
        {
            _productTypeDal.Delete(productType);
            return new SuccessResult(Messages.TypeDeleted); 
        }

        public IDataResult<List<ProductType>> GetAll()
        {
            return new SuccessDataResult<List<ProductType>>(_productTypeDal.GetList(),Messages.TypeListed);
        }

        public IDataResult<ProductType> GetById(int id)
        {
            return new SuccessDataResult<ProductType>(_productTypeDal.Get(p => p.ProductTypeId == id));
        }

        public IResult Update(ProductType productType)
        {
            _productTypeDal.Update(productType);
            return new SuccessResult(Messages.TypeUpdated);
        }
    }
}
