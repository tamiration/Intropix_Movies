using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intropix_Movies.Models
{
        public class Trailers
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Lenght { get; set; }
            public string Source_link { get; set; }
            public string Summary { get; set; }
            public int Rating { get; set; }
            public string filming_location { get; set; }
            public int Studio_id { get; set; }
        }

}
