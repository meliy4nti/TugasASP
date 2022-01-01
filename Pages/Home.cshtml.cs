using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AbsenOnline.Pages
{
    public class HomeModel : PageModel
    {
         private readonly ILogger<HomeModel> _logger;

        public HomeModel(ILogger<HomeModel> logger) => _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        public void OnGet()
        {
        }
    }
}
