using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;

namespace GravityBookstore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Book book, int id)
        {
            throw new NotImplementedException();
        }
    }
}
