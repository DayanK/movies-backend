using System;

namespace Movie.Api.Dtos;

public record class MovieSummaryDto(
    int Id,
    string Title,
    string Director,
    DateOnly ReleaseDate
);
