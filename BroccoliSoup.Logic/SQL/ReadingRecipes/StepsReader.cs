﻿using BroccoliSoup.Logic.Recipes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroccoliSoup.Logic.SQL.ReadingRecipes
{
    internal static class StepsReader
    {
        public static RecipeStep[] GetSteps(string connectionString, int recipeID)
        {
            List<RecipeStep> steps = new();

            using SqlConnection connection = new(connectionString);
            connection.Open();

            using (SqlCommand command = new($"SELECT * FROM Steps WHERE RECIPE = {recipeID} ORDER BY Step", connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string description = reader.GetString(2);
                    string? image = reader.IsDBNull(3) ? null : reader.GetString(3);
                    steps.Add(new RecipeStep(description, image));
                }
            }
            return steps.ToArray();
        }
    }
}
