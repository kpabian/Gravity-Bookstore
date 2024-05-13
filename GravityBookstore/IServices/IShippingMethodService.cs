using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IShippingMethodService
{
    Task<List<ShippingMethodDto>> Get(int id);
    Task<int> Post(ShippingMethodPostDto shippingMethod);
    Task<bool> Put(ShippingMethodPostDto shippingMethod, int id);
    Task<bool> Delete(int id);
}
