using System.ComponentModel.DataAnnotations;

namespace StorageApi.DTOs;

public class CreateProductDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public int Price { get; set; }
    public string Category { get; set; } = string.Empty;
    public string Shelf { get; set; } = string.Empty;

    [Range(0, int.MaxValue)]
    public int Count { get; set; }
    public string Description { get; set; } = string.Empty;

}

