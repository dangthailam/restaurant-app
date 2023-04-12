using CSharpFunctionalExtensions;

namespace Domain;

public class Category : Entity<Guid>
{
    public string Name { get; set; }

    public ICollection<Dish> Dishes { get; set; }

    public Category(string name)
    {
        Name = name;
        Dishes = new List<Dish>();
    }
}