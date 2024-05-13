using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IPublisherService
{
    Task<List<PublisherDto>> Get(int id);
    Task<int> Post(PublisherPostDto publisher);
    Task<bool> Put(PublisherPostDto publisher, int id);
    Task<bool> Delete(int id);
}
