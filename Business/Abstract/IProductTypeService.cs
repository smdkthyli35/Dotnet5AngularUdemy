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
        List<ProductType> GetAll();
        ProductType GetById(int id);
        void Add(ProductType productType);
        void Delete(ProductType productType);
        void Update(ProductType productType);
    }
}
