namespace Application.UseCases.CreateRestaurant;

public class CreateRestaurantCommand
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<TableDto> Tables { get; set; }
}