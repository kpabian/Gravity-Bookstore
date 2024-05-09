namespace GravityBookstore.Models;

public class Customer_address
{
    public int Customer_id { get; set; }
    public Customer Customer { get; set; }
    public int Address_id { get; set; }
	public Address Address { get; set; }
    public int Status_id { get; set; }
    public Address_status Address_status { get; set; }

}