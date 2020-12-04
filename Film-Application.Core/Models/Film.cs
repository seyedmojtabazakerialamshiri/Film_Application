using System.Collections.Generic;

namespace Film_Application.Core.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Url { get; set; }
        public ICollection<FilmGenre> FilmGenres { get; set; }
        public ICollection<FilmActor> FilmActors { get; set; }
    }
}
