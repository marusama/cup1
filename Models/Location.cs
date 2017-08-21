using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cup1.Models
{
    public class Location
    {
        public uint Id { get; set; }
        public string Place { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public uint Distance { get; set; }
    }
}
