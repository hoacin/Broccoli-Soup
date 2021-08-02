using System.ComponentModel.DataAnnotations;

namespace BroccoliSoup.Logic.Recipes
{
    public record RecipeStep
    {
        [Required]
        public string ShortDescription { get; }
        [Required]
        public string LongDescription { get; }
        [Required]
        public string Image { get; }

        public RecipeStep(string longDescription, string shortDescription, string image)
        {
            LongDescription = longDescription;
            ShortDescription = shortDescription;
            Image = image;
        }
    }
}
