using CSharpFunctionalExtensions;

namespace Domain;

public class Dish : Entity<Guid>
{
    public string Name { get; set; }

    public double PriceExcludingTax { get; set; }

    public double VAT { get; set; }

    public ICollection<Category> Categories { get; set; }

    public Dish(string name, double priceExcludingTax, double vat)
    {
        Name = name;
        PriceExcludingTax = priceExcludingTax;
        VAT = vat;
        Categories = new List<Category>();
    }
}