using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IPublisherRepository
{
    Task<List<Publisher>> Get(int? id);
    Task<int> CreatePublisher(Publisher publisher);
    Task<bool> UpdatePublisher(Publisher publisher, int id);
    Task<bool> DeletePublisher(int id);
}
