using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TipCalculatorRazorPages.Models;

namespace TipCalculatorRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public TipCalculatorModel TipCalculator { get; set; }

        public decimal? TipAmount { get; set; }
        public decimal? TotalAmount { get; set; }

        public void OnGet()
        {
            // Initial state
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                TipAmount = TipCalculator.CalculateTip();
                TotalAmount = TipCalculator.CalculateTotal();
            }
        }
    }
}
