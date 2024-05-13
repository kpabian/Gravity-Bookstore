using System.ComponentModel.DataAnnotations.Schema;

namespace GravityBookstore.Models;

public class  Book_author 
{
    [ForeignKey("Author")]
    public int Author_id { get; set; }
    public Author Author { get; set; }
    [ForeignKey("Book")]
    public int Book_id { get; set; }
    public Book Book { get; set; }
}