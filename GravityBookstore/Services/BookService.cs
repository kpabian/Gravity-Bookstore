using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

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
            var result = await _bookRepository.DeleteBook(id);
            return result;
        }

        public async Task<List<BookDto>> Get(int id)
        {
            var result = await _bookRepository.Get(id);
            var mappedResult = _mapper.Map<List<BookDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Book book)
        {
            var result = await _bookRepository.CreateBook(book);
            return result;
        }

        public async Task<bool> Put(Book book, int id)
        {
            var result = await _bookRepository.UpdateBook(book, id);
            return result;
        }
    }
}
