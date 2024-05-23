namespace BooksInventorySystem;

public class Book
{
    public int Id {get; set;}
    public required string Title {get; set;}
    public required string Authors {get; set;}
    public decimal Price {get; set;}
    public required string Genre {get; set;}
    public required DateOnly PublishedDate {get; set;}
}
