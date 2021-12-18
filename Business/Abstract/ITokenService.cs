﻿using Entities.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
