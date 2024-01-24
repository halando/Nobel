using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel.Models
{
    internal class Fajta
    {
        public int Id { get; set; } 
        public string Tipus { get; set; }

        public Fajta() { }

        public Fajta(string tipus)
        {
            Tipus = tipus;
        }

        public override string? ToString()
        {
            return Id+":"+Tipus;
        }
    }
}
