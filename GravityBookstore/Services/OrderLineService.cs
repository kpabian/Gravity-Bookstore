using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;

namespace GravityBookstore.Services
{
    public class OrderLineService : IOrderLineService
    {
        private readonly IOrderLineRepository _orderLineRepository;
        private readonly IMapper _mapper;
        public OrderLineService(IOrderLineRepository orderLineRepository, IMapper mapper)
        {
            _orderLineRepository = orderLineRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order_line>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(Order_line orderLine)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Order_line orderLine, int id)
        {
            throw new NotImplementedException();
        }
    }
}
