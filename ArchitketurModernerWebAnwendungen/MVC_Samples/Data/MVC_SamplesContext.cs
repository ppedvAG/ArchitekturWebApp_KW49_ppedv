using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Samples.Models;

namespace MVC_Samples.Data
{
    public class MVC_SamplesContext : DbContext
    {
        public MVC_SamplesContext (DbContextOptions<MVC_SamplesContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Samples.Models.Movie> Movie { get; set; }
    }
}
