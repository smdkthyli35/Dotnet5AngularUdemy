using Entities.Concrete.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        Order CreateOrder(string buyerEmail, int deliveryMethod, string basketId, Address shippingAddress);
        IReadOnlyList<Order> GetOrderForUser(string buyerEmail);
        Order GetOrderById(int id, string buyerEmail);
        IReadOnlyList<DeliveryMethod> GetDeliveryMethod();
    }
}
