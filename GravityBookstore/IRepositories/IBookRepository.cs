using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IBookRepository
{
    Task<List<Book>> Get(int? id);
    Task<int> CreateBook(Book book);
    Task<bool> UpdateBook(Book book, int id);
    Task<bool> DeleteBook(int id);
    Task<List<Book>> GetByPublisherName(string name);
}
