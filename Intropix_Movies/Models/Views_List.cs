using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intropix_Movies.Models
{
    public class Views_List
    {
        public int ID { get; set; }
        public string user_id { get; set; }
        public string movie_id { get; set; }
        public DateTime timestamp { get; set; }
    }
}
