using HandleLet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HandleLet.Models;
using System.ComponentModel;
using HandleLet.Interfaces;


namespace HandleLet.Pages.Recipes
{
    public class RecipeModel : PageModel
    {

        //private RecipeService recipeService;

        //public RecipeModel(RecipeService recipeServices)
        //{

        //    this.recipeService = recipeServices;
        //}

        //public List<Recipe> recipes { get; set; }

        //public void OnGet()
        //{

        //}

        private IRecipe repo;
        public RecipeModel(IRecipe repository)
        {
            repo = repository;
        }
        public List<Recipe> recipes { get; set; }

        public IActionResult OnGet()
        {
            recipes = repo.GetRecipe();
            recipes = recipes.OrderBy(recipe => recipe.Title).ToList();
            //if (!string.IsNullOrEmpty(FilterCriteria))
            //{
            //    itemList = repo.FilterItems(FilterCriteria);
            //}
            return Page();
        }
        public IActionResult OnPost()
        {
            return Page();
        }

       
    }
}
