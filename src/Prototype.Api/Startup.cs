using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prototype.Api.Handlers;
using Prototype.Api.Repositories;
using Prototype.Common.Auth;
using Prototype.Common.Events;
using Prototype.Common.Mongo;
using Prototype.Common.RabbitMq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Prototype.Api
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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddMvc();
            services.AddJwt(Configuration);
            services.AddRabbitMq(Configuration);
            services.AddMongoDB(Configuration);
            services.AddScoped<IEventHandler<ActivityCreated>, ActivityCreatedHandler>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // app.UseCors(options => options.WithOrigins("http://localhost:8080"));
            // app.useCors(options => options.AllowAnyOrigin);
            app.UseCors("CorsPolicy");


            app.ApplicationServices.GetService<IDatabaseInitializer>().InitializeAsync();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
