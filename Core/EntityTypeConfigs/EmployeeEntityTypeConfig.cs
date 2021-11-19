using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EmployeeEntityTypeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(e => e.EmployeeId);

        builder.Property(e => e.FirstName)
            .HasColumnType("NVARCHAR(20)")
            .IsRequired();
        
        builder.Property(e => e.LastName)
            .HasColumnType("NVARCHAR(20)")
            .IsRequired();
        
        builder.Property(e => e.Title)
           .HasColumnType("NVARCHAR(30)");

        builder.Property(e => e.ReportsTo)
            .HasColumnType("INTEGER");
  
        builder.Property(e => e.BirthDate)
            .HasColumnType("DATETIME");
  
        builder.Property(e => e.HireDate)
            .HasColumnType("DATETIME");
             
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
            
    }
}