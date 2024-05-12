using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface IBookAuthorService
{
    Task<List<Book_author>> Get(int id);
    Task<int> Post(Book_author bookAuthor);
    Task<bool> Put(Book_author bookAuthor, int id);
    Task<bool> Delete(int id);
}
