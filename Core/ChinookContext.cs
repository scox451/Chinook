using System.Reflection;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Chinook.Core
{
    public class ChinookContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        // public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> Invoice_Items { get; set; }
        public DbSet<MediaType> Media_Types { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistTrack> Playlist_Track { get; set; }
        public DbSet<Track> tracks { get; set; }

        public string DbPath { get; private set; }

        public ChinookContext()
        {

        }

        public ChinookContext(DbContextOptions options) : base(options)
        {
            //pass in from the factory derived from IDesignTimeDbContextFactory<AppDbContext>
        }

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


