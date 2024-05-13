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
        IQueryable<Book> query = _context.Books.AsQueryable();
        Book? existingBook = await query.FirstOrDefaultAsync(x => x.Book_id == id);
        if (existingBook is null)
        {
            return false;
        }
        existingBook.Title = book.Title;
        existingBook.Isbn13 = book.Isbn13;
        existingBook.Book_language_id = book.Book_language_id;
        existingBook.Num_pages = book.Num_pages;
        existingBook.Publication_date = book.Publication_date;
        existingBook.Publisher_id = book.Publisher_id;
        await _context.SaveChangesAsync();
        return true;
    }
}
