using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using HandleLet.Models;
using HandleLet.Interfaces;

namespace HandleLet.Pages.Recipes
{
    public class CreateRecipeModel : PageModel
    {
        public string errorMessage = "";
        [BindProperty]
        public Recipe recipe { get; set; }
        
        private IRecipe repo;
        public CreateRecipeModel(IRecipe repository)
        {
            repo = repository;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (repo.GetRecipeId(recipe.id).id == recipe.id)
            {
                errorMessage = "ID findes allerede";
                return Page();
            }
            else
            {
                repo.CreateRecipe(recipe);
            }
            return RedirectToPage("/Recipes/Recipe");
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
