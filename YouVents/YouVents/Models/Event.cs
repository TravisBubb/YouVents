using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouVents.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
