using MediatR;

namespace Application.UseCases.OrderFood;

public class OrderFoodCommand : IRequest
{
    public bool IsTakeAway { get; set; }
    public List<OrderDishDto> OrderDishes { get; set; }
    public Guid SessionId { get; set; }
    public Guid TableId { get; set; }
}