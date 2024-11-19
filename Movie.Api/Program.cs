using Movie.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var movies = new List<MovieDto>
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






app.MapGet("/", () => "Hello World!");

app.Run();
