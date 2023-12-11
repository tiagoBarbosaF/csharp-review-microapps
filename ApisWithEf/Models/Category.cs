using System.ComponentModel.DataAnnotations;

namespace ApisWithEf.Models;

public class Category
{
    [Key] public long Id { get; init; }

    [Required(ErrorMessage = "Field title is required")]
    [MaxLength(60, ErrorMessage = "Field title must contain between 3 and 60 characters")]
    [MinLength(3, ErrorMessage = "Field title must contain between 3 and 60 characters")]
    public string? Title { get; init; }
}