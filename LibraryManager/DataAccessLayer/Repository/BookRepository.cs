using BusinessObjects.Entity;
using System.Collections.Generic;
namespace DataAccessLayer.Repository;

public class BookRepository
{
    private List<Book> books;
    public  IEnumerable<Book> GetAll()
    {
        return books;
    }

    public Book Get(int id)
    {
        return books.FirstOrDefault(book => book.id == id);    }

    public IEnumerable<Book> ShowCat(Book.BookType category)    {
        return books.Where(book => book.Type == category);
    }
}