using MovieStoreMvc6.Models.Domain;
using MovieStoreMvc6.Models.DTO;

namespace MovieStoreMvc6.Repositories.Abstract
{
    public interface IMovieService
    {
        bool Add(Movie model);
        bool Update(Movie model);
        Movie GetById(int id);
        bool Delete(int id);
        MovieListVm List(string term = "", bool paging = false, int currentPage = 0);
        List<int> GetGenreByMovieId(int movieId);
       
    }
}
