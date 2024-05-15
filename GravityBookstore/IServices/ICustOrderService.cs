using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface ICustOrderService
{
    Task<List<CustOrderDto>> Get(int id);
    Task<List<OrderedBooksDto>> GetBooks(string language);
    Task<int> Post(CustOrderPostDto custOrder);
    Task<bool> Put(CustOrderPostDto custOrder, int id);
    Task<bool> Delete(int id);
}
