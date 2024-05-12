using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface IPublisherService
{
    Task<List<Publisher>> Get(int id);
    Task<int> Post(Publisher publisher);
    Task<bool> Put(Publisher publisher, int id);
    Task<bool> Delete(int id);
}
