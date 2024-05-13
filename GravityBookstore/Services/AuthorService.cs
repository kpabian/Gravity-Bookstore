using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.Services;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IMapper _mapper;
    public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
    {
        _authorRepository = authorRepository;
        _mapper = mapper;
    }
    public async Task<bool> Delete(int id)
    {
        bool deleteAuthorDto = await _authorRepository.DeleteAuthor(id);
        return deleteAuthorDto;
    }

    public async Task<List<AuthorDto>> Get(int id)
    {
        var result = await _authorRepository.Get(id);
        var mappedResult = _mapper.Map<List<AuthorDto>>(result);
        return mappedResult;
    }

    public async Task<int> Post(AuthorPostDto author)
    {
        Author mappedAuthor = _mapper.Map<Author>(author);
        int createAuthorDto = await _authorRepository.CreateAuthor(mappedAuthor);
        return createAuthorDto;
    }

    public async Task<bool> Put(AuthorPostDto author, int id)
    {
        Author mappedAuthor = _mapper.Map<Author>(author);
        bool updateAuthorDto = await _authorRepository.UpdateAuthor(mappedAuthor, id);
        return updateAuthorDto;
    }
}
