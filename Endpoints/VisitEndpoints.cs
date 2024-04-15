using Microsoft.AspNetCore.Http.HttpResults;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class VisitEndpoints
{

    public static void MapVisitEndpoints(this WebApplication app)
    {

        app.MapGet("/visits", () =>
        {

            var visits = StaticData.visits;
            return Results.Ok(visits);
        });
        app.MapPost("/visits", (Visit visit) =>
        {
            var visits = StaticData.visits;
            visits.Add(visit);
            return Results.Ok(visits);
        });
    }
}