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
        private readonly ICustomerAddressRepository _customerAddressRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, ICustomerAddressRepository customerAddressRepository, IAddressRepository addressRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _customerAddressRepository = customerAddressRepository;
            _addressRepository = addressRepository;
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

            List<Customer_address> customerAddresses = new List<Customer_address>();

            foreach (var address in customer.Addresses)
            {
                var mappedAddress = _mapper.Map<Address>(address);             
                var addressId = await _addressRepository.CreateAddress(mappedAddress);
                customerAddresses.Add(new Customer_address { Address_id = addressId, Customer_id = result, Status_id = 1 });
            }

            foreach (var customerAddress in customerAddresses)
            {
                await _customerAddressRepository.CreateCustomerAddress(customerAddress);
            }

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
