using System.ComponentModel.DataAnnotations;

namespace GravityBookstore.Models;

public class  Book 
{
    [Key]
    public int Book_id { get; set; }
    public string Title { get; set; }
    public string Isbn13 { get; set; }
    public int Book_language_id { get; set; }
    public Book_language? Language { get; set; }
    public int Num_pages { get; set; }
    public DateOnly Publication_date { get; set; }
    public int Publisher_id { get; set; }
    public Publisher? Publisher { get; set; }
    public List<Book_author>? BookAuthors { get; set; }
    public List<Order_line>? Order_lines { get; set; }
}