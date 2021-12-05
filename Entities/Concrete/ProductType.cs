using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProductType : IEntity
    {
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
    }
}
