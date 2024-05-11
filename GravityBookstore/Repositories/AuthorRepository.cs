using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
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
        throw new NotImplementedException();
    }

    public async Task<List<Author>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateAuthor(Author author, int id)
    {
        throw new NotImplementedException();
    }
}
