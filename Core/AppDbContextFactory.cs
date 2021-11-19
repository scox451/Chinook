using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Chinook.Core;
using System.Diagnostics;
using System.Reflection;

public class DbFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                
                optionsBuilder.UseSqlite($"Filename=c:\\projects\\app.db", 
                    options => 
                    {
                        options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                    });
                    
                return new AppDbContext(optionsBuilder.Options);

            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }

        }
    }