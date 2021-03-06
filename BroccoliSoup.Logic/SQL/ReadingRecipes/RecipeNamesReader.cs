using BroccoliSoup.Logic.Recipes;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BroccoliSoup.Logic.SQL.ReadingRecipes
{
    internal static class RecipeNamesReader
    {
        internal static RecipeName[] GetAllRecipes(string connectionString)
        {
            List<RecipeName> recipes = new();
            using SqlConnection connection = new(connectionString);
            connection.Open();
            using (SqlCommand command = new("SELECT * FROM Recipes", connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                    recipes.Add(new RecipeName(reader.GetInt32(0), reader.GetString(1), reader.GetString(3), reader.GetString(4)));
            }
            return recipes.ToArray();
        }
    }
}
