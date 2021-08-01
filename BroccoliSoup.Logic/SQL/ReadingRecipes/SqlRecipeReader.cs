using BroccoliSoup.Logic.Recipes;
using System;
using System.Data.SqlClient;

namespace BroccoliSoup.Logic.SQL.ReadingRecipes
{
    public sealed class SqlRecipeReader : IRecipesReader
    {
        private readonly SqlConnection _sqlConnection;
        public SqlRecipeReader(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
        }

        public RecipeName[] GetAllRecipes() => RecipeNamesReader.GetAllRecipes(_sqlConnection);
        public Ingredient[] GetIngredients(int recipeID) => IngredientsReader.GetIngredients(_sqlConnection, recipeID);
        public RecipeStep[] GetSteps(int recipeID) => StepsReader.GetSteps(_sqlConnection, recipeID);

        public void Dispose()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }
    }
}
