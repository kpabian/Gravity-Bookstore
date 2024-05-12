using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;

namespace GravityBookstore.Services
{
    public class ShippingMethodService : IShippingMethodService
    {
        private readonly IShippingMethodRepository _shippingMethodRepository;
        private readonly IMapper _mapper;
        public ShippingMethodService(IShippingMethodRepository _shippingMethodRepository, IMapper mapper)
        {
            _shippingMethodRepository = _shippingMethodRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Shipping_method>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(Shipping_method shippingMethod)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Shipping_method shippingMethod, int id)
        {
            throw new NotImplementedException();
        }
    }
}
