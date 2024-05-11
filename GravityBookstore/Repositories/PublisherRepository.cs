using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
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
        throw new NotImplementedException();
    }

    public async Task<bool> UpdatePublisher(Publisher publisher, int id)
    {
        throw new NotImplementedException();
    }
}
