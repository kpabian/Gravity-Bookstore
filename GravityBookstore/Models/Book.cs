namespace GravityBookstore.Models;

public class  Book 
{
    public int Book_id { get; set; }
    public string Title { get; set; }
    public string Isbn13 { get; set; }
    public Book_Language Language { get; set; }
    public int Num_pages { get; set; }
    public DateOnly Publication_date { get; set; }
    public Publisher Publisher { get; set; }
}