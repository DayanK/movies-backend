using System;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Entities;

namespace Movie.Api.Data;

public class MovieStoreContext(DbContextOptions<MovieStoreContext> options): DbContext(options)
{
    public DbSet<Entities.Movie> Movies => Set<Entities.Movie>();
    public DbSet<Director> Director => Set<Director>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Director>().HasData
        (
            new { Id = 1, Name = "Steven Spielberg", DateOfBirth = new DateOnly(1946, 12, 18), Nationality = "American" }, 
            new { Id = 2, Name = "Christopher Nolan", DateOfBirth = new DateOnly(1970, 7, 30), Nationality = "British" }, 
            new { Id = 3, Name = "Quentin Tarantino", DateOfBirth = new DateOnly(1963, 3, 27), Nationality = "American" }, 
            new { Id = 4, Name = "Martin Scorsese", DateOfBirth = new DateOnly(1942, 11, 17), Nationality = "American" }, 
            new { Id = 5, Name = "Ridley Scott", DateOfBirth = new DateOnly(1937, 11, 30), Nationality = "British" }, 
            new { Id = 6, Name = "Hayao Miyazaki", DateOfBirth = new DateOnly(1941, 1, 5), Nationality = "Japanese" }, 
            new { Id = 7, Name = "Sofia Coppola", DateOfBirth = new DateOnly(1971, 5, 14), Nationality = "American" }, 
            new { Id = 8, Name = "Guillermo del Toro", DateOfBirth = new DateOnly(1964, 10, 9), Nationality = "Mexican" }, 
            new { Id = 9, Name = "Pedro Almodóvar", DateOfBirth = new DateOnly(1949, 9, 25), Nationality = "Spanish" }, 
            new { Id = 10, Name = "Greta Gerwig", DateOfBirth = new DateOnly(1983, 8, 4), Nationality = "American" }
        );
    }

}
