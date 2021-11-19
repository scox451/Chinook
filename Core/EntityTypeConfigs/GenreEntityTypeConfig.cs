using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class GenreEntityTypeConfig : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasKey(e => e.GenreId);

        builder.Property(e => e.Name)
            .HasColumnType("NVARCHAR(120)")
            .IsRequired();    
    }
}