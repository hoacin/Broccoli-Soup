using System.ComponentModel.DataAnnotations;

namespace BroccoliSoup.Logic.Recipes
{
    public record RecipeName
    {
        public int Id { get; }
        [Required]
        public string Name { get; }

        public RecipeName(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
