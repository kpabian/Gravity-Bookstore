namespace GravityBookstore.Models;

public class Author
{
    public int Author_id { get; set; }
	public string Author_name { get; set; }
    public List<Book_author> BookAuthors { get; set; }  
}