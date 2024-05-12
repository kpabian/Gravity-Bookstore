using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface ICustomerAddressService
{
    Task<List<Customer_address>> Get(int id);
    Task<int> Post(Customer_address customerAddress);
    Task<bool> Put(Customer_address customerAddress, int id);
    Task<bool> Delete(int id);
}
