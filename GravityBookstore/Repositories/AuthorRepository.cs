using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GravityBookstore.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public AuthorRepository(AppDbContext context, ILogger<AuthorRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateAuthor(Author author)
    {
        await _context.Authors.AddAsync(author);
        await _context.SaveChangesAsync();
        return author.Author_id;
    }

    public async Task<bool> DeleteAuthor(int id)
    {
        Author? existingAuthor = await _context.Authors.FindAsync(id);
        if (existingAuthor is null)
        {
            return false;
        }
        _context.Authors.Remove(existingAuthor);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Author>> Get(int? id)
    {
        IQueryable<Author> query = _context.Authors.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Author_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateAuthor(Author author, int id)
    {
        throw new NotImplementedException();
    }
}
