using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MediaTypeEntityTypeConfig : IEntityTypeConfiguration<MediaType>
{
    public void Configure(EntityTypeBuilder<MediaType> builder)
    {
        builder.ToTable("media_types");

        builder.Property(e => e.Name).HasColumnType("NVARCHAR(120)");
    }
}