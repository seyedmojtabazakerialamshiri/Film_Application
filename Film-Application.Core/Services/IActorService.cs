using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Film_Application.Core.Models;

namespace Film_Application.Core.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Task<Actor> GetActorById(int id);
        Task<Actor> CreateActor(Actor newActor);
        Task UpdateActor(Actor old, Actor actor);
        Task DeleteActor(Actor actor);
    }
}
