using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using APISMARTHR1.Entities;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace APISMARTHR1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            MigrateDatabase(host);
            
            host.Run();
        }

        private static void MigrateDatabase(IWebHost host)
        {
            //throw new NotImplementedException();
            using (var scope = host.Services.CreateScope())
            {

                var context = scope.ServiceProvider
                            .GetRequiredService<EmployerContext>();

                context.Database.Migrate();

            }


        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
