using System.Collections.Generic;
using System.Threading.Tasks;
using Film_Application.Core;
using Film_Application.Core.Models;
using Film_Application.Core.Services;

namespace Film_Application.Services.Services
{
    public class FilmService : IFilmService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FilmService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Film> GetAllFilms()
        {
            return _unitOfWork.FilmRepository.GetAllAsync();
        }

        public Film GetFilmById(int id)
        {
            return  _unitOfWork.FilmRepository.GetByIdAsync(id);
        }

        public Task<Film> CreateFilm(Film newFilm)
        {
             _unitOfWork.FilmRepository.AddAsync(newFilm);
             _unitOfWork.Commit();
            return Task.FromResult(newFilm);
        }

        public void UpdateFilm(Film old, Film film)
        {
            old.Title = film.Title;
            old.Url = film.Url;
            old.Length = film.Length;
             _unitOfWork.Commit();
        }

        public void DeleteFilm(Film film)
        {
            _unitOfWork.FilmRepository.Remove(film);
             _unitOfWork.Commit();
        }
    }
}
