using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface ICustomerAddressService
{
    Task<List<CustomerAddressDto>> Get(int id);
    Task<int> Post(Customer_address customerAddress);
    Task<bool> Put(Customer_address customerAddress, int id);
    Task<bool> Delete(int id);
}
