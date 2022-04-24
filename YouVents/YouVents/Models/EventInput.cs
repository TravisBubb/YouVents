using System;
using System.ComponentModel.DataAnnotations;

namespace YouVents.Models
{
    public class EventInput
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        public int Capacity { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Rating { get; set; }

        public string Type { get; set; }
        public string Image { get; set; }
    }
}
