namespace BookReccomendation.BookReccomendation.Models.Services;

public interface IBookService
{
    public IEnumerable<Book> GetBooks();
    
    public IEnumerable<Book> GiveReccomendationB();
}