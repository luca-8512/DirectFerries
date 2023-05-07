using DirectFerries.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DirectFerries.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Customer customer { get; set; } = new Customer();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPostAsync()
        {
            //redirect to the next
            return Redirect($"~/next-page/{customer.Name}/{customer.DOB.Year}-{customer.DOB.Month}-{customer.DOB.Day}");
        }
    }
}