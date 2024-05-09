namespace GravityBookstore.Models;

public class  Order_history
{
    public int History_id { get; set; }
    public int Cust_order_id { get; set; }
    public Cust_order Cust_order { get; set; }
    public int Status_id { get; set; }
    public Order_status Status { get; set; }
    public DateOnly Status_date { get; set; }
}