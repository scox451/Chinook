using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TrackEntityTypeConfig : IEntityTypeConfiguration<Track>
{
    public void Configure(EntityTypeBuilder<Track> builder)
    {
        builder.ToTable("tracks");

        builder.HasIndex(e => e.AlbumId, "IFK_TrackAlbumId");

        builder.HasIndex(e => e.GenreId, "IFK_TrackGenreId");

        builder.HasIndex(e => e.MediaTypeId, "IFK_TrackMediaTypeId");

        builder.Property(e => e.Composer).HasColumnType("NVARCHAR(220)");

        builder.Property(e => e.Name)
            .IsRequired()
            .HasColumnType("NVARCHAR(200)");

        builder.Property(e => e.UnitPrice)
            .IsRequired()
            .HasColumnType("NUMERIC(10,2)");

        builder.HasOne(d => d.Album)
            .WithMany(p => p.Tracks)
            .HasForeignKey(d => d.AlbumId);

        builder.HasOne(d => d.Genre)
            .WithMany(p => p.Tracks)
            .HasForeignKey(d => d.GenreId);

        builder.HasOne(d => d.MediaType)
            .WithMany(p => p.Tracks)
            .HasForeignKey(d => d.MediaTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull);

    }
}