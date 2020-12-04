using Film_Application.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Film_Application.Data.Configs
{
    public class FilmActorConfiguration : IEntityTypeConfiguration<FilmActor>
    {
        public void Configure(EntityTypeBuilder<FilmActor> builder)
        {
            builder.HasKey(bc => new { bc.FilmId, bc.ActorId });

            builder.HasOne(a => a.Film)
                .WithMany(m => m.FilmActors)
                .HasForeignKey(a => a.FilmId);

            builder.HasOne(a => a.Actor)
                .WithMany(m => m.FilmActors)
                .HasForeignKey(a => a.ActorId);
        }
    }
}
