using MediatR;

namespace Application.UseCases.CreateDish;

public class CreateDishCommand : IRequest
{
    public string Name { get; set; }
    public ICollection<Guid> CategoryIds { get; set; }
    public double PriceExcludingTax { get; set; }
    public double VAT { get; set; }
}