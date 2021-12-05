using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public async Task<IReadOnlyList<Product>> GetProductAsync()
        {
            using (var _commerceContext = new CommerceContext())
            {
                return await _commerceContext.Products
                .Include(p => p.ProductBrand)
                .Include(p => p.ProductType)
                .ToListAsync();
            }
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandAsync()
        {
            using (var _commerceContext = new CommerceContext())
            {
                return await _commerceContext.ProductBrands.ToListAsync();
            }
        }


        public async Task<Product> GetProductByIdAsync(int id)
        {
            using (var _commerceContext = new CommerceContext())
            {
                return await _commerceContext.Products
                .Include(p => p.ProductBrand)
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(p => p.ProductId == id);
            }
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            using (var _commerceContext = new CommerceContext())
            {
                return await _commerceContext.ProductTypes.ToListAsync();
            }
        }
    }
}
