using HandleLet.Models;

namespace HandleLet.Interfaces
{
    public interface IRecipe
    {
        public List<Recipe> GetRecipe();

        public Recipe GetRecipe(string Title);

        public void DeleteRecipe(string Title);

        public void CreateRecipe(Recipe recipe);
  

    }
}
