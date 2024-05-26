using System.Runtime.InteropServices;

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
            Price = 3.99M 
        },
        new(){
            Id = 2,
            Title = "The Lord of the Rings: The Fellowship of the Ring",
            Authors = "J.R.R. Tolkien",
            PublishedDate = new DateOnly(1954, 11, 13),
            Price = 12.99M 
        },
        new(){
            Id = 3,
            Title = "To Kill a Mockingbird",
            Authors = "Harper Lee",
            PublishedDate = new DateOnly(1960, 04, 12),        
            Price = 13.99M 
        },
        new(){
            Id = 4,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Authors = "Douglas Adams",
            PublishedDate = new DateOnly(1979, 01, 23),         
            Price = 9.99M 
        },
        new(){
            Id = 5,
            Title = "One Hundred Years of Solitude",
            Authors = "Gabriel García Márquezn",
            PublishedDate = new DateOnly(1967, 12, 03),        
            Price = 11.99M 
        },
        new(){
            Id = 6,
            Title = "Frankenstein",
            Authors = "Mary Shelley",
            PublishedDate = new DateOnly(1818, 01, 23),
            Price = 6.99M 
        },
        new(){
            Id = 7,
            Title = "Dune",
            Authors = "Frank Herbert",
            PublishedDate = new DateOnly(1813, 01, 23),
            Price = 14.99M 
        },
    ];

    //providing access to books 
    public List<Book> GetBooks() => books;

    // method to add a new book to existing catalog
    public void AddBook( Book book){
        //new book
        var newBook = new Book{
            Id = books.Count + 1,
            Title = book.Title,
            Authors = book.Authors,
            PublishedDate = book.PublishedDate,
            Price = book.Price
        };

        //add new book to catalog
        books.Add(newBook);
    }

    //method to get Book by id
    public Book? GetBook(int Id){
        Book? book = books.Find(book => book.Id == Id);
        return book;
    }

    //update an existing book
    public void UpdateBook(int Id, Book updatedBook){
        Book? existingBook = GetBook(Id);

        if(existingBook is not null){
            existingBook.Title = updatedBook.Title;
            existingBook.Authors = updatedBook.Authors;
            existingBook.Price = updatedBook.Price;
            existingBook.PublishedDate = updatedBook.PublishedDate;
        }
    }


    public void DeleteBook(int Id){
        var bookToRemove = GetBook(Id);
        if(bookToRemove is not null){
            books.Remove(bookToRemove);
        }
    }

}
