using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface IAuthorService
{
    Task<List<AuthorDto>> Get(int id);
    Task<int> Post(Author author);
    Task<bool> Put(Author author, int id);
    Task<bool> Delete(int id);
}
