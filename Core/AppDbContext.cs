using System.Reflection;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Chinook.Core
{
    public class AppDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceItem> InvoiceItem { get; set; }
        public DbSet<MediaType> MediaType { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<PlaylistTrack> PlaylistTrack { get; set; }
        public DbSet<Track> Track { get; set; }

        public string DbPath { get; private set; }

         public AppDbContext(DbContextOptions options):base(options)
         {
         
         } //pass in from the factory is needed in future
    
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //   => options.UseSqlite($"Filename=c:\\projects\\app.db", 
        //             options => 
        //             {
        //                 options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        //             });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AlbumEntityTypeConfig().Configure(modelBuilder.Entity<Album>());
            new ArtistEntityTypeConfig().Configure(modelBuilder.Entity<Artist>());
            new CustomerEntityTypeConfig().Configure(modelBuilder.Entity<Customer>());
            new EmployeeEntityTypeConfig().Configure(modelBuilder.Entity<Employee>());
            new GenreEntityTypeConfig().Configure(modelBuilder.Entity<Genre>());
            new InvoicesEntityTypeConfig().Configure(modelBuilder.Entity<Invoice>());
            new InvoiceItemEntityTypeConfig().Configure(modelBuilder.Entity<InvoiceItem>());
            new MediaTypeEntityTypeConfig().Configure(modelBuilder.Entity<MediaType>());
            new PlaylistEntityTypeConfig().Configure(modelBuilder.Entity<Playlist>());
            new PlaylistTrackEntityTypeConfig().Configure(modelBuilder.Entity<PlaylistTrack>());
            new TrackEntityTypeConfig().Configure(modelBuilder.Entity<Track>());

            base.OnModelCreating(modelBuilder);
        }


    }

    

}


