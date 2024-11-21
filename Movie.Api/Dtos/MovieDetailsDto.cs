using System;

namespace Movie.Api.Dtos;

public record class MovieDetailsDto
(
    int Id,
    string Title,
    int DirectorId,
    DateOnly ReleaseDate
);
