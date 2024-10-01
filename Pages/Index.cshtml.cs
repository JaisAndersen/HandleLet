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
        private RecipeServices recipeService;

        public IndexModel(ILogger<IndexModel> logger, RecipeServices recipeServices)
        {
            _logger = logger;
            this.recipeService = recipeServices;
        }


        public void OnGet()
        {
            recipes = recipeService.GetUserStories();
        }
        public List<Recipe> recipes { get; private set; }

        
    }
}
