using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rentals.Models
{
    public class Customer
    {
        public int id { get; set; }
        public byte[] image { get; set; }
        public string Name { get; set; }
    }
}
