using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IBookService
{
    Task<List<BookDto>> Get(int id);
    Task<int> Post(Book book);
    Task<bool> Put(Book book, int id);
    Task<bool> Delete(int id);
}
