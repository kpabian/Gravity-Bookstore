using System.ComponentModel.DataAnnotations;

namespace GravityBookstore.Models;

public class Address_status
{
    [Key]
    public int Status_id { get; set; }
	public string Status_value { get; set; }
    public List<Customer_address>? Customer_address { get; set; }

}