using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Intropix_Movies.Models;

namespace Intropix_Movies.Models
{
    public class Intropix_MoviesContext : DbContext
    {
        public Intropix_MoviesContext (DbContextOptions<Intropix_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Intropix_Movies.Models.User> User { get; set; }
        public DbSet<Intropix_Movies.Models.Studio> Studio { get; set; }
        public DbSet<Intropix_Movies.Models.Views_List> Views_List { get; set; }
        public DbSet<Intropix_Movies.Models.Trailers> Trailers { get; set; }
    }
}
