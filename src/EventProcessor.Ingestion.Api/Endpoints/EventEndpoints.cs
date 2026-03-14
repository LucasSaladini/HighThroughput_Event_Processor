using EventProcessor.Ingestion.Api.DTOs;

namespace EventProcessor.Ingestion.Api.Endpoints;

public static class EventEndpoints
{
    public static void MapEventEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/v1/events");

        group.MapPost("/", (EventRequest request) =>
        {
            if (request.Id == Guid.Empty)
                return Results.BadRequest();

            return Results.Accepted();
        });
    }
}