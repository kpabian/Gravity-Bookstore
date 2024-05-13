using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class CustomerAddressService : ICustomerAddressService
    {
        private readonly ICustomerAddressRepository _customerAddressRepository;
        private readonly IMapper _mapper;
        public CustomerAddressService(ICustomerAddressRepository customerAddressRepository, IMapper mapper)
        {
            _customerAddressRepository = customerAddressRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustomerAddressDto>> Get(int CustId, int AddressId)
        {
            var result = await _customerAddressRepository.Get(CustId, AddressId);
            var mappedResult = _mapper.Map<List<CustomerAddressDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Customer_address customerAddress)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Customer_address customerAddress, int id)
        {
            throw new NotImplementedException();
        }
    }
}
