using HandleLet.Models;
using Microsoft.AspNetCore.Identity;

namespace HandleLet.Services
{
    public class RecipeServices
    {
        public List<Recipe> Recipes;

        public RecipeServices()
        {
            Recipes = MockUserStories.GetMockUserStories();
        }

        public List<Recipe> GetUserStories()
        {
            return Recipes;
        }

        public Recipe GetUserStory(int Id)
        {
            foreach (Recipe Recipe in Recipes)
            {
                if (Recipe.Id == Id)
                    return Recipe;
            }

            return null;
        }
        public Recipe DeleteUserStory(int RecipeID)
        {
            Recipe RecipeToBeDeleted = null;
            foreach (Recipe rp in Recipes)
            {
                if (rp.Id == RecipeID)
                {
                    RecipeToBeDeleted = rp;
                    break;
                }
            }
            if (RecipeToBeDeleted != null)
            {
                Recipes.Remove(RecipeToBeDeleted);
            }
            return RecipeToBeDeleted;
        }


        public void CreateUserStory(Recipe recipe)
        {

            Recipes.Add(recipe);

        }









    }
}
