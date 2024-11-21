using System;

namespace Movie.Api.Dtos;

public record class UpdateDto
(
    int Id,
    string Title,
    string Director,
    DateOnly ReleaseDate
);


