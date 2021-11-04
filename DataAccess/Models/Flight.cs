using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Flight
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Reference { get; set; }

        [MaxLength(50)]
        [Required]
        public string Destination { get; set; }
        public List<Passenger> Passengers { get; set; } = new List<Passenger>();
    }
}
