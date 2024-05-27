using System.ComponentModel.DataAnnotations;
namespace BooksInventorySystem;

public class Book
{
    public int Id {get; set;}
    [Required]
    public required string Title {get; set;}
    [Required]
    public required string Authors {get; set;}
    [Required]
    [Range(1, 5000)]
    public decimal Price {get; set;}

    public required DateOnly PublishedDate {get; set;}

    [Required(ErrorMessage = "Please enter the quantity you have in inventory")]
    public int Quantity {get; set;}
}
