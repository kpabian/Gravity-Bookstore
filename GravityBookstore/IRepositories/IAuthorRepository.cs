using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IAuthorRepository
{
    Task<List<Author>> Get(int? id);
    Task<int> CreateAuthor(Author author);
    Task<bool> UpdateAuthor(Author author, int id);
    Task<bool> DeleteAuthor(int id);
}
