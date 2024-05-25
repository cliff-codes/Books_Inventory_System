namespace BooksInventorySystem;

public class BooksClient
{
    // private readonly

    private readonly List<Book> books = [
        new(){
            Id = 1,
            Title = "Pride and Prejudice",
            Authors = "Jane Austen",
            PublishedDate = new DateOnly(1813, 01, 23),
            Genre = "Classic Literature",
            Price = 3.99M 
        },
        new(){
            Id = 2,
            Title = "The Lord of the Rings: The Fellowship of the Ring",
            Authors = "J.R.R. Tolkien",
            PublishedDate = new DateOnly(1954, 11, 13),
            Genre = "Fantasy",
            Price = 12.99M 
        },
        new(){
            Id = 3,
            Title = "To Kill a Mockingbird",
            Authors = "Harper Lee",
            PublishedDate = new DateOnly(1960, 04, 12),
            Genre = "Historical Fiction",
            Price = 13.99M 
        },
        new(){
            Id = 4,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Authors = "Douglas Adams",
            PublishedDate = new DateOnly(1979, 01, 23),
            Genre = "Science Fiction",
            Price = 9.99M 
        },
        new(){
            Id = 5,
            Title = "One Hundred Years of Solitude",
            Authors = "Gabriel García Márquezn",
            PublishedDate = new DateOnly(1967, 12, 03),
            Genre = "Magical Realism",
            Price = 11.99M 
        },
        new(){
            Id = 6,
            Title = "Frankenstein",
            Authors = "Mary Shelley",
            PublishedDate = new DateOnly(1818, 01, 23),
            Genre = "Gothic Fiction",
            Price = 6.99M 
        },
        new(){
            Id = 7,
            Title = "Dune",
            Authors = "Frank Herbert",
            PublishedDate = new DateOnly(1813, 01, 23),
            Genre = "Science Fiction",
            Price = 14.99M 
        },
    ];

    //providing access to books 
    public List<Book> GetBooks() => books;

    // method to add a new book to existing catalog
    public void AddBook( BookDetails book){
        //new book
        var newBook = new Book{
            Id = books.Count + 1,
            Title = book.Title,
            Authors = book.Authors,
            Genre = book.Genre,
            PublishedDate = book.PublishedDate,
            Price = book.Price
        };

        //add new book to catalog
        books.Add(newBook);
    }

}
