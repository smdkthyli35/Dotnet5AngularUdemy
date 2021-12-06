using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, CommerceContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (CommerceContext context = new CommerceContext())
            {
                var result = from p in context.Products
                             join b in context.ProductBrands
                             on p.ProductBrandId equals b.ProductBrandId
                             join ty in context.ProductTypes
                             on p.ProductTypeId equals ty.ProductTypeId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 Name = p.Name,
                                 Description = p.Description,
                                 Price = p.Price,
                                 PictureUrl = p.PictureUrl,
                                 ProductBrandName = b.Name,
                                 ProductTypeName = ty.Name
                             };
                return result.ToList();
            }
        }
    }
}
