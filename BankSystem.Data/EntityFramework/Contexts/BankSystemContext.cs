using BankSystem.Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Data.EntityFramework.Contexts
{
    public class BankSystemContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public BankSystemContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cart> Carts { get; set; }

    }
}
