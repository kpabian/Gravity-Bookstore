using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IBookAuthorRepository
{
    Task<List<Book_author>> Get(int? id);
    Task<(int, int)> CreateBookAuthor(Book_author bookAuthor);
    Task<bool> UpdateBookAuthor(Book_author bookAuthor, int id);
    Task<bool> DeleteBookAuthor(int id);
}
