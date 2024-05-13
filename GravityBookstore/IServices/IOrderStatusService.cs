using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IOrderStatusService
{
    Task<List<OrderStatusDto>> Get(int id);
    Task<int> Post(OrderStatusPostDto orderStatus);
    Task<bool> Put(OrderStatusPostDto orderStatus, int id);
    Task<bool> Delete(int id);
}
