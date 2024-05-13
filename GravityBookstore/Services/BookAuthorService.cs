using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class BookAuthorService : IBookAuthorService
    {
        private readonly IBookAuthorRepository _bookAuthorRepository;
        private readonly IMapper _mapper;
        public BookAuthorService(IBookAuthorRepository bookAuthorRepository, IMapper mapper)
        {
            _bookAuthorRepository = bookAuthorRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookAuthorDto>> Get(int AuthorId, int BookId)
        {
            var result = await _bookAuthorRepository.Get(AuthorId, BookId);
            var mappedResult = _mapper.Map<List<BookAuthorDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Book_author bookAuthor)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Book_author bookAuthor, int id)
        {
            throw new NotImplementedException();
        }
    }
}
