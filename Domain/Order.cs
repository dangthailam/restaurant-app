using CSharpFunctionalExtensions;

namespace Domain;

public class Order : Entity<Guid>
{
    public ICollection<OrderDish> OrderDishes { get; set; }
}

public class OrderDish : ValueObject<OrderDish>
{
    public string Note { get; set; }
    public OrderDishStatus Status { get; set; }
    public Dish Dish { get; set; }

    protected override bool EqualsCore(OrderDish other)
    {
        return Note == other.Note && Status == other.Status && Dish == other.Dish;
    }

    protected override int GetHashCodeCore()
    {
        unchecked
        {
            int hashCode = Note.GetHashCode();
            hashCode = (hashCode * 397) ^ Status.GetHashCode();
            hashCode = (hashCode * 397) ^ Dish.GetHashCode();
            return hashCode;
        }
    }
}

public enum OrderDishStatus
{
    Ordered,
    Preparing,
    Ready,
    Delivering,
    Delivered,
    Cancelled
}