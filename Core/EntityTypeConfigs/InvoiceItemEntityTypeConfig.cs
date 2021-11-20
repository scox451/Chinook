using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InvoiceItemEntityTypeConfig : IEntityTypeConfiguration<InvoiceItem>
{
    public void Configure(EntityTypeBuilder<InvoiceItem> builder)
    {
        builder.HasKey(e => e.InvoiceLineId);

        builder.ToTable("invoice_items");

        builder.HasIndex(e => e.InvoiceId, "IFK_InvoiceLineInvoiceId");

        builder.HasIndex(e => e.TrackId, "IFK_InvoiceLineTrackId");

        builder.Property(e => e.UnitPrice)
            .IsRequired()
            .HasColumnType("NUMERIC(10,2)");

        builder.HasOne(d => d.Invoice)
            .WithMany(p => p.InvoiceItems)
            .HasForeignKey(d => d.InvoiceId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.Track)
            .WithMany(p => p.InvoiceItems)
            .HasForeignKey(d => d.TrackId)
            .OnDelete(DeleteBehavior.ClientSetNull);

    }
}