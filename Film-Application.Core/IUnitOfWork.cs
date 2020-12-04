using System;
using System.Threading.Tasks;
using Film_Application.Core.Repositories;

namespace Film_Application.Core
{
    public interface IUnitOfWork
    {
        IFilmRepository FilmRepository { get; }
        IGenreRepository GenreRepository { get; }
        void Commit();
        void Rollback();
    }
}
