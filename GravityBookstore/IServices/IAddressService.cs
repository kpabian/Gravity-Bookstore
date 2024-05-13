using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface IAddressService
{
    Task<List<AddressDto>> Get(int id);
    Task<int> Post(AddressPostDto address);
    Task<bool> Put(AddressPostDto address, int id);
    Task<bool> Delete(int id);
}
