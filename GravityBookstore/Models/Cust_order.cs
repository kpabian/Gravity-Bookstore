namespace GravityBookstore.Models;

public class Cust_order
{
    public int Order_id { get; set; }
    public DateTime Order_date { get; set; }
    public int Customer_id { get; set; }
    public Customer Customer { get; set; }
    public int Shipping_id { get; set; }
    public Shipping_method Shipping_method { get; set; }
    public int Dest_address_id { get; set; }
    public Address Dest_address { get; set; }
    public List<Order_line> Order_lines { get; set; }
    public List<Order_history> Order_history { get; set; }
}