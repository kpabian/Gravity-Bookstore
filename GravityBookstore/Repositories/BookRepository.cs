using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GravityBookstore.Repositories;

public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public BookRepository(AppDbContext context, ILogger<BookRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateBook(Book book)
    {
        await _context.Books.AddAsync(book);
        await _context.SaveChangesAsync();
        return book.Book_id;
    }

    public async Task<bool> DeleteBook(int id)
    {
        Book? existingBook = await _context.Books.FindAsync(id);
        if (existingBook is null)
        {
            return false;
        }
        _context.Books.Remove(existingBook);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Book>> Get(int? id)
    {
        IQueryable<Book> query = _context.Books.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Book_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateBook(Book book, int id)
    {
        throw new NotImplementedException();
    }
}
