using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface ICustomerService
{
    Task<List<CustomerDto>> Get(int id);
    Task<int> Post(CustomerPostDto customer);
    Task<bool> Put(CustomerPostDto customer, int id);
    Task<bool> Delete(int id);

}
