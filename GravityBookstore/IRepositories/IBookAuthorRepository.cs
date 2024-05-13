﻿using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IBookAuthorRepository
{
    Task<List<Book_author>> Get(int? AuthorId, int? BookId);
    Task<(int, int)> CreateBookAuthor(Book_author bookAuthor);
    Task<bool> UpdateBookAuthor(Book_author bookAuthor, int id);
    Task<bool> DeleteBookAuthor(int AuthorId, int BookId);
}
