using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intropix_Movies.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EMail { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
