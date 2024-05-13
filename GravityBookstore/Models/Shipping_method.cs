using System.ComponentModel.DataAnnotations;

namespace GravityBookstore.Models;

public class Shipping_method
{
    [Key]
    public int Method_id { get; set; }
	public string Method_name { get; set; }
    public int Cost { get; set; }
    public List<Cust_order>? Cust_order { get; set; }

}