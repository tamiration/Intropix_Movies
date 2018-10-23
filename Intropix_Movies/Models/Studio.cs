using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Intropix_Movies.Models
{
    public class Studio
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year_of_foundation { get; set; }
        public string Location { get; set; }
    }

}
