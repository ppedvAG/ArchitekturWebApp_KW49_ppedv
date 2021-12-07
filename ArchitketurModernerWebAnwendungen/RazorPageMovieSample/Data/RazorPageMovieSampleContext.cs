using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageMovieSample.Models;

namespace RazorPageMovieSample.Data
{
    public class RazorPageMovieSampleContext : DbContext
    {
        public RazorPageMovieSampleContext (DbContextOptions<RazorPageMovieSampleContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMovieSample.Models.Movie> Movie { get; set; }
    }
}
