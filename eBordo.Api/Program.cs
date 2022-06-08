using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var eBordoContext = scope.ServiceProvider.GetRequiredService<eBordo.Api.Database.eBordoContext>();
                var korisnik_service = scope.ServiceProvider.GetRequiredService<eBordo.Api.Services.Korisnik.IKorisnikService>();
                var igrac_service = scope.ServiceProvider.GetRequiredService<eBordo.Api.Services.Igrac.IIgracService>();
                var trener_service = scope.ServiceProvider.GetRequiredService<eBordo.Api.Services.Trener.ITrenerService>();
                var utakmica_service = scope.ServiceProvider.GetRequiredService<eBordo.Api.Services.Utakmica.IUtakmicaService>();
                var izvjestaj_service = scope.ServiceProvider.GetRequiredService<eBordo.Api.Services.Izvjestaj.IIzvjestajService>();
                var trening_service = scope.ServiceProvider.GetRequiredService<eBordo.Api.Services.Trening.ITreningService>();
                Database.Data.Seed(eBordoContext, korisnik_service, igrac_service, trener_service, utakmica_service, izvjestaj_service, trening_service);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
