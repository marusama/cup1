using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cup1.Models
{
    public class User
    {
        public uint Id { get; set; }
        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Gender { get; set; }
        public long Birth_date { get; set; }

        public override string ToString()
        {
            return $"User {{ Id: {Id}, Email: {Email}, First_name: {First_name}, Last_name: {Last_name}, Gender: {Gender}, Birth_date: {Birth_date} }}";
        }
    }
}
