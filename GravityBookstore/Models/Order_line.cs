namespace GravityBookstore.Models;

public class  Order_line 
{
    public int Line_id { get; set; }
    public Cust_order Cust_order { get; set; }
    public Book Book { get; set; }
    public int Price { get; set; }
}