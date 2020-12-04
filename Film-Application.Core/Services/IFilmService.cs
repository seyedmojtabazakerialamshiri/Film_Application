using System.Collections.Generic;
using System.Threading.Tasks;
using Film_Application.Core.Models;

namespace Film_Application.Core.Services
{
    public interface IFilmService
    {
        IEnumerable<Film> GetAllFilms();
        Film GetFilmById(int id);
        Task<Film> CreateFilm(Film newFilm);
        void UpdateFilm(Film old, Film film);
        void DeleteFilm(Film film);
    }
}
