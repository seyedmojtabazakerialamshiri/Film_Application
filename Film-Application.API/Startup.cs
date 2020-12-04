using System;
using Film_Application.Core;
using Film_Application.Core.Repositories;
using Film_Application.Core.Services;
using Film_Application.Data;
using Film_Application.Data.Context;
using Film_Application.Data.Repository;
using Film_Application.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;


namespace Film_Application.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FilmDbContext>(options => options.UseSqlite("Data Source=Database.db"));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<IFilmService, FilmService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddControllers();

            services.AddSwaggerGen(option =>
            {
                var xmlDocPath = $"{AppContext.BaseDirectory}Api.xml";
                option.IncludeXmlComments(xmlDocPath, true);

                option.EnableAnnotations();

                option.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


        }
    }
}
