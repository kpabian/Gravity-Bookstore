using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GravityBookstore.Models;

public class  Order_line 
{
    [Key]
    public int Line_id { get; set; }
    [ForeignKey("Cust_order")]
    public int Cust_order_id { get; set; }
    public Cust_order? Cust_order { get; set; }
    [ForeignKey("Book")]
    public int Book_id { get; set; }
    public Book? Book { get; set; }
    public int Price { get; set; }
}