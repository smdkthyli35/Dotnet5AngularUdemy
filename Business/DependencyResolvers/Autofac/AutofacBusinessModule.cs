using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<ProductBrandManager>().As<IProductBrandService>().SingleInstance();
            builder.RegisterType<EfProductBrandDal>().As<IProductBrandDal>().SingleInstance();

            builder.RegisterType<ProductTypeManager>().As<IProductTypeService>().SingleInstance();
            builder.RegisterType<EfProductTypeDal>().As<IProductTypeDal>().SingleInstance();

            builder.RegisterType<BasketManager>().As<IBasketService>().SingleInstance();
            builder.RegisterType<EfBasketDal>().As<IBasketDal>().SingleInstance();

            builder.RegisterType<TokenManager>().As<ITokenService>().SingleInstance();

            builder.RegisterType<OrderManager>().As<IOrderService>().SingleInstance();
        }
    }
}
