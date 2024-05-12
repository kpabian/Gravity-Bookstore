using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;

namespace GravityBookstore.Services
{
    public class AddressStatusService : IAddressStatusService
    {
        private readonly IAddressStatusRepository _addressStatusRepository;
        private readonly IMapper _mapper;
        public AddressStatusService(IAddressStatusRepository addressStatusRepository, IMapper mapper)
        {
            _addressStatusRepository = addressStatusRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Address_status>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(Address_status addressStatus)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Address_status addressStatus, int id)
        {
            throw new NotImplementedException();
        }
    }
}
