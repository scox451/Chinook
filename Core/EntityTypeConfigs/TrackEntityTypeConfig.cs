using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TrackEntityTypeConfig : IEntityTypeConfiguration<Track>
{
    public void Configure(EntityTypeBuilder<Track> builder)
    {
        builder.HasKey(e => e.TrackId);

        builder.Property(e => e.Name)
            .HasColumnType("NVARCHAR(200)")
            .IsRequired();

        builder.Property(e => e.AlbumId)
            .HasColumnType("INTEGER");

        builder.Property(e => e.MediaTypeId)
            .HasColumnType("INTEGER");

        builder.Property(e => e.GenreId)
            .HasColumnType("INTEGER");

        builder.Property(e => e.Composer)
            .HasColumnType("NVARCHAR(220)")
            .IsRequired();
        
        builder.Property(e => e.Milliseconds)
            .HasColumnType("INTEGER");

        builder.Property(e => e.Bytes)
            .HasColumnType("INTEGER");

        builder.Property(e => e.UnitPrice)
            .HasColumnType("NUMERIC(10,2)");

    }
}