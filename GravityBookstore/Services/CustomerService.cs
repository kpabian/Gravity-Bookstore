using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustomerDto>> Get(int id)
        {
            var result = await _customerRepository.Get(id);
            var mappedResult = _mapper.Map<List<CustomerDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Customer customer, int id)
        {
            throw new NotImplementedException();
        }
    }
}
