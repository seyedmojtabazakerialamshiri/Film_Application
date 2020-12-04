using System.Collections.Generic;
using System.Threading.Tasks;
using Film_Application.Core.Models;

namespace Film_Application.Core.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllGenres();
        Task<Genre> GetGenreById(int id);
        Task<Genre> CreateGenre(Genre newGenre);
        Task UpdateActor(Genre old, Genre genre);
        Task DeleteActor(Genre genre);
    }
}
