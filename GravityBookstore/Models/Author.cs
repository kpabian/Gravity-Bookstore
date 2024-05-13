using System.ComponentModel.DataAnnotations;

namespace GravityBookstore.Models;

public class Author
{
    [Key]
    public int Author_id { get; set; }
	public string Author_name { get; set; }
    public List<Book_author> BookAuthors { get; set; }  
}