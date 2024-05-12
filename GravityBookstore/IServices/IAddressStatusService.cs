using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.IServices;

public interface IAddressStatusService
{
    Task<List<AddressStatusDto>> Get(int id);
    Task<int> Post(Address_status addressStatus);
    Task<bool> Put(Address_status addressStatus, int id);
    Task<bool> Delete(int id);
}
