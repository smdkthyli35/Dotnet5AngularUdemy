using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.OrderAggregate
{
    public class OrderItem : IEntity
    {
        public OrderItem()
        {

        }
        public OrderItem(ProductItemOrdered ıtemOrdered, decimal price, int quantity)
        {
            ItemOrdered = ıtemOrdered;
            Price = price;
            Quantity = quantity;
        }

        public int OrderItemId { get; set; }
        public ProductItemOrdered ItemOrdered { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
