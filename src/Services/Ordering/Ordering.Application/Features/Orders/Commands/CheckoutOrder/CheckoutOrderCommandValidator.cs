using FluentValidation;


namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommandValidator : AbstractValidator<CheckoutOrderCommand>
    {
        public CheckoutOrderCommandValidator()
        {
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("Username is required")
                .NotNull()
                .MaximumLength(50).WithMessage("Username must exceed 50 haracters.");

            RuleFor(p => p.EmailAddress)
                .NotEmpty().WithMessage("Email is required");

            RuleFor(p => p.TotalPrice)
                .NotEmpty().WithMessage("Total price is required")
                .GreaterThan(0).WithMessage("Total price should be greater than zero.");
        }
    }
}
