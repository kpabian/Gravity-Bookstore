using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class ShippingMethodService : IShippingMethodService
    {
        private readonly IShippingMethodRepository _shippingMethodRepository;
        private readonly IMapper _mapper;
        public ShippingMethodService(IShippingMethodRepository shippingMethodRepository, IMapper mapper)
        {
            _shippingMethodRepository = shippingMethodRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            var result = await _shippingMethodRepository.DeleteShippingMethod(id);
            return result;
        }

        public async Task<List<ShippingMethodDto>> Get(int id)
        {
            var result = await _shippingMethodRepository.Get(id);
            var mappedResult = _mapper.Map<List<ShippingMethodDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Shipping_method shippingMethod)
        {
            var result = await _shippingMethodRepository.CreateShippingMethod(shippingMethod);
            return result;
        }

        public async Task<bool> Put(Shipping_method shippingMethod, int id)
        {
            var result = await _shippingMethodRepository.UpdateShippingMethod(shippingMethod, id);
            return result;
        }
    }
}
