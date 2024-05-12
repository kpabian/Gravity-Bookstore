using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface IAddressService
{
    Task<List<AddressDto>> Get(int id);
    Task<int> Post(Address address);
    Task<bool> Put(Address address, int id);
    Task<bool> Delete(int id);
}
