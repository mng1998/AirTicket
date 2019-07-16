using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.Areas.Admin.Models
{
    public class ListIdentityUser
    {
        public List<IdentityUser> ListUser { get; set; }
    }
}
