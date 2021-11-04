using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public int FlightId { get; set; }
    }
}
