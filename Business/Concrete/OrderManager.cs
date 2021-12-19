using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        private IDeliveryMethodDal _deliveryMethodDal;
        private IProductService _productService;
        private IBasketService _basketService;

        public OrderManager(IOrderDal orderDal, IDeliveryMethodDal deliveryMethodDal, IProductService productService, IBasketService basketService)
        {
            _orderDal = orderDal;
            _deliveryMethodDal = deliveryMethodDal;
            _productService = productService;
            _basketService = basketService;
        }

        public Order CreateOrder(string buyerEmail, int deliveryMethod, string basketId, Address shippingAddress)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<DeliveryMethod> GetDeliveryMethod()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id, string buyerEmail)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Order> GetOrderForUser(string buyerEmail)
        {
            throw new NotImplementedException();
        }
    }
}
