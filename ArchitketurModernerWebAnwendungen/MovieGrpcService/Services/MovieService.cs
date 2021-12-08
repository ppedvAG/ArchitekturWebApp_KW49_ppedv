using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MovieGrpcService.MovieServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieGrpcService.Services
{
    public class MovieService : MyMovieService.MyMovieServiceBase
    {
        public override async Task<MovieData> GetMovies(Empty request, IServerStreamWriter<MovieData> responseStream, ServerCallContext context)
        {

            await Task.Delay(2000); // Gotta look busy


            IList<MovieData> movieList = new List<MovieData>();
            movieList.Add(new MovieData { Id = 1, Title = "Dune", Description = "Film mit Ausseriridischen" });
            movieList.Add(new MovieData { Id = 2, Title = "Dune 1", Description = "Film mit Ausseriridischen" });
            movieList.Add(new MovieData { Id = 3, Title = "Dune 2", Description = "Film mit Ausseriridischen" });
            
            
            await responseStream.WriteAsync

            return 
        }
    }
}
