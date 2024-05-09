namespace GravityBookstore.Models;

public class  Book_author 
{
    public int Author_id { get; set; }
    public Author Author { get; set; }
    public int Book_id { get; set; }
    public Book Book { get; set; }
}