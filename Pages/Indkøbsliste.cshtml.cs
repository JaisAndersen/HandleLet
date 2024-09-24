using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HandleLet.Pages
{
    public class IndkøbslisteModel : PageModel
    {
        private readonly ILogger<IndkøbslisteModel> _logger;

        public IndkøbslisteModel(ILogger<IndkøbslisteModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
