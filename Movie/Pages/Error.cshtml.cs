using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Movie.Pages
{
    public class ErrorModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Sorry. An Error was occurred";
        }
    }
}
