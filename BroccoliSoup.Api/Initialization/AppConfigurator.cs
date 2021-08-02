using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BroccoliSoup.Api.Initialization
{
    internal static class AppConfigurator
    {
        public static void Configure(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                _ = app.UseDeveloperExceptionPage();
            _ = app.UseSwagger();
            _ = app.UseSwaggerUI((c) =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BroccoliSoup.Api v1");
                c.RoutePrefix = "";
            });
            _ = app.UseHttpsRedirection();
            _ = app.UseRouting();
            _ = app.UseCors("OpenPolicy");
            _ = app.UseAuthorization();
            _ = app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapControllers();
            });
        }
    }
}
