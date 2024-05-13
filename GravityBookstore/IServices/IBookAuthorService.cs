using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface IBookAuthorService
{
    Task<List<BookAuthorDto>> Get(int AuthorId, int BookId);
    Task<int> Post(Book_author bookAuthor);
    Task<bool> Put(Book_author bookAuthor, int id);
    Task<bool> Delete(int id);
}
