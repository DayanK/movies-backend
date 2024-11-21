using System;

namespace Movie.Api.Dtos;

public record class UpdateMovieDto
(
    int Id,
    string Title,
    int DirectorId,
    DateOnly ReleaseDate
);


