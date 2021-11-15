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
            optionsBuilder.UseSqlite("Data Source=blog.db");
           using (var db = new AppDbContext(optionsBuilder.Options))
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");
                
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Customer { FirstName = "Bob" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var cust = db.Customers
                    .OrderBy(b => b.CustomerId)
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