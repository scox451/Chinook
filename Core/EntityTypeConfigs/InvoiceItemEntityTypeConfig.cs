using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InvoiceItemEntityTypeConfig : IEntityTypeConfiguration<InvoiceItem>
{
    public void Configure(EntityTypeBuilder<InvoiceItem> builder)
    {
        builder.HasKey("InvoiceLineItemId","InvoiceId");
        
        builder.Property(e => e.InvoiceLineItemId)
            .HasColumnType("INTEGER");        
            
        builder.Property(e => e.TrackId)
            .HasColumnType("INTEGER");

        builder.Property(e => e.UnitPrice)
            .HasColumnType("NUMERIC(10,2)");

        builder.Property(e => e.Quantity)
            .HasColumnType("INTEGER");


    }
}