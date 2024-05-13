using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GravityBookstore.Repositories;

public class PublisherRepository : IPublisherRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public PublisherRepository(AppDbContext context, ILogger<PublisherRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreatePublisher(Publisher publisher)
    {
        await _context.Publishers.AddAsync(publisher);
        await _context.SaveChangesAsync();
        return publisher.Publisher_id;
    }

    public async Task<bool> DeletePublisher(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Publisher>> Get(int? id)
    {
        IQueryable<Publisher> query = _context.Publishers.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Publisher_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdatePublisher(Publisher publisher, int id)
    {
        throw new NotImplementedException();
    }
}
