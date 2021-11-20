using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Chinook.Core;
using System.Diagnostics;
using System.Reflection;

public class DbFactory : IDesignTimeDbContextFactory<ChinookContext>
    {
        public ChinookContext CreateDbContext(string[] args)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<ChinookContext>();
           
            //    var filename = $"Filename=c:\\projects\\app.db";
               var filename = $"Filename=c:\\projects\\chinook\\chinook.db";
             
                optionsBuilder.UseSqlite(filename, 
                    options => 
                    {
                        options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                    });
                    
                return new ChinookContext(optionsBuilder.Options);

            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }

        }
    }