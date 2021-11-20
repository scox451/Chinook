using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AlbumEntityTypeConfig : IEntityTypeConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder.ToTable("albums");

        builder.HasIndex(e => e.ArtistId, "IFK_AlbumArtistId");

        builder.Property(e => e.Title)
            .IsRequired()
            .HasColumnType("NVARCHAR(160)");

        builder.HasOne(d => d.Artist)
            .WithMany(p => p.Albums)
            .HasForeignKey(d => d.ArtistId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}
