using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MyEvents.API.Data.Context;
using MyEvents.API.Data.Repositores;
using MyEvents.API.Domain.Entity;
using MyEvents.API.Services;

namespace MyEvents.API
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
            #region Context
            services.AddDbContext<DataContext>(context => context.UseSqlite(Configuration.GetConnectionString("SQLite")));
            #endregion

            #region Controller
            services.AddControllers();
            #endregion

            #region ServiceConfiguration
            services.AddServiceConfiguration();
            #endregion

            #region RepositoriesConfiguration
            services.AddRepositoriesConfiguration();
            #endregion

            #region ApiVersioning
            services.AddApiVersioning();
            #endregion

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyEvents.API", Version = "v1" });
            });
            #endregion

            #region AutoMapper
            services.AddAutoMapperConfiguration();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyEvents.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
