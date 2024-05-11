using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
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
        throw new NotImplementedException();
    }

    public async Task<List<Book>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateBook(Book book, int id)
    {
        throw new NotImplementedException();
    }
}
