using System.ComponentModel.DataAnnotations;

namespace TipCalculatorRazorPages.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Meal cost is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Meal cost must be greater than 0.")]
        public decimal MealCost { get; set; }

        [Required(ErrorMessage = "Tip percentage is required.")]
        [Range(0.01, 100.0, ErrorMessage = "Tip percentage must be between 0.01 and 100.")]
        public decimal TipPercentage { get; set; }

        public decimal CalculateTip()
        {
            return MealCost * (TipPercentage / 100);
        }

        public decimal CalculateTotal()
        {
            return MealCost + CalculateTip();
        }
    }
}
