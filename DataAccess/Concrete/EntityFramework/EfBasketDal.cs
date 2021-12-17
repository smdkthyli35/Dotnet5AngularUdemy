using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBasketDal : EfEntityRepositoryBase<CustomerBasket, CommerceContext>, IBasketDal
    {
        private readonly IDatabase _database;
        public EfBasketDal(IConnectionMultiplexer connectionMultiplexer)
        {
            _database = connectionMultiplexer.GetDatabase();
        }
        public bool DeleteBasket(string basketId)
        {
            return _database.KeyDelete(basketId);
        }

        public CustomerBasket GetBasket(string basketId)
        {
            var data = _database.StringGet(basketId);
            return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<CustomerBasket>(data);
        }

        public CustomerBasket UpdateBasket(CustomerBasket customerBasket)
        {
            var created = _database.StringSet(customerBasket.Id, JsonSerializer.Serialize(customerBasket),TimeSpan.FromDays(30));
            if (!created)
            {
                return null;
            }
            else
            {
                return GetBasket(customerBasket.Id);
            }
        }
    }
}
