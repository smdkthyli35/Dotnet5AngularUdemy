using Core.Entities;
using Entities.Concrete.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Identity
{
    public class AppUser : IdentityUser, IEntity
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }
}
