using BroccoliSoup.Logic.Recipes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroccoliSoup.Logic.SQL.ReadingRecipes
{
    internal static class IngredientsReader
    {
        public static Ingredient[] GetIngredients(string connectionString, int recipeID)
        {
            List<Ingredient> ingredients = new();
            using SqlConnection connection = new(connectionString);
            connection.Open();
            using (SqlCommand command = new($"SELECT * FROM Ingredients WHERE RECIPE = {recipeID}", connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ingredients.Add(new Ingredient(reader.GetString(1)));
                }
            }
            return ingredients.ToArray();
        }
    }
}
