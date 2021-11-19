using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AlbumEntityTypeConfig : IEntityTypeConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder.HasKey(e => e.AlbumId);

        builder.Property(e => e.Title)
            .HasColumnType("NVARCHAR(160)");

        builder.Property(e => e.ArtistId)
            .HasColumnType("INTEGER");
    }
}