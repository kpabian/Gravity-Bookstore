using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface IBookLanguageService
{
    Task<List<BookLanguageDto>> Get(int id);
    Task<int> Post(BookLanguagePostDto bookLanguage);
    Task<bool> Put(BookLanguagePostDto bookLanguage, int id);
    Task<bool> Delete(int id);
}
