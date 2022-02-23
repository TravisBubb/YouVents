using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouVents.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
