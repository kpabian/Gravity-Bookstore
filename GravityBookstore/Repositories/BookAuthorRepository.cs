using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GravityBookstore.Repositories;

public class BookAuthorRepository(AppDbContext context) : IBookAuthorRepository
{
    private readonly AppDbContext _context = context;

    public async Task<(int, int)> CreateBookAuthor(Book_author bookAuthor)
    {
        await _context.BookAuthors.AddAsync(bookAuthor);
        await _context.SaveChangesAsync();
        return (bookAuthor.Author_id, bookAuthor.Book_id);
    }

    public async Task<bool> DeleteBookAuthor(int AuthorId, int BookId)
    {
        IQueryable<Book_author> query = _context.BookAuthors.AsQueryable();
        Book_author? existingBookAuthor = await query.FirstOrDefaultAsync(x => x.Author_id == AuthorId && x.Book_id == BookId);
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
        IQueryable<Book_author> query = _context.BookAuthors.AsQueryable();
        Book_author? existingBookAuthor = await query.FirstOrDefaultAsync(x => x.Book_id == id);
        if (existingBookAuthor is null)
        {
            return false;
        }
        existingBookAuthor.Author_id = bookAuthor.Author_id;
        existingBookAuthor.Book_id = bookAuthor.Book_id;
        await _context.SaveChangesAsync();
        return true;
    }
}
