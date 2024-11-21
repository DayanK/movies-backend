using System;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Data;
using Movie.Api.Dtos;
using Movie.Api.Mapping;

namespace Movie.Api.Endpoints;

public static class  MoviesEndpoint
{

    private static readonly List<MovieSummaryDto> movies = new List<MovieSummaryDto>
    {
        new(1, "The Grand Adventure", "John Smith", new DateOnly(2021, 5, 20)),
        new(2, "Mystery of the Lost Island", "Emily Carter", new DateOnly(2019, 3, 15)),
        new(3, "Space Odyssey 3000", "James Brown", new DateOnly(2022, 8, 10)),
        new(4, "The Haunted Mansion", "Laura Davis", new DateOnly(2018, 10, 31)),
        new(5, "Underwater Kingdom", "Michael Johnson", new DateOnly(2020, 7, 12)),
        new(6, "The Final Frontier", "Sarah Williams", new DateOnly(2017, 9, 5)),
        new(7, "Love in the Time of Robots", "Anna Wilson", new DateOnly(2023, 2, 14)),
        new(8, "Rise of the Phoenix", "David Martinez", new DateOnly(2021, 11, 3)),
        new(9, "The Secret Code", "Sophia Lee", new DateOnly(2020, 4, 25)),
        new(10, "Legends of the Past", "Oliver Thomas", new DateOnly(2019, 6, 19))
    };

    public static RouteGroupBuilder MapMoviesEndpoint(this WebApplication app)
    {
        var group = app.MapGroup("/movies");

        group.MapGet("/", async (MovieStoreContext dbContext) => {
            return await dbContext.Movies
                            .Include(movie => movie.Director)
                            .Select(movie => movie.ToMovieSummaryDto())
                            .AsNoTracking()
                            .ToListAsync();
        });


        group.MapGet("/{id}", async (int id, MovieStoreContext dbContext) =>
        {

            Entities.Movie? movie = await dbContext.Movies.FindAsync(id);

            return  movie is null ? Results.NotFound() : Results.Ok(movie.ToMovieDetailsDto());

        }).WithName("GetMovie");


        group.MapPost("/", async (CreateMovieDto newMovie, MovieStoreContext dbContext) =>
        {
            Entities.Movie movie =  newMovie.ToEntity();

            await dbContext.Movies.AddAsync(movie);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute("GetMovie", new { id = movie.Id }, movie.ToMovieDetailsDto());

        });

        group.MapPut("/{id}", async (int id, UpdateMovieDto updateMovie, MovieStoreContext dbContext) =>
        {

            var existMovie = await dbContext.Movies.FindAsync(id);

            if (existMovie is null)
            {
                return Results.NotFound();
            }

            dbContext
                .Entry(existMovie)
                .CurrentValues
                .SetValues(updateMovie.ToEntity(id));

            await dbContext.SaveChangesAsync();

            return Results.NoContent();

        });

        group.MapDelete("/{id}", async (int id, MovieStoreContext dbContext) =>
        {


           await dbContext
                .Movies
                .Where(movie => movie.Id == id)
                .ExecuteDeleteAsync();

            return Results.NoContent();

        });


        return group;
    }

}
