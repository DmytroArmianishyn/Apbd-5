using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1,"Bee","insect",2.1,"yellow-black"),
        new Animal(2,"Elephant","animal",532.46,"gray"),
        new Animal(3,"Rabbit","animal",12.21,"white"),
    };

    public static List<Visit> visits = new List<Visit>()
    {

        new Visit(new DateTime(2012, 12, 25, 10, 30, 50), 1, "need vitamins", 195.45),
        new Visit(new DateTime(2018, 11, 29, 11, 33, 51), 2, "need blood", 280)

    };
}