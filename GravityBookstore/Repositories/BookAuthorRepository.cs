using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GravityBookstore.Repositories;

public class BookAuthorRepository : IBookAuthorRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public BookAuthorRepository(AppDbContext context, ILogger<BookAuthorRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<(int, int)> CreateBookAuthor(Book_author bookAuthor)
    {
        await _context.BookAuthors.AddAsync(bookAuthor);
        await _context.SaveChangesAsync();
        return (bookAuthor.Author_id, bookAuthor.Book_id);
    }

    public async Task<bool> DeleteBookAuthor(int id)
    {
        Book_author? existingBookAuthor = await _context.BookAuthors.FindAsync(id);
        if (existingBookAuthor is null)
        {
            return false;
        }
        _context.BookAuthors.Remove(existingBookAuthor);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Book_author>> Get(int? AuthorId, int? BookId)
    {
        IQueryable<Book_author> query = _context.BookAuthors.AsQueryable();

        if (AuthorId != null)
        {
            query = query.Where(x => x.Author_id == AuthorId);
        }
        if (BookId != null)
        {
            query = query.Where(x => x.Book_id == BookId);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateBookAuthor(Book_author bookAuthor, int id)
    {
        throw new NotImplementedException();
    }
}
