using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Entities.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Job { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Picture { get; set; }
        public int Gender { get; set; }
        public int Iban { get; set; }
        public double Balance { get; set; }
        public string CityBranch { get; set; }
    }
}
