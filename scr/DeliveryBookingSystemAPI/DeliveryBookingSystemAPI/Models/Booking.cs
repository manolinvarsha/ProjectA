using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingSystemAPI.Models
{
    public class Booking
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ExecutiveId { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan TimeOfPickup { get; set; }
        public float WeightOfPackage { get; set; }
        public float Price { get; set; }

    }
}
