using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public bool DeleteBasket(string basketId)
        {
            return _basketDal.DeleteBasket(basketId);
        }

        public CustomerBasket GetBasket(string basketId)
        {
            return _basketDal.GetBasket(basketId);
        }

        public CustomerBasket UpdateBasket(CustomerBasket customerBasket)
        {
            return _basketDal.UpdateBasket(customerBasket);
        }
    }
}
