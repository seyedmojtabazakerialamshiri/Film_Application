using Film_Application.Core.Models;
using Film_Application.Data.Configs;
using Microsoft.EntityFrameworkCore;

namespace Film_Application.Data.Context
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options) : base(options)
        {

        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<FilmGenre> FilmGenres { get; set; }
        public DbSet<FilmActor> FilmActors { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FilmActorConfiguration());
            builder.ApplyConfiguration(new FilmGenreConfiguration());
        }
    }

    
}
