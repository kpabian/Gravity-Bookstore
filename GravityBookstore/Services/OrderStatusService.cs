using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;

namespace GravityBookstore.Services
{
    public class OrderStatusService : IOrderStatusService
    {
        private readonly IOrderStatusRepository _orderStatusRepository;
        private readonly IMapper _mapper;
        public OrderStatusService(IOrderStatusRepository orderStatusRepository, IMapper mapper)
        {
            _orderStatusRepository = orderStatusRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order_status>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(Order_status orderStatus)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Order_status orderStatus, int id)
        {
            throw new NotImplementedException();
        }
    }
}
