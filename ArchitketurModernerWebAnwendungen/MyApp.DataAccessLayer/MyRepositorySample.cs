using Microsoft.EntityFrameworkCore;
using MyApp.DataAccessLayer.Data;
using MyApp.DataAccessLayer.Models;
using MyApp.DataAccessLayer.Repositories;
using MyApp.DataAccessLayer.Repositories.Interfaces;
using RepositoryPattern.Abstraction;
using RepositoryPattern.EF;
using System;

namespace MyApp.DataAccessLayer
{
    public class MyRepositorySample
    {
        public void ImplementionSample()
        {
            MovieDbContext movieDbContext = new MovieDbContext(new DbContextOptions<MovieDbContext>());

            IRepository<Movie> movieRepository = new Repository<Movie>(movieDbContext);

            IReadonlyRepository<Movie> movieRepository2 = new Repository<Movie>(movieDbContext);
        }

        public void ImplementionSample2()
        {
            MovieDbContext movieDbContext = new MovieDbContext(new DbContextOptions<MovieDbContext>());

            IMovieRepository movieRepository = new MovieRepository(movieDbContext);

            IReadonlyRepository<Movie> readonlyRepository = new MovieRepository(movieDbContext);
            
        }
    }
}
