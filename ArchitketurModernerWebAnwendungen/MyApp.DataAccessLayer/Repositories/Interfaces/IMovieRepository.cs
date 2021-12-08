using MyApp.DataAccessLayer.Models;
using RepositoryPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccessLayer.Repositories.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Movie MovieOfTheYear(int year);
    }
}
