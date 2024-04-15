using Microsoft.AspNetCore.Http.HttpResults;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            // 200 - Ok
            // 201 - Created
            // 400 - Bad Request
            // 404 - Not Found
            var animals = StaticData.animals;
            return Results.Ok(animals);
        });

        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(id);
        });

        app.MapPost("/animals", (Animal animal) =>
        {
            var animals = StaticData.animals;
            animals.Add(animal);
            return Results.Created("", animal);
        });

        app.MapDelete("/animals", (int id) =>
        {
            var animals = StaticData.animals;
            animals.RemoveAt(id-1);
            return Results.Ok(animals);


        });

        app.MapPut("/animals", (int id, string name, string category, double masa, string color) =>
        {
            var animals = StaticData.animals;
            animals[id - 1].Name = name;
            animals[id - 1].Category = category;
            animals[id - 1].Masa = masa;
            animals[id - 1].Color = color;


            return Results.Ok(animals);
        });
    }
}