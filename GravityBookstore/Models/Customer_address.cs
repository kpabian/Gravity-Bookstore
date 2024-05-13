using System.ComponentModel.DataAnnotations.Schema;

namespace GravityBookstore.Models;

public class Customer_address
{
    [ForeignKey("Customer")]
    public int Customer_id { get; set; }
    public Customer? Customer { get; set; }
    [ForeignKey("Address")]
    public int Address_id { get; set; }
	public Address Address { get; set; }
    [ForeignKey("Address_status")]
    public int Status_id { get; set; }
    public Address_status? Address_status { get; set; }

}