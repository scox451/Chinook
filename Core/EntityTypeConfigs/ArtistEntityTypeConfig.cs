using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ArtistEntityTypeConfig : IEntityTypeConfiguration<Artist>
{
    public void Configure(EntityTypeBuilder<Artist> builder)
    {
        builder.HasKey(e => e.ArtistId);

        builder.Property(e => e.Name)
            .HasColumnType("NVARCHAR(120)")
            .IsRequired();
   }
}