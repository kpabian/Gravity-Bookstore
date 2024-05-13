using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IOrderHistoryService
{
    Task<List<OrderHistoryDto>> Get(int id);
    Task<int> Post(OrderHistoryPostDto orderHistory);
    Task<bool> Put(OrderHistoryPostDto orderHistory, int id);
    Task<bool> Delete(int id);
}
