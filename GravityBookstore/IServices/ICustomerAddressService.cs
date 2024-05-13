using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface ICustomerAddressService
{
    Task<List<CustomerAddressDto>> Get(int CustId, int AddressId);
    Task<(int, int)> Post(CustomerAddressPostDto customerAddress);
    Task<bool> Put(CustomerAddressPostDto customerAddress, int id);
    Task<bool> Delete(int id);
}
