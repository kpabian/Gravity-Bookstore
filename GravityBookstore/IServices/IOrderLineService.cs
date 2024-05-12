using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IOrderLineService
{
    Task<List<OrderLineDto>> Get(int id);
    Task<int> Post(Order_line orderLine);
    Task<bool> Put(Order_line orderLine, int id);
    Task<bool> Delete(int id);
}
