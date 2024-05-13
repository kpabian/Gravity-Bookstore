using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface IAddressStatusService
{
    Task<List<AddressStatusDto>> Get(int id);
    Task<int> Post(AddressStatusPostDto addressStatus);
    Task<bool> Put(AddressStatusPostDto addressStatus, int id);
    Task<bool> Delete(int id);
}
