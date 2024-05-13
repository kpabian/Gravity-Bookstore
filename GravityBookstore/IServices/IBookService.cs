using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IBookService
{
    Task<List<BookDto>> Get(int id);
    Task<int> Post(BookPostDto book);
    Task<bool> Put(BookPostDto book, int id);
    Task<bool> Delete(int id);
}
