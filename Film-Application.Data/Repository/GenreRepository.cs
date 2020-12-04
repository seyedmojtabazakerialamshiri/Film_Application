using Film_Application.Core.Models;
using Film_Application.Core.Repositories;
using Film_Application.Data.Context;

namespace Film_Application.Data.Repository
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(FilmDbContext context) : base(context)
        {
        }
    }
}
