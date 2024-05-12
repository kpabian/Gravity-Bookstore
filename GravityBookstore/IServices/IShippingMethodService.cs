using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface IShippingMethodService
{
    Task<List<ShippingMethodDto>> Get(int id);
    Task<int> Post(Shipping_method shippingMethod);
    Task<bool> Put(Shipping_method shippingMethod, int id);
    Task<bool> Delete(int id);
}
