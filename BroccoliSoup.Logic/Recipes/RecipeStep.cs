using System.ComponentModel.DataAnnotations;

namespace BroccoliSoup.Logic.Recipes
{
    public record RecipeStep
    {
        //Notation for API
        [Required]
        public string Description { get; }
        public string? Image { get; }

        public RecipeStep(string description, string? image)
        {
            Description = description;
            Image = image;
        }
    }
}
