using Film_Application.Core.Models;
using Film_Application.Core.Repositories;
using Film_Application.Data.Context;

namespace Film_Application.Data.Repository
{
    public class ActorRepository : Repository<Actor>, IActorRepository
    {
        public ActorRepository(FilmDbContext context) : base(context)
        {
        }
    }
}
