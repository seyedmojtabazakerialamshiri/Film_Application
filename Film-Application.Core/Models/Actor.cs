using System.Collections.Generic;

namespace Film_Application.Core.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
        public ICollection<FilmActor> FilmActors { get; set; }
    }
}
