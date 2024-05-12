using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class OrderHistoryService : IOrderHistoryService
    {
        private readonly IOrderHistoryRepository _orderHistoryRepository;
        private readonly IMapper _mapper;
        public OrderHistoryService(IOrderHistoryRepository orderHistoryRepository, IMapper mapper)
        {
            _orderHistoryRepository = orderHistoryRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderHistoryDto>> Get(int id)
        {
            var result = await _orderHistoryRepository.Get(id);
            var mappedResult = _mapper.Map<List<OrderHistoryDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Order_history orderHistory)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Order_history orderHistory, int id)
        {
            throw new NotImplementedException();
        }
    }
}
