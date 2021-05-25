using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingSystemAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; }
        public string Username { get; set; }
        
        public string Password { get; set; }
        public int Age { get; set; }
        public double Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string IsVerified { get; set; }
    }
}

