using BroccoliSoup.Logic.Recipes;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BroccoliSoup.Logic.SQL.ReadingRecipes
{
    internal static class RecipeNamesReader
    {
        internal static RecipeName[] GetAllRecipes(SqlConnection sqlConnection)
        {
            List<RecipeName> recipes = new();
            using (SqlCommand command = new("SELECT * FROM Recipes", sqlConnection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    recipes.Add(new RecipeName(reader.GetInt32(0), reader.GetString(1)));
                }
            }
            return recipes.ToArray();
        }
    }
}
