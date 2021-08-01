using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace BroccoliSoup.Api.Initialization
{
    internal static class SwaggerInitialization
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            _ = services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Brocoli Soup Api", Version = "v1" });
            });
        }
    }
}
