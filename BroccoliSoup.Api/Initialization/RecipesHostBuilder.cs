using Azure.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroccoliSoup.Api.Initialization
{
    internal static class RecipesHostBuilder
    {
        public static IHostBuilder Build(string[] args)
        {
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((context, config) =>
            {
                if (context.HostingEnvironment.IsProduction())
                {
                    Uri keyVaultEndpoint = new(Environment.GetEnvironmentVariable("VaultUri")!);
                    _ = config.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());
                }
            });
            _ = hostBuilder.ConfigureWebHostDefaults(webBuilder =>
            {
                _ = webBuilder.UseStartup<Startup>();
            });
            return hostBuilder;
        }
    }
}
