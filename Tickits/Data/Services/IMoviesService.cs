using System.Threading.Tasks;
using Tickits.Data.Base;
using Tickits.Data.ViewModels;
using Tickits.Models;

namespace Tickits.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsVaules();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}
