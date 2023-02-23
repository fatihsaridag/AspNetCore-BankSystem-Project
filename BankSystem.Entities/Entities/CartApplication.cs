using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Entities.Entities
{
    public class CartApplication
    {
        public int CartApplicationId { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime DateTime { get; set; }
        public int CartId { get; set; } 
        public Cart Cart { get; set; }


    }
}
