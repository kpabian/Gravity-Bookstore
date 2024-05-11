using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IShippingMethodRepository
{
    Task<List<Shipping_method>> Get(int? id);
    Task<int> CreateShippingMethod(Shipping_method shippingMethod);
    Task<bool> UpdateShippingMethod(Shipping_method shippingMethod, int id);
    Task<bool> DeleteShippingMethod(int id);
}
