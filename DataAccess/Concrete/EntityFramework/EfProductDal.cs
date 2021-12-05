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
        CommerceContext _commerceContext;

        public EfProductDal(CommerceContext commerceContext)
        {
            _commerceContext = commerceContext;
        }

        public async Task<IReadOnlyList<Product>> GetProductAsync()
        {
            return await _commerceContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _commerceContext.Products.FindAsync(id);
        }
    }
}
