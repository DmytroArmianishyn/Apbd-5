using Tutorial4.Database;

namespace Tutorial4.Models;

public class Visit
{
    public DateTime Date{ get; set; }
    public Animal Animal{ get; set; }
    public string Description{ get; set; }
    public double Price{ get; set; }

    public Visit(DateTime date, int animal, string description, double price)
    {
        Date = date;
        Animal = StaticData.animals[animal-1];
        Description = description;
        Price = price;
    }

    public override string ToString()
    {
        return $"date= {Date} animal {Animal} + description {Description} + price {Price} ";
    }
}