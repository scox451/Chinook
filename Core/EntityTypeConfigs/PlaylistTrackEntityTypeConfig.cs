using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PlaylistTrackEntityTypeConfig : IEntityTypeConfiguration<PlaylistTrack>
{
    public void Configure(EntityTypeBuilder<PlaylistTrack> builder)
    {
        builder.HasKey(e => new { e.PlaylistId, e.TrackId });

        builder.ToTable("playlist_track");

        builder.HasIndex(e => e.TrackId, "IFK_PlaylistTrackTrackId");

        builder.HasOne(d => d.Playlist)
            .WithMany(p => p.PlaylistTracks)
            .HasForeignKey(d => d.PlaylistId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.Track)
            .WithMany(p => p.PlaylistTracks)
            .HasForeignKey(d => d.TrackId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}