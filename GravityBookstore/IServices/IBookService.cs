using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface IBookService
{
    Task<List<Book>> Get(int id);
    Task<int> Post(Book book);
    Task<bool> Put(Book book, int id);
    Task<bool> Delete(int id);
}
