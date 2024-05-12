using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;

namespace GravityBookstore.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;
        public PublisherService(IPublisherRepository publisherRepository, IMapper mapper)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Publisher>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Publisher publisher, int id)
        {
            throw new NotImplementedException();
        }
    }
}
