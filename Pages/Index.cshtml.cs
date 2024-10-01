using HandleLet.Models;
using HandleLet.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HandleLet.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private RecipeService recipeService;

        public IndexModel(ILogger<IndexModel> logger, RecipeService recipeServices)
        {
            _logger = logger;
            this.recipeService = recipeServices;
        }


        public void OnGet()
        {
            recipes = recipeService.GetRecipe();
        }
        public List<Recipe> recipes { get; private set; }

        
    }
}
