namespace GravityBookstore.Models;

public class  Publisher 
{
    public int Publisher_id { get; set; }
    public string Publisher_name { get; set; }
    public List<Book> Books { get; set; }
}