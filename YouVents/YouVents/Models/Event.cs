using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouVents.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string OrganizerId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Capacity { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public float Price { get; set; }
    }
}
