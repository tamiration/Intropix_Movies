using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Intropix_Movies.Models
{
    public class Intropix_MoviesContext : DbContext
    {
        public Intropix_MoviesContext (DbContextOptions<Intropix_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Intropix_Movies.Models.User> User { get; set; }
    }
}
