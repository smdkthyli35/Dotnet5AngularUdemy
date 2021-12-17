using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBasketDal : IEntityRepository<CustomerBasket>
    {
        CustomerBasket GetBasket(string basketId);
        CustomerBasket UpdateBasket(CustomerBasket customerBasket);
        bool DeleteBasket(string basketId);
    }
}
