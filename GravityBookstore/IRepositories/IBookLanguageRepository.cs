using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IBookLanguageRepository
{
    Task<List<Book_language>> Get(int? id);
    Task<int> CreateBookLanguage(Book_language bookLanguage);
    Task<bool> UpdateBookLanguage(Book_language bookLanguage, int id);
    Task<bool> DeleteBookLanguage(int id);
}
