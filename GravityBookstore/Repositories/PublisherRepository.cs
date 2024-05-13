using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;

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
        IQueryable<Publisher> query = _context.Publishers.AsQueryable();
        Publisher? existingPublisher = await query.FirstOrDefaultAsync(x => x.Publisher_id == id);
        if (existingPublisher is null)
        {
            return false;
        }
        _context.Publishers.Remove(existingPublisher);
        await _context.SaveChangesAsync();
        return true;
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
        IQueryable<Publisher> query = _context.Publishers.AsQueryable();
        Publisher? existingPublisher = await query.FirstOrDefaultAsync(x => x.Publisher_id == id);
        if (existingPublisher is null)
        {
            return false;
        }
        existingPublisher.Publisher_name = publisher.Publisher_name;
        await _context.SaveChangesAsync();
        return true;
    }
}
