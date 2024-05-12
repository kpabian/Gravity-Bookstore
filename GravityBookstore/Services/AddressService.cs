using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();

        }

        public async Task<List<AddressDto>> Get(int id)
        {
            var result = await _addressRepository.Get(id);
            var mappedResult = _mapper.Map<List<AddressDto>>(result);
            return mappedResult;

        }

        public async Task<int> Post(Address address)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Address address, int id)
        {
            throw new NotImplementedException();
        }
    }
}
