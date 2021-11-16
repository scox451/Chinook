using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PlaylistTrackEntityTypeConfig : IEntityTypeConfiguration<PlaylistTrack>
{
    public void Configure(EntityTypeBuilder<PlaylistTrack> builder)
    {
          builder.HasNoKey();
                builder.ToTable("PlaylistTracks");
                builder.Property(e => e.PlaylistId).HasColumnName("PlaylistId");
                builder.Property(e => e.TrackId).HasColumnName("TrackId");

    }
}