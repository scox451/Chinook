using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Chinook.Core.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public string DbPath { get; private set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            DbPath = $"c:\\projects\\app.db";

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //enable fluent mapping to our obj to handle concurrency
            modelBuilder.Entity<Customer>()
            .Property(x => x.RowVersion)
            .IsRowVersion();

            base.OnModelCreating(modelBuilder);
        }


    }
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=blog.db");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}


