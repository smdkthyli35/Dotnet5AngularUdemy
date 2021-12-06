using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductBrandService
    {
        List<ProductBrand> GetAll();
        ProductBrand GetById(int id);
        void Add(ProductBrand productBrand);
        void Delete(ProductBrand productBrand);
        void Update(ProductBrand productBrand);
    }
}
