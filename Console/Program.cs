using System;
using System.Linq;
using Chinook.Core;
using Chinook.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Chinook.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

             var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite($"Data Source=c:projects\\app.db");
           using (var db = new AppDbContext(optionsBuilder.Options))
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");
                
                // Create
                Console.WriteLine("Inserting a new Customer");
                db.Add(new Customer { FirstName = "Bob" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a Customer");
                var cust = db.Customers
                    .OrderBy(b => b.CustomerId)
                    .First();

                                    // Create
                Console.WriteLine("Inserting a new Album");
                db.Add(new Album { Title = "Space Adventure" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for an Albulm");
                var album = db.Albums
                    .OrderBy(b => b.AlbumId)
                    .First();

                // Update
                // Console.WriteLine("Updating the blog and adding a post");
                // cust.Url = "https://devblogs.microsoft.com/dotnet";
                // cust.Posts.Add(
                //     new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
                // db.SaveChanges();

                // // Delete
                // Console.WriteLine("Delete the blog");
                // db.Remove(blog);
                // db.SaveChanges();
            }
        }
    }
}