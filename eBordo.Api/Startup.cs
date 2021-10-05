using eBordo.Api.Database;
using eBordo.Api.Services.BaseREADService;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Api.Services.Drzava;
using eBordo.Api.Services.Grad;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBordo.Api.Services.Igrac;
using eBordo.Api.Services.Pozicija;
using eBordo.Api.Services.Korisnik;
using eBordo.Api.Services.IgracStatistika;
using eBordo.Model.Models;
using eBordo.Api.Services.IgracSkills;
using eBordo.Api.Services.Ugovor;
using Microsoft.AspNetCore.Authentication;
using eBordo.Api.Security;
using Microsoft.OpenApi.Models;

namespace eBordo.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eBordo API", Version = "v1" });

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

            services.AddDbContext<eBordoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(Startup));

            //SERVICES
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IDrzavaService, DrzavaService>();
            services.AddScoped<IGradService, GradService>();
            services.AddScoped<IIgracService, IgracService>();
            services.AddScoped<IPozicijaService, PozicijaService>();
            services.AddScoped<IIgracStatistikaService, IgracStatistikaService>();
            services.AddScoped<IIgracSkillsService, IgracSkillsService>();
            services.AddScoped<IUgovorService, UgovorService>();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddHttpContextAccessor();
            //services.AddScoped<IBaseREADService<eBordo.Model.Models.Drzava, object>, BaseREADService<eBordo.Model.Models.Drzava, eBordo.Api.Database.Drzava, object>>();
            //services.AddScoped<IBaseREADService<eBordo.Model.Models.Grad, eBordo.Model.Requests.Grad.GradSearchObject>, BaseREADService<eBordo.Model.Models.Grad, eBordo.Api.Database.Grad, eBordo.Model.Requests.Grad.GradSearchObject>>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

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
