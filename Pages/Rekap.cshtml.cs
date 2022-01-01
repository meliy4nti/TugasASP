using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbsenOnline.Pages
{
    public class RekapModel : PageModel
    {
         private readonly ILogger<RekapModel> _logger;

        public RekapModel(ILogger<RekapModel> logger) => _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));


        public void OnGet()
        {
        }

        public interface ILogger<T>
        {
        }
    }
}
