using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface IBookLanguageService
{
    Task<List<BookLanguageDto>> Get(int id);
    Task<int> Post(Book_language bookLanguage);
    Task<bool> Put(Book_language bookLanguage, int id);
    Task<bool> Delete(int id);
}
