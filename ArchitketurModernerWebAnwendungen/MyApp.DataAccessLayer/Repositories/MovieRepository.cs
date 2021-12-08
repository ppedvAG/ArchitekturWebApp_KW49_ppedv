using MyApp.DataAccessLayer.Data;
using MyApp.DataAccessLayer.Models;
using MyApp.DataAccessLayer.Repositories.Interfaces;
using RepositoryPattern.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccessLayer.Repositories
{
    public class MovieRepository : RepositoryAbstractClass<Movie>, IMovieRepository
    {
        public MovieRepository(MovieDbContext context)
            :base(context)
        {

        }

        public Movie MovieOfTheYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}
