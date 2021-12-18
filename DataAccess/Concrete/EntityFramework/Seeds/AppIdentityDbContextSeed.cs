using Entities.Concrete.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Seeds
{
    public class AppIdentityDbContextSeed
    {
        public static void SeedUser(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Samed",
                    Email = "samedkutahyali19@gmail.com",
                    UserName = "samedkutahyali19@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Samed",
                        LastName = "Kütahyalı",
                        Street = "Izmir Caddesi",
                        City = "Izmir",
                        State = "TR",
                        ZipCode = "35000"
                    }
                };
                userManager.CreateAsync(user, "A123456");
            }
        }
    }
}
