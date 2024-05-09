namespace GravityBookstore.Models;

public class Book_language
{
    public int Language_id { get; set; }
    public string Language_code { get; set; }
    public string Language_name { get; set; }
    public List<Book> Books { get; set; }
}