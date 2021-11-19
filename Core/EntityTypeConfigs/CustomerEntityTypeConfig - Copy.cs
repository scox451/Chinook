using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerEntityTypeConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(e => e.CustomerId);

        builder.Property(e => e.FirstName)
            .HasColumnType("NVARCHAR(40)")
            .IsRequired();
        
        builder.Property(e => e.LastName)
            .HasColumnType("NVARCHAR(20)")
            .IsRequired();
        
        builder.Property(e => e.Company)
           .HasColumnType("NVARCHAR(80)");
         
        builder.Property(e => e.Address)
           .HasColumnType("NVARCHAR(70)");
         
        builder.Property(e => e.City)
           .HasColumnType("NVARCHAR(40)");
         
        builder.Property(e => e.State)
           .HasColumnType("NVARCHAR(40)");
        
        builder.Property(e => e.Country)
           .HasColumnType("NVARCHAR(40)");
        
        builder.Property(e => e.PostalCode)
           .HasColumnType("NVARCHAR(10)");
        
        builder.Property(e => e.Phone)
            .HasColumnType("NVARCHAR(24)");
            
        builder.Property(e => e.Fax)
            .HasColumnType("NVARCHAR(24)");
                    
        builder.Property(e => e.Email)
            .HasColumnType("NVARCHAR(60)")
            .IsRequired();
            
        builder.Property(e => e.SupportRepId)
            .HasColumnType("INTEGER");
    }
}