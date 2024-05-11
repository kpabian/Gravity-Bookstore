using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using System.Net;

namespace GravityBookstore.Repositories;

public class BookLanguageRepository : IBookLanguageRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public BookLanguageRepository(AppDbContext context, ILogger<BookLanguageRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateBookLanguage(Book_language bookLanguage)
    {
        await _context.BookLanguages.AddAsync(bookLanguage);
        await _context.SaveChangesAsync();
        return bookLanguage.Language_id;
    }

    public async Task<bool> DeleteBookLanguage(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Book_language>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateBookLanguage(Book_language bookLanguage, int id)
    {
        throw new NotImplementedException();
    }
}
