using Microsoft.EntityFrameworkCore;
using MyApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccessLayer.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> dbContextOptions)
            :base(dbContextOptions)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
