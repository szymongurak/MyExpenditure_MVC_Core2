using FluentValidation;
using MyExpenditures.Models;

namespace MyExpenditures.Validation
{
    public class ExpenditureRequestValidator : AbstractValidator<ExpenditureRequest>
    {
        public ExpenditureRequestValidator()
        {
            RuleFor(e => e.PurchasedItem)
                .NotEmpty().WithMessage("Purchased item cannot be empty!");
            RuleFor(e => e.Price)
                .NotEmpty().WithMessage("Price cannot be empty!")
                .GreaterThan(0).WithMessage("Price cannot be less than 0");
            RuleFor(e => e.Category)
                .NotEmpty().WithMessage("Category cannot be empty!");
            RuleFor(e => e.MonthOfPurchase)
                .NotEmpty().WithMessage("Month of purchase cannot be empty!")
                .Length(3, 9);
            RuleFor(e => e.YearOfPurchase)
                .NotEmpty().WithMessage("Year of purchase cannot be empty!")
                .GreaterThan(1950)
                .LessThanOrEqualTo(2018);

        }
    }
}
