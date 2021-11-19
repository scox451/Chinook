using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InvoicesEntityTypeConfig : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.HasKey(e => e.InvoiceId);

        builder.Property(e => e.CustomerId)
            .HasColumnType("INTEGER");

        builder.Property(e => e.BillingAddress)
            .HasColumnType("NVARCHAR(70)")
            .IsRequired();  

        builder.Property(e => e.BillingCity)
            .HasColumnType("NVARCHAR(40)")
            .IsRequired();  

        builder.Property(e => e.BillingState)
            .HasColumnType("NVARCHAR(40)")
            .IsRequired();  

        builder.Property(e => e.BillingCountry)
            .HasColumnType("NVARCHAR(40)")
            .IsRequired();  

        builder.Property(e => e.BillingPostalCode)
            .HasColumnType("NVARCHAR(10)")
            .IsRequired();  

            builder.Property(e => e.Total)
            .HasColumnType("NUMERIC(10,2)");

    }
}