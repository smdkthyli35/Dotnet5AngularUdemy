using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDeliveryMethodDal : EfEntityRepositoryBase<DeliveryMethod, CommerceContext>, IDeliveryMethodDal
    {
    }
}
