using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MediaTypeEntityTypeConfig : IEntityTypeConfiguration<MediaType>
{
    public void Configure(EntityTypeBuilder<MediaType> builder)
    {
        builder.HasKey(e => e.MediaTypeId);

        builder.Property(e => e.Name)
            .HasColumnType("NVARCHAR(120)")
            .IsRequired();
    }
}