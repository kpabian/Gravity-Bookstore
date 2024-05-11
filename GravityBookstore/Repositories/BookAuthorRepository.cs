using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
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
        throw new NotImplementedException();
    }

    public async Task<List<Book_author>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateBookAuthor(Book_author bookAuthor, int id)
    {
        throw new NotImplementedException();
    }
}
