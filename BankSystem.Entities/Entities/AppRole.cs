using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Entities.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public string Name { get; set; }
    }
}
