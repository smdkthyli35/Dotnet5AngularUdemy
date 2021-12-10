using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductTypeService
    {
        IDataResult<List<ProductType>> GetAll();
        IDataResult<ProductType> GetById(int id);
        IResult Add(ProductType productType);
        IResult Delete(ProductType productType);
        IResult Update(ProductType productType);
    }
}
