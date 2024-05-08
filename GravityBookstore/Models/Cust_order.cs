namespace GravityBookstore.Models;

public class Cust_order
{
    public int Order_id { get; set; }
    public DateTime Order_date { get; set; }
    public Customer Customer { get; set; }
    public Shipping_method Shipping_method { get; set; }
    public Address Dest_address { get; set; }
}