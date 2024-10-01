using HandleLet.Interfaces;
using HandleLet.Models;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;

namespace HandleLet.Services
{
    public class RecipeService : IRecipe
    {
        public List<Recipe> Recipes;

        public RecipeService()
        {
           // Recipes = MockUserStories.GetMockUserStories();
        }

        public List<Recipe> GetRecipe()
        {
            return Recipes;
        }

        public Recipe GetRecipe(string Title)
        {
            foreach (Recipe Recipe in Recipes)
            {
                if (Recipe.Title == Title)
                    return Recipe;
            }

            return null;
        }
        public void DeleteRecipe(string Title)
        {
            foreach (Recipe recipe in Recipes.ToList())
            {
                if (recipe.Title == Title)
                    Recipes.Remove(recipe);
            }
        }


        public void CreateRecipe(Recipe recipe)
        {

            Recipes.Add(recipe);

        }

        //public void UpdateRecipe(Recipe Title)
        //{
        //    foreach (Recipe Recipe in Recipes)
        //    {
        //        if (Recipe._title == recipe._title)
        //        {
        //            Recipe.Id = item.id;
        //            Recipe._title = item._title;

        //        }
        //    }
        //}








    }
}
