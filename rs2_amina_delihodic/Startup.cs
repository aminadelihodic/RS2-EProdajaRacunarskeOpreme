using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.Filters;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using EProdajaRacunarskeOpreme.WebApi.Repository;
using EProdajaRacunarskeOpreme.WebApi.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rs2_amina_delihodic
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eProdaja API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });

            var connection = Configuration.GetConnectionString("connectionstring");
            services.AddDbContext<MojDbContext>(options => options.UseSqlServer(connection));
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IRepositoryKorisnici, RepositoryKorisnici>();
            services.AddScoped<IRepositoryVrsteProizvoda, RepositoryVrsteProizvoda>();
            services.AddScoped<IRepositoryProizvodi, RepositoryProizvodi>();
            services.AddScoped<IRepositoryDobavljaci, RepositoryDobavljaci>();
            services.AddScoped<IRepositoryKarakteristike, RepositoryKarakteristike>();
            services.AddScoped<IRepositoryKlijenti, RepositoryKlijenti>();
            services.AddScoped<IRepositoryNabavka, RepositoryNabavka>();
            services.AddScoped<IRepositoryNabavkaStavke, RepositoryNabavkaStavke>();
            services.AddScoped<IRepositoryOcjene, RepositoryOcjene>();
            services.AddScoped<IRepositoryProizvodjaci, RepositoryProizvodjaci>();
            services.AddScoped<IRepositoryUloge, RepositoryUloge>();
            services.AddScoped<IRepositoryNarudzba, RepositoryNarudzba>();
            services.AddScoped<IRepositoryNarudzbaStavke, RepositoryNarudzbaStavke>();
            services.AddScoped<IRepositoryRecommended, RepositoryRecommended>();
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
               
            });
            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
