namespace GravityBookstore.Models;

public class Customer_adress
{
    public Customer Customer { get; set; }
	public Address Address { get; set; }
    public Shipping_method Adress_Status { get; set; }

}