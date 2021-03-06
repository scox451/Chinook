using Microsoft.EntityFrameworkCore;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EmployeeEntityTypeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("employees");

        builder.HasIndex(e => e.ReportsTo, "IFK_EmployeeReportsTo");

        builder.Property(e => e.Address).HasColumnType("NVARCHAR(70)");

        builder.Property(e => e.BirthDate).HasColumnType("DATETIME");

        builder.Property(e => e.City).HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.Country).HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.Email).HasColumnType("NVARCHAR(60)");

        builder.Property(e => e.Fax).HasColumnType("NVARCHAR(24)");

        builder.Property(e => e.FirstName)
            .IsRequired()
            .HasColumnType("NVARCHAR(20)");

        builder.Property(e => e.HireDate).HasColumnType("DATETIME");

        builder.Property(e => e.LastName)
            .IsRequired()
            .HasColumnType("NVARCHAR(20)");

        builder.Property(e => e.Phone).HasColumnType("NVARCHAR(24)");

        builder.Property(e => e.PostalCode).HasColumnType("NVARCHAR(10)");

        builder.Property(e => e.State).HasColumnType("NVARCHAR(40)");

        builder.Property(e => e.Title).HasColumnType("NVARCHAR(30)");

        builder.HasOne(d => d.ReportsToNavigation)
            .WithMany(p => p.InverseReportsToNavigation)
            .HasForeignKey(d => d.ReportsTo);

    }
}