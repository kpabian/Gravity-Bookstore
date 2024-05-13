using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
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
        Book_language? existingBookLanguage = await _context.BookLanguages.FindAsync(id);
        if (existingBookLanguage is null)
        {
            return false;
        }
        _context.BookLanguages.Remove(existingBookLanguage);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Book_language>> Get(int? id)
    {
        IQueryable<Book_language> query = _context.BookLanguages.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Language_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateBookLanguage(Book_language bookLanguage, int id)
    {
        IQueryable<Book_language> query = _context.BookLanguages.AsQueryable();
        Book_language? existingBookLanguage = await query.FirstOrDefaultAsync(x => x.Language_id == id);
        if (existingBookLanguage is null)
        {
            return false;
        }
        existingBookLanguage.Language_name = bookLanguage.Language_name;
        await _context.SaveChangesAsync();
        return true;
    }
}
