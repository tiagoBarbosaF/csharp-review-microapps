using System.ComponentModel.DataAnnotations;

namespace ApisWithEf.Models;

public class Product
{
    [Key] public long Id { get; init; }

    [Required(ErrorMessage = "Field title is required")]
    [MaxLength(60, ErrorMessage = "Field title must contain between 3 and 60 characters")]
    [MinLength(3, ErrorMessage = "Field title must contain between 3 and 60 characters")]
    public string? Title { get; init; }

    [MaxLength(1024, ErrorMessage = "Field description must contain at most 1024 characters")]
    public string? Description { get; init; }

    [Required(ErrorMessage = "Field price is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Price must be great than zero")]
    public decimal Price { get; init; }

    [Required(ErrorMessage = "Field category id is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Invalid category")]
    public long CategoryId { get; init; }

    public Category? Category { get; init; }
}