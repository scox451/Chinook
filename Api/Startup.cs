using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace chinook.api
{
    public class Startup
    {
        readonly string CustomCorsPolicy = "CustomCorsPolicy";
        readonly string[] AllowedOrigins = new[] {
                "http://localhost:4200",
                "https://localhost:4200",
                "http://localhost",
                "https://localhost",
                "https://chinook"
            };
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "chinook.api", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy(CustomCorsPolicy, builder =>
                {
                    builder.WithOrigins(AllowedOrigins)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        //.AllowCredentials()
                        //.SetIsOriginAllowed((host) => true)
                        ;
                });
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "chinook.api v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(CustomCorsPolicy);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
