using System;
using System.ComponentModel.DataAnnotations;

namespace Movie.Api.Dtos;

public record class CreateMovieDto
(
    [Required] string Title,
    int DirectorId,
    DateOnly ReleaseDate
);


