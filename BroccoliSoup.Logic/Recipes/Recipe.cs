namespace BroccoliSoup.Logic.Recipes
{
    public class Recipe
    {
        public string Name { get; }
        public int Portions { get; }
        public string? Image { get; }

        private readonly RecipeStep[] _steps;
        private readonly Ingredient[] _ingredients;

        public Recipe(string name, int portions, string image, RecipeStep[] steps, Ingredient[] ingredients)
        {
            Name = name;
            Portions = portions;
            Image = image;
            _steps = (RecipeStep[])steps.Clone();
            _ingredients = (Ingredient[])ingredients.Clone();
        }

        public Ingredient GetIngredient(int index) => _ingredients[index];
        public RecipeStep GetStep(int index) => _steps[index];
    }
}
