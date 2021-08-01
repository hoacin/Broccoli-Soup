using BroccoliSoup.Logic.Recipes;
using System;
using System.Data.SqlClient;

namespace BroccoliSoup.Logic.SQL.ReadingRecipes
{
    public sealed class SqlRecipeReader : IRecipesReader
    {
        private readonly string _connectionString;
        public SqlRecipeReader(string connectionString)
        {
            _connectionString = connectionString;
        }

        public RecipeName[] GetAllRecipes() => RecipeNamesReader.GetAllRecipes(_connectionString);
        public Ingredient[] GetIngredients(int recipeID) => IngredientsReader.GetIngredients(_connectionString, recipeID);
        public RecipeStep[] GetSteps(int recipeID) => StepsReader.GetSteps(_connectionString, recipeID);
    }
}
