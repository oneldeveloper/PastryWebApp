using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PastryWebApp.Data;
using PastryWebApp.Database;
using PastryWebApp.Database.Entities;

namespace PastryWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool resetDb = false;
            if (args.Length > 0)
            {
                if (args.Contains("resetDb"))
                    resetDb = true;

            }

            var host = CreateHostBuilder(args).Build();
            if(resetDb)
            {
                using (var serviceScope = host.Services.CreateScope())
                {
                    var pastryContext = serviceScope.ServiceProvider.GetRequiredService<PastryDbContext>();
                    DbUtils.Create(pastryContext);

                    PastryDemo.CreateTortaParadiso(pastryContext);
                    PastryDemo.CreateTiramisu(pastryContext);
                    PastryDemo.CreateCrostata(pastryContext);
                    PastryDemo.CreateBavarese(pastryContext);

                }
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
