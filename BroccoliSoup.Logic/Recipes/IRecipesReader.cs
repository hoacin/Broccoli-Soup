using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroccoliSoup.Logic.Recipes
{
    public interface IRecipesReader : IDisposable
    {
        RecipeName[] GetAllRecipes();
        Ingredient[] GetIngredients(int recipeID);
        RecipeStep[] GetSteps(int recipeID);

    }
}
