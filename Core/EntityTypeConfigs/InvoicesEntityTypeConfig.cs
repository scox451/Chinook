using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InvoicesEntityTypeConfig : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable("invoices");

        builder.HasIndex(e => e.CustomerId, "IFK_InvoiceCustomerId");

        builder.Property(e => e.BillingAddress).HasColumnType("NVARCHAR(70)");

        builder.Property(e => e.BillingCity).HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.BillingCountry).HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.BillingPostalCode).HasColumnType("NVARCHAR(10)");

        builder.Property(e => e.BillingState).HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.InvoiceDate)
            .IsRequired()
            .HasColumnType("DATETIME");

        builder.Property(e => e.Total)
            .IsRequired()
            .HasColumnType("NUMERIC(10,2)");

        builder.HasOne(d => d.Customer)
            .WithMany(p => p.Invoices)
            .HasForeignKey(d => d.CustomerId)
            .OnDelete(DeleteBehavior.ClientSetNull);

    }
}