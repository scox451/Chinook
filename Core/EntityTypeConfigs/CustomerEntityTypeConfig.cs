using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerEntityTypeConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("customers");

        builder.HasIndex(e => e.SupportRepId, "IFK_CustomerSupportRepId");

        builder.Property(e => e.Address).HasColumnType("NVARCHAR(70)");

        builder.Property(e => e.City).HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.Company).HasColumnType("NVARCHAR(80)");

        builder.Property(e => e.Country).HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.Email)
            .IsRequired()
            .HasColumnType("NVARCHAR(60)");

        builder.Property(e => e.Fax).HasColumnType("NVARCHAR(24)");

        builder.Property(e => e.FirstName)
            .IsRequired()
            .HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.LastName)
            .IsRequired()
            .HasColumnType("NVARCHAR(20)");

        builder.Property(e => e.Phone).HasColumnType("NVARCHAR(24)");

        builder.Property(e => e.PostalCode).HasColumnType("NVARCHAR(10)");

        builder.Property(e => e.State).HasColumnType("NVARCHAR(40)");

        builder.HasOne(d => d.SupportRep)
            .WithMany(p => p.Customers)
            .HasForeignKey(d => d.SupportRepId);
    }
}