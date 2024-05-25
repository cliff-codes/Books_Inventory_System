using System.ComponentModel.DataAnnotations;

namespace BooksInventorySystem;

public class BookDetails
{
    public int Id{get; set;}
    
    [Required]
    public required string Title {get; set;}
    
    [Required]
    public required string Authors {get; set;}
    
    [Required]
    [Range(1,1000)]
    public decimal Price {get; set;}
    
    [Required]
    public required string Genre {get; set;}

    public DateOnly PublishedDate {get; set;}

}
