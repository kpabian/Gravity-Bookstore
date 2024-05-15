using GravityBookstore.Models;

namespace GravityBookstore.ModelsDto;

public class BookDto
{
    public int Book_id { get; set; }
    public string Title { get; set; }
    public string Isbn13 { get; set; }
    public int Book_language_id { get; set; }
    public int Num_pages { get; set; }
    public DateOnly Publication_date { get; set; }
    public int Publisher_id { get; set; }
    
}


public class BookPostDto
{
    public string Title { get; set; }
    public string Isbn13 { get; set; }
    public int Book_language_id { get; set; }
    public int Num_pages { get; set; }
    public DateOnly Publication_date { get; set; }
    public int Publisher_id { get; set; }
}


public class BookPublisherDto
{
    public int Book_id { get; set; }
    public string Title { get; set; }
    public string Isbn13 { get; set; }
    public int Book_language_id { get; set; }
    public Book_language? Language { get; set; }
    public int Num_pages { get; set; }
    public DateOnly Publication_date { get; set; }
    public int Publisher_id { get; set; }
    public PublisherDto? Publisher { get; set; }
    public List<BookAuthorDto>? BookAuthors { get; set; }
    public List<OrderLineDto>? Order_lines { get; set; }
}

public class OrderedBooksDto {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Isbn { get; set; }
    public int CopiesSold { get; set; }
}