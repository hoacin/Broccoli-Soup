using System.ComponentModel.DataAnnotations;

namespace BroccoliSoup.Logic.Recipes
{
    public record Ingredient
    {
        [Required]
        public string Description { get; }
        public Ingredient(string description)
        {
            Description = description;
        }
    }
}
