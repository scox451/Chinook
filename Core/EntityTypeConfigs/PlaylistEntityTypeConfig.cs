using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PlaylistEntityTypeConfig : IEntityTypeConfiguration<Playlist>
{
    public void Configure(EntityTypeBuilder<Playlist> builder)
    {
        builder.ToTable("playlists");

        builder.Property(e => e.Name).HasColumnType("NVARCHAR(120)");

    }
}