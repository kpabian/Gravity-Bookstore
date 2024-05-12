using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface IAuthorService
{
    Task<List<Author>> Get(int id);
    Task<int> Post(Author author);
    Task<bool> Put(Author author, int id);
    Task<bool> Delete(int id);
}
