using BroccoliSoup.Logic.Recipes;
using BroccoliSoup.Logic.SQL.ReadingRecipes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BroccoliSoup.Api.Initialization
{
    internal static class RecipesInitialization
    {
        public static void AddRecipesReader(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            SqlRecipeReader recipeReader = new(configuration.GetConnectionString("DefaultSqlConnection"));
            _ = serviceCollection.AddSingleton<IRecipesReader>(recipeReader);
        }
    }
}
