using Film_Application.Core.Models;
using Film_Application.Core.Repositories;
using Film_Application.Data.Context;

namespace Film_Application.Data.Repository
{
    public class FilmRepository : Repository<Film>, IFilmRepository
    {
        public FilmRepository(FilmDbContext context) : base(context)
        {
        }
    }
}
