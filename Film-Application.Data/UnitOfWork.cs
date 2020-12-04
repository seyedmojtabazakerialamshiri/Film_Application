using System;
using System.Threading.Tasks;
using Film_Application.Core;
using Film_Application.Core.Repositories;
using Film_Application.Data.Context;
using Film_Application.Data.Repository;

namespace Film_Application.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FilmDbContext _context;

        public UnitOfWork(FilmDbContext context)
        {
            _context = context;
        }


        private IFilmRepository RepositoryFilm { get; set; }
        private IGenreRepository RepositoryGenre { get; set; }

        public IFilmRepository FilmRepository => RepositoryFilm ??= new FilmRepository(_context);

        public IGenreRepository GenreRepository => RepositoryGenre ??= new GenreRepository(_context);


        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            _context.Dispose();
        }


    }
}
