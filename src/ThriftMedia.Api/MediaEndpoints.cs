using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ThriftMedia.Contracts.Dto;

public static class MediaEndpoints
{
    public static IEndpointRouteBuilder MapMediaEndpoints(this IEndpointRouteBuilder endpoints)
    {
        // Get all media
        endpoints.MapGet("/media", () => new[]
        {
            new MediaDto(1, "The Great Gatsby", "Book", "A classic novel."),
            new MediaDto(2, "Abbey Road", "Vinyl", "The Beatles album."),
            new MediaDto(3, "Casablanca", "DVD", "Classic film.")
        });

        // Get media by ID
        endpoints.MapGet("/media/{id:int}", (int id) =>
        {
            var media = new[]
            {
                new MediaDto(1, "The Great Gatsby", "Book", "A classic novel."),
                new MediaDto(2, "Abbey Road", "Vinyl", "The Beatles album."),
                new MediaDto(3, "Casablanca", "DVD", "Classic film.")
            };
            return media.FirstOrDefault(m => m.Id == id) is MediaDto found
                ? Results.Ok(found)
                : Results.NotFound();
        });

        // Add new media (fake, does not persist)
        endpoints.MapPost("/media", (MediaDto media) =>
        {
            // In a real app, save to DB
            return Results.Created($"/media/{media.Id}", media);
        });

        return endpoints;
    }
}
