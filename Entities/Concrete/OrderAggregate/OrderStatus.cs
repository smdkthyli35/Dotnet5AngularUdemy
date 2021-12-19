using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value ="Pending")]
        Pending,

        [EnumMember(Value = "Payment Recevied")]
        PaymentRecevied,

        [EnumMember(Value = "Payment Failed")]
        PaymentFailed,
    }
}
