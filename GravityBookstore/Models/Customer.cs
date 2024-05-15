using System.ComponentModel.DataAnnotations;

namespace GravityBookstore.Models;

public class Customer
{
	[Key]
    public int Customer_id { get; set; }
	public string First_name { get; set; }
	public string Last_name { get; set; }
	public string Email { get; set; }
	public List<Customer_address>? Customer_address { get; set; }
	public List<Cust_order>? Cust_order { get; set;}
}
