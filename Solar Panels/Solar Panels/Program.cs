using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GreenGo.DB.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        // var hostingUrlPrefixes = new[] { "portal/api/license" };
        //
        //     return WebHost
        //     .CreateDefaultBuilder(args)
        //     .ConfigureAppConfiguration(ApplicationConfiguration.Apply)
        //     .UseCoreLibrariesAspNetCoreHosting(hostingUrlPrefixes)
        //     .UseStartup<Startup>()
        //     .UseSetting(WebHostDefaults.ApplicationKey, typeof(LicensePortalWebHostCreator).Assembly.FullName);

    }
}
