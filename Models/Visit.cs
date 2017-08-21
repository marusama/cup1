using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cup1.Models
{
    public class Visit
    {
        public uint Id { get; set; }
        public uint Location { get; set; }
        public uint User { get; set; }
        public long Visited_at { get; set; }
        public byte Mark { get; set; }
    }
}
