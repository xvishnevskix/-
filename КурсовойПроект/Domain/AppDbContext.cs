﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace КурсовойПроект.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
    }
}
