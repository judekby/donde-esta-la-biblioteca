using BusinessObjects.Entity;

namespace DataAccessLayer.Repository;

public class BookRepository
{

    public static IEnumerable<Book> GetAll()
    {
        return new Book[10];
    }

    public static Book Get(int id)
    {
        return new Book();
    }
}