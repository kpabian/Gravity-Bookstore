using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IPublisherService
{
    Task<List<PublisherDto>> Get(int id);
    Task<int> Post(Publisher publisher);
    Task<bool> Put(Publisher publisher, int id);
    Task<bool> Delete(int id);
}
