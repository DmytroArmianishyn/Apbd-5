namespace Tutorial4.Models;

public class Animal
{
    public  int Id { get; set; }
   public  string Name { get; set; }
    
    public string Category { get; set; }
    
    public  double Masa { get; set; }
    
    public string Color { get; set; }


    public Animal(int id, string name, string category, double masa, string color)
    {
        Id = id;
        Name = name;
        Category = category;
        this.Masa = masa;
        this.Color = color;
    }

    public override string ToString()
    {
        return $"Id = {Id} name= {Name} category= {Category} masa={Masa} color= {Color} " ;
    }
}