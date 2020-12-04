using Film_Application.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Film_Application.Data.Configs
{
    public class FilmGenreConfiguration : IEntityTypeConfiguration<FilmGenre>
    {
        public void Configure(EntityTypeBuilder<FilmGenre> builder)
        {
            builder.HasKey(bc => new { bc.FilmId, bc.GenreId });

            builder.HasOne(a => a.Film)
                .WithMany(m => m.FilmGenres)
                .HasForeignKey(a => a.FilmId);

            builder.HasOne(a=>a.Genre)
                .WithMany(m=>m.FilmGenres)
                .HasForeignKey(a => a.GenreId);


        }
    }
}
