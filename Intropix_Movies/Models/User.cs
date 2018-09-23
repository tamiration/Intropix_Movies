using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Intropix_Movies.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EMail { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Is_Manager { get; set; }
    }
}
