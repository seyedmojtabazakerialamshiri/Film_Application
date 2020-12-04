using System.Collections.Generic;

namespace Film_Application.Core.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public ICollection<FilmGenre> FilmGenres { get; set; }

    }
}
