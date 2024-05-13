using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IOrderLineService
{
    Task<List<OrderLineDto>> Get(int id);
    Task<int> Post(OrderLinePostDto orderLine);
    Task<bool> Put(OrderLinePostDto orderLine, int id);
    Task<bool> Delete(int id);
}
