﻿using AutoMapper;
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
            var result = await _customerRepository.DeleteCustomer(id);
            return result;
        }

        public async Task<List<CustomerDto>> Get(int id)
        {
            var result = await _customerRepository.Get(id);
            var mappedResult = _mapper.Map<List<CustomerDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(CustomerPostDto customer)
        {
            var mappedCustomer = _mapper.Map<Customer>(customer);
            var result = await _customerRepository.CreateCustomer(mappedCustomer);
            return result;
        }

        public async Task<bool> Put(CustomerPostDto customer, int id)
        {
            var mappedCustomer = _mapper.Map<Customer>(customer);
            var result = await _customerRepository.UpdateCustomer(mappedCustomer, id);
            return result;
        }
    }
}
