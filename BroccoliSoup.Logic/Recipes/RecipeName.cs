using System.ComponentModel.DataAnnotations;

namespace BroccoliSoup.Logic.Recipes
{
    public record RecipeName
    {
        public int Id { get; }
        [Required]
        public string Name { get; }
        public string Image { get; }
        public string Ingredients { get; }

        public RecipeName(int id, string name, string image, string ingredients)
        {
            Id = id;
            Name = name;
            Image = image;
            Ingredients = ingredients;
        }
    }
}
