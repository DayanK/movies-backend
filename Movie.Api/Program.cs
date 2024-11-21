using Microsoft.EntityFrameworkCore;
using Movie.Api.Data;
using Movie.Api.Dtos;
using Movie.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MovieStore");

builder.Services.AddDbContext<MovieStoreContext>(options => {
    options.UseSqlServer(connectionString);
});


// AddSqlite<MovieStoreContext>(connectionString);

var app = builder.Build();

app.MapMoviesEndpoint();

app.MigrationDatabaseAsync();


// app.MapGet("/", () => "Hello World!");

app.Run();
