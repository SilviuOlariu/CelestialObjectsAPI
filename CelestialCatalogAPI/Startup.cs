using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CelestialCatalogAPI.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using CelestialCatalogAPI.Services;
using CelestialCatalogAPI.Extensions;

namespace CelestialCatalogAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var connectionString = _configuration["ConnectionStrings:CelestialCatalogConnectionString"];
            services.AddDbContext<CelestialCatalogContext>(
                o =>
                {
                    o.UseSqlServer(connectionString);
                }
                );
            services.AddTransient<TypeCalculator, TypeCalculator>();
            services.AddScoped<ICatalogRepository, CatalogRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
          
        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

           
        }
    }
}
