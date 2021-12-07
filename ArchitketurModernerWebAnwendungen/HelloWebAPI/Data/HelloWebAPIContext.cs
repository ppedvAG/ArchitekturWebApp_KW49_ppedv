using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloWebAPI.Models;

namespace HelloWebAPI.Data
{
    public class HelloWebAPIContext : DbContext
    {
        public HelloWebAPIContext (DbContextOptions<HelloWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWebAPI.Models.Movie> Movie { get; set; }
    }
}
