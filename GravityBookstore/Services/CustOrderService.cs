using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class CustOrderService : ICustOrderService
    {
        private readonly ICustOrderRepository _custOrderRepository;
        private readonly IMapper _mapper;
        public CustOrderService(ICustOrderRepository custOrderRepository, IMapper mapper)
        {
            _custOrderRepository = custOrderRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustOrderDto>> Get(int id)
        {
            var result = await _custOrderRepository.Get(id);
            var mappedResult = _mapper.Map<List<CustOrderDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Cust_order custOrder)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Cust_order custOrder, int id)
        {
            throw new NotImplementedException();
        }
    }
}
